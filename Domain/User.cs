using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public bool Active { get; set; }
        //public virtual IEnumerable<FinePost> FinesPosts { get; set; }
    }
}
