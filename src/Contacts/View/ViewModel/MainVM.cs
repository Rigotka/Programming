using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using System.Collections.ObjectModel;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация ViewModel для MainWindow.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит выбранный контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Индекс редактируемого объекта.
        /// </summary>
        private int _editIndex = -1;

        /// <summary>
        /// Хранит коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Команда добавления.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// оОманда удаления.
        /// </summary>
        private RelayCommand _removeCommand;

        /// <summary>
        /// Команда изменения.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Команда принятия изменений.
        /// </summary>
        private RelayCommand _applyCommnad;

        /// <summary>
        /// Команда закрытия окна.
        /// </summary>
        private RelayCommand _closeCommand;

        /// <summary>
        /// Сериализатор.
        /// </summary>
        private ContactSerializer _serializer = new ContactSerializer("contact");

        //private ContactVM _contactVM = new ContactVM();

        /// <summary>
        /// Возвращает и задает контакт.
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                ContactVM.Contact = _contact;
                OnPropertyChanged(nameof(Contact));
                if(Contacts.Contains(Contact))
                    _editIndex = -1;
                OnPropertyChanged(nameof(IsCreateOrEditMode));
                ContactVM.IsReadOnly = IsCreateOrEditMode;
            }
        }

        /// <summary>
        /// Возвращает и задает <see cref="ContactVM"/>
        /// </summary>
        public ContactVM ContactVM { get; set; } = new ContactVM();

        /// <summary>
        /// Возвращает команду добавления.
        /// </summary>
        public RelayCommand AddCommand => _addCommand ??
            (_addCommand = new RelayCommand(
                obj =>
                {
                    Contact = new Contact();
                },
                canExecute =>
                {
                    return true;
                }));

        /// <summary>
        /// Возвращает команду изменения.
        /// </summary>
        public RelayCommand EditCommand => _editCommand ??
            (_editCommand = new RelayCommand(
                obj =>
                {
                    _editIndex = Contacts.IndexOf(Contact);
                    Contact = (Contact)Contact.Clone();
                },
                canExecute =>
                {
                    return Contacts.Contains(Contact);
                })
            );

        /// <summary>
        /// Возвращает команду удаления.
        /// </summary>
        public RelayCommand RemoveCommand => _removeCommand ??
            (_removeCommand = new RelayCommand( 
                obj =>
                {
                    var index = Contacts.IndexOf(Contact);
                    Contacts.Remove(Contact);

                    if (Contacts.Count == 0)
                        return;

                    if (index == Contacts.Count)
                        index -= 1;
                    Contact = Contacts[index];
                },
                canExecute =>
                {
                    return Contacts.Contains(Contact);
                })
            );

        /// <summary>
        /// Возвращает команду принятия.
        /// </summary>
        public RelayCommand ApplyCommand => _applyCommnad ??
            (_applyCommnad = new RelayCommand(
                obj =>
                {
                    if(IsCreateMode)
                    {
                        Contacts.Add(Contact);
                    }
                    if (IsEditMode)
                    {
                        Contacts[_editIndex] = Contact;
                        Contact = Contacts[_editIndex];

                        _editIndex = -1;
                    }
                    OnPropertyChanged(nameof(IsCreateOrEditMode));
                    ContactVM.IsReadOnly = IsCreateOrEditMode;
                },
                canExecute =>
                {
                    return ContactVM.IsValid();
                })
            );

        /// <summary>
        /// Возвращает команду закрытия.
        /// </summary>
        public RelayCommand CloseCommand => _closeCommand ??
            (_closeCommand = new RelayCommand(
                obj =>
                {
                    _serializer.SaveToFile(Contacts);
                },
                canExecute =>
                {
                    return true;
                })
            );

        /// <summary>
        /// Возвращает true если создается новый контакт, иначе false.
        /// </summary>
        public bool IsCreateMode
        {
            get
            {
                return !Contacts.Contains(Contact) && Contact != null && _editIndex == -1;
            }
        }

        /// <summary>
        /// Возвращает true если изменяется контакт, иначе false. 
        /// </summary>
        public bool IsEditMode
        {
            get
            {
                return _editIndex != -1;
            }
        }

        /// <summary>
        /// Возвращает true если идет создание или изменение контакта, иначе false.
        /// </summary>
        public bool IsCreateOrEditMode
        {
            get
            {
                return IsCreateMode || IsEditMode;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            Contacts = _serializer.LoadFromFile();
        }

        /// <summary>
        /// События изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// При вызове зажигает событие <see cref="PropertyChangedEventHandler"/>
        /// </summary>
        /// <param name="prop">Имя свойства.</param>
        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
