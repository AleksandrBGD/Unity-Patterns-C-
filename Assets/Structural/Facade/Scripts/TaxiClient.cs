using UnityEngine;

// Клиент
// 
// Client 
public class TaxiClient : MonoBehaviour
{
    [SerializeField] private string _clientName = "Name";

    public string ClientName => _clientName;
}