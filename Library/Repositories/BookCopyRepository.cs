using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext context;

        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }


        /// <summary>
        /// Adds book copy object to databse.
        /// </summary>
        /// <param name="book">Book copy object to be added to databse.</param>
        public void Add(BookCopy bookCopy)
        {
            context.BookCopies.Add(bookCopy);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all book copy objects from database.
        /// </summary>
        /// <returns>Returns all book copy objects from database.</returns>
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        /// <summary>
        /// Edits the book copy object in database.
        /// </summary>
        /// <param name="bookCopy">Book copy object to be edited.</param>
        public void Edit(BookCopy bookCopy)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Finds the book copy searched for in database, by id.
        /// </summary>
        /// <param name="id">ID of book copy object to search for in database.</param>
        /// <returns>The book copy searched for. Null if not found.</returns>
        public BookCopy Find(int id)
        {
            return context.BookCopies.Find(id);
        }

        /// <summary>
        /// Removes book copy object from database.
        /// </summary>
        /// <param name="bookCopy">Book copy object to be removed from database.</param>
        public void Remove(BookCopy bookCopy)
        {
            context.BookCopies.Remove(bookCopy);
            context.SaveChanges();
        }
    }
}
