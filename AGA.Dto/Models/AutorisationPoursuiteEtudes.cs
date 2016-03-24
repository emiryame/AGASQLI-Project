using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.DTO.Models
{
    public class AutorisationPoursuiteEtudes
    {
        public AutorisationPoursuiteEtudes()
        {
            Demande = new Demande();
        }
        public int Id { get; set; }
        public string Etablissement { get; set; }
        public string AnneeScolaire { get; set; }
        public virtual Demande Demande { get; set; }
    }
}
