using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto.Mapping
{
    public static class DemandeMapping
    {
        public static Dto.Demande EntityToDto(Data.Demande demande)
        {
            Dto.Demande demandeDto = new Demande();

            demandeDto.Assistante = CollaborateurMapping.EntityToDto(demande.Assistante);
            demandeDto.AttestationConge = AttestationCongeMapping.EntityToDto(demande.AttestationConge);
            demandeDto.Collaborateur = CollaborateurMapping.EntityToDto(demande.Collaborateur);
            demandeDto.DateCreation = demande.DateCreation;
            demandeDto.DateDebutTraitement = demande.DateDebutTraitement;
            demandeDto.DateFinTraitement = demande.DateFinTraitement;
            demandeDto.EmailContenu = NotificationEmailMapping.EntityToDto(demande.EmailContenu);
            demandeDto.Id = demandeDto.Id;
            demandeDto.Statut = StatutMapping.EntityToDto(demande.Statut);
            demandeDto.TypeAttestation = TypeAttestationMapping.EntityToDto(demande.TypeAttestation);

            return demandeDto;
        }
    }
}
