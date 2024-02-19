using UnityEngine;
using UnityEngine.UI;

namespace FSM.Random
{
    public class StateMachine : MonoBehaviour
    {
        [SerializeField] Text stateText;

        const string stateMessage = "Estado actual: ";

        MeshFilter meshFilter;
        Randomizer statesCreator;
        State currentState;

        private void Awake()
        {
            meshFilter = GetComponent<MeshFilter>();
            statesCreator = GetComponent<Randomizer>();

            currentState = statesCreator.CreatedRandomStates();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C)) { SetState(); }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                currentState = statesCreator.CreatedRandomStates();
                SetState();
            }
        }

        private void SetState()
        {
            currentState = currentState.NextState;
            meshFilter.mesh = currentState.Mesh;

            stateText.text = stateMessage + currentState.Mesh.name;
        }
    }
}
