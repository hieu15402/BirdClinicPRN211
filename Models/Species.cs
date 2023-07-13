using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Species
    {
        public Species()
        {
            Patients = new HashSet<Patient>();
        }

        public int SpeciesId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
