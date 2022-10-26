using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankWPFApp.ViewModels.Base;

namespace BankWPFApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "A Consultant(alpha 0.1.001)";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        private string _Status = "Ready!";

        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
    }
}
