using System;

namespace y3s2_PROG_POE.Classes
{
    public class ReportClass
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFilePath { get; set; }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Constructor to initialize a new Report object
        public ReportClass(string location, string category, string description, string attachedFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            AttachedFilePath = attachedFilePath;
        }
		/*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method to validate the fields
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(Location))
            {
                errorMessage += "Location is required.\n";
            }
            if (string.IsNullOrWhiteSpace(Category))
            {
                errorMessage += "Category is required.\n";
            }
            if (string.IsNullOrWhiteSpace(Description))
            {
                errorMessage += "Description is required.\n";
            }
            if (string.IsNullOrWhiteSpace(AttachedFilePath))
            {
                errorMessage += "An attachment is required.\n";
            }

            return string.IsNullOrEmpty(errorMessage);
        }
    }
}
/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/
