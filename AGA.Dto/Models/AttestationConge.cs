using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.DTO.Models
{
    public class AttestationConge
    {
        public AttestationConge()
        {
            Demande=new Demande();
        }
        public int Id { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }

        public virtual Demande Demande { get; set; }
    }
}
