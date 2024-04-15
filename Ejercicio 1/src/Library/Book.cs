using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }
        public string LibrarySector { get; set; } // Esta propiedad parece pertenecer a una responsabilidad diferente
        public string LibraryShelve { get; set; } // Esta propiedad parece pertenecer a una responsabilidad diferente

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(String sector, String shelve) // Este método también parece pertenecer a una responsabilidad diferente
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}
