using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using y3s2_PROG_POE.Classes;
using y3s2_PROG_POE.Data;

namespace y3s2_PROG_POE.Forms
{
    public partial class ServiceRequestForm : Form
    {
        
        //Data Structures
        private Graph<ServiceRequest> serviceRequestGraph;
        private BinarySearchTree<ServiceRequest> serviceRequestTree;

    /*------------------------------------------------------------------------------------------------------------------------------------------------------*/
    
    /// <summary>
    /// Constructor: Initializes the form and populates data structures.
    /// </summary>
        public ServiceRequestForm()
        {
            InitializeComponent();
            serviceRequestGraph = new Graph<ServiceRequest>();
            serviceRequestTree = new BinarySearchTree<ServiceRequest>();
            LoadServiceRequests();
            PopulateComboBoxes();
        }
    /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Loads service requests from the SQLite database into the graph and tree.
        /// </summary>
        private void LoadServiceRequests()
        {
            var serviceRequestsList = new List<ServiceRequest>();

            string connectionString = "Data Source=./ServiceRequests.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ServiceRequests";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Map database fields to the ServiceRequest object
                        ServiceRequest request = new ServiceRequest
                        {
                            Id = reader.GetInt32(0),
                            Location = reader.GetString(1),
                            Category = reader.GetString(2),
                            Description = reader.GetString(3),
                            FileName = reader.IsDBNull(4) ? null : reader.GetString(4),
                            Status = reader.GetString(5),
                            FileData = reader.IsDBNull(6) ? null : (byte[])reader[6]
                        };

                        // Add to graph and list
                        serviceRequestGraph.AddNode(request);
                        serviceRequestsList.Add(request);
                    }
                }
            }

            // Populate binary search tree
            foreach (var request in serviceRequestsList)
            {
                serviceRequestTree.Insert(request);
            }

            // Add edges for requests with the same location
            var requests = serviceRequestGraph.GetNodes();
            foreach (var request in requests)
            {
                var sameLocationRequests = requests.Where(r => r.Location == request.Location && r.Id != request.Id);
                foreach (var sameLocationRequest in sameLocationRequests)
                {
                    serviceRequestGraph.AddEdge(request, sameLocationRequest);
                }
            }

            PopulateServiceRequestsList(); // Display the data in the ListView
        }
	/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Populates the ComboBoxes for filtering service requests.
        /// </summary>
        private void PopulateComboBoxes()
        {
            string connectionString = "Data Source=./ServiceRequests.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Populate Location ComboBox
                cbLocation.Items.Clear();
                cbLocation.Items.Add("--Location--");
                cbLocation.Items.Add("Any");
                string locationQuery = "SELECT DISTINCT Location FROM ServiceRequests";
                using (SQLiteCommand command = new SQLiteCommand(locationQuery, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbLocation.Items.Add(reader.GetString(0));
                    }
                }
                cbLocation.SelectedIndex = 0;

                // Populate Category ComboBox
                cbCategory.Items.Clear();
                cbCategory.Items.Add("--Category--");
                cbCategory.Items.Add("Any");
                string categoryQuery = "SELECT DISTINCT Category FROM ServiceRequests";
                using (SQLiteCommand command = new SQLiteCommand(categoryQuery, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbCategory.Items.Add(reader.GetString(0));
                    }
                }
                cbCategory.SelectedIndex = 0;

                // Populate Status ComboBox
                cbStatus.Items.Clear();
                cbStatus.Items.Add("--Status--");
                cbStatus.Items.Add("Any");
                string statusQuery = "SELECT DISTINCT Status FROM ServiceRequests";
                using (SQLiteCommand command = new SQLiteCommand(statusQuery, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbStatus.Items.Add(reader.GetString(0));
                    }
                }
                cbStatus.SelectedIndex = 0;
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Filters and displays service requests in the ListView based on selected filters.
        /// </summary>
        private void PopulateServiceRequestsList()
        {
            lvRequests.Items.Clear();
            lvRequests.Groups.Clear();

            // Define groups
            ListViewGroup searchResultsGroup = new ListViewGroup("Search Results", HorizontalAlignment.Left);
            ListViewGroup relatedResultsGroup = new ListViewGroup("Related Results", HorizontalAlignment.Left);
            lvRequests.Groups.Add(searchResultsGroup);
            lvRequests.Groups.Add(relatedResultsGroup);

            // Retrieve selected filter values
            string locationFilter = cbLocation.SelectedItem?.ToString();
            string categoryFilter = cbCategory.SelectedItem?.ToString();
            string statusFilter = cbStatus.SelectedItem?.ToString();

            // Retrieve all service requests from the binary search tree
            var requests = serviceRequestTree.GetAllNodes();

            // Apply filters
            if (!string.IsNullOrEmpty(locationFilter) && locationFilter != "Any" && locationFilter != "--Location--")
                requests = requests.Where(r => r.Location.Contains(locationFilter)).ToList();
            if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter != "Any" && categoryFilter != "--Category--")
                requests = requests.Where(r => r.Category == categoryFilter).ToList();
            if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "Any" && statusFilter != "--Status--")
                requests = requests.Where(r => r.Status == statusFilter).ToList();

            // Check if there are any search results
            // Check if there are any search results
            if (requests.Count == 0)
            {
                // Display "No results" message
                var noResultsItem = new ListViewItem("No results found...", searchResultsGroup);
                lvRequests.Items.Add(noResultsItem);

                // Display related results based on location
                if (!string.IsNullOrEmpty(locationFilter))
                {
                    var relatedRequests = serviceRequestGraph.GetNodes()
                        .Where(r => r.Location == locationFilter)
                        .Distinct()
                        .ToList();

                    if (relatedRequests.Count > 0)
                    {
                        foreach (var relatedRequest in relatedRequests)
                        {
                            var item = new ListViewItem(new[] { relatedRequest.Location, relatedRequest.Category, relatedRequest.Status }, relatedResultsGroup)
                            {
                                Tag = relatedRequest // Store the ServiceRequest object in the Tag property
                            };
                            lvRequests.Items.Add(item);
                        }
                    }
                    else
                    {
                        lblRelatedResults.Text = string.Empty; // No related results
                    }
                }
            }
            else
            {
                // Add search results to the ListView
                foreach (var request in requests)
                {
                    var item = new ListViewItem(new[] { request.Location, request.Category, request.Status }, searchResultsGroup)
                    {
                        Tag = request // Store the ServiceRequest object in the Tag property
                    };
                    lvRequests.Items.Add(item);
                }

                // Display related results based on location
                if (!string.IsNullOrEmpty(locationFilter))
                {
                    var relatedRequests = new List<ServiceRequest>();
                    foreach (var request in requests)
                    {
                        relatedRequests.AddRange(serviceRequestGraph.GetNeighbors(request)
                            .Where(r => r.Location == locationFilter && !requests.Contains(r)));
                    }

                    var distinctRelatedRequests = relatedRequests.Distinct().ToList();
                    if (distinctRelatedRequests.Count > 0)
                    {
                        foreach (var relatedRequest in distinctRelatedRequests)
                        {
                            var item = new ListViewItem(new[] { relatedRequest.Location, relatedRequest.Category, relatedRequest.Status }, relatedResultsGroup)
                            {
                                Tag = relatedRequest // Store the ServiceRequest object in the Tag property
                            };
                            lvRequests.Items.Add(item);
                        }
                    }
                    else
                    {
                        lblRelatedResults.Text = string.Empty; // No related results
                    }
                }
            }
        }

        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/


    /// <summary>
    /// Handles the Update button click event, triggering the filter application.
    /// </summary>
    private void btnUpdate_Click(object sender, EventArgs e)
        {
            PopulateServiceRequestsList();
        }
    /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Handles the selection change in the ListView and updates the preview details.
        /// </summary>
        private void lvRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRequests.SelectedItems.Count == 0) return;

            var selectedItem = lvRequests.SelectedItems[0];
            var request = selectedItem.Tag as ServiceRequest;

            if (selectedItem.SubItems.Count > 2)
            {
                var status = selectedItem.SubItems[2].Text;
                if (request != null)
                {
                    if (status == "Pending")
                    {
                        lblStatus.ForeColor = Color.Yellow;
                    }
                    else if (status == "Completed")
                    {
                        lblStatus.ForeColor = Color.LightGreen;
                    }
                    else if (status == "Cancelled")
                    {
                        lblStatus.ForeColor = Color.Red;
                    }

                    lblLocation.Text = request.Location;
                    lblCategory.Text = request.Category;
                    lblDescription.Text = request.Description;
                    lblStatus.Text = request.Status;

                    // Retrieve and display the file
                    var fileData = DatabaseHelper.GetFileData(request.Id);
                    if (fileData.fileName != null && fileData.fileData != null)
                    {
                        string fileExtension = Path.GetExtension(fileData.fileName).ToLower();
                        if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                        {
                            // Display image
                            using (MemoryStream ms = new MemoryStream(fileData.fileData))
                            {
                                pbFilePreview.Image = Image.FromStream(ms);
                                pbFilePreview.Visible = true;
                                rtbFilePreview.Visible = false;
                            }
                        }
                        else if (fileExtension == ".txt")
                        {
                            // Display text
                            rtbFilePreview.Text = Encoding.UTF8.GetString(fileData.fileData);
                            rtbFilePreview.Visible = true;
                            pbFilePreview.Visible = false;
                        }
                    }
                }
            }
        }
	/*------------------------------------------------------------------------------------------------------------------------------------------------------*/
    }
}
/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/

