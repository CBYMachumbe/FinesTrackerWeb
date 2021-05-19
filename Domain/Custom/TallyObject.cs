using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class TallyObject
    {
        public User User { get; set; }
        public int TotalFines { get; set; }
        public int FinesDue { get; set; }

        public TallyObject(User user, int totalFine, int finesDue)
        {
            User = user;
            TotalFines = totalFine;
            FinesDue = finesDue;
        }
    }
}
