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
    public partial class SurveyForm : Form
    {
        /// <summary>
        /// Creating a list of questions to ask the user after submitting their report
        /// </summary>
        private static readonly string[] Questions = new[]
        {
            "How satisfied are you with the report submission process?",
            "How would you rate the ease of use of the application?",
            "How effective do you find the reporting features?",
            "How likely are you to recommend this application to others?",
        };

        private static Random random = new Random(); //random object for selecting a random string from array

        public SurveyForm()
        {
            InitializeComponent();
            LoadRandomQuestion();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        ///  Generates the random question for the survey
        /// </summary>
        private void LoadRandomQuestion()
        {
            // Select a random question from the preloaded list
            int index = random.Next(Questions.Length);
            lblQuestion.Text = Questions[index];
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Returns the users rating from survey
        /// </summary>
        /// <returns></returns>
        private int GetSelectedRating()
        {
            // Return the selected rating based on which radio button is checked
            if (rdoStar1.Checked) return 1;
            if (rdoStar2.Checked) return 2;
            if (rdoStar3.Checked) return 3;
            if (rdoStar4.Checked) return 4;
            if (rdoStar5.Checked) return 5;
            return 0; // No rating selected
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // Handle the user's rating selection
            int rating = GetSelectedRating();
            MessageBox.Show($"Thank you for your feedback! You rated: {rating} stars.");
            this.Close();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
