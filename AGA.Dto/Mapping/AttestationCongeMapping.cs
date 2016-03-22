using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AGA.Dto.Mapping
{
    public static class AttestationCongeMapping
    {
        public static Dto.AttestationConge EntityToDto(Data.AttestationConge attestationConge)
        {
            Dto.AttestationConge attestationCongeDto = new AttestationConge();

            attestationCongeDto.DateDebut = attestationConge.DateDebut;
            attestationCongeDto.DateFin = attestationConge.DateFin;
            attestationCongeDto.Id = attestationConge.Id;

            return attestationCongeDto;
        }
   
    }
}
