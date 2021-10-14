using UnityEngine;

// Тестирование Агрегатора такси - Фасад
// 
// Testing of the Taxi Aggregator-Facade
public class StartupTest : MonoBehaviour
{
    [SerializeField] private GameObject _aggregatorObj;
    [SerializeField] private TaxiClient _client;

    private void Start()
    {
        var aggregator = _aggregatorObj.GetComponent<IAggregator>();

        // Заказ
        // 
        // Request
        aggregator.Request(_client);

        // Оповещение о том, что водитель уже в пути
        // 
        // Notification that the driver is already on the way
        aggregator.Request(_client);

        // Отмена заказа
        // 
        // Order cancellation
        aggregator.Cancel(_client);

        // Оповещение о том, что клиент не делал заказ
        // 
        // Notification that the customer has not made an order
        aggregator.Cancel(_client);
    }
}