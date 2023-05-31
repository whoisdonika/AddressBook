using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many entries would you like to add? -  ");
            int n = int.Parse(Console.ReadLine());
            AddressEntry[] entries = new AddressEntry[n];

            for (int i = 0; i < n; i++)
            {
                AddressEntry address = new AddressEntry();
                address.ReadEntry();
                entries[i] = address;
            }

            foreach (var item in entries)
            {
                item.Print();
            }
        }
    }
}
