using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;
using View.Model.Services;


namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public Contact Contact { get; set; } = new Contact();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return Contact.FullName;
            }
            set
            {
                Contact.FullName = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string PhoneNumber
        {
            get
            {
                return Contact.PhoneNumber;
            }
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public SaveCommand SaveCommand
        {
            get
            {
                return new SaveCommand(this);
            }
        }

        public LoadCommand LoadCommand
        {
            get
            {
                return new LoadCommand(this);
            }
        }
    }
}
