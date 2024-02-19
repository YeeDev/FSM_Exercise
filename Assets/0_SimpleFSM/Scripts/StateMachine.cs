using UnityEngine.UI;
using UnityEngine;

namespace FSM.Simple
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
            if (Input.GetKeyDown(KeyCode.C))
            {
                currentState = currentState.NextState;
                meshFilter.mesh = currentState.Mesh;

                stateText.text = stateMessage + currentState.name;
            }
        }
    }
}