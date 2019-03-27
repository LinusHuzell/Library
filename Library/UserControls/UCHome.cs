using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UserControls
{
    public partial class UCHome : UserControl
    {
        private LibraryForm form;

        // Constructors. -->
        /// <summary>
        /// This is required by the form, not to be used.
        /// </summary>
        public UCHome() { }

        /// <summary>
        /// Initialize the User Control
        /// </summary>
        public UCHome(Form form)
        {
            InitializeComponent();
            this.form = form as LibraryForm;
        }
        // <-- Constructors.
    }
}
