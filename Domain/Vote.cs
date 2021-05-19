using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Vote
    {
        public int VoteId { get; set; }
        public int FinePostId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual FinePost FinePost { get; set; }
    }
}
