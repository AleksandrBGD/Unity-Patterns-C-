using UnityEngine;
// Класс для теста Фабричного метода.
// 
// Class for testing the Factory Method.
public class StartupTest : MonoBehaviour
{
    [SerializeField] private Harvest _harvest;
    [SerializeField] private ProductType _type;

    private void Start()
    {
        var product = _harvest.GetProduct(_type);

        print("Product initalize: " + product.Title);
    }
}