using UnityEngine;

// Абстрактный класс заказа с пошаговым выполнением
// 
// Abstract order class with step-by-step execution
public abstract class PurchaseOrder : MonoBehaviour
{
    // Пошаговое обобщенное выполнение
    // 
    // Step-by-step generalized execution
    public void Execute()
    {
        Accept();
        Prepare();
        Deliver();
    }

    protected virtual void Accept()
    {
        print("The order is accepted!");
    }

    protected virtual void Prepare()
    {
        print("The order is being prepared!");
    }

    protected abstract void Deliver();
}