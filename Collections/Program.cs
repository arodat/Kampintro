using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.CSharp.RuntimeBinder;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Arif", "Furkan", "Ersan", "Recep" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);


            List<string> isimler2 = new List<string> {"Arif", "Furkan", "Ersan", "Recep"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




            Console.WriteLine("---------------------------------------------");
            List<object> list2 = new List<object>
            {
                "Arif",5,true,"Kovan"
            };
            foreach (var a in list2)
            {
                Console.WriteLine(a);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
        }
    }
}
