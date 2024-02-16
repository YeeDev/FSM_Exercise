using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RandomStatesCreator : MonoBehaviour
{
    [SerializeField] List<Mesh> meshes;

    List<RandomState> randomStates;

    public RandomState CreatedRandomStates()
    {
        meshes = meshes.OrderBy(x => Random.value).ToList();

        randomStates = new List<RandomState>();
        RandomState previousState = null;

        foreach (Mesh mesh in meshes)
        {
            RandomState newState = new RandomState(mesh);
            if (previousState != null) { newState.NextState = previousState; }
            previousState = newState;
            
            randomStates.Add(previousState);
        }
        randomStates[0].NextState = randomStates[randomStates.Count - 1];

        return randomStates[0];
    }
}
