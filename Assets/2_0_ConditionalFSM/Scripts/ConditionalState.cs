using UnityEngine;

namespace CFSM
{
    public class ConditionalState : MonoBehaviour
    {
        [SerializeField] ConditionalState forwardState;
        [SerializeField] ConditionalState backwardState;
        [SerializeField] Mesh mesh;

        public Mesh Mesh => mesh;

        public ConditionalState GetState(int condition) => condition > 0 ? forwardState : backwardState;
    }
}