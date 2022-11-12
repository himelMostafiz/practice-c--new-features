using System;
using System.Collections.Generic;
using System.Text;

namespace practice_csharp_feature
{
    public class GenericFeatures
    {
        public void GenericSwap<T>(ref T a, ref T b) 
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            T temp;
            temp = a;
            a = b;
            b = temp;

            watch.Start();

            Console.WriteLine($"Execution Time of swap between 2 numbers : {watch.ElapsedMilliseconds} ms");
        }
    }
}
