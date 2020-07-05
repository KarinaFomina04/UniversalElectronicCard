using System;

namespace UniversalElectronicCard
{
    class InsurancePolicy: MainPersonalData
    {
        public string SocialSecurityNumber { get; set; }

        public InsurancePolicy(string fullName,
                               Sex sex,
                               DateTime dateOfBirth, 
                               string socialSecurityNumber) : base(fullName, sex, dateOfBirth)
        {
            SocialSecurityNumber = socialSecurityNumber;
        }

        public void PrintInsurancePolicyInfo()
        {
            Console.WriteLine("Social security number: " + SocialSecurityNumber);
            PrintMainPersonalData();
        }
    }
}
