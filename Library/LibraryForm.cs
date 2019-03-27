using Library.Models;
using Library.Repositories;
using Library.Services;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {
        // Make the window movable (code from StackOverflow) -->
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // <-- Make the window movable

        private Color tabColor = Color.FromArgb(40, 39, 41);
        private Color tabSelectedColor = Color.FromArgb(0, 68, 119);

        //Instance of each service
        public AuthorService authorService { get; private set; }
        public BookCopyService bookCopyService { get; private set; }
        public BookService bookService { get; private set; }
        public LoanService loanService { get; private set; }
        public MemberService memberService { get; private set; }

        // Constructor. -->
        public LibraryForm()
        {
            // We create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // We use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.authorService = new AuthorService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.bookService = new BookService(repFactory);
            this.loanService = new LoanService(repFactory);
            this.memberService = new MemberService(repFactory);

            InitializeComponent();
            
            this.authorService.OnUpdated(this, EventArgs.Empty);
            this.bookCopyService.OnUpdated(this, EventArgs.Empty);
            this.bookService.OnUpdated(this, EventArgs.Empty);
            this.loanService.OnUpdated(this, EventArgs.Empty);
            this.memberService.OnUpdated(this, EventArgs.Empty);

            UIExtension.ChangeUC(ucHome);
        }
        // <-- Constructor.

        // Local methods. -->
        private void ChangeTabColor(Button selectedTab)
        {
            if (btnHomeTab != selectedTab)
                btnHomeTab.BackColor = tabColor;
            if (btnLoansTab != selectedTab)
                btnLoansTab.BackColor = tabColor;
            if (btnBooksTab != selectedTab)
                btnBooksTab.BackColor = tabColor;
            if (btnMembersTab != selectedTab)
                btnMembersTab.BackColor = tabColor;
            if (btnHelpTab != selectedTab)
                btnHelpTab.BackColor = tabColor;

            selectedTab.BackColor = tabSelectedColor;
        }

        private void ChangeTab(Button button, UserControl userControl)
        {
            pnlCurrentTab.Top = button.Top;
            ChangeTabColor(button);
            UIExtension.ChangeUC(userControl);
        }
        // <-- Local methods.


        // User actions. -->
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // <-- User actions.

        // Tab buttons. -->
        private void btnHomeTab_Click(object sender, EventArgs e)
        {
            ChangeTab(sender as Button, ucHome);
        }

        private void btnLoansTab_Click(object sender, EventArgs e)
        {
            ChangeTab(sender as Button, ucLoans);
        }

        private void btnBooksTab_Click(object sender, EventArgs e)
        {
            ChangeTab(sender as Button, ucEdit);
        }

        private void btnMembersTab_Click(object sender, EventArgs e)
        {
            ChangeTab(sender as Button, ucMembers);
        }

        private void btnHelpTab_Click(object sender, EventArgs e)
        {
            ChangeTab(sender as Button, ucHelp);    
        }
        // <-- Tab buttons. 

        // Move window. -->
        private void pbIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // <-- Move window.
    }
}
