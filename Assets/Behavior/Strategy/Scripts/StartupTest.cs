using UnityEngine;

// Класс тест стратегии
// 
// Strategy test class
public class StartupTest : MonoBehaviour
{
    [SerializeField] private Person _person;
    [SerializeField] private Animal _animal;

    // Запуск
    // 
    // Launch
    private void Start()
    {
        _person.Move();
        _person.Jump();

        _animal.Move();
    }
}