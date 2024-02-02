// ReSharper disable VirtualMemberCallInConstructor
namespace EventHub.Data.Models
{
    using System;
    using System.Collections.Generic;

    using EventHub.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Reviews = new HashSet<Review>();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        // Personal Information
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Organizer Details
        public bool IsOrganizer { get; set; }

        // Event Details
        public virtual ICollection<Event> OrganizedEvents { get; set; }

        public virtual ICollection<Event> AttendedEvents { get; set; }

        // Additional Contact Information
        public string PhoneNumber { get; set; }

        // Address Information (Optional)
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        // Profile Image URL (Optional)
        public string ProfileImageUrl { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
