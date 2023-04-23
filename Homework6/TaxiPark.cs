using Homework6.A_Class;
using Homework6.D_Class;
using Homework6.M_Class;
using Homework6.S_Class;

namespace Homework6
{
    public class TaxiPark
    {
        private MicroCar[] _microCars =
        {
            new MicroCar("Smart", "Fortwo", 16500, "A-Class", 5, 2017, 1, "Сoupe", 2, 4, "Front", "White", "Germany"),
            new MicroCar("Toyota", "iQ", 14000, "A-Class", 5, 2015, 1.4, "Сoupe", 2, 3, "Front", "Grey", "Japan"),
            new MicroCar("Aston Martin", "Cygnet", 36000, "A-Class", 6, 2017, 1.3, "Сoupe", 2, 4, "Front", "Red", "United Kingdom"),
        };
        private CityCar[] _cityCars =
        {
             new CityCar("Ford", "KA", 12400, "A-Class", 7, 2012, 1.2, "Hatchback", 4, 5, "Front", "Blue", "USA"),
             new CityCar("Opel", "Karl", 13800, "A-Class", 4.8, 2019, 1, "Hatchback", 4, 5, "Front", "White", "Germany"),
             new CityCar("KIA", "Picanto", 12992, "A-Class", 4.5, 2016, 1.2, "Hatchback", 4, 5, "Front", "Pink", "South Korea"),
        };
        private MidSizeCar[] _midSizeCars =
        {
            new MidSizeCar("Volkswagen", "Passat", 28300, "D-Class", 8.3, 2019, 2.0, "Sedan", 4, 5, "Front", "Yellow", "Germany"),
            new MidSizeCar("Ford", "Mondeo", 17600, "D-Class", 11.6, 2012, 2.5, "Sedan", 4, 5, "Front", "Metalic", "USA"),
            new MidSizeCar("Peugeot", "508", 22100, "D-Class", 7.2, 2019, 1.6, "Sedan", 4, 5, "Front", "Red", "France")
        };
        private CompactExecutiveCar[] _compactExecutiveCars =
        {
             new CompactExecutiveCar("Mercedes-Benz", "C 200", 29400, "D-Class", 8.7, 2016, 1.5, "Sedan", 4, 5, "Rear", "White", "Germany"),
             new CompactExecutiveCar("BMW", "320", 25300, "D-Class", 7.3, 2017, 2.0, "Sedan", 4, 5, "Rear", "Black", "Germany"),
             new CompactExecutiveCar("Alfa Romeo", "159", 23318, "D-Class", 12.2, 2017, 1.9, "Sedan", 4, 5, "Front", "Red", "Switzerland"),
        };
        private CompactMinivan[] _compactMinivans =
        {
             new CompactMinivan("Nissan", "Note", 15400, "D-Class", 8.5, 2016, 1.6, "Compact Minivan", 5, 5 / 7, "Full", 4100, "Gold", "Japan"),
             new CompactMinivan("Mazda", "5", 11400, "D-Class", 9.3, 2015, 1.8, "Compact Minivan", 5, 7, "Front", 4585, "Indigo", "Japan"),
             new CompactMinivan("Citroen", "Berlingo Multispace ", 17900, "D-Class", 4.1, 2020, 1.5, "Compact Minivan", 5, 5 / 7, "Front", 4403, "Brown", "France"),
        };
        private Minivan[] _minivans =
        {
            new Minivan("Mercedes-Benz", "Vito", 21400, "D-Class", 6.2, 2017, 2.0, "Minivan", 5, 8, "Full", 5140, "Black", "Germany"),
            new Minivan("Toyota", "Alphard", 25700, "D-Class", 11.3, 2020, 2.5, "Minivan", 5, 7, "Full", 4945, "Dark Blue", "Japan"),
            new Minivan("Ford", "Galaxy", 20200, "D-Class", 5.7, 2018, 2.0, "Minivan", 5, 5 / 7, "Full", 4848, "Black", "USA"),
        };
        private BusinessCar[] _businessCars =
        {
            new BusinessCar("Mercedes-Benz", "Maybach S-680", 150000, "S-Class", 14.3, 2021, 6.0, "Sedan", 4, 4, "Full", "Yes", "Black", "Germany"),
            new BusinessCar("Jaguar", "XJ", 120000, "S-Class", 16.2, 2021, 5.0, "Sedan", 4, 5, "Rear", "Yes", "Brown", "Germany"),
            new BusinessCar("Maserati", "Quattroporte Trofeo", 180000, "S-Class", 17.5, 2021, 3.8, "Sedan", 4, 4, "Full", "Yes", "Gold", "Germany"),
        };
        private Convertible[] _convertibles =
        {
            new Convertible("Bentley", "Continental GT Convertible", 95000, "S-Class", 14.8, 2021, 6.0, "Sedan", 2, 4, "Full", "No", "Coffee", "Germany"),
            new Convertible("Lexus", "LC 500 Convertible ", 80000, "S-Class", 8.7, 2020, 5.0, "Sedan", 2, 4, "Full", "No", "Yellow", "Japan"),
            new Convertible("Porsche", "718 Spyder", 110000, "S-Class", 8.1, 2021, 4.0, "Sedan", 2, 4, "Full", "No", "White", "Germany"),
        };
        public MicroCar[] GetMicroCars()
        {
            for (int i = 0; i < _microCars.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(_microCars[i].GetInfoTaxiPark() + " ");
            }

            return _microCars;
        }

        public CityCar[] GetCityCars()
        {
            for (int i = 0; i < _cityCars.Length; i++)
            {
                Console.Write(i + 4 + ". ");

                Console.WriteLine(_cityCars[i].GetInfoTaxiPark());
            }

            return _cityCars;
        }

        public MidSizeCar[] GetMidSizeCars()
        {
            for (int i = 0; i < _midSizeCars.Length; i++)
            {
                Console.Write(i + 7 + ". ");
                Console.WriteLine(_midSizeCars[i].GetInfoTaxiPark());
            }

            return _midSizeCars;
        }

        public CompactExecutiveCar[] GetCompactExecutiveCars()
        {
            for (int i = 0; i < _compactExecutiveCars.Length; i++)
            {
                Console.Write(i + 10 + ". ");
                Console.WriteLine(_compactExecutiveCars[i].GetInfoTaxiPark());
            }

            return _compactExecutiveCars;
        }

        public CompactMinivan[] GetCompactMinivans()
        {
            for (int i = 0; i < _compactMinivans.Length; i++)
            {
                Console.Write(i + 13 + ". ");
                Console.WriteLine(_compactMinivans[i].GetInfoTaxiPark());
            }

            return _compactMinivans;
        }

        public Minivan[] GetMinivanans()
        {
            for (int i = 0; i < _minivans.Length; i++)
            {
                Console.Write(i + 16 + ". ");
                Console.WriteLine(_minivans[i].GetInfoTaxiPark());
            }

            return _minivans;
        }

        public BusinessCar[] GetBusinessCars()
        {
            for (int i = 0; i < _businessCars.Length; i++)
            {
                Console.Write(i + 19 + ". ");
                Console.WriteLine(_businessCars[i].GetInfoTaxiPark());
            }

            return _businessCars;
        }

        public Convertible[] GetConvertibles()
        {
            for (int i = 0; i < _convertibles.Length; i++)
            {
                Console.Write(i + 22 + ". ");
                Console.WriteLine(_convertibles[i].GetInfoTaxiPark());
            }

            return _convertibles;
        }
    }
}
