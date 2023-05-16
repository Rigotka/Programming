using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует интерфейс ICommand и представляет команду, которая принимает делегаты для выполнения и проверки возможности выполнения.
    /// </summary>
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;

        private Func<object, bool> _canExecute;

        /// <summary>
        /// Событие, которое указывает, что результат CanExecute изменился.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        ///  Создает новый экземпляр RelayCommand с указанными делегатами выполнения и проверки возможности выполнения.
        /// </summary>
        /// <param name="execute">Делегат, который будет вызван при выполнении команды.</param>
        /// <param name="canExecute">Делегат, который будет вызван для определения возможности выполнения команды.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>true, если команда может выполняться; в противном случае — false.</returns>
        public bool CanExecute(object parameter)
        {
            return this._canExecute == null || this._canExecute(parameter);
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
    }
}

