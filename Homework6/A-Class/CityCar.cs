using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.A_Class
{
    public class CityCar : AClass
    {
        private int _doors;
        private int _seats;
        private string _wheelDrive;
        private string _color;
        private string _country;
        public string Country
        {
            get { return _country; }
        }

        public string Color
        {
            get { return _color; }
        }

        public int Doors
        {
            get { return _doors; }
        }

        public int Seats
        {
            get { return _seats; }
        }

        public string WheelDrive
        {
            get { return _wheelDrive; }
        }

        public CityCar(string brand, string model, int price, string level, double fuelConsuption, int year, double engine, string type, int doors, int seats, string wheelDrive, string color, string country)
            : base(brand, model, price, level, fuelConsuption, year, engine, type)
        {
            _doors = doors;
            _seats = seats;
            _wheelDrive = wheelDrive;
            _color = color;
            _country = country;
        }

        public new string GetInfoTaxiPark()
        {
            return base.GetInfoTaxiPark() + $" | Doors: {_doors} | Seats: {_seats} | Wheel Drive: {_wheelDrive} | Color: {_color} | Country: {_country} |";
        }
    }
}
