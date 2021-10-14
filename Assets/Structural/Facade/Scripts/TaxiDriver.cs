using UnityEngine;

// Таксист
// 
// Cabbie
public class TaxiDriver : MonoBehaviour
{
    private readonly TaxiNavigator _navigator = new TaxiNavigator();

    public TaxiClient Client { get; private set; }

    public bool Free => Client == null;

    // Добавить клиента
    // 
    // Add a client
    public void AddClient(TaxiClient client)
    {
        Client = client;
    }

    // Удалить клиента
    // 
    // Delete a client
    public void RemoveClient()
    {
        Client = null;
    }

    // Двигаться на цель
    // 
    // Move to the target
    public void MoveOnTarget(Vector3 position)
    {
        var target = _navigator.BuildPath(position);
        print("Водитель следует по пути: " + target);
    }
}