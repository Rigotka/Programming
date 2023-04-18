using System;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация интерфейса <see cref="ICommand"/> для сохранения в файл.
    /// </summary>
    public class SaveCommand : ICommand
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
        /// Создает экземпляр <see cref="SaveCommand"/>
        /// </summary>
        /// <param name="mainVM">ViewModel главного окна.</param>
        public SaveCommand(MainVM mainVM)
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
        /// Выполнение команды сохранения в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _serializer.SaveToFile(MainVM.Contact);
        }
    }
}
