using UnityEngine;

// Класс - жизни(стандартный класс)
// 
// Class - Life(standard class)
public class Health : MonoBehaviour, IHealth
{

    // Принятие урона
    // 
    // Taking damage
    public void ApplyDamage(float damage)
    {
        Debug.Log("ApplyDamage -" + damage.ToString());
    }
}