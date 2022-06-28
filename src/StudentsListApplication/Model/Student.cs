using System;
using System.Collections.Generic;
using System.Text;
using StudentsListApplication.Service;

namespace StudentsListApplication.Model
{
    /// <summary>
    /// Хранит данные о студенте.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Количество студентов.
        /// </summary>
        private static int _allStudentsCount = 100000;
        
        /// <summary>
        /// Уникальные номер зачетки.
        /// </summary>
        private int _recordNumber;

        /// <summary>
        /// Полное имя студента.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Группа студента.
        /// </summary>
        private string _group;

        /// <summary>
        /// Факультет студента.
        /// </summary>
        private Faculty _faculty;

        /// <summary>
        /// Форма обучения студента.
        /// </summary>
        private EducationForm _educationForm;

        /// <summary>
        /// Возвращает номер зачетки.
        /// </summary>
        public int RecordNumber
        {
            get
            {
                return _recordNumber;
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя студента. Должно быть не более 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertNotNull(value, nameof(FullName));
                Validator.AssertStringMaxLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает группу студента. Должно быть не более 10 символов.
        /// </summary>
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                Validator.AssertNotNull(value, nameof(Group));
                Validator.AssertStringMaxLength(value, 10, nameof(Group));
                _group = value;
            }
        }

        /// <summary>
        /// Возвращает и задает факультет. Не может быть пустым.
        /// </summary>
        public Faculty Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                if (value == Faculty.None)
                    throw new ArgumentException("Choose faculty");
                _faculty = value;
            }
        }

        /// <summary>
        /// Возвращает и форму обучения. Не может быть пустым.
        /// </summary>
        public EducationForm EducationForm 
        {
            get
            {
                return _educationForm;
            }
            set
            {
                if (value == EducationForm.None)
                    throw new ArgumentException("Choose a form of study");
                _educationForm = value;
            }
        }

        /// <summary>
        /// Возвращает и задает картинку Base64.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="Student"/>.
        /// </summary>
        public Student()
        {
            _recordNumber = _allStudentsCount;
            _allStudentsCount++;
        }

        /// <summary>
        /// Проверяет что все поля заполнены.
        /// </summary>
        /// <param name="student">Студент</param>
        /// <returns>Возвращает true если все поля заполнены, иначе false</returns>
        public bool IsFullData()
        {
            bool isFullData = this.FullName != null
              && this.Group != null
              && this.Faculty != Faculty.None
              && this.EducationForm! != EducationForm.None;
            return isFullData;
        }
    }
}
