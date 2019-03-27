using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library.UserControls.Loans
{
    public partial class UCReturnBook : UserControl
    {
        private LibraryForm form;
        private Loan currentLoan;
        private Timer messageTimer = new Timer();
        private Color btnReturnLoanBackColor;

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCReturnBook() { }

        /// <summary>
        /// Initialize the User Control
        /// </summary>
        public UCReturnBook(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.btnReturnLoanBackColor = btnReturnLoan.BackColor;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCReturnBook_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                currentLoan = UIExtension.currentItem as Loan;
                UIExtension.ClearTextBoxesInPanel(pnlBookInfo);
                UIExtension.ClearTextBoxesInPanel(pnlLoanInfo);

                btnReturnLoan.Enabled = true;
                btnReturnLoan.BackColor = btnReturnLoanBackColor;
                lblMessage.Visible = false;

                lblBookTitle.Text = currentLoan.BookCopy.Book.ToString();

                txtISBN.Text = currentLoan.BookCopy.Book.ISBN;
                txtBookCopy.Text = currentLoan.BookCopy.ToString();
                txtAuthor.Text = currentLoan.BookCopy.Book.AuthorsToString();
                txtYear.Text = currentLoan.BookCopy.Book.Year.ToString();
                txtDescription.Text = currentLoan.BookCopy.Book.Description;

                lblOnTime.Visible = false;
                txtOnTime.Visible = false;
                lblReturned.Visible = false;
                txtReturned.Visible = false;
                lblDebt.Visible = false;
                txtDebt.Visible = false;
                UpdateLoanInfo();
            }
        }
        // <-- Constructors.

        // Misc. functionality -->
        private void btnBack_Click(object sender, EventArgs e)
        {
            UIExtension.ChangeUC(form.ucLoansSearch);
        }

        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            try
            {
                form.loanService.Return(currentLoan);
                lblMessage.Visible = true;
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Loan returned successfully!";
                UpdateLoanInfo();
                lblOnTime.Visible = true;
                txtOnTime.Visible = true;
                lblReturned.Visible = true;
                txtReturned.Visible = true;
                txtReturned.Text = currentLoan.DateOfReturn.Value.ToShortDateString();
                lblDebt.Visible = true;
                txtDebt.Visible = true;
                txtDebt.Text = $"{currentLoan.Debt.ToString()} kr";
                txtDebt.ForeColor = (currentLoan.Debt > 0) ? Color.OrangeRed : Color.Green;
                btnReturnLoan.Enabled = false;
                btnReturnLoan.BackColor = Color.Gray;
            }
            catch (Exception exception)
            {
                UIExtension.ShowMessage(messageTimer, lblMember, exception.Message, Color.Red);
            }
        }
        // <-- Misc. functionality.

        // Information fields handling. -->
        private void UpdateLoanInfo()
        {
            txtMember.Text = currentLoan.Member.ToString();
            txtLoanDate.Text = currentLoan.DateOfLoan.Value.ToShortDateString();
            txtDueDate.Text = currentLoan.DueDate.Value.ToShortDateString();
            if (form.loanService.CalculateDaysLeft(currentLoan) >= 0)
            {
                lblDaysLeft.Text = "Days left:";
                txtDaysLeft.Text = form.loanService.CalculateDaysLeft(currentLoan).ToString();
                txtDaysLeft.ForeColor = Color.Black;
                txtOnTime.Text = "Yes";
                txtOnTime.ForeColor = Color.Green;
            }
            else
            {
                lblDaysLeft.Text = "Overdue:";
                txtDaysLeft.Text = $"{form.loanService.CalculateDaysOverdue(currentLoan).ToString()} day(s)";
                txtDaysLeft.ForeColor = Color.OrangeRed;
                txtOnTime.Text = "No";
                txtOnTime.ForeColor = Color.OrangeRed;
            }
        }
        // <- Information fields handling.
    }
}
