using UnityEngine;

// Класс клиента для работы со строителем - StoreSmartphoneBuilder.
// 
// The client class for working with the builder - StoreSmartphoneBuilder.
public class BuyingClient : MonoBehaviour
{
    [SerializeField] private GameObject _builderObj;

    private void Start()
    {
        var builder = _builderObj.GetComponent<StoreSmartphoneBuilder>();
        if (builder == null) return;

        // Построение/Добавление комплектации продуктов и вывод информации
        // 
        // Construction/Adding a complete set of products and displaying information
        BuildComplectGeneral(builder);
        BuildBatteryCharger(builder);
    }

    private void BuildComplectGeneral(StoreSmartphoneBuilder builder)
    {
        builder.Add();
        builder.AddBatteryCharger();
        builder.AddGarniture();

        PrintDataSale(builder);

        builder.Reset();
    }

    private void BuildBatteryCharger(StoreSmartphoneBuilder builder)
    {
        builder.AddBatteryCharger();

        PrintDataSale(builder);

        builder.Reset();
    }

    private void PrintDataSale(StoreSmartphoneBuilder builder)
    {
        var data = builder.Complect.GetPurchaseData();

        print("New basket sale");

        for (int i = 0; i < data.Length; i++)
        {
            print(data[i]);
        }
    }
}