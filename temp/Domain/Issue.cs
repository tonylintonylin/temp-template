using System;

namespace temp.Domain
{
    public partial class Issue
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int OwnerId { get; set; }
        public string OwnerAlias { get; set; }

        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public int? ChangedBy { get; set; }

        // relationship
        public virtual Project Project { get; set; }
        public Guid ProjectId { get; set; }

        public string ProjectTitle { get; set; }
        // public virtual User Owner { get; set; }
    }
}
