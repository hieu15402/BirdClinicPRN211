using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Gender
    {
        public Gender()
        {
            Accounts = new HashSet<Account>();
        }

        public int Gender1 { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
