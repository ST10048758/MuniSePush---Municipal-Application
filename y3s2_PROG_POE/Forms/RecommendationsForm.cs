using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using y3s2_PROG_POE.Classes;

namespace y3s2_PROG_POE.Forms
{
    public partial class RecommendationsForm : Form
    {
        public event Action<EventClass> EventSelected;

        /// <summary>
        /// Constructor for RecommendationsForm
        /// </summary>
        public RecommendationsForm()
        {
            InitializeComponent();
            DisplayRecommendationLinks(new List<EventClass>());
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to display recommended events as clickable links
        /// </summary>
        /// <param name="recommendedEvents"></param>
        public void DisplayRecommendationLinks(List<EventClass> recommendedEvents)
        {
            llEvent1.Visible = false;
            llEvent2.Visible = false;
            llEvent3.Visible = false;

            if (recommendedEvents.Count > 0)
            {
                llEvent1.Text = $"{recommendedEvents[0].Name}";
                llEvent1.Tag = recommendedEvents[0]; 
                llEvent1.Visible = true;
                rtbEvent1.Text = $"{recommendedEvents[0].Description}";
            }

            if (recommendedEvents.Count > 1)
            {
                llEvent2.Text = $"{recommendedEvents[1].Name}";
                llEvent2.Tag = recommendedEvents[1];
                llEvent2.Visible = true;
                rtbEvent2.Text = $"{recommendedEvents[1].Description}";
            }

            if (recommendedEvents.Count > 2)
            {
                llEvent3.Text = $"{recommendedEvents[2].Name}";
                llEvent3.Tag = recommendedEvents[2];
                llEvent3.Visible = true;
                rtbEvent3.Text = $"{recommendedEvents[2].Description}";
            }

        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Event handler for clicking on a recommendation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llEvent_Click(object sender, EventArgs e)
        {
            LinkLabel selectedLinkLabel = sender as LinkLabel;
            var selectedEvent = (EventClass)selectedLinkLabel.Tag;
            EventSelected?.Invoke(selectedEvent);
            this.Close();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
