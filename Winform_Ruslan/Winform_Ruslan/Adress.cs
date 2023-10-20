using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Ruslan
{
    public class Adress
    {
        private string _country;
        private string _city;
        private string _street;
        private int _house;

        public Adress()
        {
            _country = "Ukraine";
            _city = "Kherson";
            _street = "Street_Kherson";
            _house = 0;
        }

        public Adress(string country, string city, string street, int house)
        {
            _country = country;
            _city = city;
            _street = street;
            _house = house;
        }
        public Adress(Adress ad)
        {
            this._country = ad._country;
            this._city = ad._city;
            this._street = ad._street;
            this._house = ad._house;
        }

        public string adressToString()
        {
            return (
                "Country: " + this._country + "\n" +
                "City: " + this._city + "\n" +
                "Street: " + this._street + "\n" +
                "House: " + this._house.ToString()
                );
        }
        public Adress inputAdress()
        {
            Console.WriteLine("Country: "); string country = Console.ReadLine();
            Console.WriteLine("City: "); string city = Console.ReadLine();
            Console.WriteLine("Street: "); string street = Console.ReadLine();
            Console.WriteLine("House: ");int house = int.Parse(Console.ReadLine());

            Adress adress = new Adress(country, city, street, house);
            return adress;
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public int House
        {
            get { return _house; }
            set { _house = value; }
        }
    }
}
