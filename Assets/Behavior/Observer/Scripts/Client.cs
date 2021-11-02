using UnityEngine;

// Клиент
// 
// Client
public class Client : MonoBehaviour, IClient
{
    [SerializeField] private GameObject _groupObj;
    private IGroup _group;

    private void Awake()
    {
        _group = _groupObj.GetComponent<IGroup>();
    }

    private void OnEnable()
    {
        _group?.Add(this);
    }

    private void OnDisable()
    {
        _group?.Remove(this);
    }

    // Обновление
    // 
    // Update
    public void Refresh(string text)
    {
        print(text);
    }
}