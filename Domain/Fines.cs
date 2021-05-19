using System;
using System.Collections.Generic;

namespace Domain
{
    public partial class Fines
    {
        public int FineId { get; set; }
        public string FineTitle { get; set; }
        public string FineText { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }

        //public virtual IEnumerable<FinePost> FinePosts { get; set; }
    }
}
