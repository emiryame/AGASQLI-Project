using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto.Mapping
{
    public static class TypeAttestationMapping
    {
        public static Dto.TypeAttestation EntityToDto(Data.TypeAttestation typeAttestation)
        {
            Dto.TypeAttestation typeAttestationDto = new TypeAttestation();

            typeAttestationDto.Code = typeAttestation.Code;
            typeAttestationDto.Id = typeAttestation.Id;
            typeAttestationDto.Label = typeAttestation.Label;

            return typeAttestationDto;
        }
    }
}
