using UnityEngine;

// Класс команда покраски
// 
// Class painting command
public class PaintCommand : ICommand
{
    private readonly Color _color;
    private readonly PaintJob _paintJob;

    public PaintCommand(Color color, PaintJob paintJob)
    {
        _color = color;
        _paintJob = paintJob;
    }

    // Выполнить команду покраски - вперед
    // 
    // Execute the paint command-go ahead
    public void Execute()
    {
        _paintJob.SetColor(_color);
    }

    // Выполнить команду покраски в предыдущий цвет - назад
    // 
    // Run the paint command to the previous color-back
    public void Undo()
    {
        _paintJob.SetPreviousColor();
    }
}