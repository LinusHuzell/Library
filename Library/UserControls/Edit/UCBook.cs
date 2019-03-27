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
    public partial class UCBook : UserControl
    {
        private LibraryForm form;
        private Book currentBook, tempBook;
        private string txtFilterPlaceholder;
        private Timer messageTimer = new Timer();

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCBook() { }

        /// <summary>
        /// Initialize the User Control.
        /// </summary>
        public UCBook(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.txtFilterPlaceholder = txtFilter.Text;
            UIExtension.CreateListViewAlphabeticGroups(lvSelectAuthor);

            // Subscribes the information fields update methods to run whenever other services are updated in database.
            this.form.authorService.Updated += AuthorService_Updated;
            this.form.bookCopyService.Updated += BookCopyService_Updated;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCAddBook_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (UIExtension.operation == UIExtension.Operation.Add)
                {
                    lblTitle.Text = "Add New Book";
                    pbNew.Visible = true;
                    ClearAuthorFilter();
                    UIExtension.ClearTextBoxesInPanel(pnlBookInfo);
                    lvBookAuthors.Items.Clear();
                    ToggleBookCopyVisibility(false);
                    UIExtension.EnableTextbox(txtISBN);
                }
                else if (UIExtension.operation == UIExtension.Operation.Edit)
                {
                    currentBook = UIExtension.currentItem as Book;
                    StoreTemporaryBook(currentBook);
                    lblTitle.Text = $"Edit {currentBook}";
                    pbNew.Visible = false;
                    ToggleBookCopyVisibility(true);
                    InsertAuthors();
                    txtISBN.Text = currentBook.ISBN;
                    txtTitle.Text = currentBook.Title;
                    txtYear.Text = currentBook.Year.ToString();
                    txtDescription.Text = currentBook.Description;
                    UIExtension.DisableTextbox(txtISBN);
                }
            }
            else
                ClearAuthorFilter(sender, e);
        }
        // <-- Constructors.

        // Local methods. -->
        private void ToggleBookCopyVisibility(bool showElements)
        {
            if (showElements)
            {
                UpdatelvBookCopies();
                btnAddBookCopy.Visible = true;
                lvBookCopies.Visible = true;
            }
            else
            {
                btnAddBookCopy.Visible = false;
                lvBookCopies.Visible = false;
            }
        }

        private void StoreTemporaryBook(Book book)
        {
            tempBook = new Book(book.ISBN, book.Title, book.Authors, book.Year, book.Description);
        }

        private void RestoreBook(Book book)
        {
            book.Authors = tempBook.Authors;
            book.Description = tempBook.Description;
            book.Title = tempBook.Title;
            book.Year = tempBook.Year;
        }
        // <-- Local methods.

        // Misc. functionality. --> 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvBookAuthors.Items.Count == 0 || txtISBN.Text.Trim() == "" || txtTitle.Text.Trim() == "" || txtYear.Text.Trim() == "")
                UIExtension.ShowMessage(messageTimer, lblMessage, $"You must enter values for all required fields!", Color.Red);
            else
            {
                try
                {
                    List<Author> authorList = new List<Author>();

                    foreach (ListViewItem author in lvBookAuthors.Items)
                    {
                        authorList.Add(author.Tag as Author);
                    }

                    if (UIExtension.operation == UIExtension.Operation.Add)
                    {
                        Book book = new Book(txtISBN.Text.Trim(), txtTitle.Text.Trim(), authorList, Convert.ToInt64(txtYear.Text.Trim()), txtDescription.Text.Trim());
                        form.bookService.Add(book);
                        form.bookCopyService.Add(new BookCopy(book));
                        UIExtension.ShowMessage(messageTimer, lblMessage, $"{txtTitle.Text.Trim()} was successfully added to the library!", Color.Green);
                        ClearAuthorFilter(sender, e);
                        UIExtension.ClearTextBoxesInPanel(pnlBookInfo);
                        lvBookAuthors.Items.Clear();
                    }
                    else
                    {
                        currentBook.Authors = authorList;
                        currentBook.Title = txtTitle.Text.Trim();
                        currentBook.Year = Convert.ToInt64(txtYear.Text.Trim());
                        currentBook.Description = txtDescription.Text.Trim();
                        form.bookService.Edit(currentBook);
                        lblTitle.Text = $"Edit {currentBook}";
                        UIExtension.ShowMessage(messageTimer, lblMessage, $"{currentBook} was successfully edited!", Color.Green);
                    }
                }
                catch (FormatException)
                {
                    UIExtension.ShowMessage(messageTimer, lblMessage, $"You need to enter a valid value for Year", Color.Red);
                    if (UIExtension.operation == UIExtension.Operation.Edit)
                        RestoreBook(currentBook);
                }
                catch (Exception exception)
                {
                    UIExtension.ShowMessage(messageTimer, lblMessage, exception.Message, Color.Red);
                    if (UIExtension.operation == UIExtension.Operation.Edit)
                        RestoreBook(currentBook);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UIExtension.ChangeUC(form.ucEdit);
        }
        // <-- Misc. functionality.

        // Filter functionality. -->
        private void ClearAuthorFilter(object sender = null, EventArgs e = null)
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

            // Key press events. -->
        /// <summary>
        /// Escapes the textbox when pressing enter.
        /// </summary>
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ClearAuthorFilter(sender, e);
            }
        }

        /// <summary>
        /// Filters the list view of authors in realtime when typing in textbox.
        /// </summary>
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text != txtFilterPlaceholder)
            {
                UpdatelvSelectAuthor(form.authorService.Filter(txtFilter.Text));
            }
        }
            // <-- Key press events.

        // <-- Filter functionality.

        // Information fields handling -->
        private void AuthorService_Updated(object sender, EventArgs e)
        {
            UpdatelvSelectAuthor();
        }

        private void BookCopyService_Updated(object sender, EventArgs e)
        {
            UpdatelvBookCopies();
        }

        /// <summary>
        /// Populates the list view of authors to select for book.
        /// </summary>
        /// <param name="authorList">Optional parameter: The list to populate with.</param>
        private void UpdatelvSelectAuthor(IEnumerable<Author> authorList = null)
        {
            lvSelectAuthor.Items.Clear();
            if (authorList == null)
                authorList = form.authorService.All();
            foreach (Author author in authorList)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = author.ToString(),
                    Tag = author
                };
                UIExtension.AddToAlphabeticListViewGroup(lvSelectAuthor, item);
                lvSelectAuthor.Items.Add(item);
            }
        }

        private void UpdatelvBookCopies()
        {
            if (currentBook != null)
            {
                lvBookCopies.Items.Clear();
                foreach (BookCopy bookCopy in form.bookService.BookCopiesOrderByCopyID(currentBook))
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

        private void InsertAuthors()
        {
            lvBookAuthors.Items.Clear();
            foreach (Author author in currentBook.Authors)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = author.ToString(),
                    Tag = author
                };
                lvBookAuthors.Items.Add(item);
            }
        }

            // Focus events. -->
        /// <summary>
        /// Prevents the user from changing the column width in the list view.
        /// </summary>
        private void lvSelectAuthor_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvSelectAuthor.Columns[e.ColumnIndex].Width;
        }
            // <-- Focus events.

            //Click events. -->
        private void btnAddBookCopy_Click(object sender, EventArgs e)
        {
            form.bookCopyService.Add(new BookCopy(currentBook));
            UIExtension.ShowMessage(messageTimer, lblMessage, "Book Copy added!", Color.Green);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvBookAuthors.SelectedItems.Count == 0)
            {
                UIExtension.ShowMessage(messageTimer, lblMessage, "You need to select an author to remove!", Color.Red);
            }
            else
            {
                UIExtension.ShowMessage(messageTimer, lblMessage, $"{lvBookAuthors.SelectedItems[0].Tag.ToString()} was successfully removed from the book!", Color.Green);
                lvBookAuthors.Items.RemoveAt(lvBookAuthors.SelectedIndices[0]);
            }

        }

        /// <summary>
        /// Adds the selected author to the list view of authors of book.
        /// </summary>
        private void btnSelectAuthor_Click(object sender, EventArgs e)
        {
            if (lvSelectAuthor.SelectedItems.Count == 0)
            {
                UIExtension.ShowMessage(messageTimer, lblMessage, "You need to select an author from the list!", Color.Red);
            }
            else
            {
                ListViewItem item = lvSelectAuthor.SelectedItems[0].Clone() as ListViewItem;

                if (lvBookAuthors.FindItemWithText(item.Tag.ToString()) != null)
                {
                    UIExtension.ShowMessage(messageTimer, lblMessage, $"{item.Tag.ToString()} is already an author of this book!", Color.Red);
                }
                else
                {
                    lvBookAuthors.Items.Add(item);
                    UIExtension.ShowMessage(messageTimer, lblMessage, $"{item.Tag.ToString()} was selected to the book!", Color.Green);
                }
                ClearAuthorFilter(sender, e);
            }
        }
        // <-- Click events.

        // Key press events. -->
        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }

        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }
            // <-- Key press events.

        // <-- List View Handling.










    }
}
