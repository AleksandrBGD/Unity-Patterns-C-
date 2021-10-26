using UnityEngine;

// Класс для активации команд 
// 
// A class for activating commands
public class StartupTest : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private PaintJob _paintJob;
    [SerializeField] private PaintInvoker _invoker;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            ICommand command = new PaintCommand(_color, _paintJob);
            _invoker.AddCommand(command);

            print("Paint - New Color");
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            _invoker.Undo();
            print("Paint - Undo Color");
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            _invoker.Redo();
            print("Paint - Redo Color");
        }
    }
}