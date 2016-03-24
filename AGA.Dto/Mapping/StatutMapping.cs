using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGA.DTO.Models;

namespace AGA.DTO.Mapping
{
    /// <summary>
    /// Classe pour le mapping entre les objets statut "Data" et "DTO"
    /// </summary>
    public static class StatutMapping
    {
        /// <summary>
        /// Permet la convertion d'un objet statut data en un objet statut DTO
        /// </summary>
        /// <param name="statut">statut Data</param>
        /// <returns>statut DTO</returns>
        public static Statut EntityToDto(Data.Statut statut)
        {
            Statut statutDto = new Statut();

            statutDto.Id = statut.Id;
            statutDto.Label = statut.Label;
            statutDto.MailTemplate = MailTemplateMapping.EntityToDto(statut.MailTemplate);

            return statutDto;
        }

    }
}
