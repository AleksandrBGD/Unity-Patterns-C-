using UnityEngine;

// Класс запуск отправки оповещения
// 
// Class starting sending an alert
public class StartupTest : MonoBehaviour
{
    [SerializeField] private GameObject _groupObj;

    private void Start()
    {
        _groupObj.GetComponent<IGroup>()?.Notify();
    }
}