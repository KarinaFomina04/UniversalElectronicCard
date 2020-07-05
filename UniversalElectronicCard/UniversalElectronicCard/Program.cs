using System;

namespace UniversalElectronicCard
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversalElectronicCard universalElectronicCard = InitCard();
            InitUI(universalElectronicCard);

        }
        private static void  InitUI(UniversalElectronicCard universalElectronicCard)
        {
            Console.WriteLine("Hello user, what do you want to do?");
            Console.WriteLine("Select option number.");
            Console.WriteLine("1. View passport data.");
            Console.WriteLine("2. View insurance policy.");
            Console.WriteLine("3. Pay for purchase.");
            Console.WriteLine("4. Pay for ticket.");
            Console.WriteLine("5. View drivers license.");
            Console.WriteLine("For exit input the word \"exit\". ");
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        universalElectronicCard.PrintIdentification();
                        break;
                    case "2":
                        universalElectronicCard.PrintInsurancePolicyInfo();
                        break;
                    case "3":
                        Console.WriteLine("Input the sum:");
                        string sum = Console.ReadLine();
                        if (int.TryParse(sum, out _))
                        {
                            universalElectronicCard.PayForPurchase(Convert.ToInt32(sum));
                        }
                        else
                        {
                            Console.WriteLine("Invalid sum.");
                        }

                        break;
                    case "4":
                        universalElectronicCard.PayForATickets();
                        break;
                    case "5":
                        universalElectronicCard.IdentifyDriverLicense();
                        break;
                    case "exit":
                        Console.WriteLine("Good bye.");
                        return;
                    default:
                        Console.WriteLine("Invalid variant.");
                        break;
                }

            }
        }

        private static UniversalElectronicCard InitCard()
        {

            DateTime dateOfBirth = Convert.ToDateTime("04.08.1997");
            string fullName = "Karina Fomina";

            PassportData passportData = new PassportData(fullName,
                                                            Sex.FEMALE,
                                                            dateOfBirth,
                                                            "TM", "9371284",
                                                            "70YUW0CEY6N3SQ",
                                                            Convert.ToDateTime("20.12.2010"),
                                                            Convert.ToDateTime("20.01.2021"),
                                                            "Russia,  Voronezhskaya oblast,  Voronezh",
                                                            "Ministry of Internal Affairs of Russia in the city of Voronezh");

            InsurancePolicy insurancePolicy = new InsurancePolicy(fullName,
                                                                  Sex.FEMALE,
                                                                  dateOfBirth,
                                                                  "70YUW0CEY6N3SQ");

            CardData cardData = new CardData("4485754016244293", Convert.ToDateTime("20.01.2025"), fullName, "123", 500);

            Ticket ticket = new Ticket(Convert.ToDateTime("20.08.2020"), 34);

            DriversLicense driversLicense = new DriversLicense(fullName,
                                                               dateOfBirth,
                                                               "Russia,  Voronezhskaya oblast,  Voronezh",
                                                                Convert.ToDateTime("20.10.2018"),
                                                                Convert.ToDateTime("20.10.2023"),
                                                                "Ministry of Internal Affairs of Russia in the city of Voronezh",
                                                                "576BM78",
                                                                CarCategory.B);

            UniversalElectronicCard universalElectronicCard = new UniversalElectronicCard(passportData,
                                                                                          insurancePolicy,
                                                                                          cardData,
                                                                                          ticket,
                                                                                          driversLicense);
            return universalElectronicCard;
        } 


    }
}
