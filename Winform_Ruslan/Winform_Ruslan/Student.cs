using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Ruslan
{
    public class Student : Human
    {
        private int _group;
        private Key _key;
        private List<Coursework> _listCoursework;


        public Student() : base()
        {
            _listCoursework = new List<Coursework>();
        }
        public Student(string name, string surname, int age, Adress adress, string email, string photo, int group, Key key) : base(name, surname, age, adress, email, photo)
        {
            _group = group;
            _key = key;
        }
        public Student(Student student) : base(student._name, student._surname, student._age, student._adress, student._email, student._photo)
        {
            this._group = student._group;
            this._key = student._key;
            this._listCoursework = student._listCoursework;
        }

        public void addCoursework(Coursework coursework)
        {
            _listCoursework.Add(coursework);
        }
        public void removeCoursework(Coursework coursework)
        {
            if (_listCoursework.Contains(coursework))
            {
                _listCoursework.Remove(coursework);
            }
        }
        public void clearCoursework()
        {
            _listCoursework.Clear();
        }


        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public Key SKey
        {
            get { return _key; }
            set { _key = value; }
        }
        public List<Coursework> ListCoursework
        {
            get { return _listCoursework; }
        }
    }
}
