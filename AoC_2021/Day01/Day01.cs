using AoC_2021.Helpers;
using AoC_2021.Interfaces;
using Serilog;
using System;
using System.Threading.Tasks;

namespace AoC_2021.Problems
{
    public class Day01 : IDailyProblem
    {
        public async Task Run()
        {
           await Problem2();
        }

        private Task Problem1()
        {
            Log.Information($"In method {nameof(Run)} of class {nameof(Day01)}");
            var count = 0;
            var inputs = InputHelper.GetStringArrayFromInput("Day01.txt");
            for (int i = 0; i < inputs.Length; i++)
            {
                if (i == 0) { continue; }
                if (Convert.ToInt64(inputs[i]) > Convert.ToInt64(inputs[i - 1]))
                {
                    count++;
                }
            }
            Log.Information($"There are {count} measurements that are larger than the previous measurement.");
            return Task.FromResult(0);
        }
        private Task Problem2()
        {
            Log.Information($"In method {nameof(Run)} of class {nameof(Day01)}");
            var count = 0;
            var inputs = InputHelper.GetStringArrayFromInput("Day1.txt");
            var intArray = Array.ConvertAll(inputs, s=> Int64.Parse(s));
           
            
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i < 3) { continue; }
                var firstNo = intArray[i-3] + intArray[i-2] + intArray[i-1];
                var secondNo = intArray[i - 2] + intArray[i - 1] + intArray[i];
                if (secondNo > firstNo)
                {
                    count++;
                }
            }
            Log.Information($"There are {count} measurements that are larger than the previous measurement.");
            return Task.FromResult(0);
        }

    }
}
