using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookCopyService : IService<BookCopy>
    {
        /// <summary>
        /// BookCopy repository with set context.
        /// </summary>
        BookCopyRepository BookCopyRepository;

        /// <summary>
        /// Event that's triggered whenever there's an book copy updated.
        /// </summary>
        public event EventHandler Updated;

        // Constructor. -->
        /// <summary>
        /// Book Copy Service that handle all book copies.
        /// </summary>
        /// <param name="rFactory">The Repository Factory used.</param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.BookCopyRepository = rFactory.CreateBookCopyRepository();
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
        /// Sends a book copy object to repository for adding to database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="bookCopy">Book copy object to be added to database.</param>
        public void Add(BookCopy bookCopy)
        {
            BookCopyRepository.Add(bookCopy);
            OnUpdated(bookCopy, EventArgs.Empty);
        }

        /// <summary>
        /// Get all book copies from databse.
        /// </summary>
        /// <returns>A list of all book copies in database.</returns>
        public IEnumerable<BookCopy> All()
        {
            return BookCopyRepository.All();
        }

        /// <summary>
        /// Finds a book copy in database from a specific ID.
        /// </summary>
        /// <param name="id">ID of the book copy to find</param>
        /// <returns>The book copy object found.</returns>
        public BookCopy Find(int id)
        {
            return BookCopyRepository.Find(id);
        }

        /// <summary>
        /// Sends a specific bok copy object to repository for editing in database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="bookCopy">Book copy object to edit in database.</param>
        public void Edit(BookCopy bookCopy)
        {
            BookCopyRepository.Edit(bookCopy);
            OnUpdated(bookCopy, EventArgs.Empty);
        }

        /// <summary>
        /// Remove a specific book copy from database.
        /// </summary>
        /// <param name="bookCopy">Book copy object to be removed.</param>
        public void Remove(BookCopy bookCopy)
        {
            BookCopyRepository.Remove(bookCopy);
            OnUpdated(bookCopy, EventArgs.Empty);
        }
        // <-- Standard query-methods implemented by the IService interface.

        // Specific query-methods for this service. -->
        /// <summary>
        /// Get all book copies of a specific book.
        /// </summary>
        /// <param name="book">Book to get copies from.</param>
        /// <returns>A list of book copies from the specific book.</returns>
        public IEnumerable<BookCopy> BookCopiesFromBook(Book book)
        {
            return All().Where(copy => copy.Book.BookID == book.BookID);
        }
        // <-- Specific query-methods for this service.
    }
}
