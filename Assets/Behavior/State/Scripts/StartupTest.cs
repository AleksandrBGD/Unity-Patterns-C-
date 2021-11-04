using UnityEngine;

// Класс для установки текущего состояния
// 
// Class for setting the current state
public class StartupTest : MonoBehaviour
{
    [SerializeField] private MobAI _ai;
    [SerializeField] [Range(0, 2)] private int _indexState;
    [SerializeField] private bool _installState;

    private void Update()
    {
        if (_installState)
        {
            _ai?.SetState(_indexState);
            _installState = false;
        }
    }
}