using UnityEngine;

// Класс запуск создания посылки
// 
// Class starting the creation of a parcel
public class StartupTest : MonoBehaviour
{
    [SerializeField] private CreatorProductPackage _creator;

    private void Start()
    {
        _creator.Create();
    }
}