using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Ruslan
{
    public class ListTeacher
    {
        private List<Teacher> _listTeacher;
        public ListTeacher()
        {
            _listTeacher = new List<Teacher>();
        }
        public ListTeacher(ListTeacher listTeacher)
        {
            this._listTeacher = listTeacher.LTeacher;
        }

        public void add(Teacher teacher)
        {
            _listTeacher.Add(teacher);
        }
        public void removeCoursework(Teacher teacher)
        {
            if (_listTeacher.Contains(teacher))
            {
                _listTeacher.Remove(teacher);
            }
        }
        public void clear()
        {
            _listTeacher.Clear();
        }

        public List<Teacher> LTeacher
        {
            get { return _listTeacher; }
        }
    }
}
