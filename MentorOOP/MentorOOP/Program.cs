using MentorOOP.Task_1;
using MentorOOP.Task2;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace MentorOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Task1
            ////1.Create a class hierarchy for a vehicle dealership that includes classes for Vehicle, Car, Truck, Motorcycle, 
            ////and Boat.Each class should have properties for things like make, model, year, and price, and methods for operations 
            ////like accelerating, braking, and turning.Use inheritance to reduce code duplication and promote code reuse.

            //Car myCar = new Car() { make ="Audi" , model = "A8", price = 60000, year = 2020};

            //Boat myBoat = new Boat() { make="CostaConcordia" , model = "Cruse", price = 10000000, year=1986};

            //Truck myTruck = new Truck("Volvo") { model="VL90", price = 30000, year = 2012 };

            //Motorcycle myMotorcycle= new Motorcycle() { make= "Yamaha", model="R35", price = 60000, year= 2032};

            //myBoat.Accelerating();
            //myCar.Turning();
            //myTruck.Braking();
            //myMotorcycle.Accelerating();

            //Console.WriteLine("\n" + myBoat.make);
            //Console.WriteLine(myTruck.make);



            //#endregion

            //#region Task2
            ////2.Create a class for a bank account that includes properties for the account holder's name, account number,
            ////and balance, as well as methods for depositing and withdrawing funds. Implement validation logic to ensure that 
            ////the account balance does not go negative, and use encapsulation to hide the account number from outside access.

            //BankAccount bc1 = new BankAccount("Salman", -23, 122354);

            //Console.WriteLine($"Working Account Number: {bc1.accountNumber}");

            //bc1.Withdrawing(300);

            //bc1.Withdrawing(325);

            //#endregion

            //#region Task3

            ////Create a class hierarchy for a game that includes classes for Game, Player, and Enemy.Each class should have properties 
            ////and methods appropriate for their role in the game, such as health points, attack power, and movement behavior.
            ////Use inheritance and polymorphism to enable the creation of new types of players and enemies.

            //#endregion

            //#region Task4

            ////Create a class for a library that includes properties for books, borrowers, and librarians, as well as methods for 
            ////checking out and returning books.Use interfaces to allow for different types of books to be added to the library, 
            ////such as novels, biographies, and textbooks.

            //#endregion

            myQueue<int> myQueue = new myQueue<int>();

            myQueue.Add(1);
            myQueue.Add(2);
            myQueue.Add(3);
            myQueue.Add(4);

            for (int i = 0; i < myQueue.Count; i++)
            {
                Console.WriteLine(myQueue[i]);
            }

            Shopping shopping = new Shopping();
            shopping.Add(new Product() { Id = 1, Price = 50, Name = "yumis" });

        
        }
    }

    public class myQueue<T>
    {
        private T[] items;
        private int count;
        private int head;
        private int tail;

        public myQueue()
        {
            items = Array.Empty<T>();
        }

        public T this[int index] 
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public int Count 
        {
            get { return count; }
        }

        public void Add(T value)
        {
            //var oldArray = items;

            T[] newArray = new T[items.Length+1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = items[i];
            }
            newArray[count] = value;
            tail= count;
            count--; 
            
        }

        public void Clear()
        {
            items= Array.Empty<T>();
            count = 0;
            head = 0;
            tail = 0;
        }

        public void Delete()
        {
            T[] newArray = new T[items.Length -1];

            for (int i = 0; i < newArray.Length-1; i++)
            {
                newArray[i] = items[i+1];
            }
            items= newArray;
            tail = count;
            count++;

        }

        public void Peak()
        {
            Console.WriteLine(items[head]);
        }
    }

    public class Shopping
    {
        private static List<Product>? products;
        public Shopping()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(int id)
        {
            products.RemoveAt(id);
           // products.Remove( s=> s.Id == id);
        }

        public int Calculate()
        {
            int sum = 0;
            
            foreach (var item in products)
            {
                sum += item.Price;
            }

            return sum;
        }

        public void CheckOut()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.Name, "\n" , item.Price, "\n", item.Id);
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

}
