﻿using System;
using System.Collections.Generic;

namespace temp.Domain
{
    public partial class Error
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime ErrorDate { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string IpAddress { get; set; }
        public string Url { get; set; }
        public string HttpReferer { get; set; }
        public string UserAgent { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public int? ChangedBy { get; set; }

        public virtual User User { get; set; }
    }
}
