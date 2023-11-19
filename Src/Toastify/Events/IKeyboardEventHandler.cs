
using System.Windows.Input;

namespace Toastify.Events
{
    public interface IKeyboardEventHandler
    {
        void Handle(KeyEventArgs eventArgs);
    }
}
