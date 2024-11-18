using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace y3s2_PROG_POE.Classes
{
    public class EventClass
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int EntryFee { get; set; }
        public string Venue { get; set; }
        public Image EventImage { get; set; }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Parameterised Constructor for EventClass
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="entryFee"></param>
        /// <param name="venue"></param>
        /// <param name="eventImage"></param>
        public EventClass(string name, string category, DateTime date, string description, int entryFee, string venue, Image eventImage)
        {
            Name = name;
            Category = category;
            Date = date;
            Description = description;
            EntryFee = entryFee;
            Venue = venue;
            EventImage = eventImage;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Creates a list of EventClass objects with sample data
        /// </summary>
        /// <returns></returns>
        public static List<EventClass> LoadEventData()
        {
            return new List<EventClass>
            {
                new EventClass("Music Festival", "Music", new DateTime(2024, 10, 20), "A grand music festival with famous bands.", 100, "CTICC", LoadImage("Resources/music_festival.png")),
                new EventClass("Food Expo", "Food", new DateTime(2024, 11, 1), "A food expo showcasing local and international cuisine.", 150, "CTICC", LoadImage("Resources/Food Festival poster.png")),
                new EventClass("Art Exhibit", "Art", new DateTime(2024, 10, 15), "An art exhibit featuring contemporary artists.", 10, "CTICC", LoadImage("Resources/Art expo poster.png")),
                new EventClass("Marathon", "Sports", new DateTime(2024, 10, 18), "A charity marathon event.", 50, "CTICC", LoadImage("Resources/marathon poster.png")),
                new EventClass("Beach Cleanup", "Other", new DateTime(2024, 10, 18), "Come join cleaning up Camps Bay beach.", 0, "CTICC", LoadImage("Resources/beach cleanup poster.png")),
                new EventClass("Jazz Night", "Music", new DateTime(2024, 11, 5), "An evening of smooth jazz with local artists.", 50, "Jazz Club", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Craft Beer Festival", "Food", new DateTime(2024, 11, 10), "Explore a variety of craft beers from local breweries.", 80, "City Park", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Photography Workshop", "Art", new DateTime(2024, 11, 15), "Learn the basics of photography from experienced professionals.", 120, "Art Studio", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Soccer Tournament", "Sports", new DateTime(2024, 11, 20), "Join us for a friendly soccer tournament for all ages.", 30, "Local Stadium", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Community Cleanup", "Other", new DateTime(2024, 11, 25), "Help us clean up the neighborhood!", 0, "Community Center", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Rock Concert", "Music", new DateTime(2024, 12, 1), "A night of rock music featuring top bands.", 100, "City Arena", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Wine Tasting", "Food", new DateTime(2024, 12, 5), "Sample a selection of wines from around the world.", 60, "Wine Cellar", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Pottery Class", "Art", new DateTime(2024, 12, 10), "Get creative with clay in this hands-on pottery class.", 40, "Art Studio", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Running Club", "Sports", new DateTime(2024, 12, 15), "Join us for weekly runs and fitness tips.", 20, "City Park", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Beach Volleyball Tournament", "Sports", new DateTime(2024, 12, 20), "Compete in our exciting beach volleyball tournament!", 50, "Camps Bay Beach", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Open Mic Night", "Music", new DateTime(2024, 12, 25), "Showcase your talent or enjoy performances from others.", 10, "Community Hall", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Farmers Market", "Food", new DateTime(2025, 01, 01), "Shop for fresh produce and handmade goods.", 0, "Town Square", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Art Fair", "Art", new DateTime(2025, 01, 10), "Discover local artists and their creations.", 5, "Art Gallery", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Yoga in the Park", "Other", new DateTime(2025, 01, 15), "Relax and rejuvenate with a yoga session in the park.", 15, "City Park", LoadImage("Resources/4-4700104.jpg")),
                new EventClass("Charity Gala", "Other", new DateTime(2025, 01, 20), "Attend our charity gala and help raise funds for local causes.", 150, "Grand Hotel", LoadImage("Resources/4-4700104.jpg")),
            };
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to load an image from a file path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static Image LoadImage(string path)
        {
            if (File.Exists(path))
            {
                return Image.FromFile(path);
            }
            return null;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to filter events based on category and date range
        /// </summary>
        /// <param name="events"></param>
        /// <param name="category"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <returns></returns>
        public static List<EventClass> FilterEvents(List<EventClass> events, string category, DateTime minDate, DateTime maxDate)
        {
            var filteredEvents = events.Where(e => e.Date >= minDate && e.Date <= maxDate).ToList();

            if (!string.IsNullOrEmpty(category) && category != "All Categories")
            {
                filteredEvents = filteredEvents.Where(e => e.Category == category).ToList();
            }

            return filteredEvents;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
        /*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
