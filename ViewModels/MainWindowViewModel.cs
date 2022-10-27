using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BankWPFApp.Infrastructure.Commands;
using BankWPFApp.ViewModels.Base;

namespace BankWPFApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "A Consultant(alpha 0.1.001)";
        private string _Status = "Ready!";

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
    }
}
