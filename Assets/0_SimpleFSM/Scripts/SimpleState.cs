using UnityEngine;

[CreateAssetMenu(fileName ="New State", menuName ="State")]
public class SimpleState : ScriptableObject
{
    [SerializeField] SimpleState nextState;
    [SerializeField] Mesh mesh;

    public SimpleState NextState => nextState;
    public Mesh Mesh => mesh;
}
