using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Week8Test.WPF.Commands
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<object?> _executeMethod;
        private Predicate<object?> _canExecute;

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeMethod?.Invoke(parameter);
        }
    }
}
