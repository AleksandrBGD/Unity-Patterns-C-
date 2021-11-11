using UnityEngine;

public class PersonMovement : MonoBehaviour, IMovable
{
    [SerializeField] private string _name;

    public void Do()
    {
        print("Person Movement: " + _name);
    }
}