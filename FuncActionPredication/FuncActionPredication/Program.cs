using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncActionPredication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Task1-Integer arrayin max ve min-in tapan Func<> yaradin.
            //Task2-String listini reverse(ters) cevirmek ucun Action<> delegate yaradin 
            //Task3-String list-de icerisinde e- herfi olmayan sozleri cixadan Predicate<> yaradin

            //listin reverse methodu nece isledilir? void cevire bilmezsen xetasi aldim
            #region Task1


            int[] intArray = { 3, 1, 9, -2, 6, 3, 4, 1 };

            //Func<int[], int> funcMin = (int[] array) => { return array.Min(); };
            //Func<int[], int> funcMax = (int[] array) => { return array.Max(); };

            //Func<int[], int> funcMax = IntMax;
            //int result = funcMax(intArray);
            //Console.WriteLine(funcMax(intArray));

            Func<int[], int[]> funcMaxAndMin = IntMaxAndMin;

            Console.WriteLine("Task1\n");

            for (int i = 0; i < funcMaxAndMin(intArray).Length; i++)
            {
                Console.WriteLine(funcMaxAndMin(intArray)[i]);
            }

            #endregion

            #region Task2
            List<string> strings = new List<string>() { "lale", "zambag"};
            strings.Add("Salam");
            strings.Add("Baki");
            strings.Add("Baxariq");

            //List<string> kkh = new List<string> { "nas", "das" };
            //kkh.ForEach(kkh.Add(kkh.Reverse()));
            //kkh.Add(kkh.Reverse());
            //Console.WriteLine(strings.Reverse());

            Action< List<string> > actionReverser = Reverser;

            actionReverser(strings);
            //Console.WriteLine();

            #endregion

            #region Task3
            //Predicate<List<string>> predicate = new Predicate<List<string>>();

            List<string> strngList = new List<string>() { "lale", "zambag", "Eli", "e", "Baxariq", "E", "lale",
                                                          "Zale", "fvfd", "e", "dss", "rrg","fvf", "DEs", "ds"};
            strngList.Add("Salam");


            Predicate<List<string>> predicate = ExceptE;
            //8 soz cixmalidi...
            bool result = predicate(strngList);

            if (result == false)
            {
                Console.WriteLine("\nSomething is wrong...");
            }
            else
            {
                Console.WriteLine("\nMission Complicated...");
            }

            #endregion
        }

        public static int[] IntMaxAndMin(int[] array)
        {
            int[] result = new int[2];
            try
            {
                result[0] = Convert.ToInt32(array.Max());
                result[1] = Convert.ToInt32(array.Min());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return result ;
        }

        public static void IntMax(int[] array)
        {
            int MaxRes = array[0];

            //1,2,7,9,-2,4,9,3,1
            for (int i = 1; i < array.Length; i++)
            {
                if (MaxRes < array[i])
                {
                    MaxRes = array[i];
                }
            }

            Console.WriteLine(MaxRes);
        }

        public static void Reverser( List<string> strings)
        {
            string[] reversedStrings = new string[strings.Count];

            try
            {
                //a,b,d
                for (int i = 0; i < strings.Count; i++)
                {
                    reversedStrings[i] = strings[strings.Count - 1 - i];
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nTask2\n");

                foreach (var item in reversedStrings)
                {
                    Console.WriteLine(item);
                }
            }   
        }

        public static bool ExceptE(List<string> myText)
        {
            //ewfjnvn fnvdj riijiv wewej 
            try
            {
                int count = myText.Count-1;
                int counter = -1;

                for (int i = 0; i < count; i++)
                {
                    //e ve E heri olan her bir sozu gonderdiyimizi listden silib onu yenileyir...
                    if (myText[i].Contains('e') || myText[i].Contains('E'))
                    {
                        myText.Remove(myText[i]);
                        i--;
                        counter = myText.Count - 1;
                    }

                    //i eger yeni yaranan list'in sonuncu indexine beraber olsa stop edir...
                    if (i == counter)
                    {
                        break;
                    }

   
                }

                Console.WriteLine("\nTask3\n");

                foreach (var item in myText)
                {
                    
                    Console.WriteLine(item);
                }
            }
            catch (Exception)
            {

                return false;
            }  
            

            return true;
        }
    }
}
