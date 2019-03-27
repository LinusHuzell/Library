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

namespace Library.UserControls.Members
{
    public partial class UCViewMember : UserControl
    {
        private LibraryForm form;
        private Member currentMember;

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCViewMember() { }

        /// <summary>
        /// Initialize the User Control
        /// </summary>
        public UCViewMember(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;

            // Subscribes the information fields update methods to run whenever other services are updated in database.
            this.form.loanService.Updated += LoanService_Updated;
            this.form.memberService.Updated += MemberService_Updated;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCViewMember_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                this.currentMember = UIExtension.currentItem as Member;
                UpdateMemberInformation();
                UpdatelvLoans();
                UIExtension.ClearTextBoxesInPanel(pnlLoanInformation);
                ActiveControl = null;
                pnlLoanInformation.Visible = false;
            }
        }



        // <-- Constructors. 

        // Misc. functionality. --> 
        private void btnBack_Click(object sender, EventArgs e)
        {
            UIExtension.ChangeUC(form.ucMembers);
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            UIExtension.operation = UIExtension.Operation.Edit;
            UIExtension.ChangeUC(form.ucMember);
        }
        // <-- Misc. functionallity.

        // Information fields handling. -->
        private void MemberService_Updated(object sender, EventArgs e)
        {
            UpdateMemberInformation();
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            UpdatelvLoans();
        }

        private void UpdatelvLoans()
        {
            if (currentMember != null)
            {
                lvLoans.Items.Clear();
                IEnumerable<Loan> loanList = form.loanService.LoansByMember(currentMember);

                ListViewGroup grCurrent = new ListViewGroup("Current Loans");
                ListViewGroup grReturned = new ListViewGroup("Returned Loans");
                lvLoans.Groups.Add(grCurrent);
                lvLoans.Groups.Add(grReturned);

                foreach (Loan loan in loanList)
                {
                    ListViewItem item = new ListViewItem();

                    if (loan.DateOfReturn != null)
                        item.Group = grReturned;
                    else
                        item.Group = grCurrent;
                    item.Text = loan.BookCopy.Book.Title.ToString();
                    item.Tag = loan;
                    item.SubItems.Add(loan.DateOfLoan.Value.ToShortDateString());
                    lvLoans.Items.Add(item);
                }

            }
        }

        private void UpdateMemberInformation()
        {
            UIExtension.ClearTextBoxesInPanel(pnlMemberInformation);
            if (currentMember != null)
            {
                double totalDebt = form.memberService.CalculateTotalDebt(currentMember);

                txtFirstname.Text = currentMember.FirstName;
                txtLastName.Text = currentMember.LastName;
                txtUsername.Text = currentMember.Username;
                txtPersonalID.Text = currentMember.PersonalID;
                txtRegistered.Text = currentMember.Registered.Value.ToShortDateString();
                if (totalDebt == 0)
                    txtTotalDebt.ForeColor = Color.Green;
                else
                    txtTotalDebt.ForeColor = Color.Red;
                txtTotalDebt.Text = $"{totalDebt.ToString()} kr";
            }
        }

        private void UpdateLoanInformation(object sender, EventArgs e)
        {
            UIExtension.ClearTextBoxesInPanel(pnlLoanInformation);
            if (lvLoans.SelectedItems.Count > 0)
            {
                Loan selectedLoan = lvLoans.SelectedItems[0].Tag as Loan;
                double daysOverdue = form.loanService.CalculateDaysOverdue(selectedLoan);

                txtBook.Text = selectedLoan.BookCopy.Book.Title;
                txtDateOfLoan.Text = selectedLoan.DateOfLoan.Value.ToShortDateString();
                txtDueDate.Text = selectedLoan.DueDate.Value.ToShortDateString();
                txtOverdue.Text = daysOverdue.ToString() + " day(s)";
                txtDebt.Text = $"{selectedLoan.Debt} kr";

                if (selectedLoan.DateOfReturn == null)
                {
                    txtTimeOfReturn.Text = "-";
                    UIExtension.HideLabelAndTextbox(lblOnTime, txtOnTime);
                }
                else
                {
                    txtTimeOfReturn.Text = selectedLoan.DateOfReturn.Value.ToShortDateString();
                    UIExtension.ShowLabelAndTextbox(lblOnTime, txtOnTime);
                }

                if (daysOverdue > 0)
                {
                    UIExtension.ShowLabelAndTextbox(lblOverdue, txtOverdue);
                    txtOnTime.ForeColor = Color.Red;
                    txtOnTime.Text = "No";
                    UIExtension.ShowLabelAndTextbox(lblOnTime, txtOnTime);
                    UIExtension.ShowLabelAndTextbox(lblDebt, txtDebt);
                }
                else
                {
                    UIExtension.HideLabelAndTextbox(lblOverdue, txtOverdue);
                    txtOnTime.ForeColor = Color.Green;
                    txtOnTime.Text = "Yes";
                    UIExtension.HideLabelAndTextbox(lblDebt, txtDebt);
                }      
            }
        }

            // Focus events. -->
        private void lvLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoans.SelectedItems.Count == 0)
                UIExtension.ClearTextBoxesInPanel(pnlLoanInformation);

            else
            {
                pnlLoanInformation.Visible = true;
                UpdateLoanInformation(sender, e);
            }

        }
            // <-- Focus events.

        // <-- Information fields handling.
    }
}
