using UnityEngine;
using System.Collections.Generic;

// Группа
// 
// Group
public class Group : MonoBehaviour, IGroup
{
    private List<IClient> _clients = new List<IClient>();

    // Добавить
    // 
    // Append
    public void Add(IClient client)
    {
        _clients.Add(client);
    }

    // Удалить
    // 
    // Delete
    public void Remove(IClient client)
    {
        _clients.Remove(client);
    }

    // Отправка/Обновление
    // 
    // Shipment/Update
    public void Notify()
    {
        foreach (var client in _clients)
        {
            var text = client + " Refresh";
            client.Refresh(text);
        }
    }
}