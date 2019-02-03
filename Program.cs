using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash("Fleshka");
            Console.WriteLine("Память флешки: " + flash.GetMemoryCapacity() + "Mb");
            Console.WriteLine("Память файла: 565Gb");
            Console.WriteLine("---------------------------------");
            flash.CopyDateToTheDevice();
            Console.WriteLine("---------------------------------");
            Console.WriteLine(flash.GetFullInfoAboutDevice());
            Console.WriteLine("---------------------------------");

            Console.Read();
        }
    }
}
