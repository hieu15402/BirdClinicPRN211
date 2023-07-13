using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public int SpeciesId { get; set; }
        public string Username { get; set; }
        public bool Status { get; set; }

        public virtual Species Species { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
