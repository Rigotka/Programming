using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace Model;

/// <summary>
/// Хранит данные о контакте.
/// </summary>
public class Contact : INotifyPropertyChanged, ICloneable
{
    /// <summary>
    /// ФИО контакта.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    private string _phoneNumber;

    /// <summary>
    /// Электронная почта контакта.
    /// </summary>
    private string _email;

    /// <summary>
    /// Возвращает и задет ФИО контакта.
    /// </summary>
    public string FullName
    {
        get
        {
            return _fullName;
        }
        set
        {
            _fullName = value;
            OnPropertyChanged(nameof(FullName));
        }
    }

    /// <summary>
    /// возвращает и задает номер телефона контакта.
    /// </summary>
    public string PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            _phoneNumber = value;
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
            return _email;
        }
        set
        {
            _email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Создает экземпляр <see cref="Contact"/>
    /// </summary>
    public Contact()
    {
        FullName = "";
        PhoneNumber = "";
        Email = "";
    }

    /// <summary>
    /// Создает экземпляр <see cref="Contact"/>
    /// </summary>
    /// <param name="fullName">ФИО.</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <param name="email">Электронная почта.</param>
    public Contact(string fullName, string phoneNumber, string email)
    {
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Email = email;
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

    public object Clone() => MemberwiseClone();
}