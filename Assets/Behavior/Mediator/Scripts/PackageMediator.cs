using UnityEngine;

// Медиатор для упаковки и отправки после создания
// 
// Mediator for packaging and sending after creation
public class PackageMediator : MonoBehaviour, IPackagedMediator
{
    [SerializeField] private CreatorProductPackage _creator;
    [SerializeField] private PackagingProductPackage _packaging;
    [SerializeField] private DeliveryProductPackage _delivery;

    public void Do(Package package)
    {
        if(package == _creator)
        {
            _packaging.Execute(_creator.ProductPackage);
            return;
        }
           
        if(package == _packaging)
        {
            _delivery.Send(_packaging.ProductPackage);
            return;
        }
    }
}