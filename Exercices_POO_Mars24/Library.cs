using System;
namespace Exercices_POO_Mars24
{
	public class Library
	{
        public static List<IBook> Books { get; set; }

        public Library()
        {
            Books = new List<IBook>();
        }

        public void AddBook(IBook book)
        {
            Books.Add(book);
        }

        public void RemoveBook(IBook book)
        {
            Books.Remove(book);
        }

        public void CheckOutBook(IBook book)
        {
            book.CheckOut();
            Console.WriteLine(book.Title + "Ce livre a bien été emprunté");
        }

        public void CheckInBook(IBook book)
        {
            book.CheckIn();
            Console.WriteLine(book.Title + " a bien été rendu, il est de nouveau disponible");
        }


        public void ListBooks()
        {
            foreach (IBook book in Books)
            {
                Console.WriteLine(book.Title);
            }
        }

	}
}

