using System.Collections.Generic;

// Комплект с продуктами внутри. Преобразует данные о продуктах в нужный формат.
// 
// A set with products inside. Converts product data to the desired format.
public class Complectation
{
    private List<ProductData> _products = new List<ProductData>();

    public void Add(ProductData product)
    {
        _products.Add(product);
    }

    // Преобразование и получение
    // 
    // Converting and receiving
    public string[] GetPurchaseData()
    {
        string[] data = new string[_products.Count];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = "Name: " + _products[i].Name + " || " + "Price: " + _products[i].Price.ToString() + "$";
        }

        return data;
    }
}