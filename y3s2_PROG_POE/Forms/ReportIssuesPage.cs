using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using y3s2_PROG_POE.Classes;
using y3s2_PROG_POE.Data;

namespace y3s2_PROG_POE.Forms
{
    public partial class ReportIssuesPage : Form
    {
        private ProgressBar progressBar;
        private bool isLocationFilled = false;
        private bool isCategoryFilled = false;
        private bool isDescriptionFilled = false;
        private bool isFileAttached = false;
        private List<ReportClass> reportList = new List<ReportClass>();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public ReportIssuesPage()
        {
            InitializeComponent();
            this.Resize += new EventHandler(ReportIssuesPage_Resize);
            txbLocation.TextChanged += UpdateProgress;
            cmbCategory.SelectedIndexChanged += UpdateProgress;
            rtbDescription.TextChanged += UpdateProgress;
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        ///  Updates the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProgress(object sender, EventArgs e)
        {
            int progress = 0;

            // Check if Location is filled
            if (!string.IsNullOrWhiteSpace(txbLocation.Text))
            {
                isLocationFilled = true;
            }
            else
            {
                isLocationFilled = false;
            }

            // Check if Category is selected
            if (cmbCategory.SelectedIndex != -1)
            {
                isCategoryFilled = true;
            }
            else
            {
                isCategoryFilled = false;
            }

            // Check if Description is filled
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                isDescriptionFilled = true;
            }
            else
            {
                isDescriptionFilled = false;
            }

            // Calculate progress based on completed fields
            //100% / 4 fields = 25%
            //  -> Each field is worth 25%
            if (isLocationFilled) progress += 25;
            if (isCategoryFilled) progress += 25;
            if (isDescriptionFilled) progress += 25;
            if (isFileAttached) progress += 25;

            // Update the progress bar value
            pbCustomProgressBar.Value = progress;
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Submission method which checks all input fields, opens a
        /// confirmation window and then  uploads data to list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the user-entered data from the form fields
            string location = txbLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString(); // Get selected category
            string description = rtbDescription.Text;
            string attachedFile = openFileDialog.FileName; // File selected from the OpenFileDialog

            // Create a new Report object
            ReportClass newReport = new ReportClass(location, category, description, attachedFile);

            // Validate the report data
            if (newReport.Validate(out string errorMessage))
            {
                // Create the confirmation form and pass the report data to it
                ConfirmationForm confirmationForm = new ConfirmationForm(location, category, description);
                confirmationForm.StartPosition = FormStartPosition.CenterParent;

                // Displaying confirmation form as a modal dialog
                confirmationForm.ShowDialog();

                // Check if the user confirmed the submission
                if (confirmationForm.IsConfirmed)
                {
                    // Add the report to the list
                    reportList.Add(newReport);

                    // Display a success message
                    MessageBox.Show("Your report has been succesfully submitted!");
                    DatabaseHelper.AddServiceRequest(location, category, description, attachedFile);
                    this.Close();
                    SurveyForm surveyForm = new SurveyForm();
                    surveyForm.StartPosition = FormStartPosition.CenterParent;
                    surveyForm.ShowDialog();
                }
                else
                {
                    // User cancelled the submission - display a message 
                    MessageBox.Show("Report submission cancelled.");
                }

                // Clearing fields for a new report entry
                txbLocation.Clear();
                cmbCategory.SelectedIndex = -1;
                rtbDescription.Clear();
                attachedFile = string.Empty; // Reset file selection
            }
            else
            {
                // Display error messages
                MessageBox.Show("Please correct the following errors:\n" + errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Open s a file dialog to allow users to enter text or image file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            isFileAttached= false;
            lblFileError.Visible = false;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                isFileAttached = true;
                UpdateProgress(null, null); // Call UpdateProgress to refresh progress bar

                // Reset previous previews
                pbFilePreview.Image = null;
                rtbFilePreview.Clear();

                // Handle preview based on file type
                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                {
                    // Image Preview
                    panelbox.Visible = false;
                    pbFilePreview.Visible = true;
                    btnDeleteAttachment.Visible = true;
                    btnAttachMedia.Enabled = false;
                    pbFilePreview.Image = Image.FromFile(filePath);
                }
                else if (fileExtension == ".txt")
                {
                    // Text Preview
                    panelbox.Visible = false;
                    rtbFilePreview.Visible = true;
                    btnDeleteAttachment.Visible = true;
                    btnAttachMedia.Enabled = false;
                    rtbFilePreview.Text = File.ReadAllText(filePath);
                }
                else
                {
                    // File type is not supported
                    lblFileError.Visible = true;
                    isFileAttached = false;
                    UpdateProgress(null, null);
                }
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/
       
        /// <summary>
        /// Returns user to menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Return user to menu page
            ExitConfirmationForm exitConfirmationForm = new ExitConfirmationForm();
            exitConfirmationForm.StartPosition = FormStartPosition.CenterParent;
            exitConfirmationForm.ShowDialog();

            //Waits from user input before closing
            if (exitConfirmationForm.IsConfirmed)
            {
                this.Close();
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Used to delete attachment 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            
            openFileDialog.FileName = "";
            isFileAttached = false; 
            btnAttachMedia.Enabled = true;

            // Clear the file preview
            pbFilePreview.Image = null; //Removing image from preview
            pbFilePreview.Visible = false; // Hide the image preview

            rtbFilePreview.Clear();  // Clear text from text preview
            rtbFilePreview.Visible = false; // Hide the text preview

            lblFileError.Visible = false;
            btnDeleteAttachment.Visible = false;
            panelbox.Visible = true;
            UpdateProgress(null, null);
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Creating the report form and setting dimensions to 50% of the users screen by default.
        /// -- Code sourced from https://www.youtube.com/watch?v=bKnpxTulUIs&ab_channel=EETechStuff
        ///                     EETechStuff's Youtube Video - "C# How to Auto Size Windows Forms & Controls"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportIssuesPage_Load(object sender, EventArgs e)
        {
            labelText.TextAlign = ContentAlignment.MiddleCenter; // Ensure text is centered
            labelText.Dock = DockStyle.Fill; // Fill the panel with the label, keeping it centered
            labelText.Text = "File Preview"; 
        }

        private void ReportIssuesPage_Resize(object sender, EventArgs e)
        {
           
        }

        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
