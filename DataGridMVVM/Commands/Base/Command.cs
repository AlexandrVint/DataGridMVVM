using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataGridMVVM.Commands.Base
{
    public abstract class Command:ICommand
    {
        // проверка может ли команда выполниться
        public abstract bool CanExecute(object? parameter);

        // выполнение, если команда может выполниться
        public abstract void Execute(object? parameter);

        // событие, когда команда выполняется
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
