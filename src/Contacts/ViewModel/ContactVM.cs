using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using Model;

namespace ViewModel;

/// <summary>
/// ViewModel контакта.
/// </summary>
public partial class ContactVM : ObservableValidator
{
    /// <summary>
    /// Хранит значение указывающее, что поля доступны только для чтения.
    /// </summary>
    [ObservableProperty]
    private bool _isReadOnly = false;

    /// <summary>
    /// Хранит контакт.
    /// </summary>
    private Contact _contact = new();

    /// <summary>
    /// Возвращает и задет контакт.
    /// </summary>
    public Contact Contact
    {
        get => _contact;
        set
        {
            _contact = value;
            ValidateAllProperties();
            OnPropertyChanged(nameof(FullName));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Возвращает и здает имя контакта.
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string FullName
    {
        get => Contact?.FullName;
        set
        {
            ValidateProperty(value);
            Contact.FullName = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Возвращает и задает номер телефона контакта.
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string PhoneNumber
    {
        get => Contact?.PhoneNumber;
        set
        {
            ValidateProperty(value);
            Contact.PhoneNumber = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Возрвщает и задает почту контакта.
    /// </summary>
    [EmailAddress]
    [MaxLength(100)]
    public string Email
    {
        get => Contact?.Email;
        set
        {
            ValidateProperty(value);
            Contact.Email = value;
            OnPropertyChanged();
        }
    }
}

