namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задет ФИО контакта.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="Contact"/>
        /// </summary>
        public Contact()
        {
            FullName = "Петров Петр";
            PhoneNumber = "8-800-555-35-35";
            Email = "some_soap@mail.ru";
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
    }
}
