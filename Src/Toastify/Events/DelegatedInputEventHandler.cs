using System;
using System.Windows.Input;

namespace Toastify.Events
{
    public class DelegatedInputEventHandler : IKeyboardEventHandler
    {
        private readonly Action<KeyEventArgs> _action;

        public DelegatedInputEventHandler(Action<KeyEventArgs> action)
        {
            _action = action;
        }

        public void Handle(KeyEventArgs eventArgs)
        {
            _action(eventArgs);
        }
    }
}