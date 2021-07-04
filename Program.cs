namespace PowerfullyPunchyPayPacketApp
{
    using System.Net.Http;
    using System;
    using PowerfullyPunchyPayPacketApp.Controllers;
    using PowerfullyPunchyPayPacketApp.Models;

    public class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            HttpClient client = new HttpClient();


            // update port and uri settings:
            SetupNetworking setupNetworking = new SetupNetworking();
            client = setupNetworking.NetworkSetup(client);

            // Retrieve user input and assign it to our Salary Model:
            SalaryItems salary = new SalaryItems();
            UserInput userInput = new UserInput();
            salary = userInput.getUserInput(salary);

            // Make the post request with our new information:
            PostRequest postRequest = new PostRequest();
            try
            {
                salary = await postRequest.CreateProductAsync(salary, client);
            }
            catch(Exception e)
            {
               Console.WriteLine("The API encountered an error, ensure your internet is connect and you have input correct data");
            }

            // Format the response object and print it
            PrintObject printObject = new PrintObject();
            printObject.printObject(salary);
        }
    }
}
