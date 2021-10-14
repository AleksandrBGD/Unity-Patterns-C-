using UnityEngine;

// Фасад - агрегатор
// 
// Facade-aggregator
public class AggregatorFacade : MonoBehaviour, IAggregator
{
    [SerializeField] private TaxiDriver[] _drivers;

    // Заказ
    // 
    // Request
    public void Request(TaxiClient client)
    {
        var driver = TryGetDriverByClient(client);

        if (driver != null)
        {
            print("Машина уже в пути!");
            return;
        }

        var index = GetFreeDriverIndex();

        if (index < 0)
        {
            print("Свободных машин нет!");
            return;
        }

        _drivers[index].AddClient(client); 
        _drivers[index].MoveOnTarget(client.transform.position);
    }

    // Отмена
    // 
    // Cancel
    public void Cancel(TaxiClient client)
    {
        var driver = TryGetDriverByClient(client);

        if (driver == null)
        {
            print("Клиент не найден");
            return;
        }

        driver.RemoveClient();
        print("Клиент: " + client.ClientName + " отменил поездку");
    }

    // Получение индекса свободного водителя
    // 
    // Getting the free driver index
    private int GetFreeDriverIndex()
    {
        var index = -1;

        for (int i = 0; i < _drivers.Length; i++)
        {
            if (_drivers[i].Free)
                return i;
        }

        return index;
    }

    // Получение водителя по клиенту
    // 
    // Getting a driver by client
    private TaxiDriver TryGetDriverByClient(TaxiClient client)
    {
        for (int i = 0; i < _drivers.Length; i++)
        {
            if (_drivers[i].Client == client)
            {
                return _drivers[i];
            }
        }

        return null;
    }
}