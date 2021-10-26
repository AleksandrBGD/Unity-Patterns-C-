using System.Collections.Generic;
using UnityEngine;

// Класс с командами
// 
// A class with commands
public class PaintInvoker : MonoBehaviour
{
    private int _counter;
    private readonly Queue<ICommand> _buffer = new Queue<ICommand>();
    private readonly List<ICommand> _history = new List<ICommand>();

    // Добавить и выполнить команду
    // 
    // Add and execute the command
    public void AddCommand(ICommand command)
    {
        while (_counter < _history.Count)
        {
            _history.RemoveAt(_counter);
        }

        _buffer.Enqueue(command);
        ExecuteBufferCommand();
    }

    // Назад
    // 
    // Back
    public void Undo()
    {
        if (_counter > 0)
        {
            _counter--;
            _history[_counter].Undo();
        }
    }

    // Вперед
    // 
    // Forward
    public void Redo()
    {
        if (_counter < _history.Count)
        {
            _history[_counter].Execute();
            _counter++;
        }
    }

    // Выполнить
    // 
    // Execute
    private void ExecuteBufferCommand()
    {
        ICommand command = _buffer.Dequeue();
        _history.Add(command);

        command.Execute();
        _counter++;
    }
}