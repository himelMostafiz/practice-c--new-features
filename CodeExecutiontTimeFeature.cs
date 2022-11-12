using System;
using System.Collections.Generic;
using System.Text;

namespace practice_csharp_feature
{
    public class CodeExecutiontTimeFeature
    {
        public void CodeExecutiontTimeCalculation()
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            watch.Stop();

            Console.WriteLine();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }


        public void ExecutiontTimeCalculationForMultipleLoopPortion()
        {
            Console.WriteLine();

            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            watch.Stop();

            var currentdate = DateTime.Today;

            if (!watch.IsRunning) // checks if it is not running
                watch.Start(); // Start the counter from where it stopped

            Console.WriteLine();

            for (int j = 0; j < 100; j++)
            {
                Console.Write(j);
                Console.Write(" ");
            }

            watch.Stop();
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
