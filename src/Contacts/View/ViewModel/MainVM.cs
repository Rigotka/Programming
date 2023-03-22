using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация ViewModel для MainWindow.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Возвращает и задает контакт.
        /// </summary>
        public Contact Contact { get; set; } = new Contact();

        /// <summary>
        /// События изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает ФИО контакта.
        /// </summary>
        public string FullName
        {
            get
            {
                return Contact.FullName;
            }
            set
            {
                Contact.FullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
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

        /// <summary>
        /// При вызове зажигает событие <see cref="PropertyChangedEventHandler"/>
        /// </summary>
        /// <param name="prop">Имя свойства.</param>
        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Команда сохранения в файл.
        /// </summary>
        public SaveCommand SaveCommand
        {
            get
            {
                return new SaveCommand(this);
            }
        }

        /// <summary>
        /// Команда чтения из файла.
        /// </summary>
        public LoadCommand LoadCommand
        {
            get
            {
                return new LoadCommand(this);
            }
        }
    }
}
