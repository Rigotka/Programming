using System;
using System.Windows.Input;
using View.Model.Services;
using System.Windows;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        private ContactSerializer _serializer = new ContactSerializer("contact");

        public MainVM MainVM { get; set; }

        public LoadCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainVM.Contact = _serializer.LoadFromFile();
        }
    }
}
