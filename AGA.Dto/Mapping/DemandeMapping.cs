using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGA.DTO.Models;

namespace AGA.DTO.Mapping
{
    /// <summary>
    /// Classe pour le mapping entre les objets demande "Data" et "DTO"
    /// </summary>
    public static class DemandeMapping
    {
        /// <summary>
        /// Permet la convertion d'un objet demande data en un objet demande DTO
        /// </summary>
        /// <param name="demande">demande Data</param>
        /// <returns>demande DTO</returns>
        public static Demande EntityToDto(Data.Demande demande)
        {
            Demande demandeDto = new Demande();

            demandeDto.Assistante = CollaborateurMapping.EntityToDto(demande.Assistante);
            demandeDto.Collaborateur = CollaborateurMapping.EntityToDto(demande.Collaborateur);
            demandeDto.DateCreation = demande.DateCreation;
            demandeDto.DateDebutTraitement = demande.DateDebutTraitement;
            demandeDto.DateFinTraitement = demande.DateFinTraitement;
            demandeDto.Id = demandeDto.Id;
            demandeDto.Statut = StatutMapping.EntityToDto(demande.Statut);
            demandeDto.TypeAttestation = TypeAttestationMapping.EntityToDto(demande.TypeAttestation);
            return demandeDto;
        }

        /// <summary>
        /// Permet la convertion d'une liste de demandes data en une liste de demandes DTO
        /// </summary>
        /// <param name="demandesList">La liste de demandes Data</param>
        /// <returns>La liste de demandes DTO</returns>
        public static List<Demande> EntityToDto(List<Data.Demande> demandesList)
        {
            List<Demande> demandesListDto = new List<Demande>();
            demandesList.ForEach(d => demandesListDto.Add(DemandeMapping.EntityToDto(d)));

            return demandesListDto;    
        }
    }
}
