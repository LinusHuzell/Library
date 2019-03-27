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
    public partial class UCLoansSearch : UserControl
    {
        private LibraryForm form;
        private string txtSearchPlaceholder;
        private Timer messageTimer = new Timer();

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCLoansSearch() { }

        /// <summary>
        /// Initialize the User Control.
        /// </summary>
        public UCLoansSearch(Form form = null)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.txtSearchPlaceholder = txtSearch.Text;
            UIExtension.CreateListViewAlphabeticGroups(lvNewLoan);
            UIExtension.CreateListViewAlphabeticGroups(lvReturnLoan);

            // Subscribes the information fields update methods to run whenever other services are updated in database.
            this.form.authorService.Updated += AuthorService_Updated;
            this.form.bookService.Updated += BookService_Updated;
            this.form.bookCopyService.Updated += BookCopyService_Updated;
            this.form.loanService.Updated += LoanService_Updated;
            this.form.memberService.Updated += MemberService_Updated;
        }
        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCLoansSearch_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (UIExtension.loanStatus == UIExtension.Loan.New)
                    LoadNewLoan();
                else if (UIExtension.loanStatus == UIExtension.Loan.Return)
                    LoadReturnLoan();
                else
                    btnBack_Click(sender, e);
            }
        }
        // <-- Constructors.


        // <-- Constructors.

        // Local methods. -->
        private void LoadNewLoan()
        {
            lblTitle.Text = "New loan";
            txtSearch.Enabled = true;
            lblTodaysDate.Visible = false;
            UIExtension.ToggleListViewSearch(lvNewLoan, lvReturnLoan);
            UIExtension.ClearSearch(lvNewLoan, txtSearch, txtSearchPlaceholder, rbtnBook, rbtnMember, false);
        }

        private void LoadReturnLoan()
        {
            lblTitle.Text = "Return loan";
            txtSearch.Enabled = false;
            lblTodaysDate.Visible = true;
            lblTodaysDate.Text = DateTime.Today.ToShortDateString();
            UIExtension.ToggleListViewSearch(lvReturnLoan, lvNewLoan);
            UIExtension.ClearSearch(lvReturnLoan, txtSearch, txtSearchPlaceholder, rbtnBook, rbtnMember, true);
        }
        // <-- local methods.

        // Misc. functionality -->
        private void btnBack_Click(object sender, EventArgs e)
        {
            UIExtension.ChangeUC(form.ucLoans);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ListView listView;
            UserControl userControl;
            if (UIExtension.loanStatus == UIExtension.Loan.New)
            {
                listView = lvNewLoan;
                userControl = form.ucLoanBook;
            }
            else
            {
                listView = lvReturnLoan;
                userControl = form.ucReturnBook;
            }

            if (listView.SelectedItems.Count > 0)
            {
                if (listView.SelectedItems[0].Checked)
                    UIExtension.ShowMessage(messageTimer, lblMessage, "The book is not available for the moment!", Color.Red);
                else
                {
                    UIExtension.currentItem = listView.SelectedItems[0].Tag;
                    UIExtension.ChangeUC(userControl);
                }
            }
            else
                UIExtension.ShowMessage(messageTimer, lblMessage, "You must first select an item in the list!", Color.Red);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
        }
        // <-- Misc. functionality.

        // Filter functionality. -->
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != txtSearchPlaceholder)
            {
                btnSearch.Enabled = true;
                if (rbtnBook.Checked)
                {
                    UpdatelvReturnLoan(form.loanService.FilterCurrentLoansByBookTitle(txtSearch.Text));
                }
                else if (rbtnMember.Checked)
                {
                    UpdatelvReturnLoan(form.loanService.FilterCurrentLoansByMember(txtSearch.Text));
                }
                else
                {
                    UpdatelvNewLoan(form.bookService.FilterByTitle(txtSearch.Text));
                }
            }
        }
            // Focus events. -->
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtSearch, txtSearchPlaceholder);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtSearch, txtSearchPlaceholder);
        }
            // <-- Focus events.

            // Key press events.-->
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = "";
                UIExtension.ShowPlaceholder(txtSearch, txtSearchPlaceholder);
                ActiveControl = null;
            }
        }
            // <-- Key press events.

        // <-- Filter functionality.

        // Information fields handling. -->
        private void AuthorService_Updated(object sender, EventArgs e)
        {
            UpdatelvNewLoan();
        }

        private void BookService_Updated(object sender, EventArgs e)
        {
            UpdatelvNewLoan();
            UpdatelvReturnLoan();
        }

        private void BookCopyService_Updated(object sender, EventArgs e)
        {
            UpdatelvNewLoan();
            UpdatelvReturnLoan();
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            UpdatelvNewLoan();
            UpdatelvReturnLoan();
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            UpdatelvReturnLoan();
        }

        private void UpdatelvNewLoan(IEnumerable<Book> bookList = null)
        {
            lvNewLoan.Items.Clear();
            if (bookList == null)
                bookList = form.bookService.All();

            foreach (Book book in bookList)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = book.ToString(),
                    Tag = book,
                    UseItemStyleForSubItems = false
                };
                item.SubItems.Add(book.AuthorsToString());


                int bookCopiesTotal = book.BookCopies.Count();
                int bookCopiesOnLoan = form.loanService.CurrentLoansWithBook(book).Count();

                if (bookCopiesTotal - bookCopiesOnLoan == 0)
                {
                    item.SubItems.Add("Not available");
                    item.SubItems[2].ForeColor = Color.Red;
                    item.Checked = true;
                }
                else
                {
                    item.SubItems.Add($"{(bookCopiesTotal - bookCopiesOnLoan).ToString()} available");
                    item.SubItems[2].ForeColor = Color.Green;
                }

                UIExtension.AddToAlphabeticListViewGroup(lvNewLoan, item);
                lvNewLoan.Items.Add(item);
            }
        }

        private void UpdatelvReturnLoan(IEnumerable<Loan> loanList = null)
        {
            lvReturnLoan.Items.Clear();
            if (loanList == null)
                loanList = form.loanService.CurrentLoans();

            foreach (Loan loan in form.loanService.OrderByDueDateAndBookID(loanList))
            {
                ListViewItem item = new ListViewItem
                {
                    Text = loan.BookCopy.Book.ToString(),
                    Tag = loan,
                    UseItemStyleForSubItems = false
                };
                item.SubItems.Add(loan.BookCopy.ToString());
                item.SubItems.Add(loan.Member.ToString());
                item.SubItems.Add(loan.DueDate.Value.ToShortDateString());

                if (form.loanService.CalculateDaysOverdue(loan) > 0)
                    item.SubItems[3].ForeColor = Color.Red;

                UIExtension.AddToAlphabeticListViewGroup(lvReturnLoan, item);
                lvReturnLoan.Items.Add(item);
            }
        }
            // Focus events. -->
        private void rbtnBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBook.Checked)
            {
                txtSearch.Enabled = true;
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                ActiveControl = txtSearch;
            }
        }

        private void rbtnMember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMember.Checked)
            {
                txtSearch.Enabled = true;
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                ActiveControl = txtSearch;
            }
        }
            // <-- Focus events.

        // <- Information fields handling.





















    }
}
