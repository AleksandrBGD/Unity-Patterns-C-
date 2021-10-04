using System.Collections.Generic;
using UnityEngine;

// Коллекция кошельков, работа со всеми сразу через методы
// 
// Collection of wallets, working with all at once through the methods
public class WalletCollection : MonoBehaviour, IWalletComposite
{
    [SerializeField] private List<Wallet> _wallets = new List<Wallet>();

    // Дать деньги(всем)
    // 
    // Give money(to everyone)
    public void GiveMoney(int money)
    {
        for (int i = 0; i < _wallets.Count; i++)
        {
            _wallets[i].GiveMoney(money);
        }
    }

    // Забрать деньги(у всех)
    // 
    // Take money(from everyone)
    public void TakeMoney(int money)
    {
        for (int i = 0; i < _wallets.Count; i++)
        {
            _wallets[i].TakeMoney(money);
        }
    }
}