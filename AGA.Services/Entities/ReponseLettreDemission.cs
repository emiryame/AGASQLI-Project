using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Services.Entities
{
    public class ReponseLettreDemission : Attestation
    {
        public DateTime DateFinContrat { get; set; }
        public DateTime DateReceptionDemande { get; set; }
        public String Reference { get; set; }
    }
}
