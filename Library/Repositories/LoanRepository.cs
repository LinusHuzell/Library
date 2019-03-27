using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        public LoanRepository (LibraryContext c)
        {
            this.context = c;
        }


        /// <summary>
        /// Adds loan object to databse.
        /// </summary>
        /// <param name="item">Loan object to be added to database.</param>
        public void Add(Loan loan)
        {
            context.Loans.Add(loan);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all author objects from database.
        /// </summary>
        /// <returns>Returns all author objects from database.</returns>
        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        /// <summary>
        /// Edits the loan object in database.
        /// </summary>
        /// <param name="loan"> Loan object to be edited.</param>
        public void Edit(Loan loan)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Finds the loan searched for in database, by id.
        /// </summary>
        /// <param name="id">ID of loan object to search for in database.</param>
        /// <returns>The loan searched for. Null if not found.</returns>
        public Loan Find(int id)
        {
            return context.Loans.Find(id);
        }

        /// <summary>
        /// Removes loan object from database.
        /// </summary>
        /// <param name="loan">Author object to be removed from database.</param>
        public void Remove(Loan loan)
        {
            context.Loans.Remove(loan);
            context.SaveChanges();
        }
    }
}