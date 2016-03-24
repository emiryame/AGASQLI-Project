using AGA.DTO.Mapping;
using AGA.DTO.Models;
using AGA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Business
{
    /// <summary>
    /// La classe permet de changer les statuts des demandes, récupèrer des demandes selon un critère..
    /// </summary>
    public class TraiterDemande :ITraiterDemande
    {
        /// <summary>
        /// Retourne la liste des demandes "En Attente"
        /// </summary>
        /// <returns>Liste des demandes</returns>
        public List<Demande> GetDemandesEnAttenteList()
        {
            var context = new Data.AGADataBaseContainer();
            List <Data.Demande> demandesList=context.DemandeSet.Where(d => d.Statut.Label == "En Attente").ToList();
            context.Dispose();

            return DemandeMapping.EntityToDto(demandesList);    
        }

        /// <summary>
        /// Retourne le nombre de demande en attente (non traitées encore)
        /// </summary>
        /// <returns></returns>
        public int GetNombreDemandesEnAttente()
        {
            return this.GetDemandesEnAttenteList().Count();
        }
        
        /// <summary>
        /// Retourne toutes les demandes faites par un collaborateur donné
        /// </summary>
        /// <param name="idCollaborateur">L'id du collaborateur</param>
        /// <returns>La liste des demandes</returns>
        public List<Demande> GetDemandesListParCollaborateur(int idCollaborateur)
        {
            var context = new Data.AGADataBaseContainer();
            List<Data.Demande> demandesList=context.DemandeSet.Where(d => d.Collaborateur.Id == idCollaborateur).ToList();
            context.Dispose();

            return DemandeMapping.EntityToDto(demandesList);
        }

        /// <summary>
        /// Retourne la liste des demandes en cours de traitement par une assistante donnée
        /// </summary>
        /// <param name="idAssistante">L'id de l'assistante</param>
        /// <returns>La liste des demandes</returns>
        public List<Demande> GetDemandesEnCoursParAssistante(int idAssistante)
        {
            var context = new Data.AGADataBaseContainer();
            List<Data.Demande> demandesList = context.DemandeSet.Where(d => d.Assistante.Id == idAssistante).ToList();
            context.Dispose();

            return DemandeMapping.EntityToDto(demandesList);
        }

        /// <summary>
        /// Change le statut d'une demande à "En cours"
        /// </summary>
        /// <param name="demande">La demande</param>
        public void ChangerStatutEnCours(Demande demande)
        {
            demande.Statut = GetStatut("En Cours");
        }

        /// <summary>
        /// Change le statut d'une demande à "Prete"
        /// </summary>
        /// <param name="demande">La demande</param>
        public void ChangerStatutPrete(Demande demande)
        {
            demande.Statut = GetStatut("Prete");
        }

        /// <summary>
        /// Change le statut d'une demande à "Rejetee"
        /// </summary>
        /// <param name="demande">La demande</param>
        public void ChangerStatutRejetee(Demande demande)
        {
            demande.Statut = GetStatut("Rejetee");
        }

        /// <summary>
        /// Récupère le statut de la base de donnée
        /// </summary>
        /// <param name="label">Le label du statut</param>
        /// <returns></returns>
        private Statut GetStatut(String label)
        {
            var context = new Data.AGADataBaseContainer();
            Data.Statut statut = context.StatutSet.FirstOrDefault(s => s.Label == label);
            context.Dispose();

            return StatutMapping.EntityToDto(statut);    
        }
    }
}
