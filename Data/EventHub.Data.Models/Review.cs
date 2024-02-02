namespace EventHub.Data.Models
{
    using System;

    using EventHub.Data.Common.Models;

    public class Review : BaseDeletableModel<int>
    {

        public string EventId { get; set; }

        public virtual Event Event { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public double Rating { get; set; }

        public string Comment { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}
