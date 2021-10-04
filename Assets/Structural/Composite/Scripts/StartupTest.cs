using UnityEngine;

// Класс тестирования Компоновщика, прибавление и убавление денег
// 
// Testing class, adding and subtracting money
public class StartupTest : MonoBehaviour
{
    [SerializeField] private GameObject _walletCompositeObj;
    [SerializeField] [Range(0, 1000000)] private int _increaseMoney = 10000, _decreaseMoney = 100;

    private void Start()
    {
        var wallet = _walletCompositeObj.GetComponent<IWalletComposite>();
        
        wallet?.GiveMoney(_increaseMoney);
        wallet?.TakeMoney(_decreaseMoney);
    }
}