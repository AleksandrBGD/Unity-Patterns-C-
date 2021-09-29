using UnityEngine;

// Класс для покраски Седана
// 
// Class for painting a Sedan
public class SedanColor : MonoBehaviour, IColorable
{
    [SerializeField] private MeshRenderer _mainMesh;
    [SerializeField] private MeshRenderer[] _wheels;

    // Имплементированная покраска
    // 
    // Implemented painting
    public void PaintImplementation(Color color)
    {
        _mainMesh.sharedMaterial.color = color;

        for (int i = 0; i < _wheels.Length; i++)
        {
            _wheels[i].sharedMaterial.color = color;
        }
    }
}