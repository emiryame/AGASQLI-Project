using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto.Mapping
{
    public static class CollaborateurMapping
    {
        public static Dto.Collaborateur EntityToDto(Data.Collaborateur collaborateur)
        {
            Dto.Collaborateur collaborateurDto = new Collaborateur();

            collaborateurDto.Banque = collaborateur.Banque;
            collaborateurDto.Cin = collaborateur.Cin;
            collaborateurDto.Cnss = collaborateur.Cnss;
            collaborateurDto.DateDebutTravail = collaborateur.DateDebutTravail;
            collaborateurDto.Id = collaborateur.Id;
            collaborateurDto.IsEligible = collaborateur.IsEligible;
            collaborateurDto.Nom = collaborateur.Nom;
            collaborateurDto.Poste = collaborateurDto.Poste;
            collaborateurDto.Prenom = collaborateurDto.Prenom;

            return collaborateurDto;
        }
    }
}
