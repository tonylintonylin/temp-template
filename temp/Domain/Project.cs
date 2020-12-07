using System;
using System.Collections.Generic;

namespace temp.Domain
{
    public class Project
    {
        public Project()
        {
            Issue = new HashSet<Issue>();
        }

        public Guid Id { get; set; }
                    // change to title later

        public string Title { get; set; }
        public string Description { get; set; }

        public int TotalTickets { get; set; }
        
        public int OwnerId { get; set; }
        public string OwnerAlias { get; set; }

        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public int? ChangedBy { get; set; }

        // public virtual User Owner { get; set; }
        public virtual ICollection<Issue> Issue { get; set; }
    }
}
