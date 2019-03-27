using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseIfModelChanges<LibraryContext> {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);


            // Add authors to database.
            Author jkAuthor = new Author("J.K.", "Rowling");
            context.Authors.Add(jkAuthor);
            Author jrrAuthor = new Author("J.R.R.", "Tolkien");
            context.Authors.Add(jrrAuthor);
            Author ernestAuthor = new Author("Ernest", "Hemingway");
            context.Authors.Add(ernestAuthor);
            Author janeAuthor = new Author("Jane", "Austen");
            context.Authors.Add(janeAuthor);
            Author charlesAuthor = new Author("Charles", "Dickens");
            context.Authors.Add(charlesAuthor);

            //Add books to database.
            List<Book> booksInDB = new List<Book>();
            Book harryP1 = new Book("0-7475-3269-9", "Harry Potter and the Philosopher's Stone", new List<Author>() { jkAuthor }, 1997, "Good book! :)");
            context.Books.Add(harryP1);
            booksInDB.Add(harryP1);
            Book harryP2 = new Book("0-7475-3849-2", "Harry Potter and the Chamber of Secrets", new List<Author>() { jkAuthor }, 1998, "Good book! :)");
            context.Books.Add(harryP2);
            booksInDB.Add(harryP2);
            Book harryP3 = new Book("0-7475-4215-5", "Harry Potter and the Prisoner of Azkaban", new List<Author>() { jkAuthor }, 1999, "Good book! :)");
            context.Books.Add(harryP3);
            booksInDB.Add(harryP3);
            Book harryP4 = new Book("0-7475-4624-X", "Harry Potter and the Goblet of Fire", new List<Author>() { jkAuthor }, 2000, "Good book! :)");
            context.Books.Add(harryP4);
            booksInDB.Add(harryP4);
            Book harryP5 = new Book("0-7475-5100-6", "Harry Potter and the Order of the Phoenix", new List<Author>() { jkAuthor }, 2003, "Good book! :)");
            context.Books.Add(harryP5);
            booksInDB.Add(harryP5);
            Book harryP6 = new Book("0-7475-8108-8", "Harry Potter and the Half Blood Prince", new List<Author>() { jkAuthor }, 2005, "Good book! :)");
            context.Books.Add(harryP6);
            booksInDB.Add(harryP6);
            Book harryP7 = new Book("0-545-01022-5", "Harry Potter and the Deathly Hallows", new List<Author>() { jkAuthor }, 2007, "Good book! :)");
            context.Books.Add(harryP7);
            booksInDB.Add(harryP7);
            Book sagan1 = new Book("0544003411", "The Lord of the Rings", new List<Author>() { jrrAuthor }, 1954, "Best book! :)");
            context.Books.Add(sagan1);
            booksInDB.Add(sagan1);
            Book sagan2 = new Book("0007522916", "The Two Towers", new List<Author>() { jrrAuthor }, 1954, "Better book! :)");
            context.Books.Add(sagan2);
            booksInDB.Add(sagan2);

            //Add members to database.
            Member linus = new Member("930126-0001", "Limpanxd", "Linus", "Huzell", new DateTime(1993, 1, 26));
            context.Members.Add(linus);
            Member philip = new Member("950724-0002", "Phille", "Philip", "Öhlund", new DateTime(1995, 7, 24));
            context.Members.Add(philip);
            Member martin = new Member("920314-0003", "Styrbjorn", "Martin", "Stenberg", new DateTime(2018, 10, 25));
            context.Members.Add(martin);
            Member per = new Member("890906-0004", "Perka", "Per", "Jernlund", new DateTime(2018, 10, 25));
            context.Members.Add(per);
            Member anton = new Member("930807-0005", "Anton1337","Anton", "Backe", null);
            context.Members.Add(anton);
            Member gorkem = new Member("860101-0006", "GorkemUberHaxx", "Görkem", "Paçaci", null);
            context.Members.Add(gorkem);

            //Add book copies to database.
            foreach (Book book in booksInDB)
            {
                for (int i = 0; i < 2; i++)
                {
                    context.BookCopies.Add(new BookCopy(book));
                }
            }

            BookCopy hp1 = new BookCopy(harryP1);
            context.BookCopies.Add(hp1);
            BookCopy hp2 = new BookCopy(harryP2);
            context.BookCopies.Add(hp2);
            BookCopy hp3 = new BookCopy(harryP3);
            context.BookCopies.Add(hp3);
            BookCopy hp4 = new BookCopy(harryP4);
            context.BookCopies.Add(hp4);
            BookCopy hp5 = new BookCopy(harryP5);
            context.BookCopies.Add(hp5);
            BookCopy hp6 = new BookCopy(harryP6);
            context.BookCopies.Add(hp6);
            BookCopy hp7 = new BookCopy(harryP7);
            context.BookCopies.Add(hp7);

            DateTime Date1 = new DateTime(2004, 10, 22);


            //Add loans to database.
            Loan lhp1 = new Loan(hp1, linus);
            context.Loans.Add(lhp1);
            context.Loans.Add(new Loan(hp2, linus, new DateTime(2004, 10, 22), new DateTime(2004, 10, 28)));
            context.Loans.Add(new Loan(hp3, linus, new DateTime(2018, 10, 25)));
            context.Loans.Add(new Loan(hp4, linus, new DateTime(2017, 11, 1), new DateTime(2017, 11, 27)));
            context.Loans.Add(new Loan(hp5, linus, new DateTime(2018, 10, 12)));
            context.Loans.Add(new Loan(hp6, philip));
            context.Loans.Add(new Loan(hp7, philip));

            // Persist changes to the database.
            context.SaveChanges();
        }
    }
}
