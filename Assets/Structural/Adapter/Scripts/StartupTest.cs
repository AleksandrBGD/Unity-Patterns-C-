using UnityEngine;

// Класс для тестирования Адаптера
// 
// Class for testing the Adapter
public class StartupTest : MonoBehaviour
{
    // Обьект с компонентом IHealth
    // 
    // An object with the IHealth component
    [SerializeField] private GameObject _alive;
    [SerializeField] [Range(1f, 5f)] private float _damage = 2f;

    private void Start()
    {
        // Чтение компонента и нанесение урона
        // 
        // Reading a component and dealing damage
        var health = _alive.GetComponent<IHealth>();
        health.ApplyDamage(_damage);
    }
}