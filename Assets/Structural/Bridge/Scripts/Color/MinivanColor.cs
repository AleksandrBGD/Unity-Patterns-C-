using UnityEngine;

// Класс для покраски Минивэна
// 
// Class for painting a Minivan
public class MinivanColor : MonoBehaviour, IColorable
{
    [SerializeField] private MeshRenderer _mainMesh;

    // Имплементированная покраска
    // 
    // Implemented painting
    public void PaintImplementation(Color color)
    {
        _mainMesh.sharedMaterial.color = color;
    }
}