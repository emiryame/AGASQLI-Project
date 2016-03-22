using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Business.Entities
{
    class AttestationConge : Attestation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
    }
}
