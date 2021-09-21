using UnityEngine;

// Класс товара с данными.
// 
// Product class with data.
[System.Serializable]
public class ProductData 
{
    [SerializeField] private string _name;
    [SerializeField] private int _price;

    public string Name => _name;
    public int Price => _price;

    public ProductData(string name, int price)
    {
        _name = name;
        _price = price;
    }
}