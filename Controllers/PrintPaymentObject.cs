namespace PowerfullyPunchyPayPacketApp.Controllers
{
    using System;
    using PowerfullyPunchyPayPacketApp.Models;
    public class PrintObject
    {
        public void printObject(SalaryItems salary)
        {
            printOutObjects(salary);
        }

        private void printOutObjects(SalaryItems salary)
        {
            //Originally wrote an object dumper to output the entire object in one line of code, it looked ugly on output so this is a beter formatted version:
            Console.WriteLine(" ");
            Console.WriteLine("Gross Package: " + salary.grossPackage.ToString("C2"));
            Console.WriteLine("Super Contribution: " + salary.superContribution.ToString("C2"));
            Console.WriteLine("Taxable Income: " + salary.taxableIncome.ToString("C2"));
            Console.WriteLine(" ");

            Console.WriteLine("Deductions: ");
            Console.WriteLine("Medicare Levy: " + salary.deductionItems.medicareLevy.ToString("C2"));
            Console.WriteLine("Budget repair Levy: " + salary.deductionItems.budgetRepairLevy.ToString("C2"));
            Console.WriteLine("Income tax: " + salary.deductionItems.incomeTax.ToString("C2"));
            Console.WriteLine(" ");

            Console.WriteLine("Net Income: " + salary.netIncome.ToString("C2"));
            Console.WriteLine("Pay Packet: " + salary.payFrequencyAmount.ToString("C2") + " " + salary.payFrequency);
        }
    }
}
