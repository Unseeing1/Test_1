using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Winform_Ruslan
{
    public enum Key { JavaScript, Swift, Go, PHP, Python, Java, Kotlin, Scala };
    public class Human
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected Adress _adress;
        protected string _email;
        protected string _photo;

        public Human()
        {
            _name = "Name";
            _surname = "Surname";
            _age = 18;
            _adress = new Adress();
            _email = "Name_Surname@email.ua";
            _photo = Application.StartupPath + @"\image\default_image.png";
        }
        public Human(string name, string surname, int age, Adress adress, string email, string photo)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _adress = adress;
            _email = email;
            _photo = photo;
        }
        public Human(Human hum)
        {
            this._name = hum._name;
            this._surname = hum._surname;
            this._age = hum._age;
            this._adress = hum._adress;
            this._email = hum._email;
            this._photo = hum._photo;
        }
        public void WriteToJson(string pathToFile)
        {
            File.WriteAllText(pathToFile, JsonConvert.SerializeObject(this));
        }
        public void changeInfo()
        {
            Console.WriteLine("Enter new data: ");
            Console.WriteLine("Name: "); Name = Console.ReadLine();
            Console.WriteLine("Surname: "); Surname = Console.ReadLine();
            Console.WriteLine("Age: "); Age = Int32.Parse(Console.ReadLine());
        }
        public static bool operator >(Human one, Human two)
        {
            bool result = one._age > two._age;
            return result;
        }
        public static bool operator <(Human one, Human two)
        {
            bool result = one._age < two._age;
            return result;
        }
        public virtual void printInfo()
        {
            Console.WriteLine(dataToStr());
        }
        public string dataToStr()
        {
            string str;
            str = "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" + _adress.adressToString();
            return str;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Adress Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
    }
}