using UnityEngine;

public class AnimalMovement : MonoBehaviour, IMovable
{
    [SerializeField] private string _name;

    public void Do()
    {
        print("Animal Movement: " + _name);
    }
}