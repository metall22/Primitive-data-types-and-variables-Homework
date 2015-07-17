using System;




    class SwitchingValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b=10;
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine("a={0}\nb={1}", a, b);
        }
    }

