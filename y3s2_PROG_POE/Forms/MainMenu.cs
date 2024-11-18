using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using y3s2_PROG_POE.Forms;

namespace y3s2_PROG_POE
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens new instance of the report window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportIssuesPage reportIssueForm = new ReportIssuesPage();
            // Set the ReportIssuePage as a child form of the MDI parent
            reportIssueForm.MdiParent = this;
            reportIssueForm.Show();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Used to quit the program (Application.Exit)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Creating the main form and setting dimensions to 80% of the users screen by default.
        ///     -> Code sourced from https://www.youtube.com/watch?v=bKnpxTulUIs&ab_channel=EETechStuff
        ///                     EETechStuff's Youtube Video - "C# How to Auto Size Windows Forms & Controls"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

            this.Size = new System.Drawing.Size(Convert.ToInt32(.9* workingRectangle.Width),
                Convert.ToInt32(.9 * workingRectangle.Height));

            this.Location = new System.Drawing.Point(10, 10);
        }

        private void localEventsComingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalEventsForm eventsForm = new LocalEventsForm();
            // Set the ReportIssuePage as a child form of the MDI parent
            eventsForm.MdiParent = this;
            eventsForm.Show();
        }

        private void serviceRequestsComingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceRequestForm requestForm = new ServiceRequestForm();
            // Set the ReportIssuePage as a child form of the MDI parent
            requestForm.MdiParent = this;
            requestForm.Show();
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
