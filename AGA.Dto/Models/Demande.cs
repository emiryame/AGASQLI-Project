using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto
{
    public class Demande
    {
        public int Id { get; set; }
        public System.DateTime DateCreation { get; set; }
        public Nullable<System.DateTime> DateDebutTraitement { get; set; }
        public Nullable<System.DateTime> DateFinTraitement { get; set; }

        public virtual TypeAttestation TypeAttestation { get; set; }
        public virtual AttestationConge AttestationConge { get; set; }
        public virtual Collaborateur Collaborateur { get; set; }
        public virtual Statut Statut { get; set; }
        public virtual Collaborateur Assistante { get; set; }
        public virtual NotificationEmail EmailContenu { get; set; }
    }
}
