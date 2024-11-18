 MuniSePush


This Windows Forms application allows users to report issues to their municipalities by providing their location, selecting a category, describing the issue, and attaching relevant media files. Users must confirm their submission before it's saved, and once a report is successfully submitted, a short survey is presented to gather feedback. Users may also view a list of upcoming and past events. Filter options are available to help refine their searches, and recommendations for events will be generated for each user, according to their recent search/filter options. Finally, user can track the status of their service requests, which are created in part 1, and view details regarding their reports such as the location, category, description as well as the request status (Pending, Completed or Canceled)

Features:
- Issue Reporting: Users can input their location, select a category, provide a description, and attach media files to report an issue.
- Viewing events and announcements: Users can view events in their area. To help refine searches, users can filter results by category or date period. 
	Recommendations will be generated based on filters used while searching.
Tracking Service request Status: Users can view a complete list of all service requests and filter out options. Related service requests will also be displayed to the user, which are generated according to the users search location.

Requirements
- Development Environment: Visual Studio 2019 or higher
- Supported OS: Windows 10 or later

How to Compile and Run
	Step 1: Clone the Repository
	- Clone the repository to your local machine: git clone https://github.com/ST10048758/MuniSePush---Municipal-Application.git

	Step 2: Open in Visual Studio
	- Open Visual Studio.
	- Click File > Open > Project/Solution.
	- Navigate to the project directory and open the .sln file.

	Step 3: Build the Project
	- In Visual Studio, select Build > Build Solution or press Ctrl+Shift+B.
	- Ensure there are no build errors.

	Step 4: Configure the Database
	- Place the ServiceRequests.db file in the project's root directory.
	- Update the database connection string in ServiceRequestForm.cs if necessary: string connectionString = "Data Source=./ServiceRequests.db;Version=3;";

	Step 5: Run the Application
	- Click Start in Visual Studio or press F5.
	- The application will launch and display the main interface.

PART 1
Report an Issue:
	Fill out the fields for Location, Category, and Description.
	Attach any media files related to the issue by clicking the Attach button and selecting files using the file dialogue.

1. Track Progress:
	As you fill out the form, the progress bar at the bottom will update to reflect its complete extent.

2. Submit the Report:
	Click the Submit button after completing the form.
	A confirmation window will appear showing the report's details (Location, Category, Description). Review the details.
	If confirmed, the report is added to the list and saved.

3. Post-Submission Survey:
	After submission, a survey window will pop up with a single question and a 5-star rating system.
	Random survey questions will be displayed from the preloaded set.

	

PART 2

Local Events Form
1. Filtering Data:
	Users can filter events based on category and date range.
	The filter options include a dropdown for categories and a date range selector.
	The btnApplyFilter button applies the selected filters to the event list.

2. Removing Filters:
	Users can reset the filters to view all events.
	The btnResetFilters button clears the selected filters and displays the complete list of events.

3. Viewing Event Data:
	The event data is displayed in a DataGridView.
	When a user clicks on an event in the DataGridView, detailed information about the event is shown, including the name, date, category, description, entry fee, venue, and an image.

4. Generating Recommendations:
	After applying filters multiple times, the form generates event recommendations based on user preferences.
	The btnRecommendations button becomes visible, allowing users to view the recommended events.

Recommendations Form
The RecommendationsForm displays a list of recommended events based on the user's search preferences. It provides the following functionalities:
1. Displaying Recommended Events:
	The form shows up to three recommended events as clickable links.
	Each link includes the event name and description.

2. Selecting a Recommended Event:
	Users can click on a recommended event link to select it.
	When an event is selected, the EventSelected event is triggered, passing the selected event back to the LocalEventsForm.

How to Use
1. Filtering Events:
	Open the LocalEventsForm.
	Select a category from the dropdown and a date range using the date range selector.
	Click the Apply Filter button to filter the events.

2. Removing Filters:
	Click the Reset Filters button to clear the filters and view all events.

3. Viewing Event Details:
	Click on an event in the DataGridView to view detailed information about the event.

4. Viewing Recommendations:
	After applying filters multiple times, click the Recommendations button to open the RecommendationsForm.
	Click on a recommended event link to select it and view its details in the LocalEventsForm.

Exiting the Application:
	To exit the application entirely, click the Exit button. This will close all windows and stop the application.

PART 3
Service request Status Checker

	1. Service Request Management
		- View service requests in a structured ListView.
		- Filter requests by location, category, and status.

	2. Data Structures
		- Binary Search Tree: Organizes requests for efficient searching.
		- Graph: Establishes relationships between requests based on location.

	3. File Previews
		- Preview attached images and text files for each request.

	4. Interactive UI
		- Combobox filters for dynamic search.
		- Color-coded statuses for quick identification.

Usage Guide
	Viewing Requests:
		- Open the application to see all service requests in the main ListView.

	Filtering Requests:
		- Use the dropdown menus for location, category, and status to refine your search.
		- Click the Update button to apply filters.

	Viewing File Attachments:
		- Select a request from the ListView.
		- View attached files in the preview area:
		- Images are displayed in the PictureBox.
		- Text files are shown in the RichTextBox.

Data Structures and Their Roles
	Binary Search Tree (BST)
		- The BST organises service requests by ID for fast insertion and search operations.
		- Each request is inserted into the BST upon loading from the database.
		- Efficiency: Enables logarithmic search for specific requests by ID.

	Example: 
	When a new request with ID 25 is added, the BST quickly determines its correct position for storage.

	Graph
		- The graph represents relationships between service requests and the exact location.

		Implementation:
			Nodes - Represents individual service requests.
			Edges - Connect requests with the exact location.
			Efficiency - Responsible for finding related requests using graph traversal algorithms.

	Example: 
	If a user selects a location filter (e.g., "Cape Town"), the graph identifies related requests using Breadth-First Search (BFS).


Examples and Scenarios
	Example 1: Filtering Requests by Location
		- User selects "Durban" from the location dropdown.
		- The graph identifies all nodes with the same location (Durban).
		- Matching requests are displayed in the search results under a separate heading.

	Example 2: Viewing Related Results
		- No direct matches are found for "Johannesburg" and "Sanitation."
		- The graph suggests related requests based on proximity and shared attributes.

Contribution to Efficiency
	1. Binary Search Tree
		Benefit: Reduces search time for specific requests.
		Scenario: On average, searching for a request with ID 102 in a dataset of 1000 entries takes ~10 comparisons.
	2. Graph
		Benefit: Enables efficient traversal for related results.
		Scenario: Finding all requests related to "City Center" is completed in linear time relative to connected nodes.

Troubleshooting
	Database Connection Error:
		Ensure the ServiceRequests.db file exists in the correct directory (Found in ./Debug/bin/ServiceRequests.db)
		Verify the connection string matches your setup.

	File Preview Issues:
		Ensure attached files are in supported formats (.jpg, .png, .txt).





