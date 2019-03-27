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
    public partial class UCMembers : UserControl
    {
        private LibraryForm form;
        private string txtSearchPlaceholder;
        private Timer messageTimer = new Timer();

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCMembers() { }

        /// <summary>
        /// Initialize the User Control
        /// </summary>
        public UCMembers(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
            this.txtSearchPlaceholder = txtSearch.Text;
            UIExtension.CreateListViewAlphabeticGroups(lvMembers);

            // Subscribes the information fields update methods to run whenever other services are updated in database.
            this.form.memberService.Updated += MemberService_Updated;
        }

        /// <summary>
        /// This is not an actual constructor but the code runs whenever the User Control gets visible.
        /// </summary>
        private void UCMembers_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                txtSearch.Text = "";
                UIExtension.ClearSearch(lvMembers, txtSearch, txtSearchPlaceholder);
            }
        }
        // <-- Constructors.

        // Misc. functionality -->
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            UIExtension.operation = UIExtension.Operation.Add;
            UIExtension.ChangeUC(form.ucMember);
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lvMembers.SelectedItems.Count > 0)
            {
                UIExtension.currentItem = lvMembers.SelectedItems[0].Tag;
                UIExtension.ChangeUC(form.ucViewMember);

            }
            else
            {
                UIExtension.ShowMessage(messageTimer, lblMessage, "You must first select an item to edit!", Color.Red);
            }
        }
        // <-- Misc. functionality.

        // Filter functionality. -->

            // Focus events. -->
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            UIExtension.HidePlaceholder(txtSearch, txtSearchPlaceholder);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            UIExtension.ShowPlaceholder(txtSearch, txtSearchPlaceholder);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != txtSearchPlaceholder)
            {
                btnSearch.Enabled = true;
                UpdatelvMembers(form.memberService.Filter(txtSearch.Text));
            }
        }
            // <-- Focus events.

            // Key press events.-->
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                UIExtension.ClearSearch(lvMembers, txtSearch, txtSearchPlaceholder);
                ActiveControl = null;
            }
        }
            // <-- Key press events.

        // <-- Filter functionality.

        // Information fields handling. -->
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
                item.SubItems.Add(member.Username);
                UIExtension.AddToAlphabeticListViewGroup(lvMembers, item);
                lvMembers.Items.Add(item);
            }
        }
        // <- Information fields handling.
    }
}
