using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = " \t Hello World \t   ";

            var bytes = Encoding.Default.GetBytes(str);

            var trimmedBytes = bytes.Trim();

            Console.WriteLine(Encoding.Default.GetString(trimmedBytes));
        }
    }
}
