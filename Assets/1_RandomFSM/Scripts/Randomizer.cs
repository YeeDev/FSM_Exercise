using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace FSM.Random
{
    public class Randomizer : MonoBehaviour
    {
        [SerializeField] List<Mesh> meshes;

        List<State> randomStates;

        public State CreatedRandomStates()
        {
            meshes = meshes.OrderBy(x => UnityEngine.Random.value).ToList();

            randomStates = new List<State>();
            State previousState = null;

            foreach (Mesh mesh in meshes)
            {
                State newState = new State(mesh);
                if (previousState != null) { newState.NextState = previousState; }
                previousState = newState;

                randomStates.Add(previousState);
            }
            randomStates[0].NextState = randomStates[randomStates.Count - 1];

            return randomStates[0];
        }
    }
}