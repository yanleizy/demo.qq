using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo.QQ.Common
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return IsCanExecute?.Invoke(parameter) == true;
        }

        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }

        public CommandBase(Action<object> doExecute, Func<object, bool> isCanExecute)
        {
            DoExecute = doExecute;
            IsCanExecute = isCanExecute;
        }

        public Action<object> DoExecute { get; set; }
        public Func<object, bool> IsCanExecute { get; set; }
    }
}
