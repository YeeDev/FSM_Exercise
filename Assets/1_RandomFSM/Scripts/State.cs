using UnityEngine;

namespace FSM.Random
{
    public class State
    {
        Mesh mesh;
        State nextState;

        public Mesh Mesh => mesh;
        public State NextState { get => nextState; set => nextState = value; }

        public State(Mesh mesh) => this.mesh = mesh;
    }
}