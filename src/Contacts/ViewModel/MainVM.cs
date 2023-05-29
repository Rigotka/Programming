using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using CommunityToolkit.Mvvm.ComponentModel;
using Model.Services;

namespace ViewModel;

/// <summary>
/// Реализация ViewModel для MainWindow.
/// </summary>
public partial class MainVM : ObservableObject
{
    /// <summary>
    /// Хранит коллекцию контактов.
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<Contact> _contacts;

    /// <summary>
    /// Возвращает и задает <see cref="ContactVM"/>
    /// </summary>
    [ObservableProperty]
    private ContactVM _contactVM = new ContactVM();

    /// <summary>
    /// Индекс редактируемого объекта.
    /// </summary>
    private int _editIndex = -1;

    /// <summary>
    /// Сериализатор.
    /// </summary>
    private ContactSerializer _serializer = new ContactSerializer("contact");

    /// <summary>
    /// Хранит выбранный контакт.
    /// </summary>
    private Contact _contact;

    /// <summary>
    /// Возрващает и задает контакт. 
    /// </summary>
    public Contact Contact
    {
        get => _contact;
        set
        {
            _contact = value;
            ContactVM.Contact = _contact;
            if (Contacts.Contains(Contact))
                _editIndex = -1;
            OnPropertyChanged();
            ContactVM.IsReadOnly = IsCreateOrEditMode;
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
            OnPropertyChanged(nameof(IsCreateOrEditMode));
        }
    }

    /// <summary>
    /// Команда добавления.
    /// </summary>
    [RelayCommand]
    private void Add()
    {
        _editIndex = -1;
        Contact = new Contact();
        ContactVM.Contact = Contact;
    }

    /// <summary>
    /// Команда изменения.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanEdit))]
    private void Edit()
    {
        _editIndex = Contacts.IndexOf(Contact);
        Contact = (Contact)Contact.Clone();
        ContactVM.Contact = Contact;
    }

    private bool CanEdit()
    {
        return Contacts.Contains(Contact);
    }

    /// <summary>
    /// Команда удаления.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanRemove))]
    private void Remove()
    {
        var index = Contacts.IndexOf(Contact);
        Contacts.Remove(Contact);

        if (Contacts.Count == 0)
            return;

        if (index == Contacts.Count)
            index -= 1;

        Contact = Contacts[index];
    }

    private bool CanRemove()
    {
        return Contacts.Contains(Contact);
    }

    /// <summary>
    /// Команда принятия.
    /// </summary>
    [RelayCommand]
    private void Apply()
    {
        if (IsCreateMode)
        {
            Contacts.Add(ContactVM.Contact);
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }
        if (IsEditMode)
        {
            Contacts[_editIndex] = Contact;
            Contact = Contacts[_editIndex];

            _editIndex = -1;
        }
        OnPropertyChanged(nameof(IsCreateOrEditMode));
        ContactVM.IsReadOnly = IsCreateOrEditMode;
    }

    /// <summary>
    /// Команда закрытия.
    /// </summary>
    [RelayCommand]
    private void Close()
    {
        _serializer.SaveToFile(Contacts);
    }

    /// <summary>
    /// Возвращает true если создается новый контакт, иначе false.
    /// </summary>
    public bool IsCreateMode
    {
        get => !Contacts.Contains(Contact) && Contact != null && _editIndex == -1;
    }

    /// <summary>
    /// Возвращает true если изменяется контакт, иначе false. 
    /// </summary>
    public bool IsEditMode
    {
        get => _editIndex != -1;
    }

    /// <summary>
    /// Возвращает true если идет создание или изменение контакта, иначе false.
    /// </summary>
    public bool IsCreateOrEditMode
    {
        get => IsCreateMode || IsEditMode;
    }

    /// <summary>
    /// Создает экземпляр <see cref="MainVM"/>
    /// </summary>
    public MainVM()
    {
        Contacts = _serializer.LoadFromFile();
    }
}
