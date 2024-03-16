using System;
namespace Exercices_POO_Mars24
{
    public class NonFictionBook : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Reference { get; set; }
        public string Subject { get; set; }

        public NonFictionBook(string title, string author, string reference, string subject)
        {
            Title = title;
            Author = author;
            Reference = reference;
            Subject = subject;
        }

        public void CheckIn()
        {
            Library.Books.Add(this);
        }

        public void CheckOut()
        {
            Library.Books.Remove(this);
        }

        public bool IsCheckedOut()
        {
            foreach (IBook book in Library.Books)
            {
                if (book.Title != this.Title)
                {
                    return true;
                }
                Console.WriteLine(book.Title + " n'est plus disponible");
            }
            return false;
        }
    }
}

