using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Library.Services
{
    public class BookService : IService<Book>
    {
        /// <summary>
        /// Book repository with set context.
        /// </summary>
        private BookRepository BookRepository;

        /// <summary>
        /// Event that's triggered whenever there's a book updated
        /// </summary>
        public event EventHandler Updated;

        // Constructor. -->
        /// <summary>
        /// Book Service that handles all books.
        /// </summary>
        /// <param name="rFactory">The Repository Factory used.</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.BookRepository = rFactory.CreateBookRepository();
        }
        // <-- Constructor.

        /// <summary>
        /// Triggers all subscribers of the event.
        /// </summary>
        public void OnUpdated(object sender, EventArgs e)
        {
            Updated?.Invoke(sender, e);
        }


        // Standard query-methods implemented by the IService interface (CRUD functions). -->
        /// <summary>
        /// Validates and sends a book object to repository for adding to database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="book">Book object to be added to database.</param>
        public void Add(Book book)
        {
            ValidateInputs(book, true);
            BookRepository.Add(book);
            OnUpdated(book, EventArgs.Empty);
        }

        /// <summary>
        /// Get all books from database.
        /// </summary>
        /// <returns>A list of all books in database.</returns>
        public IEnumerable<Book> All()
        {
            return BookRepository.All().OrderBy(book => book.Title);
        }

        /// <summary>
        /// Finds a book in database from a specific ID.
        /// </summary>
        /// <param name="id">ID of book to find.</param>
        /// <returns>The book object found.</returns>
        public Book Find(int id)
        {
            return BookRepository.Find(id);
        }

        /// <summary>
        /// Validates and sends a specific book object to repository for editing in database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="book">Book object to edit in database.</param>
        public void Edit(Book book)
        {
            ValidateInputs(book, false);
            BookRepository.Edit(book);
            OnUpdated(book, EventArgs.Empty);
        }

        /// <summary>
        /// Removes a specific book from database.
        /// </summary>
        /// <param name="book">Book object to be removed.</param>
        public void Remove(Book book)
        {
            BookRepository.Remove(book);
            OnUpdated(book, EventArgs.Empty);
        }
        // <-- Standard query-methods implemented by the IService interface.


        // Specific query-methods for this service. -->
        /// <summary>
        /// Sorts Book Copies from a specific book by Book Copy ID.
        /// </summary>
        /// <param name="book">The book to get Book Copies from.</param>
        /// <returns>List of the Book Copies ordered by Book Copy ID.</returns>
        public IEnumerable<BookCopy> BookCopiesOrderByCopyID(Book book)
        {
            return book.BookCopies.OrderBy(copy => copy.BookCopyID);
        }

        /// <summary>
        /// Filters all books by title from an entered value. Works as a search method.
        /// </summary>
        /// <param name="title">Value to search book titles with.</param>
        /// <returns>A list of all books which title contains the searched value.</returns>
        public IEnumerable<Book> FilterByTitle(string title)
        {
            return All().Where(book => book.ToString().ToLower().Contains(title.ToLower()));
        }

        /// <summary>
        /// Filters all books by authors name from an entered value. Works as a search method.
        /// </summary>
        /// <param name="name">Value to search books by author's name.</param>
        /// <returns></returns>
        public IEnumerable<Book> FilterByAuthor(string name)
        {
            return All().Where(book => book.Authors.Any(author => author.ToString().ToLower().Contains(name.ToLower())));
        }

        /// <summary>
        /// Checks if the title already exists in database.
        /// </summary>
        /// <param name="bookTitle">Title to check in databse.</param>
        /// <returns>Returns true if title already exists.</returns>
        public bool TitleExists(string bookTitle)
        {
            if (All().Where(book => book.Title == bookTitle).Count() == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Checks if the ISBN already exists in databse.
        /// </summary>
        /// <param name="isbn">ISBN to check in database.</param>
        /// <returns>Returns true if ISBN already exists.</returns>
        public bool ISBNExists(string isbn)
        {
            if (All().Where(book => book.ISBN == isbn).Count() == 0)
                return false;
            else
                return true;
        }
        // <-- Specific query-methods for this service. 

        // Local methods for this service. -->
        /// <summary>
        /// Validate inputs for a book that's going to be sent to database.
        /// </summary>
        /// <param name="book">Book that is going to be validated.</param>
        /// <param name="add">Checks if there is an add operation running.</param>
        private void ValidateInputs(Book book, bool add)
        {
            Regex regexISBN = new Regex(@"[0-9]$");
            // Checks if book already exists.
            if (add && TitleExists(book.Title))
                throw new OperationCanceledException("This book already exists!");
            // Checks if the year is valid.
            if (book.Year > DateTime.Now.Year)
                throw new OperationCanceledException("The book cannot be written in the future!");
            if (book.Year < 0)
                throw new OperationCanceledException("The year cannot be negative!");
            //Checks if the ISBN is valid.
            if (add && ISBNExists(book.ISBN))
                throw new OperationCanceledException("This book already exists!");

            string testISBN = ClearString(book.ISBN.Trim(), '-');

            if (book.Year > 2006 && testISBN.Length > 13)
                throw new OperationCanceledException("Books published after 2006 needs the 13 digit ISBN!");
            if (book.Year < 2006 && ClearString(testISBN, '-').Length > 10)
                throw new OperationCanceledException("Books published before 2007 needs the 10 digit ISBN!");
            if (!regexISBN.IsMatch(ClearString(testISBN.ToLower(), 'x')))
                throw new OperationCanceledException("The entered ISBN was invalid!");
        }

        /// <summary>
        /// Takes a string and clears it from a specific given char.
        /// </summary>
        /// <param name="_string">String to be cleared.</param>
        /// <param name="c">Char to be cleared from string.</param>
        /// <returns>String cleared from a given char.</returns>
        private string ClearString(string _string, char c)
        {
            while (_string.IndexOf(c)!= -1)
            {
                _string = $"{_string.Substring(0, _string.IndexOf(c)-1)}{_string.Substring(_string.IndexOf(c)+1)}";
            }
            return _string;
        }
        // <-- Local methods for this service.

    }
}
