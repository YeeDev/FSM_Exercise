using UnityEngine;

namespace RFSM
{
    public class RandomState
    {
        Mesh mesh;
        RandomState nextState;

        public Mesh Mesh => mesh;
        public RandomState NextState { get => nextState; set => nextState = value; }

        public RandomState(Mesh mesh) => this.mesh = mesh;
    }
}