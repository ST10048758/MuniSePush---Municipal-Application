using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace y3s2_PROG_POE.Classes
{
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public byte[] FileData { get; set; }

        public int CompareTo(ServiceRequest other)
        {
            if (other == null) return 1;
            return Id.CompareTo(other.Id);
        }
    }
}
