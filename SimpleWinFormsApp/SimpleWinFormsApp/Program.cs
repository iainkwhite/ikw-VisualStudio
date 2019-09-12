using System;
// The minimum required windows forms namespaces.   
using System.Windows.Forms;

namespace SimpleWinFormsApp
{
    // This is the application object.   
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MainWindow("My Window", 200, 300));
        }
    }

    // This is the main window.   
    class MainWindow : Form
    {
        // Members for a simple menu system.   
        private MenuStrip mnuMainMenu = new MenuStrip();
        private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
        private ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();

        public MainWindow(string title, int height, int width)
        {
            // Set various properties from the parent classes.   
            Text = title;
            Width = width;
            Height = height;
            // Inherited method to center the form on the screen.   
            CenterToScreen();
            // Method to create the menu system.   
            BuildMenuSystem();
        }

        private void BuildMenuSystem()
        {
            // Add the File menu item to the main menu.   
            mnuFile.Text = "&File";
            mnuMainMenu.Items.Add(mnuFile);

            // Now add the Exit menu to the File menu.   
            mnuFileExit.Text = "Exit";
            mnuFile.DropDownItems.Add(mnuFileExit);
            mnuFileExit.Click += (o, s) =>
            {
                MessageBox.Show(string.Format("{0} sent this event", o.ToString()));
                Application.Exit();
            };

            // Finally, set the menu for this Form.   
            Controls.Add(this.mnuMainMenu);
            MainMenuStrip = this.mnuMainMenu;
        }
    }
}