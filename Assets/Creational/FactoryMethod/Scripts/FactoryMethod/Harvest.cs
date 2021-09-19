using UnityEngine;

// Тип продукта.
//
// Product type.
public enum ProductType { apple, pear, orange };

// Абстрактный класс для фабричного метода.
// 
// Abstract class for a factory method.
public abstract class Harvest : MonoBehaviour
{
    public ProductData GetProduct(ProductType Type)
    {
        var config = GetProductConfig(Type);
        var product = Instantiate(config.Prefab);

        product.Initialize(config.Title);

        return product;
    }

    protected abstract ProductHarvestConfig GetProductConfig(ProductType Type);
}