using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2021.Helpers
{
    public static class InputHelper
    {
        static string rootFolder = Path.Combine(Directory.GetCurrentDirectory(), "Inputs");
        public static string[] GetStringArrayFromInput(string inputFileName)
        {
            var fileName = Path.Combine(rootFolder, inputFileName);
            if (!File.Exists(fileName))
            {
                return null;
            }
            return File.ReadAllLines(fileName);
        }
    }
}
