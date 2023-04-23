using Homework6.Interfaces;

namespace Homework6
{
    public class Cars : IShowTaxiPark, IComparable<Cars>
    {
        private string _brand;
        private string _model;
        private int _price;
        private string _level;
        private double _fuelConsumption;
        private int _year;
        public string Brand
        {
            get { return _brand; }
        }

        public string Model
        {
            get { return _model; }
        }

        public int Price
        {
            get { return _price; }
        }

        public string Level
        {
            get { return _level; }
        }

        public double FuelConsumption
        {
            get { return _fuelConsumption; }
        }

        public int Year
        {
            get { return _year; }
        }

        public Cars(string brand, string model, int price, string level, double fuelConsuption, int year)
        {
            _brand = brand;
            _model = model;
            _price = price;
            _level = level;
            _fuelConsumption = fuelConsuption;
            _year = year;
        }

        public string GetInfoTaxiPark()
        {
            return $"Brand: {_brand} | Model: {_model} | Level: {_level} | Fuel: {_fuelConsumption}L | Price: {_price}$ | Year: {_year} ";
        }

        public int CompareTo(Cars? other)
        {
            return FuelConsumption.CompareTo(FuelConsumption);
        }
    }
}
