using AGA.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.DTO.Mapping
{
    /// <summary>
    /// Classe pour le mapping entre les objets mailtemplate "Data" et "DTO"
    /// </summary>
    public static class MailTemplateMapping
    {
        /// <summary>
        /// Permet la convertion d'un objet mailTemplate data en un objet mailTemplate DTO
        /// </summary>
        /// <param name="mailTemplate">mailTemplate Data</param>
        /// <returns>mailTemplate DTO</returns>
        public static MailTemplate EntityToDto(Data.MailTemplate mailTemplate)
        {
            MailTemplate mailTemplateDto = new MailTemplate();

            mailTemplateDto.Code = mailTemplate.Code;
            mailTemplateDto.Contenu = mailTemplate.Contenu;
            mailTemplateDto.Id = mailTemplate.Id;
            mailTemplateDto.Objet = mailTemplate.Objet;

            return mailTemplateDto;
        }
    }
}
