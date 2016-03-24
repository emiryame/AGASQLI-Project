using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGA.DTO.Models;

namespace AGA.DTO.Mapping
{
    /// <summary>
    /// Classe pour le mapping entre les objets typeAttestation "Data" et "DTO"
    /// </summary>
    public static class TypeAttestationMapping
    {
        /// <summary>
        /// Permet la convertion d'un objet typeAttestation data en un objet typeAttestation DTO
        /// </summary>
        /// <param name="statut">typeAttestation Data</param>
        /// <returns>typeAttestation DTO</returns>
        public static TypeAttestation EntityToDto(Data.TypeAttestation typeAttestation)
        {
            TypeAttestation typeAttestationDto = new TypeAttestation();

            typeAttestationDto.Id = typeAttestation.Id;
            typeAttestationDto.Label = typeAttestation.Label;
            typeAttestation.Template.CopyTo(typeAttestationDto.Template,0);
            return typeAttestationDto;
        }
    }
}
