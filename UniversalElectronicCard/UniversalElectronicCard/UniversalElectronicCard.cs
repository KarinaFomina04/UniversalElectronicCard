using System;


namespace UniversalElectronicCard
{
    class UniversalElectronicCard 
    {
        public PassportData PassportData { get; set; }
        public InsurancePolicy InsurancePolicy { get; set; }
        public CardData CardData { get; set; }
        public Ticket Ticket { get; set; }
        public DriversLicense DriversLicense { get; set; }

        public UniversalElectronicCard(PassportData passportData,
                                        InsurancePolicy insurancePolicy, 
                                        CardData cardData, 
                                        Ticket ticket, 
                                        DriversLicense driversLicense)
        {
            PassportData = passportData;
            InsurancePolicy = insurancePolicy;
            CardData = cardData;
            Ticket = ticket;
            DriversLicense = driversLicense;
        }

        public void PrintIdentification()
        {
            PassportData.PrintIdentificationInfo();
        }
        public void PrintInsurancePolicyInfo()
        {
            InsurancePolicy.PrintInsurancePolicyInfo();
        }
        public void PayForPurchase(int Sum)
        {
            CardData.PayForPurchase(Sum);
        }
        public void FillBalance(int Sum)
        {
            CardData.FillBalance(Sum);
        }
   
        public void PayForATickets()
        {
            if (IsDurationExpired()) {
                Console.WriteLine("Duration is expired");
                int TicketCost = Ticket.Cost;
                if (CardData.Balance >= TicketCost)
                {
                    Console.WriteLine("Registration of a new ticket");
                    CardData.PayForPurchase(TicketCost);
                    Ticket.Duration = DateTime.Today.AddMonths(1);
                }
            }
            else { 
                Console.WriteLine("Ticket paid"); 
            }   
        }

        private bool IsDurationExpired()
        {
            return DateTime.Today > Ticket.Duration;
        }

        public void IdentifyDriverLicense()
        {
            DriversLicense.IdentifyDriverLicense();
        }
    }

}
