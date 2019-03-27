using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UserControls.Loans
{
    public partial class UCLoans : UserControl
    {
        private LibraryForm form;

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCLoans() { }

        /// <summary>
        /// Initialize the User Control.
        /// </summary>
        public UCLoans(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
        }
        // <-- Constructors.

        // Misc. functionality -->
        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            UIExtension.loanStatus = UIExtension.Loan.New;
            UIExtension.ChangeUC(form.ucLoansSearch);
        }

        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            UIExtension.loanStatus = UIExtension.Loan.Return;
            UIExtension.ChangeUC(form.ucLoansSearch);
        }
        // <-- Misc. functionality.
    }
}
