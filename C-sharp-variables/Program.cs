﻿using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {

        int q = 1;
        char x = 'b';
        double n = 5.5;
        string name = "omran";
        bool o = false;



        Console.WriteLine(q+" "+x);
        Console.WriteLine(q +" "+ n);
        Console.WriteLine(n +" "+ name);

        //Read() 

        int a;
        int b;
        Console.WriteLine("Enet a Number:  ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enet a Second Number:  ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("a+b="+""+(a+b));
        Console.WriteLine("a-b="+""+(a-b));
        Console.WriteLine("b-a="+""+(b-a));
        Console.WriteLine("a/b="+""+(a/b));
        Console.WriteLine("b/a="+""+(b/a));
        Console.WriteLine("a*b="+""+(a*b));
        Console.WriteLine("a%b="+""+(a%b));
        Console.WriteLine("b%a="+""+(b%a));

        ///new task
        ///writ code to swap the value of two variables
        int a1;
        int b1;
        Console.WriteLine("Enet a Number (a1):  ");
        a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enet a Second Number(b1):  ");
        b1 = Convert.ToInt32(Console.ReadLine());
        int a3=a1;
        a1=b1;
        b1=a3;

        
        Console.WriteLine(a1);
        Console.WriteLine(b1);

        string l1;
        string l2;

        Console.WriteLine("Enet a string (l1):  ");
        l1 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enet a Second string(l2):  ");
        l2 = Convert.ToString(Console.ReadLine());
        (l1, l2) = (l2, l1);//another way to swap values 


        Console.WriteLine(l1);
        Console.WriteLine(l2);


        // loops count from 1 -10

        for(int i = 1; i <= 10; i++)
        { 
            //int[] ints = new int[10];
            //ints[i] = i;
            Console.WriteLine(i);
        }
        // count from 10-0 using while loop
            int i1 = 10;
            while (i1 >= 0)
            {
                Console.WriteLine(i1);
                 i1--;
            }

         



    }
}