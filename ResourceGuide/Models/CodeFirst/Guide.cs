using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourceGuide.Models
{
    public class Guide
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }

        public virtual ApplicationUser Owner { get; set; }
    }
}