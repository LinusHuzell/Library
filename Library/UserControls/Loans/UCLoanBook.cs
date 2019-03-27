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
    public partial class UCLoanBook : UserControl
    {
        private LibraryForm form;
        private Book currentBook;
        private string txtFilterPlaceholder;
        private Timer messageTimer = new Timer();

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCLoanBook() { }

        /// <summary>
        /// Initialize the User Control
        /// </summary>
        public UCLoanBook(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.txtFilterPlaceholder = txtFilter.Text;
            UIExtension.CreateListViewAlphabeticGroups(lvMembers);

            // Subscribes the information fields update methods to run whenever other services are updated in database.
            this.form.memberService.Updated += MemberService_Updated;
            this.form.bookCopyService.Updated += BookCopyService_Updated;
            this.form.loanService.Updated += LoanService_Updated;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCLoanBook_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                currentBook = UIExtension.currentItem as Book;
                UpdatelvBookCopies();
                ClearMemberFilter(sender, e);
                lblBookTitle.Text = currentBook.ToString();
                txtISBN.Text = currentBook.ISBN;
                txtAuthors.Text = currentBook.AuthorsToString();
                txtYear.Text = currentBook.Year.ToString();
                txtDescription.Text = currentBook.Description;
            }
        }
        // <-- Constructors.

        // Misc. functionality -->
        private void btnBack_Click(object sender, EventArgs e)
        {
            UIExtension.ChangeUC(form.ucLoansSearch);
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            if (lvMembers.SelectedItems.Count == 0 || lvBookCopies.SelectedItems.Count == 0)
                UIExtension.ShowMessage(messageTimer, lblMessage, "You must select a member and a book copy to loan!", Color.Red);
            else
            {
                try
                {
                    Loan loan = new Loan(lvBookCopies.SelectedItems[0].Tag as BookCopy, lvMembers.SelectedItems[0].Tag as Member);
                    this.form.loanService.Add(loan);
                    MessageBox.Show($"You've lend the book {currentBook}, copy number {loan.BookCopy}. Return on {loan.DueDate.Value.ToShortDateString()}.");
                    UIExtension.ChangeUC(form.ucLoans);
                }
                catch (Exception exception)
                {
                    UIExtension.ShowMessage(messageTimer, lblMessage, exception.Message, Color.Red);
                }
            }
        }
        // <-- Misc. functionality.

        // Filter functionality. -->
        private void ClearMemberFilter(object sender, EventArgs e)
        {
            ActiveControl = null;
            txtFilter.Text = "";
            txtFilter_Leave(sender, e);
        }

            // Focus events. -->
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtFilter, txtFilterPlaceholder);
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtFilter, txtFilterPlaceholder);
        }
            // <-- Focus events.

            // Key press events.-->
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ClearMemberFilter(sender, e);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text != txtFilterPlaceholder)
            {
                UpdatelvMembers(form.memberService.Filter(txtFilter.Text));
            }
        }
            // <-- Key press events.
        // <-- Filter functionality.

        // Information fields handling. -->
        private void LoanService_Updated(object sender, EventArgs e)
        {
            UpdatelvBookCopies();
        }

        private void BookCopyService_Updated(object sender, EventArgs e)
        {
            UpdatelvBookCopies();
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            UpdatelvMembers();
        }

        private void UpdatelvMembers(IEnumerable<Member> memberList = null)
        {
            lvMembers.Items.Clear();
            if (memberList == null)
                memberList = form.memberService.All();
            foreach (Member member in memberList)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = member.ToString(),
                    Tag = member
                };
                UIExtension.AddToAlphabeticListViewGroup(lvMembers, item);
                lvMembers.Items.Add(item);
            }
        }

        private void UpdatelvBookCopies()
        {
            if (currentBook != null)
            {
                lvBookCopies.Items.Clear();
                IEnumerable<BookCopy> bookCopiesAvailable = form.bookCopyService.BookCopiesFromBook(currentBook).Except(form.loanService.BookCopiesOnLoan(currentBook));
                foreach (BookCopy bookCopy in bookCopiesAvailable)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = "Book Copy number " + bookCopy.ToString(),
                        Tag = bookCopy
                    };
                    lvBookCopies.Items.Add(item);
                }
            }
        }
        // <- Information fields handling.
















    }
}
