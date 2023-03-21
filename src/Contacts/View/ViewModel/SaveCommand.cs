using System;
using System.Windows.Input;
using View.Model.Services;
using System.Windows;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        private ContactSerializer _serializer = new ContactSerializer("contact");

        public MainVM MainVM { get; set; }

        public SaveCommand(MainVM mainVM)
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
            _serializer.SaveToFile(MainVM.Contact);
        }
    }
}
