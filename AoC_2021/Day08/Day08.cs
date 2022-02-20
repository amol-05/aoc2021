using AoC_2021.Helpers;
using AoC_2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2021.Problems
{
    public class Day08 : IDailyProblem
    {
        public async Task Run()
        {
            await Problem1();
        }

        private Task Problem1()
        {
            return Task.FromResult(0);
        }

        private async Task Problem2()
        {

        }

        private async Task ReadInputs()
        {
            var inputs = InputHelper.GetStringArrayFromInput("Day08.txt");
        }
    }
}
