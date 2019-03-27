using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Loan
    {
        /// <summary>
        /// Unique ID of loan.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanID { get; private set; }
        /// <summary>
        /// Total debt of loan. Calculates when get method is called.
        /// </summary>
        public double Debt
        {
            get
            {
                return CalculateDebt(DueDate, DateOfReturn);
            }
        }
        /// <summary>
        /// Price per overdue day in SEK. 
        /// </summary>
        public double OverdueDayPrice { get; private set; }
        /// <summary>
        /// Date when loan is made.
        /// </summary>
        public virtual DateTime? DateOfLoan { get; private set; }
        /// <summary>
        /// Date when loan is supposed to be returned.
        /// </summary>
        public virtual DateTime? DueDate { get; private set; }
        /// <summary>
        /// Date when loan was returned. Null if loan is not returned yet.
        /// </summary>
        public virtual DateTime? DateOfReturn { get; set; }
        /// <summary>
        /// Time span for loans in amount of days.
        /// </summary>
        public double LoanTime { get; private set; }
        /// <summary>
        /// Shows which book copy is lend. 
        /// </summary>
        public virtual BookCopy BookCopy { get; private set; }
        /// <summary>
        /// Shows which member who made the loan.
        /// </summary>
        public virtual Member Member { get; private set; }

        // Constructors. -->
        public Loan() { }

        public Loan(BookCopy _BookCopy, Member _Member, DateTime? _DateOfLoan = null, DateTime? _DateOfReturn = null)
        {
            if (_DateOfLoan != null)
                DateOfLoan = _DateOfLoan;
            else
                DateOfLoan = DateTime.Now;

            if (_DateOfReturn != null)
            {
                DateOfReturn = _DateOfReturn;
            }

            BookCopy = _BookCopy;
            Member = _Member;
            OverdueDayPrice = 10;
            LoanTime = 15;
            DueDate = DateOfLoan.Value.AddDays(LoanTime);
        }
        // <-- Constructors.



        // Class methods. -->
        private double CalculateDebt(DateTime? dueDate, DateTime? dateOfReturn)
        {
            double daysBetween;

            if (DateOfReturn != null)
                daysBetween = Math.Floor((dateOfReturn.Value - dueDate.Value).TotalDays);
            else
                daysBetween = Math.Floor((DateTime.Now - dueDate.Value).TotalDays);

            if (daysBetween > 0)
                return daysBetween * OverdueDayPrice;
            else
                return 0;
        }
        // <-- Class methods.
    }
}
