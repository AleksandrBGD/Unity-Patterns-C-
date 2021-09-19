using UnityEngine;

// Продукт с характеристиками.
//
// A product with characteristics.
public class ProductData : MonoBehaviour
{
    public string Title { get; private set; }

    public void Initialize(string productName)
    {
        Title = productName;
    }
}