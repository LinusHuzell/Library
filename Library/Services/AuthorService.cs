using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class AuthorService : IService<Author>
    {
        /// <summary>
        /// Author repository with set context.
        /// </summary>
        AuthorRepository AuthorRepository;

        /// <summary>
        /// Event that's triggered whenever there's an author updated.
        /// </summary>
        public event EventHandler Updated;

        // Constructor. -->
        /// <summary>
        /// Author Service that handles all authors.
        /// </summary>
        /// <param name="rFactory">The Repository Factory used.</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.AuthorRepository = rFactory.CreateAuthorRepository();
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
        /// Validates and sends an author object to repository for adding to database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="author">Author object to be added to database.</param>
        public void Add(Author author)
        {
            if (Exists(author.FirstName, author.LastName))
                throw new OperationCanceledException("Cancelled. Author already exists.");
            AuthorRepository.Add(author);
            OnUpdated(author, EventArgs.Empty);
        }

        /// <summary>
        /// Get all authors from database.
        /// </summary>
        /// <returns>A list of all authors in database.</returns>
        public IEnumerable<Author> All()
        {
            return AuthorRepository.All().OrderBy(author => author.FirstName);
        }

        /// <summary>
        /// Finds an author in database from a specific ID.
        /// </summary>
        /// <param name="id">ID of author to find.</param>
        /// <returns>The author object found.</returns>
        public Author Find(int id)
        {
            return AuthorRepository.Find(id);
        }

        /// <summary>
        /// Sends a specific author object to repository for editing in database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="author">Author object to edit in database.</param>
        public void Edit(Author author)
        {
            AuthorRepository.Edit(author);
            OnUpdated(author, EventArgs.Empty);
        }

        /// <summary>
        /// Removes a specific author from database.
        /// </summary>
        /// <param name="author">Author object to be removed.</param>
        public void Remove(Author author)
        {
            AuthorRepository.Remove(author);
            OnUpdated(author, EventArgs.Empty);
        }
        // <-- Standard query-methods implemented by the IService interface.

        // Specific query-methods for this service. -->
        /// <summary>
        /// Filters all authors by name from an entered value. Works as a search method.
        /// </summary>
        /// <param name="name">Value to search authors name with.</param>
        /// <returns>A list of all authors which name contains the searched value.</returns>
        public IEnumerable<Author> Filter(string name)
        {
            return All().Where(author => author.ToString().ToLower().Contains(name.ToLower()));
        }

        /// <summary>
        /// Checks if the first name and last name already exist in the database.
        /// </summary>
        /// <param name="firstName">First Name to check in database.</param>
        /// <param name="lastName">Last Name to check in database.</param>
        /// <returns>Returns true if it already exists.</returns>
        public bool Exists(string firstName, string lastName)
        {
            if (All().Where(author => author.FirstName == firstName && author.LastName == lastName).Count() == 0)
                return false;
            else
                return true;
        }
        // <-- Specific query-methods for this service. 
    }
}
