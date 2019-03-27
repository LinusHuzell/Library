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
    public partial class UCAuthor : UserControl
    {
        private LibraryForm form;
        private Author currentAuthor;
        private Author tempAuthor;
        private Timer messageTimer = new Timer();
        private string txtFirstNamePlaceholder;
        private string txtLastNamePlaceholder;

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCAuthor() { }

        /// <summary>
        /// Initialize the User Control.
        /// </summary>
        /// <param name="form"></param>
        public UCAuthor(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.txtFirstNamePlaceholder = txtFirstName.Text;
            this.txtLastNamePlaceholder = txtLastName.Text;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCAuthor_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (UIExtension.operation == UIExtension.Operation.Add)
                {
                    lblTitle.Text = "Add New Author";
                    pbNew.Visible = true;
                    ClearTextboxes();
                }
                else if (UIExtension.operation == UIExtension.Operation.Edit)
                {
                    currentAuthor = UIExtension.currentItem as Author;
                    StoreTemporaryAuthor(currentAuthor);
                    lblTitle.Text = $"Edit {currentAuthor}";
                    pbNew.Visible = false;
                    UIExtension.InsertValueToTextBox(txtFirstName, currentAuthor.FirstName);
                    UIExtension.InsertValueToTextBox(txtLastName, currentAuthor.LastName);
                }
            }
        }
        // <-- Constructors.

        // Local methods. -->
        private void ClearTextboxes()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            UIExtension.ShowPlaceholder(txtFirstName, txtFirstNamePlaceholder);
            UIExtension.ShowPlaceholder(txtLastName, txtLastNamePlaceholder);
        }

        private void StoreTemporaryAuthor(Author author)
        {
            tempAuthor = new Author(author.FirstName, author.LastName);
        }

        private void RestoreAuthor(Author author)
        {
            author.FirstName = tempAuthor.FirstName;
            author.LastName = tempAuthor.LastName;
        }
        // <-- Loacal methods.

        // Misc. functionality. --> 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "" || txtFirstName.Text == txtFirstNamePlaceholder || txtLastName.Text == txtLastNamePlaceholder)
                UIExtension.ShowMessage(messageTimer, lblMessage, $"You must enter a value for both First and Last Name!", Color.Red);
            else
            {
                try
                {
                    if(UIExtension.operation == UIExtension.Operation.Add)
                    {
                        form.authorService.Add(new Author(txtFirstName.Text.Trim(), txtLastName.Text.Trim()));
                        UIExtension.ShowMessage(messageTimer, lblMessage, $"New author \"{txtFirstName.Text} {txtLastName.Text}\" added!", Color.LimeGreen);
                        ClearTextboxes();
                    }
                    else
                    {
                        currentAuthor.FirstName = txtFirstName.Text;
                        currentAuthor.LastName = txtLastName.Text;
                        form.authorService.Edit(currentAuthor);
                        UIExtension.ShowMessage(messageTimer, lblMessage, $"{txtFirstName.Text} {txtLastName.Text} edited!", Color.LimeGreen);
                        lblTitle.Text = $"Edit {currentAuthor}";
                    }
                    ActiveControl = null;
                }
                catch (Exception exception)
                {
                    UIExtension.ShowMessage(messageTimer, lblMessage, exception.Message, Color.Red);
                    if (UIExtension.operation == UIExtension.Operation.Edit)
                        RestoreAuthor(currentAuthor);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UIExtension.ChangeUC(form.ucEdit);
        }
        // <-- Misc. functionality.

        // Information fields handling --> 
        
            // Focus events. -->
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtFirstName, txtFirstNamePlaceholder);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtFirstName, txtFirstNamePlaceholder);
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtLastName, txtLastNamePlaceholder);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtLastName, txtLastNamePlaceholder);
        }
            // <-- Focus events.

            // Key press events. -->
        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }
            // <-- Key press events.

    }
}
