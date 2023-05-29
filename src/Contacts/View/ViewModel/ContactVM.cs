using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel контакта.
    /// </summary>
    public class ContactVM : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Хранит значение указывающее, что поля доступны только для чтения.
        /// </summary>
        private bool _isReadOnly = false;
        
        /// <summary>
        /// Хранит контакт.
        /// </summary>
        private Contact _contact = null;

        /// <summary>
        /// Возвращет и задает значение указывающее, что поля доступны только для чтения.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return _isReadOnly;
            }
            set
            {
                _isReadOnly = value;
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

        /// <summary>
        /// Проверяет корректность введенных данных.
        /// </summary>
        /// <returns>true - если все корректко, иначе false</returns>
        public bool IsValid()
        {
            string error = this[nameof(FullName)];
            if(error == null)
                return true;
            return false;
        }

        /// <summary>
        /// Возвращает и задет контакт.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
            set 
            {
                _contact = value;

                OnPropertyChanged(nameof(FullName));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возвращает и здает имя контакта.
        /// </summary>
        public string FullName 
        {
            get
            {
                return Contact?.FullName;
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
                return Contact?.PhoneNumber;
            }
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возрвщает и задает почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return Contact?.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
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

        public string this[string columnName]
        {
            get
            {
                string error = null;
                switch (columnName)
                {
                    case "FullName":
                        if (FullName?.Length > 100)
                        {
                            error = "Field cannot be longer than 100 characters";
                        }
                        break;
                    case "PhoneNumber":
                        if (PhoneNumber?.Length > 100)
                        {
                            error = "Field cannot be longer than 100 characters";
                        }
                        break;
                    case "Email":
                        if (Email?.Length > 100)
                        {
                            error = "Field cannot be longer than 100 characters";
                        }
                        break;
                }
                return error;
            }
        }
        public string Error
        {
            get
            {
                return null;
            }
        }
    }


}
