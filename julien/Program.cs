using System;

namespace julien
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 28, b = 16;
            //int ggt = a - b;

            GGT ggt = new GGT();

            int result = ggt.GGTFunction(a, b);

            Console.WriteLine(result);

            //bool stopcondition = false;

            //while (!stopcondition)
            //{
            //    if (a - b == 0)
            //    {
            //        Console.WriteLine($"GGT is {a}");
            //        stopcondition = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"a is {a}");
            //        Console.WriteLine($"b is {b}");

            //        int ggt = a - b;

            //        if (b < ggt)
            //        {
            //            b = a;
            //            a = ggt;
            //        }

            //        a = b;
            //        b = ggt;
            //        Console.WriteLine($"ggt is {ggt}");
            //    }
            //}
        }

    }
}
