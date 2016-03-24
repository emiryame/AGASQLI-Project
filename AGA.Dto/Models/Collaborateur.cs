using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.DTO.Models
{
    public class Collaborateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Collaborateur()
        {
            this.IsEligible = true;
            Civilite = new Civilite();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Cin { get; set; }
        public string Cnss { get; set; }
        public string Poste { get; set; }
        public Nullable<System.DateTime> DateDebutTravail { get; set; }
        public string Banque { get; set; }
        public bool IsEligible { get; set; }
        public string Adresse { get; set; }

        public virtual Civilite Civilite { get; set; }

    }
}
