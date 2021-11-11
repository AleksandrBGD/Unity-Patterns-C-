using UnityEngine;

// Животное(стратегия - перемещение)
// 
// Animal (strategy-moving)
public class Animal : MonoBehaviour
{
    [SerializeField] private GameObject _movementObj;
    private IMovable _movement;

    private void Awake()
    {
        _movement = _movementObj.GetComponent<IMovable>();
    }

    public void Move()
    {
        _movement.Do();
    }
}