using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Library
{
    public static class UIExtension
    {
        /// <summary>
        /// What to do with loans; Add new or Return.
        /// </summary>
        public enum Loan { New, Return };
        /// <summary>
        /// Type of operation to do on a specific item; Add or Edit.
        /// </summary>
        public enum Operation { Add, Edit };

        private static UserControl currentUC;
        /// <summary>
        /// Status of what to do with loans - using enum Loan.
        /// </summary>
        public static Loan loanStatus;
        /// <summary>
        /// What type of operation to do on a specific item - using enum Operation.
        /// </summary>
        public static Operation? operation;
        /// <summary>
        /// The current selected item which is to be viewed or edited etc.
        /// </summary>
        public static object currentItem;

        /// <summary>
        /// Change the User Control to be displayed.
        /// </summary>
        /// <param name="newUC">New User Control to show.</param>
        public static void ChangeUC(UserControl newUC)
        {
            if (currentUC != null)
                currentUC.Visible = false;
            newUC.Visible = true;
            currentUC = newUC;
        }

        /// <summary>
        /// Show a message to the user for 4 seconds via a label, e.g. an error message or success message.
        /// </summary>
        /// <param name="timer">Timer for the message. Insert a new timer, use the same timer for every User Control.</param>
        /// <param name="label">The message label where the message is outputed.</param>
        /// <param name="message">The message to be displayed.</param>
        /// <param name="color">The color of the message.</param>
        public static void ShowMessage(Timer timer, Label label, string message, Color color)
        {
            label.Text = message;
            label.ForeColor = color;
            label.Visible = true;
            if (timer.Enabled)
                timer.Stop();
            timer.Interval = 4000;
            timer.Tick += new EventHandler((sender, e) => HideMessage(sender, e, timer, label));
            timer.Start();
        }

        // Private method to hide the message from the Show Message-method.
        private static void HideMessage(object sender, EventArgs e, Timer timer, Label label)
        {
            label.Visible = false;
            timer.Stop();
        }

        /// <summary>
        /// Show a gray placeholder in a text box.
        /// </summary>
        /// <param name="textBox">The text box object where the placeholder should be.</param>
        /// <param name="placeholder">The placeholder text.</param>
        public static void ShowPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == "")
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = placeholder;
            }
        }

        /// <summary>
        /// Hide the placeholder in the text box.
        /// </summary>
        /// <param name="textBox">The text box object where the placeholder is.</param>
        /// <param name="placeholder">The placeholder text.</param>
        public static void HidePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = "";
            }
        }

        /// <summary>
        /// Clears all text boxes in a panel.
        /// </summary>
        /// <param name="panel">Panel to clear texboxes in.</param>
        public static void ClearTextBoxesInPanel(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }
        }

        /// <summary>
        /// Hides a label and a text box.
        /// </summary>
        /// <param name="label">Label to hide.</param>
        /// <param name="textbox">Textbox to hide.</param>
        public static void HideLabelAndTextbox(Label label, TextBox textbox)
        {
            label.Visible = false;
            textbox.Visible = false;
        }

        /// <summary>
        /// Shows a label and text box.
        /// </summary>
        /// <param name="label">Label to show.</param>
        /// <param name="textbox">Text box to show.</param>
        public static void ShowLabelAndTextbox(Label label, TextBox textbox)
        {
            label.Visible = true;
            textbox.Visible = true;
        }

        /// <summary>
        /// Clears the elements within a search with a single list view.
        /// </summary>
        /// <param name="listView">The list view to clear.</param>
        /// <param name="textBoxSearch">The search text box to clear.</param>
        /// <param name="placeholder">The placeholder for the search text box.</param>
        /// <param name="radiobtn1">The first radio button to clear (optional).</param>
        /// <param name="radiobtn2">The second radio button to clear (optional).</param>
        /// <param name="showRadioButtons">Whether radio buttons should be visible (true) or not (false), but is optional (can be null as well).</param>
        public static void ClearSearch(ListView listView, TextBox textBoxSearch, string placeholder, RadioButton radiobtn1 = null, RadioButton radiobtn2 = null, bool? showRadioButtons = null)
        {
            currentItem = null;
            operation = null;
            listView.SelectedItems.Clear();
            textBoxSearch.ForeColor = Color.Gray;
            textBoxSearch.Text = placeholder;
            if (radiobtn1 != null)
                radiobtn1.Checked = false;
            if (radiobtn2 != null)
                radiobtn2.Checked = false;

            if (showRadioButtons != null)
            {
                if(showRadioButtons.Value == true)
                {
                    radiobtn1.Visible = true;
                    radiobtn2.Visible = true;
                }
                else
                {
                    radiobtn1.Visible = false;
                    radiobtn2.Visible = false;
                }
            }
        }

        /// <summary>
        /// Clear the elements within a search with multiple list views etc.
        /// </summary>
        /// <param name="listView1">The first list view to clear and hide.</param>
        /// <param name="listView2">The second list view to clear and hide.</param>
        /// <param name="textBoxSearch">The search text box to clear.</param>
        /// <param name="radiobtn1">The first radio button to clear.</param>
        /// <param name="radiobtn2">The second radio button to clear.</param>
        /// <param name="panel">The panel to show instead of list views.</param>
        /// <param name="dropdown">The dropdown-list to clear and hide.</param>
        /// <param name="placeholder">The placeholder for the search text box.</param>
        public static void ClearSearch(ListView listView1, ListView listView2, TextBox textBoxSearch, RadioButton radiobtn1, RadioButton radiobtn2, Panel panel, ComboBox dropdown, string placeholder)
        {
            ClearSearch(listView1, textBoxSearch, placeholder, radiobtn1, radiobtn2);
            listView2.SelectedItems.Clear();
            listView1.Visible = false;
            listView2.Visible = false;
            dropdown.Visible = false;
            dropdown.SelectedIndex = 0;
            panel.Visible = true;
            textBoxSearch.Enabled = false;
        }

        /// <summary>
        /// Create Alphatbetic groups in a list view.
        /// </summary>
        /// <param name="listView">The list view object to create groups in.</param>
        public static void CreateListViewAlphabeticGroups(ListView listView)
        {
            List<string> alphabet = new List<string>();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphabet.Add(c.ToString());
            }
            alphabet.Add("Other");

            foreach (string header in alphabet)
            {
                listView.Groups.Add(new ListViewGroup(header));
            }
        }

        /// <summary>
        /// Add an item to a specific alphabetic list view group (based on the CreateListViewAlphabeticGroups-method). Adds to "other" group if no matching group is found.
        /// </summary>
        /// <param name="listView">The list view object where the item is.</param>
        /// <param name="item">The item to be added in the group.</param>
        public static void AddToAlphabeticListViewGroup(ListView listView, ListViewItem item)
        {
            foreach (ListViewGroup group in listView.Groups)
            {
                if (item.Text.Substring(0, 1).ToLower() == group.Header.ToLower())
                {
                    item.Group = group;
                    return;
                }
            }
            item.Group = listView.Groups[listView.Groups.Count - 1];
        }

        /// <summary>
        /// Hide a list view, show another list view and hide a panel (optional).
        /// </summary>
        /// <param name="showListView">The list view to show.</param>
        /// <param name="hideListView">The list view to hide.</param>
        /// <param name="hidePanel">The panel to hide (optional).</param>
        public static void ToggleListViewSearch(ListView showListView, ListView hideListView, Panel hidePanel = null)
        {
            showListView.Visible = true;
            hideListView.Visible = false;
            if (hidePanel != null)
                hidePanel.Visible = false;
        }

        /// <summary>
        /// Insert a value into a text box and set the color to black.
        /// </summary>
        /// <param name="textBox">The text box to insert into.</param>
        /// <param name="value">The text value to insert.</param>
        public static void InsertValueToTextBox(TextBox textBox, string value)
        {
            textBox.ForeColor = Color.Black;
            textBox.Text = value;
        }

        /// <summary>
        /// Disable a text box and change the color to gray.
        /// </summary>
        /// <param name="textBox">The text box to be disabled.</param>
        public static void DisableTextbox(TextBox textBox)
        {
            textBox.Enabled = false;
            textBox.BackColor = Color.LightGray;
            textBox.ForeColor = Color.Black;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Enable a text box and change the color to white.
        /// </summary>
        /// <param name="textBox">The text box to be enabled.</param>
        public static void EnableTextbox(TextBox textBox)
        {
            textBox.Enabled = true;
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
            textBox.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
