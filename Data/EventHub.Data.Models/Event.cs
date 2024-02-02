namespace EventHub.Data.Models
{
    using System;
    using System.Collections.Generic;

    using EventHub.Data.Common.Models;

    public class Event : BaseDeletableModel<string>
    {
        public Event()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Attendees = new HashSet<ApplicationUser>();
            this.Reviews = new HashSet<Review>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int EventCategoryId { get; set; }

        public virtual EventCategory EventCategory { get; set; }

        // Organizer (Creator) of the Event
        public string OrganizerId { get; set; }

        public virtual ApplicationUser Organizer { get; set; }

        // Attendees of the Event
        public virtual ICollection<ApplicationUser> Attendees { get; set; }

        public bool IsCompleted { get; set; }

        // Reviews of the Event
        public virtual ICollection<Review> Reviews { get; set; }

        // Venue Information (Optional)
        public int VenueId { get; set; }

        public virtual Venue Venue { get; set; }
    }
}
