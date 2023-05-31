using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook1
{
    internal class AddressEntry
    {
        
        
            private int id;

            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string address;

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            private int number;

            public int Number
            {
                get { return number; }
                set { number = value; }
            }

            private int rating;

            public int Rating
            {
                get { return rating; }
                set { rating = value; }
            }

            private static int count;

            public static int Count
            {
                get { return count; }
                set { count = value; }
            }



            public AddressEntry(int id, string name, string address, int number, int rating)
            {
                this.ID = id;
                this.Name = name;
                this.Address = address;
                this.Number = number;
                this.Rating = rating;
            }

            public AddressEntry() : this(0, "", "Unknown", 0, 0) { }

            public AddressEntry(string name, int number)
            {
                this.name = name;
                this.address = "Unknown";
                this.number = number;
            }

            public void ReadEntry()
            {
                Console.Write($"Enter id: ");
                this.ID = int.Parse(Console.ReadLine());

                Console.Write($"Enter name: ");
                this.Name = Console.ReadLine();

                Console.Write($"Enter address: ");
                this.Address = Console.ReadLine();

                Random rnd = new Random();
                this.Number = rnd.Next(860000000, 899999999);

                Console.Write($"Enter rating: ");
                this.Rating = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            public void Print()
            {
                Console.WriteLine($"Entry!");
                Console.WriteLine($"ID: {this.ID}");
                Console.WriteLine($"Name: {this.Name}");
                Console.WriteLine($"Address {this.Address}");
                Console.WriteLine($"Number: 0{this.Number}");
                Console.WriteLine($"Rating: {this.Rating}");
                Console.WriteLine();
            }
        }
}
