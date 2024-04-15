using System;

namespace Ucu.Poo.Expert
{
    class Program
    {
        static void Main()
        {
            LibraryInventory inventory = new LibraryInventory();

            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            inventory.ShelveBook(book1, "A", "7");
            inventory.ShelveBook(book2, "B", "3");
        }
    }
}
