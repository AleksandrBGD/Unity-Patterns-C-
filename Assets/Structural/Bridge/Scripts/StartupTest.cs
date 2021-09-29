using UnityEngine;

// Класс - тестирования Моста, покраска обьектов(машин)
// 
// Class - Bridge testing, painting objects(cars)
public class StartupTest : MonoBehaviour
{
    // Обьекты - машины для покраски и цвет
    // 
    // Objects - painting machines and color
    [SerializeField] private Car _sedan, _minivan;
    [SerializeField] private Color _colorSedan, _colorMinivan;

    private void Start()
    {
        _sedan.Paint(_colorSedan);
        _minivan.Paint(_colorMinivan);
    }
}