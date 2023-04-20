using Homework6.A_Class;
using Homework6.D_Class;
using Homework6.M_Class;
using Homework6.S_Class;

namespace Homework6
{
    public class Starter
    {
        public void Run()
        {
            var index = 0;
            TaxiPark taxiPark = new TaxiPark();
            Cars[] carsInPark = new Cars[1];

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nWelcome to *F1rst Motors Dealership*");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("-----");
                Console.WriteLine("1. Show cars");
                Console.WriteLine("2. Subscribe a selected car park");
                Console.WriteLine("3. Find car in your car park");
                Console.WriteLine("4. Contact us");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\nWelcome to *F1rst Motors Dealership*");
                        Console.WriteLine("\nPresentation of cars:");
                        Console.WriteLine("\n" + new string('-', 40));
                        MicroCar[] microCars = taxiPark.GetMicroCars();
                        CityCar[] cityCars = taxiPark.GetCityCars();
                        MidSizeCar[] midSizeCars = taxiPark.GetMidSizeCars();
                        CompactExecutiveCar[] compactExecutiveCars = taxiPark.GetCompactExecutiveCars();
                        CompactMinivan[] compactMinivans = taxiPark.GetCompactMinivans();
                        Minivan[] minivans = taxiPark.GetMinivanans();
                        BusinessCar[] businessCars = taxiPark.GetBusinessCars();
                        Convertible[] convertibles = taxiPark.GetConvertibles();
                        Console.WriteLine(new string('-', 40));
                        Console.Write("\nWhat car you want to add: ");
                        int takeCar = Convert.ToInt32(Console.ReadLine());
                        if (takeCar >= 1 && takeCar <= 3)
                        {
                            for (int i = 0; i < microCars.Length; i++)
                            {
                                if (i == (takeCar - 1))
                                {
                                    carsInPark[index] = microCars[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeCar >= 4 && takeCar <= 6)
                        {
                            for (int i = 0; i < cityCars.Length; i++)
                            {
                                if (i == (takeCar - 4))
                                {
                                    carsInPark[index] = cityCars[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeCar >= 7 && takeCar <= 9)
                        {
                            for (int i = 0; i < midSizeCars.Length; i++)
                            {
                                if (i == (takeCar - 7))
                                {
                                    carsInPark[index] = midSizeCars[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeCar >= 10 && takeCar <= 12)
                        {
                            for (int i = 0; i < compactExecutiveCars.Length; i++)
                            {
                                if (i == (takeCar - 10))
                                {
                                    carsInPark[index] = compactExecutiveCars[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeCar >= 13 && takeCar <= 15)
                        {
                            for (int i = 0; i < compactMinivans.Length; i++)
                            {
                                if (i == (takeCar - 13))
                                {
                                    carsInPark[index] = compactMinivans[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeCar >= 16 && takeCar <= 18)
                        {
                            for (int i = 0; i < minivans.Length; i++)
                            {
                                if (i == (takeCar - 16))
                                {
                                    carsInPark[index] = minivans[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeCar >= 19 && takeCar <= 21)
                        {
                            for (int i = 0; i < businessCars.Length; i++)
                            {
                                if (i == (takeCar - 19))
                                {
                                    carsInPark[index] = businessCars[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeCar >= 22 && takeCar <= 24)
                        {
                            for (int i = 0; i < convertibles.Length; i++)
                            {
                                if (i == (takeCar - 22))
                                {
                                    carsInPark[index] = convertibles[i];
                                    index++;
                                }
                            }

                            Cars[] carsInParkMore = new Cars[carsInPark.Length + 1];
                            for (int i = 0; i < carsInPark.Length; i++)
                            {
                                carsInParkMore[i] = carsInPark[i];
                            }

                            carsInPark = carsInParkMore;
                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        break;
                    case "2":
                        Console.Clear();
                        var sumPriceOfCars = 0;
                        Console.WriteLine("|* Your personal car park *|");
                        Console.WriteLine("\n" + new string('-', 40));
                        Array.Sort(carsInPark);
                        for (int i = 0; i < carsInPark.Length; i++)
                        {
                            if (carsInPark[i] != null)
                            {
                                Console.WriteLine(carsInPark[i].GetInfoTaxiPark());
                            }
                        }

                        for (int i = 0; i < carsInPark.Length; i++)
                        {
                            if (carsInPark[i] != null)
                            {
                                sumPriceOfCars += carsInPark[i].Price;
                            }
                        }

                        Console.WriteLine(new string('-', 40));
                        Console.WriteLine($"\nTotal price: {sumPriceOfCars}$");
                        break;
                    case "3":
                        var indexItem = 0;
                        Console.Write("Find by standart (write year): ");
                        var findItem = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < carsInPark.Length; i++)
                        {
                            if (carsInPark[i] != null)
                            {
                                carsInPark[indexItem] = carsInPark[i];
                                if (findItem == carsInPark[indexItem].Year)
                                {
                                    Console.WriteLine(carsInPark[indexItem].GetInfoTaxiPark());
                                }
                            }
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(" *Contact Us*");
                        Console.WriteLine(new string('-', 25));
                        ContactUs contactUs = new ContactUs();
                        contactUs.GetContact();
                        Console.WriteLine(new string('-', 25));
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
