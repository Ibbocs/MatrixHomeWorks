using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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

            //global value isletmekle ref yazmagin ferqi nedir? cvb ref copyalanma olmadan value type ref. kimi davranmasini eleyir. global valueni her methoda vermek istmeye bilerik deye elverisli olacaq
            //clas icinde class yaratmaq neye lazimdi ki?
            //kodun nece saniyey islediyine, harda ne bas verdiyine nece baxa bilerik
            //garbage collector ancaq heapdaki seyleri silir? stackden hec ne silmir? cvb heap, stack onsuzda scope bagalanda silinir
            //men ytda bele bir sey gordum ki, GC 1 defe ise dusenden sora sag qalani gen0 atir, bu duz fikirdi? siz ilk yaranan kimi gen0 dusur demisdiz deyesen cvb yt duz deyib
            //generation sonsuz saya qeder gedir? yoxsa yalniz 3 merhelesi var cvb 3 merhelesi var
            //exception butun xetalari ozunde saxlayirsa, biz onun sayesinde ele her bir xetani gore bilerik yoxsa o biri alt sinifleri de mutleq isletmeliyik? cvb ozel seyler ucun o biri clasdari isledirik

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
            List<string> user = new List<string>();
            user.Add("Qasim Qanixli");
            user.Add("Veli Sebiyev");

            User users = new User();

            users.Diger(user);
            #endregion


        }


        public delegate float OperationDelegate(float a, float b);

        static float Add(float _a, float _b)
        {
            return _a + _b;
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
            return _a / _b;
        }
        static float Applay(float _a, float _b, OperationDelegate method)
        {
            Console.WriteLine("Your Calculation:");
            return method.Invoke(_a, _b);
        }



        public delegate void CatDelegate(int _value);
        static void CatMethod(CatDelegate catDelegate)
        {
            catDelegate.Invoke(34);
        }

        public static void she()
        {

        }

        public delegate void PersonDel();

        static void PersonMethod(PersonDel pd)
        {
            Console.WriteLine("Person:");
            pd.Invoke();
        }


    }
}
