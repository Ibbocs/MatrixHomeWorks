using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //metodlardan basqa hecnede isledilmir delegate?
            //main iicindeki args nedi?
            //OperationDelegate opd = new OperationDelegate(Add); bele nece islede bilerik
            //delegate moterezesindeki int falan sadece  yaazilis ucundu yoxsa hesablamada isletmek olar?
            //bizimm motereze tapsiriginda (((()))) bu niye duzdu ki? acilib baglanmayanlar var axi

            #region Task1
            Console.WriteLine(Applay(4.2F, 3, Add));
            Console.WriteLine(Applay(4.2F, 3, Subtract));
            Console.WriteLine(Applay(4.2F, 3, Multiply));
            Console.WriteLine(Applay(4.2F, 3, Divide));
            //Applay(4.2F, 3, Divide); bele yazsam hesablama cixmir
            #endregion

            #region Task2
            Cat cat = new Cat();
            CatMethod(cat.Sleep);
            CatMethod(cat.Play);
            CatMethod(cat.Feed);
            #endregion

            #region Task3
            Person prs = new Person("Ehmed", "Qanixov");
            PersonMethod(prs.WriteLastName);
            PersonMethod(prs.WriteName);
            #endregion

            #region Task4
            MobilePhone ayfon = new MobilePhone("X", 2, 600);
            Console.WriteLine($"Info: {ayfon.model}, {ayfon.pathYear}, {ayfon.beginPrices}, {ayfon.nowPrice}");

            ayfon.ChangeProporties(4);
            ayfon.ChangeProporties("14 Pro Max");

            decimal b = 890;
            ayfon.ChangeProporties(b);

            Console.WriteLine($"Info 2: {ayfon.model}, {ayfon.pathYear}, {ayfon.beginPrices}, {ayfon.nowPrice}");
            #endregion
            #region Task5
            List<string>user= new List<string>();
            user.Add("Qasim Qanixli");
            user.Add("Veli Sebiyev");

            User users = new User();

            users.Diger(user);
            #endregion


        }


        public delegate float OperationDelegate(float a, float b);

        static float Add(float _a, float _b) 
        { 
        return _a+ _b;
        }
        static float Subtract(float _a, float _b) 
        {
        return _a - _b;
        }
        static float Multiply(float _a, float _b) 
        { 
        return _a * _b;
        }
        static float Divide(float _a, float _b) 
        {
        return _a/ _b;
        }
        static float Applay(float _a, float _b, OperationDelegate method ) 
        {
            Console.WriteLine("Your Calculation:");
            return method.Invoke(_a, _b);
        }

        public delegate void CatDelegate(int _value);
        static void CatMethod(CatDelegate catDelegate)
        {
            catDelegate.Invoke(34);
        }

        public delegate void PersonDel();

        static void PersonMethod(PersonDel pd)
        {
            Console.WriteLine("Person:");
            pd.Invoke();
        }


    }
}
