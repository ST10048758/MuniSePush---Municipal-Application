using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using y3s2_PROG_POE.Classes;

namespace y3s2_PROG_POE.Forms
{
    public partial class LocalEventsForm : Form
    {
        private List<EventClass> eventList;
        private Dictionary<string, int> categorySearchCount = new Dictionary<string, int>();
        private Dictionary<DateTime, int> dateSearchCount = new Dictionary<DateTime, int>();
        public List<EventClass> recommendedEvents = new List<EventClass>();
        private int filterCounter = 0;
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Constructor for LocalEventsForm
        /// </summary>
        public LocalEventsForm()
        {
            InitializeComponent();
            LoadEventData();
            DisplayEvents(eventList);
            dgvEvents.CellClick += dgvEvents_CellClick;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to load event data
        /// </summary>
        private void LoadEventData()
        {
            eventList = EventClass.LoadEventData();

            var uniqueCategories = eventList.Select(e => e.Category).Distinct().ToList();
            cmbCategories.Items.Add("All Categories");
            cmbCategories.Items.AddRange(uniqueCategories.ToArray());
            cmbCategories.SelectedIndex = 0;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to display events in the DataGridView
        /// </summary>
        /// <param name="events"></param>
        private void DisplayEvents(List<EventClass> events)
        {
            dgvEvents.Rows.Clear();
            dgvEvents.Columns.Clear();

            dgvEvents.Columns.Add("Name", "Event Name");
            dgvEvents.Columns.Add("Category", "Category");
            dgvEvents.Columns.Add("Date", "Event Date");
            dgvEvents.Columns.Add("Description", "Description");

            dgvEvents.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEvents.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEvents.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEvents.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (var ev in events)
            {
                dgvEvents.Rows.Add(ev.Name, ev.Category, ev.Date.ToShortDateString(), ev.Description);
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Add event details to the labels and picture box when a cell is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEvents.Rows[e.RowIndex];
                lblEventName.Text = selectedRow.Cells["Name"].Value?.ToString();
                lblEventDate.Text = selectedRow.Cells["Date"].Value?.ToString();
                lblEventCat.Text = selectedRow.Cells["Category"].Value?.ToString();
                rtbEventDesc.Text = selectedRow.Cells["Description"].Value?.ToString();

                var selectedEvent = eventList.FirstOrDefault(ev => ev.Name == selectedRow.Cells["Name"].Value?.ToString());
                if (selectedEvent != null)
                {
                    lblEventPrice.Text = "R" + selectedEvent.EntryFee.ToString();
                    lblEventVenue.Text = selectedEvent.Venue;
                    imgEventPoster.Image = selectedEvent.EventImage;
                }
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Apply the selected filter to the event list and display the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            filterCounter++;
            btnResetFilter.Visible = true;

            string selectedCategory = cmbCategories.SelectedItem.ToString();
            DateTime minDate = mcEventDateRange.SelectionRange.Start.Date;
            DateTime maxDate = mcEventDateRange.SelectionRange.End.Date;

            RecordUserSearchPreference(selectedCategory, minDate, maxDate);
            var searchResults = EventClass.FilterEvents(eventList, selectedCategory, minDate, maxDate);
            DisplayEvents(searchResults);

            if (filterCounter >= 5)
            {
                GenerateRecommendations();
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Record the user's search preferences
        /// </summary>
        /// <param name="category"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        private void RecordUserSearchPreference(string category, DateTime minDate, DateTime maxDate)
        {
            if (!string.IsNullOrEmpty(category) && category != "All Categories")
            {
                if (categorySearchCount.ContainsKey(category))
                {
                    categorySearchCount[category]++;
                }
                else
                {
                    categorySearchCount[category] = 1;
                }
            }

            if (dateSearchCount.ContainsKey(minDate))
            {
                dateSearchCount[minDate]++;
            }
            else
            {
                dateSearchCount[minDate] = 1;
            }
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to generate recommendations based on user search preferences
        /// </summary>
        private void GenerateRecommendations()
        {
            string selectedCategory = cmbCategories.SelectedItem.ToString();
            DateTime minDate = mcEventDateRange.SelectionRange.Start.Date;
            DateTime maxDate = mcEventDateRange.SelectionRange.End.Date;

            recommendedEvents = EventClass.FilterEvents(eventList, selectedCategory, minDate, maxDate)
                .Where(e => e.Category == selectedCategory) // Filter by category first
                .OrderBy(e => e.Date) // Order by date (if multiple events in the same category)
                .Take(3) // Limit to 3 recommendations
                .ToList();

            // If fewer than 3 events are found, fall back on date-based filtering
            if (recommendedEvents.Count < 3)
            {
                // Add events based on the date, ignoring the category if necessary
                var additionalEvents = eventList
                    .Where(e => e.Date >= minDate && e.Date <= maxDate && !recommendedEvents.Contains(e)) // Filter by date
                    .OrderBy(e => e.Date) // Order by date
                    .Take(3 - recommendedEvents.Count) // Add enough events to make up the difference
                    .ToList();

                recommendedEvents.AddRange(additionalEvents);
            }

            // If no events are found for category and date, show future events (fallback)
            if (recommendedEvents.Count < 3)
            {
                var fallbackEvents = eventList
                    .Where(e => e.Date >= DateTime.Now && !recommendedEvents.Contains(e)) // Future events (fallback)
                    .OrderBy(e => e.Date)
                    .Take(3 - recommendedEvents.Count)
                    .ToList();

                recommendedEvents.AddRange(fallbackEvents);
            }

            btnRecommendations.Visible = true;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to display the recommendation page
        /// </summary>
        /// <param name="recEvents"></param>
        private void ShowRecommendationPage(List<EventClass> recEvents)
        {
            RecommendationsForm recommendationsForm = new RecommendationsForm();
            recommendationsForm.DisplayRecommendationLinks(recEvents);
            recommendationsForm.EventSelected += OnEventSelected;
            recommendationsForm.ShowDialog();
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Callback method for when an event is selected from the recommendations
        /// </summary>
        /// <param name="selectedEvent"></param>
        private void OnEventSelected(EventClass selectedEvent)
        {
            lblEventName.Text = selectedEvent.Name;
            lblEventDate.Text = selectedEvent.Date.ToShortDateString();
            lblEventCat.Text = selectedEvent.Category;
            rtbEventDesc.Text = selectedEvent.Description;
            lblEventPrice.Text = "R" + selectedEvent.EntryFee.ToString();
            lblEventVenue.Text = selectedEvent.Venue;
            imgEventPoster.Image = selectedEvent.EventImage;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Reset the filters and display all events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = 0;
            mcEventDateRange.SetDate(DateTime.Now);
            DisplayEvents(eventList);
            filterCounter = 0;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Open the recommendation page when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            // Display recommended events in the panel
            ShowRecommendationPage(recommendedEvents);
        }

        private void imgEventPoster_Click(object sender, EventArgs e)
        {

        }
    }
}
		/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
