using System;

namespace IndexerApplication
{
    public class IndexedBooks
    {
        private string[] books = new string[10];
        public string this[int index]
        {
            get
            {
                return books[index];
            }

            set
            {
                books[index] = value;
            }
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            IndexedBooks books = new IndexedBooks();
            books[0] = "book0";
            books[1] = "book1";
            books[2] = "book2";
            books[3] = "book3";
            Console.WriteLine(books[0]);
        }
    }
}