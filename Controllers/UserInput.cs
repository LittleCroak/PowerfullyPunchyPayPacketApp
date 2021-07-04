namespace PowerfullyPunchyPayPacketApp.Controllers
{
    using PowerfullyPunchyPayPacketApp.Models;
    using System;
    public class UserInput
    {
        public SalaryItems getUserInput (SalaryItems salary)
        {
            salary = getInputFromUser(salary);
            return salary;
        }

        private SalaryItems getInputFromUser(SalaryItems salary)
        {
            salary.grossPackage = getGrossPayFromUser();
            salary.payFrequency = getPayFrequencyFromUser();

            return salary;
        }

        private double getGrossPayFromUser()
        {
            Console.WriteLine("Please Enter your Gross Pay packet: ");
            double incGross = 0;
            bool correctInput = false;

            while (correctInput == false)
            {
                if (double.TryParse(Console.ReadLine(), out incGross))
                {
                    correctInput = true;
                }
                else
                {
                    // Give error if the user trys to be 'clever' with their user input
                    Console.WriteLine("Please enter a correct number");
                }
            }
            return incGross;
        }

        private string getPayFrequencyFromUser()
        {
            var incString = "empty";
            StringErrorChecker stringErrorChecker = new StringErrorChecker();
            var correctInput = false;

            while (correctInput == false)
            {
                Console.WriteLine("Please Enter your frequency of pay, for example: ");
                Console.WriteLine("Weekly, Fortnightly, Monthly");
                incString = Console.ReadLine();
                correctInput = stringErrorChecker.stringErrorChecker(incString);            
            }
            return incString;
        }
    }
}
