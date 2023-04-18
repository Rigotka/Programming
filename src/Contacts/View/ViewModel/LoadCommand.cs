using System;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация интерфейса <see cref="ICommand"/> для загрузки из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private ContactSerializer _serializer = new ContactSerializer("contact");

        /// <summary>
        /// ViewModel главного окна.
        /// </summary>
        public MainVM MainVM { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="LoadCommand"/>
        /// </summary>
        /// <param name="mainVM">ViewModel главного окна.</param>
        public LoadCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }

        /// <summary>
        /// Событие изменения возможности вызова команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Проверяет возможность выполнения команды.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполнение команды загрузки из файла.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            var contact = _serializer.LoadFromFile();
            MainVM.FullName = contact.FullName;
            MainVM.PhoneNumber = contact.PhoneNumber;
            MainVM.Email = contact.Email;
        }
    }
}
