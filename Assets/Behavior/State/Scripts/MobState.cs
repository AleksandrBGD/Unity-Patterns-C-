using UnityEngine;

public abstract class MobState : MonoBehaviour
{
    // Вход
    //    
    // Enter
    public abstract void Enable();

    // Выполнение
    // 
    // Execute
    public abstract void Refresh();

    // Выход
    // 
    // Exit
    public abstract void Disable();
}