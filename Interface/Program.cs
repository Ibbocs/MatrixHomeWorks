using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Excepition handle deyende problemi hell elemek yoxsa problem oldugunu usere soylemey nezerde tutulur.
            //qeydlerdeki suallar
            //ovtamatik kodlari seliqeli siralamani hansi qisa yolla edirik
            //prop adi boyukle yazilmalidi
            //bool methoduntrue ve ya false 2sinden birini veziyyete gore geri dondermesini nece eleyek
            //task 3de niye interface yaradim e, ele try-catch program clasinda isledib yoxla bilmezdim ki?
            #region Task1

            Gun pist = new Gun("Luger");

            // test for methods
            pist.Label();
            pist.Shoot();


            if (pist is IShootable && pist is Weapon)
            {
                Console.WriteLine("Yes, it is my parents.");
            }

            #endregion

            #region Task2
            Car car = new Car(0);

            bool check = car.Refuel(0);

        ifHeading:
            if (check == true && car.Fuel > 0)
            {
                car.Drive();
            }
            else
            {
                car.Refuel(23);
                goto ifHeading;
            }

            //while (true)
            //{
            //    if (check == true && car.Fuel > 0)
            //    {
            //        car.Drive();
            //        break;
            //    }
            //    else
            //    {
            //        car.Refuel(23);

            //    }
            //}
            #endregion

            #region Task3

            FerqliAdda1 ferqliAdda1 = new FerqliAdda1();
            FerqliAdda2 ferqliAdda2 = new FerqliAdda2();

            ferqliAdda1.LogInformation();
            ferqliAdda2.LogInformation();

            #endregion

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("Qasim",4);
            Contractor contractor = new Contractor("Feride",6);

            fullTimeEmployee.Calculate();
            contractor.Calculate();
        }
    }
}
