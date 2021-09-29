using UnityEngine;

// Наследник от Базовой машины - Минивэн
// 
// The heir from the Base car is a Minivan
public class MinivanCar : Car
{
    // Свои данные ...
    // 
    // Your data ...
    private readonly int _productCapacity = 15;

    // Переопределение метода покраски
    // 
    // Redefining the painting method
    public override void Paint(Color color)
    {
        base.Paint(color);
        print("Paint - MinivanColor");
    }
}