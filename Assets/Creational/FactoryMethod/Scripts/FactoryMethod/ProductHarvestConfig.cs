using UnityEngine;

// Данные для создания продукта.
//
// Data for creating a product.
public class ProductHarvestConfig : MonoBehaviour
{
    [SerializeField] private ProductData _prefab;
    [SerializeField] private string _title;
    
    public ProductData Prefab => _prefab;
    public string Title => _title;
}