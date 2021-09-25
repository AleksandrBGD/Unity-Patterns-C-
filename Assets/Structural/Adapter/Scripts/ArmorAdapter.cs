using UnityEngine;

// Класс - обертка для нанесения урона(Адаптер) - Броня
// 
// Damage Wrapper Class (Adapter) - Armor
public class ArmorAdapter : MonoBehaviour, IHealth
{
    // Класс Брони
    // 
    // Armor Class
    private readonly Armor _armor = new Armor();

    // Нанесение урона 
    // 
    // Dealing damage
    public void ApplyDamage(float damage)
    {
        _armor.DestroyArmor(damage);
    }
}