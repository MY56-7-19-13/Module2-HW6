using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.S_Class
{
    public class SClass : Cars
    {
        private string _type;
        private double _engine;
        public double Engine
        {
            get { return _engine; }
        }

        public string Type
        {
            get { return _type; }
        }

        public SClass(string brand, string model, int price, string level, double fuelConsuption, int year, double engine, string type)
            : base(brand, model, price, level, fuelConsuption, year)
        {
            _engine = engine;
            _type = type;
        }

        public new string GetInfoTaxiPark()
        {
            return base.GetInfoTaxiPark() + $" | Engine: {_engine} | Type: {_type} ";
        }
    }
}
