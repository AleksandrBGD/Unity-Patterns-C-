using UnityEngine;

// Тест шаблонного метода
// 
// Template Method Test
public class StartupTest : MonoBehaviour
{
    // Тип заказа
    // 
    // Order type
    [SerializeField] private PurchaseOrder _order;

    private void Start()
    {
        _order.Execute();
    }
}