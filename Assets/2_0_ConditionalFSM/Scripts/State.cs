using UnityEngine;

namespace FSM.Conditional
{
    public class State : MonoBehaviour
    {
        [SerializeField] State forwardState;
        [SerializeField] State backwardState;
        [SerializeField] Mesh mesh;

        public Mesh Mesh => mesh;

        public State GetState(int condition) => condition > 0 ? forwardState : backwardState;
    }
}