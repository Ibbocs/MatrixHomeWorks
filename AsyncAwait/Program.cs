using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //buu thread icinde delegate cixan ggostere bilersiz??
            //thread niye hansi veziyyetlerde isletmelin olaram da?
            //thread moterezesinde overload eleyir? main gonderende ele bir sey yazdi
            //adi normal bir delegate yaradib onu new thread gondermek  olarmi?
            // burda makeTeaAsync yazanda niye alti yasil olurdu?

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine($"Start Program");
            var task1 = MethodAAsync();
            var task2 = MethodBAsync();
            var task = Task.Run(async () => await MethodAAsync());
            var task4 = Task.Run(async () => await MethodBAsync());
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");
            Console.ReadKey();

            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();
            //Console.WriteLine($"Start Program");
            //MethodA();
            //MethodB();
            //watch.Stop();
            //Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");
            //Console.ReadKey();


            //var task = Task.Run(async () => await MakeTeaAsync());
            //Console.WriteLine(task.Result);

        }
        

        static async Task< int> MethodAAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" A{i}");
                await Task.Delay(500);

            }
            //var res = await MethodBAsync();

            int result = 123;
            Console.WriteLine($" A returns result {result}");
            return result;
        }
        static async Task<int> MethodBAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" B{i}");
                await Task.Delay(500);
                
            }
           // var res = await MethodAAsync();
            int result = 456;
            Console.WriteLine($" B returns result {result}");
            return result;
        }





        static int MethodA()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" A{i}");
                Task.Delay(500).Wait();
            }
            int result = 123;
            Console.WriteLine($" A returns result {result}");
            return result;
        }
        static int MethodB()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" B{i}");
                Task.Delay(500).Wait();
            }
            int result = 456;
            Console.WriteLine($" B returns result {result}");
            return result;
        }




        //public static async Task<string> MakeTeaAsync() 
        //{
        //    var water = BoilWaterAsync();
        //    Console.WriteLine("Get cup");
        //    Console.WriteLine("Put tea in cups");
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString()); 
        //    //yuxaridaki sadece hansi thread islediyini gosterir
        //    var boil = await water;
        //    Console.WriteLine("add"+boil);
        //    return "tea";

        //}

        //public static async Task<string> BoilWaterAsync()
        //{
        //    Console.WriteLine("Start kettle");
        //    await Task.Delay(1000);
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
        //    Console.WriteLine("Finished");
        //    return "Water";
        //}
    }
}
