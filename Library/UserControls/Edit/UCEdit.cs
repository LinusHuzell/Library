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

namespace Library.UserControls.Books
{
    public partial class UCEdit : UserControl
    {
        private LibraryForm form;
        private string txtSearchPlaceholder;
        private Timer messageTimer = new Timer();

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCEdit() { }

        /// <summary>
        /// Initialize the User Control
        /// </summary>
        public UCEdit(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.txtSearchPlaceholder = txtSearch.Text;
            UIExtension.CreateListViewAlphabeticGroups(lvSearchAuthor);
            UIExtension.CreateListViewAlphabeticGroups(lvSearchBook);

            // Subscribes the information fields update methods to run whenever other services are updated in database.
            this.form.authorService.Updated += AuthorService_Updated;
            this.form.bookService.Updated += BookService_Updated;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCBooks_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                UIExtension.ClearSearch(lvSearchAuthor, lvSearchBook, txtSearch, rbtnAuthor, rbtnBook, pnlSearch, drdwnBookSearchBy, txtSearchPlaceholder);
        }
        // <-- Constructors.

        // Local methods. -->
        private void ClearTextBoxAndButton(TextBox textBox, Button button, string placeholder)
        {
            textBox.Enabled = true;
            button.Enabled = true;
            textBox.Text = "";
            UIExtension.ShowPlaceholder(textBox, placeholder);
        }
        // <-- Local methods.

        // Information fields handling. -->
        private void AuthorService_Updated(object sender, EventArgs e)
        {
            UpdatelvSearchAuthor();
            UpdatelvSearchBook();
        }

        private void BookService_Updated(object sender, EventArgs e)
        {
            UpdatelvSearchBook();
        }

        private void UpdatelvSearchAuthor(IEnumerable<Author> authorList = null)
        {
            lvSearchAuthor.Items.Clear();
            if (authorList == null)
                authorList = form.authorService.All();

            foreach (Author author in authorList)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = author.ToString(),
                    Tag = author
                };
                UIExtension.AddToAlphabeticListViewGroup(lvSearchAuthor, item);
                lvSearchAuthor.Items.Add(item);
            }
        }

        private void UpdatelvSearchBook(IEnumerable<Book> bookList = null)
        {
            lvSearchBook.Items.Clear();
            if (bookList == null)
                bookList = form.bookService.All();
            foreach (Book book in bookList)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = book.ToString(),
                    Tag = book
                };
                item.SubItems.Add(book.AuthorsToString());
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.ISBN);
                UIExtension.AddToAlphabeticListViewGroup(lvSearchBook, item);
                lvSearchBook.Items.Add(item);
            }
        }

            // Focus events. -->
        private void rbtnAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAuthor.Checked)
            {
                ClearTextBoxAndButton(txtSearch, btnSearch, txtSearchPlaceholder);
                drdwnBookSearchBy.Visible = false;
                drdwnBookSearchBy.SelectedIndex = 0;
                UIExtension.ToggleListViewSearch(lvSearchAuthor, lvSearchBook, pnlSearch);
            }
        }

        private void rbtnBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBook.Checked)
            {
                ClearTextBoxAndButton(txtSearch, btnSearch, txtSearchPlaceholder);
                drdwnBookSearchBy.Visible = true;
                UIExtension.ToggleListViewSearch(lvSearchBook, lvSearchAuthor, pnlSearch);
            }
        }

        private void drdwnBookSearchBy_SelectedValueChanged(object sender, EventArgs e)
        {
            if (drdwnBookSearchBy.Visible)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                ActiveControl = txtSearch;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtSearch, txtSearchPlaceholder);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtSearch, txtSearchPlaceholder);
        }
            // <-- Focus events.

            // Click events. -->
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            UIExtension.operation = UIExtension.Operation.Add;
            UIExtension.ChangeUC(form.ucBook);
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            UIExtension.operation = UIExtension.Operation.Add;
            UIExtension.ChangeUC(form.ucAuthor);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbtnAuthor.Checked && lvSearchAuthor.SelectedItems.Count > 0)
            {
                UIExtension.currentItem = lvSearchAuthor.SelectedItems[0].Tag;
                UIExtension.operation = UIExtension.Operation.Edit;
                UIExtension.ChangeUC(form.ucAuthor);
            }
            else if (rbtnBook.Checked && lvSearchBook.SelectedItems.Count > 0)
            {
                UIExtension.currentItem = lvSearchBook.SelectedItems[0].Tag;
                UIExtension.operation = UIExtension.Operation.Edit;
                UIExtension.ChangeUC(form.ucBook);
            }
            else
            {
                UIExtension.ShowMessage(messageTimer, lblMessage, "You must first select an item to edit!", Color.Red);
            }
        }
            // <-- Click events.

            // Key press events. -->
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                UIExtension.ClearSearch(lvSearchAuthor, lvSearchBook, txtSearch, rbtnAuthor, rbtnBook, pnlSearch, drdwnBookSearchBy, txtSearchPlaceholder);
        }

        private void lvSearchAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                UIExtension.ClearSearch(lvSearchAuthor, lvSearchBook, txtSearch, rbtnAuthor, rbtnBook, pnlSearch, drdwnBookSearchBy, txtSearchPlaceholder);
        }

        private void lvSearchBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                UIExtension.ClearSearch(lvSearchAuthor, lvSearchBook, txtSearch, rbtnAuthor, rbtnBook, pnlSearch, drdwnBookSearchBy, txtSearchPlaceholder);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != txtSearchPlaceholder)
            {
                btnSearch.Enabled = true;
                if (rbtnAuthor.Checked)
                {
                    UpdatelvSearchAuthor(form.authorService.Filter(txtSearch.Text));
                }
                else if (rbtnBook.Checked)
                {
                    if (drdwnBookSearchBy.Text == "Search by title")
                        UpdatelvSearchBook(form.bookService.FilterByTitle(txtSearch.Text));
                    else if (drdwnBookSearchBy.Text == "Search by author")
                        UpdatelvSearchBook(form.bookService.FilterByAuthor(txtSearch.Text));
                }
            }
        }
            // <-- Key press events.

        // <-- Information fields handling.














    }
}
