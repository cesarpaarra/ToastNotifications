using System.Windows.Input;

namespace Toastify.Events
{
    public class BlockAllKeyInputEventHandler: IKeyboardEventHandler
    {
        public void Handle(KeyEventArgs eventArgs)
        {
            eventArgs.Handled = true;
        }
    }
}