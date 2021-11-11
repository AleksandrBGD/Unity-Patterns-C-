using UnityEngine;

public class PersonJump : MonoBehaviour, IJumpable
{
    [SerializeField] private string _name;
    
    public void Do()
    {
        print("Person Jump: " + _name);
    }
}