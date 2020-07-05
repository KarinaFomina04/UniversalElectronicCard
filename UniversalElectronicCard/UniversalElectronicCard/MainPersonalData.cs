using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalElectronicCard
{
    abstract class MainPersonalData
    {
        public string FullName { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }

        protected MainPersonalData(string fullName, 
                                    Sex sex, 
                                    DateTime dateOfBirth)
        {
            FullName = fullName;
            Sex = sex;
            DateOfBirth = dateOfBirth;
        }

        public void PrintMainPersonalData()
        {
            Console.WriteLine("Full name: " + FullName);
            Console.WriteLine("Sex: " + Sex);
            Console.WriteLine("Date of birth: " + DateOfBirth.ToString("d"));
        }
        
    }
}
