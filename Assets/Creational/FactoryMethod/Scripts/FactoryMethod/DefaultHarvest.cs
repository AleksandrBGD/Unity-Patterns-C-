using UnityEngine;

// Класс для обработки типа создаваемого продукта и получение конфигурации.
//
// Class for processing the type of product being created and getting the configuration.
public class DefaultHarvest : Harvest
{
    // Конфигурации
    //
    // Configurations
    [SerializeField] private ProductHarvestConfig _apple, _pear, _orange;

    // Переопределенный метод получения конфигураций.
    //
    // Redefined method of getting.
    protected override ProductHarvestConfig GetProductConfig(ProductType Type)
    {
        var config = GetByType(Type);
        return config;
    }

    // Получение по типу.
    //
    // Getting by type.
    private ProductHarvestConfig GetByType(ProductType Type)
    {
        var configs = new ProductHarvestConfig[3];
        configs[0] = _apple;
        configs[1] = _pear;
        configs[2] = _orange;

        var index = (int)Type;
        return configs[index];
    }
}