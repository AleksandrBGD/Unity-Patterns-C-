using UnityEngine;

// Кошелек с деньгами
// 
// Wallet with money
public class Wallet : MonoBehaviour, IWalletComposite
{
    [SerializeField] [Range(0, 1000000)] private int _money = 1000;

    // Свойство денег, корректировка
    // 
    // Property of money, adjustment
    private int Money
    {
        get => _money;
        set
        {
            _money = value;
            _money = Mathf.Clamp(_money, 0, 1000000);
        }
    }

    // Дать деньги
    // 
    // Give money
    public void GiveMoney(int money)
    {
        if (money <= 0) return;

        Money += money;
        print("GiveMoney || Update money: " + Money);
    }

    // Забрать деньги
    // 
    // Take the money
    public void TakeMoney(int money)
    {
        if (money <= 0) return;

        Money -= money;
        print("TakeMoney || Update money: " + Money);
    }
}