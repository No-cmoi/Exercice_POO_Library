namespace Exercices_POO_Mars24;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        FictionBook book1 = new FictionBook("Harry Potter à l'école des sorciers", "JK Rollins", "HP1", "fantastique");
        FictionBook book2 = new FictionBook("Harry Potter et la chambre des secrets", "JK Rollins", "HP2", "fantastique");
        NonFictionBook book3 = new NonFictionBook("Radiohead", "Thibaut Matthieu", "RAD1", "musique");
        NonFictionBook book4 = new NonFictionBook("La Terre entre nos mains", "Thomas Pesquet", "TER1", "astronomie");
        ReferenceBook book5 = new ReferenceBook("Le grand livre de l'orthographe", "Dominique Dumas", "GRA1", "education");
        ReferenceBook book6 = new ReferenceBook("Le petit Robert de la langue française", "collectif d'auteurs", "DIC1", "dictionnaire");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);
        library.AddBook(book5);
        library.AddBook(book6);

        library.ListBooks();
        Console.WriteLine("_____________________________\n");

        library.CheckOutBook(book1);
        Console.WriteLine();
        library.CheckOutBook(book2);
        library.ListBooks();
        Console.WriteLine("_____________________________\n");

        library.CheckInBook(book1);
        library.ListBooks();
    }
}

