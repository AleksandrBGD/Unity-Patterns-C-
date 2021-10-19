using UnityEngine;

// Базовый абстрактный класс для машин(цепочка)
// 
// Basic abstract class for machines(chain)
public abstract class Car : MonoBehaviour, ICustomСar
{
    [SerializeField] private int _capacity = 2;

    // Следующая машина для цепочки
    // 
    // The next machine for the chain
    public Car NextCar { get; set; }
    private string CarName => gameObject.name;

    // К заказу
    // 
    // To order
    public void ToOrder(CustomerOrder order)
    {
        if (order.RequiredCapacity <= _capacity)
        {
            print("Машина выезжает на заказ - " + CarName);
            return;
        }

        if (NextCar != null)
        {
            print("Данная машина не подходит - " + CarName);
            NextCar.ToOrder(order);
            return;
        }

        print("Подходящих машин не найдено");
    }
}