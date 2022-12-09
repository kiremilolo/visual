using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var input = Console.ReadLine();
            //if (input == "salam")
            //{
            //    Console.WriteLine("Aleykuma salam");
            //}

            //else if (input == "Sagol")
            //{
            //    Console.WriteLine("sende sagol");
            //}
            //else
            //{
            //    Console.WriteLine("Rusca danisma");


            //}

            //var adlar= Console.ReadLine();
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    if ()
            //}
            Console.WriteLine("Rus delinde danismayin;(,indi ise sozuvuzu yazin:) :");
            var input = Console.ReadLine();
            if (input == "Salam")
            {
                Console.WriteLine("Aleykuma Salam");
            }
            else if (input == "sagol")
            {
                Console.WriteLine("Sende sagol");
            }
            else
            {
                Console.WriteLine("Ya niznayuu poruski :(");
            }
            Console.WriteLine("===================");
            Console.WriteLine("Bekarsan?Onda bir regem yax =)");
            var day = Console.ReadLine();
            if (day == "1")
            {
                Console.WriteLine("Monday");

            }

            else if (day == "2")
            {
                Console.WriteLine("tuesday");

            }
            else if (day == "3")
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == "4")
            {
                Console.WriteLine("Thursday");

            }
            else if (day == "5")
            {
                Console.WriteLine("friday");
            }
            else if (day == "6")
            {
                Console.WriteLine("Saturday");

            }
            else if (day == "7")
            {
                Console.WriteLine("Sunday");
            }
            Console.WriteLine("=======================");

            Console.WriteLine("He indi birdene adivi yaz=)");
            var name = Console.ReadLine();
            var Firstname = name[0];
            bool hasA = false;
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] != 'a' && name[i] != 'A')
            //    {
            //        continue;
            //    }

            //    hasA = true;

            //}
           
            hasA = false;
            int i = 0;
            while (i < name.Length)
            {
                if (name[i] == 'a' || name[i] == 'A') 
                {
                    hasA = true;
                    break;
                }
                i++;
            }
            



            if (hasA)
            {
                Console.WriteLine("A herifi var");



            }
            else {

                Console.WriteLine("A herifi yoxtur");
            }


        }

    }
}

   
