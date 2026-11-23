using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netologia0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new Unit();
            var obj2 = new Unit("Orc");
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Damage);
            Console.WriteLine(obj.Armor);
            Console.WriteLine(obj2.Name);
            Console.WriteLine(obj2.Damage);
            Console.WriteLine(obj2.Armor);
            Console.WriteLine(obj.SetDamage(10)); 
        }
    }
}
