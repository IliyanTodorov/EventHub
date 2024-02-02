namespace EventHub.Data.Models
{
    using System.Collections.Generic;

    using EventHub.Data.Common.Models;

    public class Venue : BaseDeletableModel<int>
    {
        public Venue()
        {
            this.Events = new HashSet<Event>();
        }

        public string Name { get; set; }

        // Address details
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        // Additional details
        public string Description { get; set; }

        // Navigation property for events
        public virtual ICollection<Event> Events { get; set; }
    }

}
