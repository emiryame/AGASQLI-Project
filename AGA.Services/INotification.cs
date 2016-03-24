﻿using AGA.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Services
{
    /// <summary>
    /// Envoyer des notifications mail aux collaborateurs, assistantes et responsable
    /// </summary>
    public interface INotification
    {
        /// <summary>
        /// Notifie le collaborateur par mail de l'état d'avancement de sa demande
        /// </summary>
        /// <param name="demande">la demande créée par le collaborateur</param>
        void NotifierCollaborateur(Demande demande);

        /// <summary>
        /// Notifie les assistantes par mail du nombre des demandes en attente
        /// </summary>
        void NotifierAssistantesDemandesEnAttente();

        /// <summary>
        /// Notifie le responsable de la demande en attente de sa décision
        /// </summary>
        /// <param name="demande">La demande</param>
        void NotifierResponsable(Demande demande);
    }
}
