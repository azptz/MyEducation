﻿
using System;

namespace Example003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

           int max = a;
           if(a > max) max = a;
           if(b > max) max = b;
           if(c > max) max = c;
           if(d > max) max = d;
           if(e > max) max = e;
           Console.WriteLine(max);

        }
}
}