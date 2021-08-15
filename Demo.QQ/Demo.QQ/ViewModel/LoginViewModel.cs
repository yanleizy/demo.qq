using Demo.QQ.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Demo.QQ.ViewModel
{
    public class LoginViewModel
    {
        public CommandBase CloseWindowCommand { get; set; }
        public CommandBase MiniWindowCommand { get; set; }

        public LoginViewModel()
        {
            Action<object> action1 = (o) =>
            {
                (o as Window).Close();
            };
            Func<object, bool> func1 = (o) =>
            {
                return true;
            };
            CloseWindowCommand = new CommandBase(action1, func1);

            Action<object> action2 = (o) =>
            {
                (o as Window).WindowState = WindowState.Minimized;
            };
            Func<object, bool> func2 = (o) =>
            {
                return true;
            };
            MiniWindowCommand = new CommandBase(action2, func2);
        }
    }
}
