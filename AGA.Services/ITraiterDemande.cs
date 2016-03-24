using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGA.DTO.Models;

namespace AGA.Services
{
    /// <summary>
    /// Permet de changer les statuts des demandes, récupèrer des demandes selon un critère..
    /// </summary>
    public interface ITraiterDemande
    {
        /// <summary>
        /// Retourne la liste des demandes "En Attente"
        /// </summary>
        /// <returns>Liste des demandes</returns>
        List<Demande> GetDemandesEnAttenteList();

        /// <summary>
        /// Retourne le nombre de demande en attente (non traitées encore)
        /// </summary>
        /// <returns></returns>
        int GetNombreDemandesEnAttente();

        /// <summary>
        /// Retourne toutes les demandes faites par un collaborateur donné
        /// </summary>
        /// <param name="idCollaborateur">L'id du collaborateur</param>
        /// <returns>La liste des demandes</returns>
        List<Demande> GetDemandesListParCollaborateur(int idCollaborateur);

        /// <summary>
        /// Retourne la liste des demandes en cours de traitement par une assistante donnée
        /// </summary>
        /// <param name="idAssistante">L'id de l'assistante</param>
        /// <returns>La liste des demandes</returns>
        List<Demande> GetDemandesEnCoursParAssistante(int idAssistante);

        /// <summary>
        /// Change le statut d'une demande à "En cours"
        /// </summary>
        /// <param name="demande">La demande</param>
        void ChangerStatutEnCours(Demande demande);

        /// <summary>
        /// Change le statut d'une demande à "Prete"
        /// </summary>
        /// <param name="demande">La demande</param>
        void ChangerStatutPrete(Demande demande);

        /// <summary>
        /// Change le statut d'une demande à "Rejetee"
        /// </summary>
        /// <param name="demande">La demande</param>
        void ChangerStatutRejetee(Demande demande);
        
    }
}
