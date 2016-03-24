using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.DTO.Models
{
    public class Demande
    {
        public Demande()
        {
            TypeAttestation = new TypeAttestation();
            Collaborateur = new Collaborateur();
            Statut = new Statut();
            Assistante = new Collaborateur();
        }
        public int Id { get; set; }
        public System.DateTime DateCreation { get; set; }
        public Nullable<System.DateTime> DateDebutTraitement { get; set; }
        public Nullable<System.DateTime> DateFinTraitement { get; set; }

        public virtual TypeAttestation TypeAttestation { get; set; }
        public virtual Collaborateur Collaborateur { get; set; }
        public virtual Statut Statut { get; set; }
        public virtual Collaborateur Assistante { get; set; }
    }
}
