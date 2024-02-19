using UnityEngine;

namespace FSM.Simple
{
    [CreateAssetMenu(fileName = "New State", menuName = "State")]
    public class State : ScriptableObject
    {
        [SerializeField] State nextState;
        [SerializeField] Mesh mesh;

        public State NextState => nextState;
        public Mesh Mesh => mesh;
    }
}