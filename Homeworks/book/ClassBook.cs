using System;

namespace book
{
    class ClassBook : IComparable
    {
        private string author;
        private string title;
        private int year;
        private int pages;

        public void SetBook(String author, String title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }

        public void Show()
        {
            Console.WriteLine($"Author: {author} Title: {title} Year of publishing: { year} { pages} pages");
        }
        public int CompareTo(object obj)
        {
            ClassBook it = obj as ClassBook;
            
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
    }
}
