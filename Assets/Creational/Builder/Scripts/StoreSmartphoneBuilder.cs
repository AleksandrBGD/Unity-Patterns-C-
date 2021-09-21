using UnityEngine;

// Класс для добавления продуктового комплекта(в корзину): Смартфон, Зарядное устройство, Гарнитура.
//
// Class for adding a grocery kit(to the basket): Smartphone, Charger, Headset.
public class StoreSmartphoneBuilder : MonoBehaviour, ISmartphoneSale
{
    // Референсы товаров 
    // 
    // Product references
    [SerializeField] private ProductData _smartphone;
    [SerializeField] private ProductData _batteryCharger;
    [SerializeField] private ProductData _garniture;

    // Комплектация продуктов - текущий комплект
    // 
    // Complete set of products - the current set
    public Complectation Complect { get; private set; } = new Complectation();

    public void Add()
    {
        InstanceProduct(_smartphone);
    }

    public void AddBatteryCharger()
    {
        InstanceProduct(_batteryCharger);
    }

    public void AddGarniture()
    {
        InstanceProduct(_garniture);
    }

    public void Reset()
    {
        Complect = new Complectation();
    }

    private void InstanceProduct(ProductData reference)
    {
        var instance = new ProductData(reference.Name, reference.Price);
        Complect.Add(instance);
    }
}