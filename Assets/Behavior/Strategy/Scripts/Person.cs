using UnityEngine;

// Персонаж(стратегия - перемещение, прыжок)
// 
// Character(strategy-move, jump)
public class Person : MonoBehaviour
{
    [SerializeField] private GameObject _movementObj;
    [SerializeField] private GameObject _jumpObj;

    private IMovable _movement;
    private IJumpable _jump;

    private void Awake()
    {
        _movement = _movementObj.GetComponent<IMovable>();
        _jump = _jumpObj.GetComponent<IJumpable>();
    }

    public void Move()
    {
        _movement.Do();
    }

    public void Jump()
    {
        _jump.Do();
    }
}