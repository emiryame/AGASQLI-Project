using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGA.DTO.Models;

namespace AGA.DTO.Mapping
{
    /// <summary>
    /// Classe pour le mapping entre les objets civilite "Data" et "DTO"
    /// </summary>
    public static class CiviliteMapping
    {
        /// <summary>
        /// Permet la convertion d'un objet civilite data en un objet civilite DTO
        /// </summary>
        /// <param name="civilite">civilite Data</param>
        /// <returns>civilite DTO</returns>
        public static Civilite EntityToDto(Data.Civilite civilite)
        {
            Civilite civiliteDto = new Civilite();
            civiliteDto.Id = civilite.Id;
            civiliteDto.Label = civilite.Label;

            return civiliteDto;
        }
    }
}
