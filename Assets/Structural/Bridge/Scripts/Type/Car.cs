using UnityEngine;

// Стандартная машина - Базовый класс
// 
// Standard Car - Base Class
public class Car : MonoBehaviour
{
    // Интерфейсе покраски
    // 
    // The painting interface
    protected IColorable _color;

    private void Awake()
    {
        _color = GetComponent<IColorable>();
    }

    // Покраска(Возможно переопределение)
    // 
    // Painting(Possible redefinition)
    public virtual void Paint(Color color)
    {
        _color.PaintImplementation(color);
    }
}