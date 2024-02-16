using UnityEngine;
using UnityEngine.UI;

namespace CFSM
{
    public class ConditionalFSM : MonoBehaviour
    {
        [SerializeField] ConditionalState initialState;
        [SerializeField] Text stateText;

        const string stateMessage = "Estado actual: ";

        MeshFilter meshFilter;
        ConditionalState currentState;

        private void Awake()
        {
            meshFilter = GetComponent<MeshFilter>();

            currentState = initialState;
        }

        private void Update()
        {
            if (Input.GetButtonDown("Horizontal"))
            {
                currentState = currentState.GetState((int)Input.GetAxisRaw("Horizontal"));
                meshFilter.mesh = currentState.Mesh;
                stateText.text = stateMessage + currentState.transform.name;
            }
        }
    }
}