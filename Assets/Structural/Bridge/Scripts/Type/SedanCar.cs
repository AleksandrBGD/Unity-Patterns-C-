using UnityEngine;

// Наследник от Базовой машины - Седан
// 
// The heir from the Base car is a Sedan
public class SedanCar : Car
{
    // Свои данные ...
    // 
    // Your data ...
    private readonly float _maxSpeed = 180f;

    // Переопределение метода покраски
    // 
    // Redefining the painting method
    public override void Paint(Color color)
    {
        base.Paint(color);
        print("Paint - SedanColor");
    }
}