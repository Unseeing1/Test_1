using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Ruslan
{
    public class Coursework
    {
        private string _title;
        private string _description;
        private DateTime _date;

        public Coursework()
        {
            _title = "title of my work";
            _description = "description of my work";
            _date = DateTime.Today;
        }
        public Coursework(string title, string description, DateTime date)
        {
            _title = title;
            _description = description;
            _date = date;
        }
        public Coursework(Coursework c)
        {
            this._title = c._title;
            this._description = c._description;
            this._date = c._date;
        }
        public string toStr()
        {
            return
                ("Title: " + this.Title + "\n" +
                 "Description: " + this.Description + "\n" +
                 "Deadline: " + this.Date.ToString());
        }
        public void printInfo() => this.toStr();

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
