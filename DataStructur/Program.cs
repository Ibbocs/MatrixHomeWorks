using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace DataStructur
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //*****consolApp fikiri****
            //githubda 3-4 neferin baxa bileceyi repository
            //SortedList
            //HashTable nedi?
            //ObservableCollection<T>
            //SortedSet<T>
            //LinkedList<T>
            //Bulardan (yuxaridaki) hansilar onemlidi baxmag lazimdi?
            //Type nedi neleri ehate edir?
            //dream sozunun 2 ferqli menasi yuxu ve arzu var burda key dream, value ise onun menalaridi. Key datanin ozu, value ise sayi bu duz fikirdi?
            //trygetvalue, removewhere hashsetde ne methodlaridi bular
            //biz kodumuza colden hansisa dictionary cekib islede bilerik
            //list.ForEach(x => { }); // ne bu?

            
            Stack<int> stack = new Stack<int>();
            HashSet<int> visited = new HashSet<int>();
            ObservableCollection<int> collection = new ObservableCollection<int>();
            LinkedList<int> first = new LinkedList<int>();
            ISet<int> set = new HashSet<int>(); // bu nedi?
            Hashtable hashtable = new Hashtable();
            //IReadOnlySet<int> values = new IReadOnlySet<int>(); //ne bu
            SortedSet <int> sortedSet = new SortedSet <int>();
            // CharSet charSet = CharSet.Ansi;




            //foreach (KeyValuePair<int,int> item in dict)
            //{
            //    //item.Value
            //    //item.Key
            //}

            #region Task1
            //Console.WriteLine("Enter Value");
            //string value = Console.ReadLine();

            ////bracket
            //Queue<char> bracket = new Queue<char>();
            //// HashSet<char> bracket = new HashSet<char>();

            //foreach (var item in value)
            //{
            //    bracket.Enqueue(item);
            //}

            //int a = 0;

            //if (bracket.Count % 2 == 0) //acilib baglanmani yoxlayiram, eger 3 durse moterize aciqdir meselen
            //{
            //    for (int i = 0; i < bracket.Count; i += 2)
            //    {
            //        if (value[i] == '(' && value[i + 1] == ')')
            //        {
            //            a++;
            //        }
            //        else if (value[i] == '{' && value[i + 1] == '}')
            //        {
            //            a++;
            //        }
            //        else if (value[i] == '[' && value[i + 1] == ']')
            //        {
            //            a++;
            //        }
            //        else //eger bunlar beraber deyilese onsuz da yazilis sehvdi deye loop dayandiriram
            //        {
            //            Console.WriteLine("False");
            //            a = 0;
            //            break;
            //        }

            //    }

            //    if (a > 0)
            //    {
            //        Console.WriteLine("True");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            #endregion

            #region Task2

            string input = "loveleetcode";

            Dictionary<char, int> task2 = new Dictionary<char,int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!task2.ContainsKey(input[i]))
                {
                    task2.Add(input[i], 1);
                }
                else
                {
                    task2[input[i]]++;
                }
            }

            foreach (KeyValuePair<char,int> item in task2)
            {
                if (item.Value ==1)
                {
                    Console.WriteLine(input.IndexOf(item.Key));
                    break;
                }
            }
            #endregion

            #region Task3
            int[] inputArray = new int[] {2,2,1 };
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!dict.ContainsKey(inputArray[i]))
                {
                    dict.Add(inputArray[i],1);
                }
                else
                {
                    dict[inputArray[i]]++;
                }
            }
            foreach (KeyValuePair<int,int> item in dict)
            {
                if (item.Value==1)
                {
                    Console.WriteLine(item.Key);
                }
            }
            #endregion

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(1);

            Queue<int> queue = new Queue<int>();

            foreach (var item in list)
            {
                queue.Enqueue(item);
            }

            
        }
    }
}
