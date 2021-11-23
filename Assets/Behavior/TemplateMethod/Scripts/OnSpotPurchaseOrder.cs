public class OnSpotPurchaseOrder : PurchaseOrder
{
    protected override void Deliver()
    {
        print("The customer took the order!");
    }
}