using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class LoanService : IService<Loan>
    {
        /// <summary>
        /// Loan r epository Repository with set context.
        /// </summary>
        LoanRepository LoanRepository;

        /// <summary>
        /// Event that's triggered whenever there's a loan updated.
        /// </summary>
        public event EventHandler Updated;

        //Constructor. -->
        /// <summary>
        /// Loan Service that handle all loans.
        /// </summary>
        /// <param name="rFactory"></param>
        public LoanService (RepositoryFactory rFactory)
        {
            this.LoanRepository = rFactory.CreateLoanRepository();
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
        /// Validates and sends a loan object to repository for adding to database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="loan">Loan object to be added to databse.</param>
        public void Add(Loan loan)
        {
            if (All().Where(_loan => _loan.DateOfReturn == null).Where(_loan => _loan.BookCopy == loan.BookCopy).Count() != 0)
                throw new OperationCanceledException("This book copy is already on loan!");
            LoanRepository.Add(loan);
            OnUpdated(loan, EventArgs.Empty);
        }

        /// <summary>
        /// Get all loans from database.
        /// </summary>
        /// <returns>A list of all loans in database.</returns>
        public IEnumerable<Loan> All()
        {
            return LoanRepository.All();
        }

        /// <summary>
        /// Finds a loan in database from a sepcific ID.
        /// </summary>
        /// <param name="id">ID of loan to find.</param>
        /// <returns>The loan object found.</returns>
        public Loan Find(int id)
        {
            return LoanRepository.Find(id);
        }

        /// <summary>
        /// Sends a specific loan object to repository for editing in database and then raises the OnUpdated event.
        /// </summary>
        /// <param name="loan">Loan object to edit in database.</param>
        public void Edit(Loan loan)
        {
            LoanRepository.Edit(loan);
            OnUpdated(loan, EventArgs.Empty);
        }

        /// <summary>
        /// Removes a specific loan from database.
        /// </summary>
        /// <param name="loan">Loan object to be removed.</param>
        public void Remove(Loan loan)
        {
            LoanRepository.Remove(loan);
            OnUpdated(loan, EventArgs.Empty);
        }
        // <-- Standard query-methods implemented by the IService interface.

        // Specific query-methods for this service. -->
        /// <summary>
        /// Returns a loan and saves to database.
        /// </summary>
        /// <param name="loan">Loan to be returned.</param>
        public void Return(Loan loan)
        {
            loan.DateOfReturn = DateTime.Now;
            Edit(loan);
        }

        /// <summary>
        /// Get all loans that's currently on loan and not returned.
        /// </summary>
        /// <returns>A list of all books currently on loan and not returned.</returns>
        public IEnumerable<Loan> CurrentLoans()
        {
            return All().Where(loan => loan.DateOfReturn == null);
        }

        /// <summary>
        /// Get all loans that's currently on loan and not returned of a specific book.
        /// </summary>
        /// <param name="book">Book to find loans current loans of.</param>
        /// <returns>A list of all loans of a specific book.</returns>
        public IEnumerable<Loan> CurrentLoansWithBook(Book book)
        {
            return All().Where(loan => loan.DateOfReturn == null && loan.BookCopy.Book.BookID == book.BookID);
        }

        /// <summary>
        /// Get all loans made by member.
        /// </summary>
        /// <param name="member">Member to get all oans from.</param>
        /// <returns>A list of all loans made by member.</returns>
        public IEnumerable<Loan> LoansByMember(Member member)
        {
            return All().Where(loan => loan.Member.MemberID == member.MemberID).OrderByDescending(loan => loan.DateOfLoan);
        }

        /// <summary>
        /// Get all book copies currently on loan and not returned.
        /// </summary>
        /// <param name="book">Book ro find book copies currently on loan of.</param>
        /// <returns>A list of all book copies currently on loan from a specific book.</returns>
        public IEnumerable<BookCopy> BookCopiesOnLoan(Book book)
        {
            return CurrentLoansWithBook(book).Select(loan => loan.BookCopy);
        }

        /// <summary>
        /// Filters all current loans by book title from an entered value. Works as a search method.
        /// </summary>
        /// <param name="title">Value to search book title with.</param>
        /// <returns>A list of all loans searched for by book title.</returns>
        public IEnumerable<Loan> FilterCurrentLoansByBookTitle(string title)
        {
            return All().Where(loan => loan.DateOfReturn == null && loan.BookCopy.Book.ToString().ToLower().Contains(title.ToLower()));
        }

        /// <summary>
        /// Filters all current loans by member from an entered value. Works as a search method.
        /// </summary>
        /// <param name="name">Value to search member name with.</param>
        /// <returns>A list of all current loans searched for by member name.</returns>
        public IEnumerable<Loan> FilterCurrentLoansByMember(string name)
        {
            return All().Where(loan => loan.DateOfReturn == null && loan.Member.ToString().ToLower().Contains(name.ToLower()));
        }

        /// <summary>
        /// Orders a list of loans by Due Date and then Book ID.
        /// </summary>
        /// <param name="loanList">The list to be sorted.</param>
        /// <returns>The sorted list.</returns>
        public IEnumerable<Loan> OrderByDueDateAndBookID(IEnumerable<Loan> loanList)
        {
            return loanList.OrderBy(loan => loan.DueDate).ThenBy(loan => loan.BookCopy.BookCopyID);
        }
        // <-- Specific query-methods for this service. 

        // Public methods for this service. -->
        /// <summary>
        /// Calculates number of days overdue for a loan.
        /// </summary>
        /// <param name="loan">Loan to calculate days overdue of.</param>
        /// <returns>Number of days overdue, negative number if returned before due date.</returns>
        public double CalculateDaysOverdue(Loan loan)
        { 
            DateTime returnDate;
            if (loan.DateOfReturn == null)
                returnDate = DateTime.Now;
            else
                returnDate = loan.DateOfReturn.Value;

            double daysOverdue = Math.Floor((returnDate - loan.DueDate.Value).TotalDays);

            if (daysOverdue > 0)
                return Math.Ceiling(daysOverdue);
            else
                return Math.Floor(daysOverdue);
        }

        /// <summary>
        /// Calculates number of days left of a loan.
        /// </summary>
        /// <param name="loan">Loan to calculate days left of.</param>
        /// <returns>Number of days left.</returns>
        public double CalculateDaysLeft(Loan loan)
        {
            return Math.Ceiling((loan.DueDate.Value - DateTime.Now).TotalDays);
        }
        // <-- Public methods for this service.
    }
}
