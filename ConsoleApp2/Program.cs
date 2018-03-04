using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Inttoboolean
    {
        static void Main(string[] args)
        {
          int d = 0;
            
            bool b = Convert.ToBoolean(d);
          Console.WriteLine(b);
          Console.Read();
        }
    }
}
