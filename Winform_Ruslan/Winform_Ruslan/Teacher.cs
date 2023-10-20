using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Ruslan
{
    public class Teacher : Human
    {
        private int _salary;
        private int _numofseat;
        private Key _key;
        private List<Student> _listStudent;
        public Teacher() : base()
        {
            _listStudent = new List<Student>();
        }
        public Teacher(string name, string surname, int age, Adress adress, string email, string photo, int salary, int numofseat, Key key) : base(name, surname, age, adress, email, photo)
        {
            _salary = salary;
            _numofseat = numofseat;
            _key = key;
        }
        public void addStudent(Student student)
        {
            if ((this._key == student.SKey)&& (_listStudent.Count <= _numofseat))
            {
                _listStudent.Add(student);
            }
        }
        public void removeStudent(Student student)
        {
            if (_listStudent.Contains(student))
            {
                _listStudent.Remove(student);
            }
        }
        public void clearStudent()
        {
            _listStudent.Clear();
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public int Numofseat
        {
            get { return _numofseat; }
            set { _numofseat = value; }
        }
        public Key TKey
        {
            get { return _key; }
            set { _key = value; }
        }
        public List<Student> ListStudent
        {
            get { return _listStudent; }
        }
    }
}
