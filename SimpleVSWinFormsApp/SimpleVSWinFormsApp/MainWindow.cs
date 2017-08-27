using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVSWinFormsApp
{
    public partial class MainWindow : Form
    {
        private string lifeTimeInfo = "";

        public MainWindow()
        {
            InitializeComponent();
            CenterToScreen();
            // Handle various lifetime events.   
            FormClosing += new FormClosingEventHandler(MainWindow_Closing);
            Load += new EventHandler(MainWindow_Load);
            FormClosed += new FormClosedEventHandler(MainWindow_Closed);
            Activated += new EventHandler(MainWindow_Activated);
            Deactivate += new EventHandler(MainWindow_Deactivate);
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            lifeTimeInfo += "Load event\n";
        }

        private void MainWindow_Activated(object sender, System.EventArgs e)
        {
            lifeTimeInfo += "Activate event\n";
        }

        private void MainWindow_Deactivate(object sender, System.EventArgs e)
        {
            lifeTimeInfo += "Deactivate event\n";
        }

        private void MainWindow_Closing(object sender, FormClosingEventArgs e)
        {
            lifeTimeInfo += "FormClosing event\n";

            // Show a message box with Yes and No buttons.   
            DialogResult dr = MessageBox.Show("Do you REALLY want to close this app?",
            "Closing event!", MessageBoxButtons.YesNo);

            // Which button was clicked?   
            if (dr == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void MainWindow_Closed(object sender, FormClosedEventArgs e)
        {
            lifeTimeInfo += "FormClosed event\n";
            MessageBox.Show(lifeTimeInfo);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Close();
        }

        private void MainWindow_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Text = string.Format("Mouse Position: {0}", e.Location);
        }
    }
}
