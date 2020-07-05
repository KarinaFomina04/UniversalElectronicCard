using System;

namespace UniversalElectronicCard
{
    class CardData
    {
        public string CardNumber { get; set; }
        public DateTime Duration { get; set; }
        public string NameCard { get; set; }
        public string SecurityCode { get; set; }
        public int Balance { get; set; }

        public CardData(string cardNumber, 
                        DateTime duration, 
                        string nameCard, 
                        string securityCode, 
                        int balance)
        {
            CardNumber = cardNumber;
            Duration = duration;
            NameCard = nameCard;
            SecurityCode = securityCode;
            Balance = balance;
        }

        public void PayForPurchase(int Sum)
        {
            Balance -= Sum;
            Console.WriteLine("Purchase paid in the amount of " + Sum);
        }
        public void FillBalance(int Sum)
        {
            Balance += Sum;
            Console.WriteLine("The balance is replenished on " + Sum);
        }
    }
}
