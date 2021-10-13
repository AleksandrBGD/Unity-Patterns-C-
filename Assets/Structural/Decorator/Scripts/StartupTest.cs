using UnityEngine;

// Класс для тестирования Обертки
// 
// A class for testing the Wrapper
public class StartupTest : MonoBehaviour
{
    private void Start()
    {
        // Обьект
        // 
        // Object
        var woodBuilding = new DescriptionWoodBuilding();

        // Обертки
        // 
        // Wrappers
        var defaultDecorator = new DefaultDesciptionBuilding(woodBuilding);
        var levelDecorator = new LevelDescriptionBuilding(woodBuilding, 3);

        // Выполнение
        // 
        // Execution
        print(defaultDecorator.GetDescription());
        print(levelDecorator.GetDescription());
    }
}