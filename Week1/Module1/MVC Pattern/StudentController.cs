using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    public class StudentController
    {
        private Student _student;
        private StudentView _view;

        public StudentController(Student student, StudentView view)
        {
            _student = student;
            _view = view;
        }
        public void SetStudentName(string name)
        {
            _student.Name = name;
        }
        public string GetStudentName()
        {
            return _student.Name;
        }

        public void SetStudentId(int id)
        {
            _student.Id = id;
        }

        public int GetStudentId()
        {
            return _student.Id;
        }

        public void SetStudentGrade(string grade)
        {
            _student.Grade = grade;
        }

        public string GetStudentGrade()
        {
            return _student.Grade;
        }

        public void UpdateView()
        {
            _view.DisplayStudentDetails(_student.Name, _student.Id, _student.Grade);
        }
    }

    }
