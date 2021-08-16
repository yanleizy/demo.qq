using Demo.QQ.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Demo.QQ.View;
namespace Demo.QQ.ViewModel
{
    public class LoginViewModel
    {
        public CommandBase CloseWindowCommand { get; set; }
        public CommandBase MiniWindowCommand { get; set; }

        public CommandBase LoginCommand { get; set; }
        public LoginViewModel()
        {
            Action<object> CloseWindowaction = (o) =>
            {
                (o as Window).Close();
            };
            Func<object, bool> CloseWindowfunc = (o) =>
            {
                return true;
            };
            CloseWindowCommand = new CommandBase(CloseWindowaction, CloseWindowfunc);

            Action<object> MiniWindowaction = (o) =>
            {
                (o as Window).WindowState = WindowState.Minimized;
            };
            Func<object, bool> MiniWindowfunc = (o) =>
            {
                return true;
            };
            MiniWindowCommand = new CommandBase(MiniWindowaction, MiniWindowfunc);
            Action<object> Loginaction = (o) =>
            {
                MainView mainView = new MainView();
                mainView.Show();
                (o as Window).Close();

            };
            Func<object, bool> Loginfunc = (o) =>
            {
                return true;
            };
            LoginCommand = new CommandBase(Loginaction, Loginfunc);
        }
    }
}
