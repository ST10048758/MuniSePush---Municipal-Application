using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace y3s2_PROG_POE.Forms
{
    public partial class ConfirmationForm : Form
    {
        public bool IsConfirmed { get; private set; }

        public ConfirmationForm(string location, string category, string description)
        {
            InitializeComponent();
            string longDescription = description;
            string shortDescription = TruncateDescription(longDescription);
            // Populate the labels with the report data
            lblLocation.Text = location;
            lblCategory.Text = category;
            lblDescription.Text = shortDescription;
            IsConfirmed = false; // Default to false, meaning user hasn't confirmed yet
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Just close the form without confirming
            this.Close();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfrim_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        public string TruncateDescription(string description)
        {
            // Check if the description is longer than 10 characters
            if (description.Length > 15)
            {
                // Truncate the string and append "..."
                return description.Substring(0, 15) + "...";
            }
            else
            {
                // If it's shorter than 10 characters, return the original string
                return description;
            }
        }
    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
