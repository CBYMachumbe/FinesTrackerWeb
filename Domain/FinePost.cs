using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class FinePost
    {
        public int FinePostId { get; set; }
        public int FineId { get; set; }
        public int FinerId { get; set; }
        public int FineeId { get; set; }

        public virtual Fines Fine { get; set; }
        public virtual User Finee { get; set; }
        public virtual User Finer { get; set; }
        public virtual IEnumerable<Vote> Votes { get; set; }
    }
}
