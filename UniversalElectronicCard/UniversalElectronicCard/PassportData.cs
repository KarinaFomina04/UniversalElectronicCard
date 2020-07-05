using System;


namespace UniversalElectronicCard
{
    class PassportData: MainPersonalData
    {
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string IdentificatioNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiration { get; set; }
        public string PlaceOfBirth { get; set; }
        public string IssuingBy { get; set; }

        public PassportData(string fullName,
                                    Sex sex,
                                    DateTime dateOfBirth, 
                                    string passportSeries, 
                                    string passportNumber,
                                    string identificatioNumber, 
                                    DateTime dateOfIssue, 
                                    DateTime dateOfExpiration, 
                                    string placeOfBirth, 
                                    string issuingBy) : base(fullName, sex, dateOfBirth)
        {
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            IdentificatioNumber = identificatioNumber;
            DateOfIssue = dateOfIssue;
            DateOfExpiration = dateOfExpiration;
            PlaceOfBirth = placeOfBirth;
            IssuingBy = issuingBy;
        }

        public void PrintIdentificationInfo()
        {
            Console.WriteLine("Passport series and number: "+ PassportSeries + PassportNumber);
            Console.WriteLine("Identification number: " + IdentificatioNumber);
            Console.WriteLine("Date of issue: " + DateOfIssue.ToString("d"));
            Console.WriteLine("Date of expiration: " + DateOfExpiration.ToString("d"));
            Console.WriteLine("Place of birth: " + PlaceOfBirth);
            Console.WriteLine("Issuing by: " + IssuingBy);
            PrintMainPersonalData();
        }
    }
}
