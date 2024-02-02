namespace EventHub.Data.Models
{
    using System;
    using System.Collections.Generic;

    using EventHub.Data.Common.Models;

    public class EventCategory : BaseDeletableModel<int>
    {
        public EventCategory()
        {
            this.Events = new HashSet<Event>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
