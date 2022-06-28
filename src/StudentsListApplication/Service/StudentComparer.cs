using System;
using System.Collections.Generic;
using System.Text;
using StudentsListApplication.Model;

namespace StudentsListApplication.Service
{
    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (!student1.IsFullData() && !student2.IsFullData())
                return 0;
            else if (!student1.IsFullData())
                return -1;
            else if (!student2.IsFullData())
                return 1;
            else
                return student1.FullName.CompareTo(student2.FullName);
        }
    }
}
