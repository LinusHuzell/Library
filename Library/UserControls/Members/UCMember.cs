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
using System.Text.RegularExpressions;


namespace Library.UserControls.Members
{
    public partial class UCMember : UserControl
    {
        private LibraryForm form;
        private string txtFirstNamePlaceholder, txtLastNamePlaceholder, txtPersonalIDPlaceholder, txtUsernamePlaceholder;
        private Timer messageTimer = new Timer();
        private Member currentMember, tempMember;

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCMember() { }

        /// <summary>
        /// Initialize the User Control
        /// </summary>
        public UCMember(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.txtFirstNamePlaceholder = txtFirstName.Text;
            this.txtLastNamePlaceholder = txtLastName.Text;
            this.txtPersonalIDPlaceholder = txtPersonalID.Text;
            this.txtUsernamePlaceholder = txtUsername.Text;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCAddMember_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (UIExtension.operation == UIExtension.Operation.Add)
                {
                    lblTitle.Text = "Add New Member";
                    pbNew.Visible = true;
                    pbEdit.Visible = false;
                    btnSave.Text = "  Add Member";
                    ResetFields();
                }
                else if (UIExtension.operation == UIExtension.Operation.Edit)
                {
                    this.currentMember = UIExtension.currentItem as Member;
                    StoreTemporaryMember(currentMember);
                    lblTitle.Text = "Edit Member";
                    pbNew.Visible = false;
                    pbEdit.Visible = true;
                    btnSave.Text = "  Edit Member";
                    PopulateFields();
                }
            }
            else
                ResetFields();
        }
        // <-- Constructors.

        // Local methods. -->
        private void ResetFields()
        {
            UIExtension.EnableTextbox(txtPersonalID);
            txtPersonalID.Text = "";
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            UIExtension.ShowPlaceholder(txtFirstName, txtFirstNamePlaceholder);
            UIExtension.ShowPlaceholder(txtLastName, txtLastNamePlaceholder);
            UIExtension.ShowPlaceholder(txtPersonalID, txtPersonalIDPlaceholder);
            UIExtension.ShowPlaceholder(txtUsername, txtUsernamePlaceholder);
        }

        private void PopulateFields()
        {
            UIExtension.DisableTextbox(txtPersonalID);
            txtPersonalID.Text = currentMember.PersonalID;
            txtFirstName.Text = currentMember.FirstName;
            txtUsername.Text = currentMember.Username;
            txtFirstName.Text = currentMember.FirstName;
            txtLastName.Text = currentMember.LastName;
            txtFirstName.ForeColor = Color.Black;
            txtLastName.ForeColor = Color.Black;
            txtUsername.ForeColor = Color.Black;
        }

        private bool AllFieldsFilledIn()
        {
            if (txtPersonalID.Text.Trim() == "" || txtUsername.Text.Trim() == "" || txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
                return false;
            else
                return true;
        }

        private void StoreTemporaryMember(Member member)
        {
            tempMember = new Member(member.PersonalID, member.Username, member.FirstName, member.LastName);
        }

        private void RestoreMember(Member member)
        {
            currentMember.Username = tempMember.Username;
            currentMember.FirstName = tempMember.FirstName;
            currentMember.LastName = tempMember.LastName;
        }

        // <-- Local methods.

        // Misc. functionality. --> 
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (UIExtension.operation == UIExtension.Operation.Add)
                UIExtension.ChangeUC(form.ucMembers);
            else if (UIExtension.operation == UIExtension.Operation.Edit)
                UIExtension.ChangeUC(form.ucViewMember);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!AllFieldsFilledIn())
                UIExtension.ShowMessage(messageTimer, lblMessage, $"You must enter values for all required fields!", Color.Red);
            else
            {
                try
                {
                    if (UIExtension.operation == UIExtension.Operation.Add)
                    {
                        Member newMember = new Member(txtPersonalID.Text.Trim(), txtUsername.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim());
                        form.memberService.Add(newMember);
                        UIExtension.ShowMessage(messageTimer, lblMessage, $"New member \"{txtFirstName.Text} {txtLastName.Text}\" added!", Color.LimeGreen);
                        ResetFields();
                    }
                    else if (UIExtension.operation == UIExtension.Operation.Edit)
                    {
                        currentMember.Username = txtUsername.Text.Trim();
                        currentMember.FirstName = txtFirstName.Text.Trim();
                        currentMember.LastName = txtLastName.Text.Trim();
                        form.memberService.Edit(currentMember);
                        UIExtension.ShowMessage(messageTimer, lblMessage, $"Current member was successfully edited!", Color.LimeGreen);
                    }
                }
                catch (Exception exception)
                {
                    if (UIExtension.operation == UIExtension.Operation.Edit)
                        RestoreMember(tempMember);
                    UIExtension.ShowMessage(messageTimer, lblMessage, exception.Message, Color.Red);


                }
            }
        }
        // <-- Misc. functionallity.

        // Information fields handling. -->

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

        private void txtPersonalID_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtPersonalID, txtPersonalIDPlaceholder);
        }

        private void txtPersonalID_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtPersonalID, txtPersonalIDPlaceholder);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtUsername, txtUsernamePlaceholder);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtUsername, txtUsernamePlaceholder);
        }
            // <-- Focus events.

            // Key press events.-->
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }

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

        // <-- Information fields handling.



    }
}
