using MentorOOP.Task_1;
using MentorOOP.Task2;
using Microsoft.VisualBasic;
using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace MentorOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.Create a class hierarchy for a vehicle dealership that includes classes for Vehicle, Car, Truck, Motorcycle, 
            //and Boat.Each class should have properties for things like make, model, year, and price, and methods for operations 
            //like accelerating, braking, and turning.Use inheritance to reduce code duplication and promote code reuse.

            Car myCar = new Car() { make ="Audi" , model = "A8", price = 60000, year = 2020};

            Boat myBoat = new Boat() { make="CostaConcordia" , model = "Cruse", price = 10000000, year=1986};

            Truck myTruck = new Truck("Volvo") { model="VL90", price = 30000, year = 2012 };

            Motorcycle myMotorcycle= new Motorcycle() { make= "Yamaha", model="R35", price = 60000, year= 2032};

            myBoat.Accelerating();
            myCar.Turning();
            myTruck.Braking();
            myMotorcycle.Accelerating();

            Console.WriteLine("\n" + myBoat.make);
            Console.WriteLine(myTruck.make);



            #endregion

            #region Task2
            //2.Create a class for a bank account that includes properties for the account holder's name, account number,
            //and balance, as well as methods for depositing and withdrawing funds. Implement validation logic to ensure that 
            //the account balance does not go negative, and use encapsulation to hide the account number from outside access.

            BankAccount bc1 = new BankAccount("Salman", -23, 122354);

            Console.WriteLine($"Working Account Number: {bc1.accountNumber}");

            bc1.Withdrawing(300);

            bc1.Withdrawing(325);

            #endregion

            #region Task3

            //Create a class hierarchy for a game that includes classes for Game, Player, and Enemy.Each class should have properties 
            //and methods appropriate for their role in the game, such as health points, attack power, and movement behavior.
            //Use inheritance and polymorphism to enable the creation of new types of players and enemies.

            #endregion

            #region Task4

            //Create a class for a library that includes properties for books, borrowers, and librarians, as well as methods for 
            //checking out and returning books.Use interfaces to allow for different types of books to be added to the library, 
            //such as novels, biographies, and textbooks.

            #endregion
        }
    }
}
