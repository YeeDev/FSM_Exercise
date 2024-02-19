using UnityEngine;
using UnityEngine.UI;

namespace FSM.Conditional
{
    public class StateMachine : MonoBehaviour
    {
        [SerializeField] State initialState;
        [SerializeField] Text stateText;

        const string stateMessage = "Estado actual: ";

        MeshFilter meshFilter;
        State currentState;

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