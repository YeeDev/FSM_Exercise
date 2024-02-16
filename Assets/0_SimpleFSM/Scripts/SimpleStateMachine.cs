using UnityEngine.UI;
using UnityEngine;

namespace SFSM
{
    public class SimpleStateMachine : MonoBehaviour
    {
        [SerializeField] SimpleState initialState;
        [SerializeField] Text stateText;

        const string stateMessage = "Estado actual: ";

        MeshFilter meshFilter;
        SimpleState currentState;

        private void Awake()
        {
            meshFilter = GetComponent<MeshFilter>();

            currentState = initialState;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                currentState = currentState.NextState;
                meshFilter.mesh = currentState.Mesh;

                stateText.text = stateMessage + currentState.name;
            }
        }
    }
}