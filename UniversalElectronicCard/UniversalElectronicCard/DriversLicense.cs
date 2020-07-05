using System;

namespace UniversalElectronicCard
{
    class DriversLicense
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiration { get; set; }
        public string IssuingBy { get; set; }
        public string SerialNumber { get; set; }
        public CarCategory Category { get; set; }

        public DriversLicense(string fullName, 
                                DateTime dateOfBirth, 
                                string placeOfBirth, 
                                DateTime dateOfIssue, 
                                DateTime dateOfExpiration, 
                                string issuingBy, 
                                string serialNumber, 
                                CarCategory category)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            DateOfIssue = dateOfIssue;
            DateOfExpiration = dateOfExpiration;
            IssuingBy = issuingBy;
            SerialNumber = serialNumber;
            Category = category;
        }

        public void IdentifyDriverLicense()
        {
            Console.WriteLine("Full name: " + FullName);
            Console.WriteLine("Date of birth: " + DateOfBirth.ToString("d"));
            Console.WriteLine("Place of birth: " + PlaceOfBirth);
            Console.WriteLine("Date of issue: " + DateOfIssue.ToString("d"));
            Console.WriteLine("Date of expiration: " + DateOfExpiration.ToString("d"));
            Console.WriteLine("Issuing by: " + IssuingBy);
            Console.WriteLine("Serial number: " + SerialNumber);
            Console.WriteLine("Category: " + Category);
          
        }



}
}
