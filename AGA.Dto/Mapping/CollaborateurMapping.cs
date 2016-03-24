using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGA.DTO.Models;

namespace AGA.DTO.Mapping
{
    /// <summary>
    /// Classe pour le mapping entre les objets collaborateur "Data" et "DTO"
    /// </summary>
    public static class CollaborateurMapping
    {
        /// <summary>
        /// Permet la convertion d'un objet collaborateur data en un objet collaborateur DTO
        /// </summary>
        /// <param name="collaborateur">collaborateur data</param>
        /// <returns>L'objet collaborateur DTO</returns>
        public static Collaborateur EntityToDto(Data.Collaborateur collaborateur)
        {
            Collaborateur collaborateurDto = new Collaborateur();

            collaborateurDto.Banque = collaborateur.Banque;
            collaborateurDto.Cin = collaborateur.Cin;
            collaborateurDto.Cnss = collaborateur.Cnss;
            collaborateurDto.DateDebutTravail = collaborateur.DateDebutTravail;
            collaborateurDto.Id = collaborateur.Id;
            collaborateurDto.IsEligible = collaborateur.IsEligible;
            collaborateurDto.Nom = collaborateur.Nom;
            collaborateurDto.Poste = collaborateur.Poste;
            collaborateurDto.Prenom = collaborateur.Prenom;
            collaborateurDto.Adresse = collaborateur.Adresse;
            collaborateurDto.Civilite = CiviliteMapping.EntityToDto(collaborateur.Civilite);

            return collaborateurDto;
        }

        /// <summary>
        /// Permet la convertion d'une liste de collaborateurs data en une liste de collaborateurs DTO
        /// </summary>
        /// <param name="collaborateursList">La liste des collaborateur Data</param>
        /// <returns>La liste de collaborateurs DTO</returns>
        public static List<Collaborateur> EntityToDto(List<Data.Collaborateur> collaborateursList)
        {
            List<Collaborateur> listCollaborateurDto = new List<Collaborateur>();
            collaborateursList.ForEach(c => listCollaborateurDto.Add(EntityToDto(c)));
            return listCollaborateurDto;
        }
    }
}
