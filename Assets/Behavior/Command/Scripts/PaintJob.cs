using System.Collections.Generic;
using UnityEngine;

// Установка нового или прежнего цвета
// 
// Setting a new or previous color
public class PaintJob : MonoBehaviour
{
    [SerializeField] private MeshRenderer _renderer;

    private readonly List<Color> _colors = new List<Color>();
    private Color _originalColor;
    private int _currentIndex = -1;

    private bool CanInstallPreviousColor => _currentIndex > -1;

    private void Awake()
    {
        _originalColor = _renderer.sharedMaterial.color;
    }

    // Установить новый цвет
    // 
    // Set a new color
    public void SetColor(Color color)
    {
        _colors.Add(color);
        _renderer.sharedMaterial.color = color;
        _currentIndex++;
    }

    // Установить предыдущий цвет
    // 
    // Set the previous color
    public void SetPreviousColor()
    {
        if (CanInstallPreviousColor)
        {
            _colors.RemoveAt(_currentIndex);
            _currentIndex--;

            var color = CanInstallPreviousColor ? _colors[_currentIndex] : _originalColor;
            _renderer.sharedMaterial.color = color;
        }
    }
}