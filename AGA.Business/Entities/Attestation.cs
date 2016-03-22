using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGA.Dto;

namespace AGA.Business.Entities
{
    public class Attestation
    {
        public Collaborateur Collaborateur { get; set; }
        public DateTime DateDemande { get; set; }
    }
}
