﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Services.Entities
{
    public class AttestationIrrevocableSalaire : Attestation
    {
        public DateTime DateRemiseMainLibre { get; set; }
        public String NumeroCompte { get; set; }
    }
}
