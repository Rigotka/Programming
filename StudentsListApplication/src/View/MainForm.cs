using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentsListApplication.src.Model;
using StudentsListApplication.src.Service;

namespace StudentsListApplication
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция студентов.
        /// </summary>
        private List<Student> _students = new List<Student>();

        /// <summary>
        /// Сериалайзер.
        /// </summary>
        private StudentSerializer _serializer = new StudentSerializer();

        /// <summary>
        /// Выбранный студент.
        /// </summary>
        private Student _currentStudent;

        public MainForm()
        {
            InitializeComponent();

            var facultyValues = Enum.GetValues(typeof(Faculty));
            foreach (var value in facultyValues)
            {
                FacultyComboBox.Items.Add(value);
            }

            var educationFormValues = Enum.GetValues(typeof(EducationForm));
            foreach (var value in educationFormValues)
            {
                EducationFormComboBox.Items.Add(value);
            }
            
            _students = _serializer.LoadFromFile();
            UpdateList();
        }

        /// <summary>
        /// Проверяет что все поля заполнены.
        /// </summary>
        /// <param name="student">Студент</param>
        /// <returns>Возвращает true если все поля заполнены, иначе false</returns>
        private bool IsFullData(Student student)
        {
            bool isFullData = student.FullName != null
              && student.Group != null
              && student.Faculty != Faculty.None
              && student.EducationForm! != EducationForm.None;
            return isFullData;
        }

        /// <summary>
        /// Формирует строку из данных студента.
        /// </summary>
        /// <param name="student">Студент.</param>
        /// <returns>Возвращает строку</returns>
        private string FormatedText(Student student)
        {
            return $"{student.FullName} - " +
                   $"{student.Group} / " +
                   $"{student.Faculty}";
        }

        /// <summary>
        /// Выделение не введенных полей.
        /// </summary>
        private void HighlightingNotEntered()
        {
            int index = StudentsListBox.SelectedIndex;
            if (HighlightCheckBox.Checked && index != -1)
            {
                if (FullNameTextBox.Text == string.Empty)
                    FullNameTextBox.BackColor = AppColor.HighlightColor;
                if (GroupTextBox.Text == string.Empty)
                    GroupTextBox.BackColor = AppColor.HighlightColor;
                if ((Faculty)FacultyComboBox.SelectedIndex == Faculty.None)
                    FacultyComboBox.BackColor = AppColor.HighlightColor;
                if ((EducationForm)EducationFormComboBox.SelectedIndex == EducationForm.None)
                    EducationFormComboBox.BackColor = AppColor.HighlightColor;

            }
            else
            {
                FullNameTextBox.BackColor = AppColor.CorrectColor;
                GroupTextBox.BackColor = AppColor.CorrectColor;
                FacultyComboBox.BackColor = AppColor.CorrectColor;
                EducationFormComboBox.BackColor = AppColor.CorrectColor;
            }
        }

        /// <summary>
        /// Обновление списка студентов.
        /// </summary>
        private void UpdateList()
        {
            int recordNumber = -1;
            if (_currentStudent != null)
                recordNumber = _currentStudent.RecordNumber;
            StudentsListBox.Items.Clear();
            
            _students.Sort(delegate (Student st1, Student st2)
            {
                if (!IsFullData(st1) && !IsFullData(st2)) 
                    return 0;
                else if (!IsFullData(st1)) 
                    return -1;
                else if (!IsFullData(st2)) 
                    return 1;
                else 
                    return st1.FullName.CompareTo(st2.FullName); 
            });

            foreach (var student in _students)
            {
                if (IsFullData(student))
                    StudentsListBox.Items.Add(FormatedText(student));
                else
                    StudentsListBox.Items.Add("not full data");
            }
            if (_currentStudent != null)
                StudentsListBox.SelectedIndex = _students.FindIndex(s => s.RecordNumber == recordNumber);
        }

        /// <summary>
        /// Обновление полей с информацией о студенте.
        /// </summary>
        private void UpdateFieldsInfo()
        {
            FullNameTextBox.Text = _currentStudent.FullName;
            RecordNumberTextBox.Text = _currentStudent.RecordNumber.ToString();
            GroupTextBox.Text = _currentStudent.Group;
            FacultyComboBox.SelectedIndex = (int)_currentStudent.Faculty;
            EducationFormComboBox.SelectedIndex = (int)_currentStudent.EducationForm;
            
            if (!string.IsNullOrEmpty(_currentStudent.Image))
            {
                AvatarPictureBox.Image = ConverterBase64.Base64ToImage(_currentStudent.Image);
                DeleteAvatarPictureBox.Image = Properties.Resources.avatar_delete;
                DeleteAvatarPictureBox.Enabled = true;
            }
            else
            {
                AvatarPictureBox.Image = Properties.Resources.defaultAvatar;
                DeleteAvatarPictureBox.Image = Properties.Resources.avatar_delete_disable;
                DeleteAvatarPictureBox.Enabled = false;
            }

            AddAvatarPictureBox.Enabled = true;
            AddAvatarPictureBox.Image = Properties.Resources.avatar_add;
        }

        /// <summary>
        /// Очистка полей с информацией о студенте. 
        /// </summary>
        private void ClearFieldsInfo()
        {
            FullNameTextBox.Text = string.Empty;
            RecordNumberTextBox.Text = string.Empty;
            GroupTextBox.Text = string.Empty;
            FacultyComboBox.SelectedIndex = -1;
            EducationFormComboBox.SelectedIndex = -1;
            AvatarPictureBox.Image = null;
            AddAvatarPictureBox.Enabled = false;
            AddAvatarPictureBox.Image = Properties.Resources.avatar_add_disable;
        }

        private void AddStudentPictureBox_Click(object sender, EventArgs e)
        {
            _currentStudent = new Student();
            _students.Add(_currentStudent);
            UpdateList();
            UpdateFieldsInfo();
        }

        private void DeleteStudentPictureBox_Click(object sender, EventArgs e)
        {
            int index = StudentsListBox.SelectedIndex;
            if (index == -1)
                return;

            _students.RemoveAt(index);
            UpdateList();
            ClearFieldsInfo();
            HighlightingNotEntered();
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = StudentsListBox.SelectedIndex;
            if (index == -1)
                return;

            _currentStudent = _students[index];
            UpdateFieldsInfo();
            HighlightingNotEntered();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = StudentsListBox.SelectedIndex;
            if (index == -1)
                return;

            FullNameTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentStudent.FullName = FullNameTextBox.Text;
                UpdateList();
            }
            catch
            {
                FullNameTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void RecordNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GroupTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = StudentsListBox.SelectedIndex;
            if (index == -1)
                return;

            GroupTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentStudent.Group = GroupTextBox.Text;
                UpdateList();
            }
            catch
            {
                GroupTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void FacultyComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = StudentsListBox.SelectedIndex;
            if (index == -1)
                return;

            FacultyComboBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentStudent.Faculty = (Faculty)FacultyComboBox.SelectedIndex;
                UpdateList();
            }
            catch
            {
                FacultyComboBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void EducationFormComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = StudentsListBox.SelectedIndex;
            if (index == -1)
                return;

            EducationFormComboBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentStudent.EducationForm = (EducationForm)EducationFormComboBox.SelectedIndex;
                UpdateList();
            }
            catch
            {
                EducationFormComboBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void HighlightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HighlightingNotEntered();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*List <Student> list = new List<Student>();
            foreach(var student in _students)
            {
                if (IsFullData(student))
                    list.Add(student);
            }
            _serializer.SaveToFile(list);*/
        }

        private void AddStudentPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddStudentPictureBox.Image = Properties.Resources.student_add_color;
        }

        private void AddStudentPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddStudentPictureBox.Image = Properties.Resources.student_add;
        }

        private void AddStudentPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AddStudentPictureBox.BackColor = SystemColors.ActiveBorder;
        }

        private void AddStudentPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddStudentPictureBox.BackColor = SystemColors.Control;
        }

        private void DeleteStudentPictureBox_MouseEnter(object sender, EventArgs e)
        {
            DeleteStudentPictureBox.Image = Properties.Resources.student_delete_color;
        }

        private void DeleteStudentPictureBox_MouseLeave(object sender, EventArgs e)
        {
            DeleteStudentPictureBox.Image = Properties.Resources.student_delete;
        }

        private void DeleteStudentPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            DeleteStudentPictureBox.BackColor = SystemColors.ActiveBorder;
        }

        private void DeleteStudentPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            DeleteStudentPictureBox.BackColor = SystemColors.Control;
        }

        private void AddAvatarPictureBox_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"(*.png)|*.png";
            openFileDialog.Title = @"Выбор картинки";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() != DialogResult.OK) 
                return;
            var fileName = openFileDialog.FileName;
            var image = Image.FromFile(fileName);
            _currentStudent.Image = ConverterBase64.ImageToBase64(image);
            AvatarPictureBox.Image = image;
            DeleteAvatarPictureBox.Enabled = true;
            DeleteAvatarPictureBox.Image = Properties.Resources.avatar_delete;
        }

        private void AddAvatarPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddAvatarPictureBox.Image = Properties.Resources.avatar_add_color;
        }

        private void AddAvatarPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddAvatarPictureBox.Image = Properties.Resources.avatar_add;
        }

        private void AddAvatarPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AddAvatarPictureBox.BackColor = SystemColors.ActiveBorder;
        }

        private void AddAvatarPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddAvatarPictureBox.BackColor = SystemColors.Control;
        }

        private void DeleteAvatarPictureBox_Click(object sender, EventArgs e)
        {
            AvatarPictureBox.Image = Properties.Resources.defaultAvatar;
            _currentStudent.Image = null;
            DeleteAvatarPictureBox.Image = Properties.Resources.avatar_delete_disable;
            DeleteAvatarPictureBox.Enabled = false;
        }

        private void DeleteAvatarPictureBox_MouseEnter(object sender, EventArgs e)
        {
            DeleteAvatarPictureBox.Image = Properties.Resources.avatar_delete_color;
        }

        private void DeleteAvatarPictureBox_MouseLeave(object sender, EventArgs e)
        {
            if(DeleteAvatarPictureBox.Enabled)
                DeleteAvatarPictureBox.Image = Properties.Resources.avatar_delete;
        }

        private void DeleteAvatarPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            DeleteAvatarPictureBox.BackColor = SystemColors.ActiveBorder;
        }

        private void DeleteAvatarPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            DeleteAvatarPictureBox.BackColor = SystemColors.Control;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                bool answer = true;
                List<Student> list = new List<Student>();
                foreach (var student in _students)
                {
                    if (IsFullData(student))
                        list.Add(student);
                    else
                        answer = false;

                }
                e.Cancel = true;
                if (!answer)
                {
                    string message = "\"not full data\" will not be saved. Are you sure you want to leave?";
                    answer = MessageBox.Show(
                            message,
                            "EXIT?",
                            MessageBoxButtons.YesNo) == DialogResult.Yes;
                }
                if (answer)
                {
                    Application.Exit();
                    _serializer.SaveToFile(list);
                }
            }
        }
    }
}
