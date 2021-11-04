using UnityEngine;

// Текущие и остальные состояния мобов
// 
// Current and other states of mobs
public class MobAI : MonoBehaviour
{
    [SerializeField] private MobState[] _states;
    private MobState _currentState;

    private void Start()
    {
        foreach (var state in _states)
        {
            if (state != null)
            {
                _currentState = state;
                _currentState.Enable();
                break;
            }
        }
    }

    // Выполнение текущего состояния
    // 
    // Executing the current state
    private void Update()
    {
        _currentState?.Refresh();
    }

    // Установка текущего состояния
    // 
    // Setting the current state
    public void SetState(int index)
    {
        if (_states.Length > 0)
        {
            var result = Mathf.Clamp(index, 0, _states.Length - 1);
            var state = _states[result];

            ReplaceState(state);
        }
    }

    // Замена текущего состояния
    // 
    // Replace the current state
    private void ReplaceState(MobState state)
    {
        _currentState?.Disable();
        _currentState = state;
        _currentState?.Enable();
    }
}