using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassBook book1 = new ClassBook();
            book1.SetBook("author1", "title1", 100, 1990);
            ClassBook book2 = new ClassBook();
            book2.SetBook("author2", "title2", 150, 1999);
            ClassBook book3 = new ClassBook();
            book3.SetBook("author3", "title3", 190, 2009);
            ClassBook book4 = new ClassBook();
            book4.SetBook("author4", "title4", 179, 1970);
            ClassBook book5 = new ClassBook();
            book5.SetBook("author5", "title5", 130, 1950);
            ClassBook[] bookArray = new ClassBook[5] { book1, book2, book3, book4, book5 };

            Console.WriteLine($"Before sorting:");
            foreach (ClassBook book in bookArray) book.Show();

            Array.Sort(bookArray);

            Console.WriteLine($"After sorting:");
            foreach (ClassBook book in bookArray) book.Show();

            Console.ReadLine();
        }
    }
}
