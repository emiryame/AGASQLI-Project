﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using AGA.DTO.Models;
using AGA;
using AGA.Services;
using AGA.DTO.Mapping;

namespace AGA.Business
{
    /// <summary>
    /// Envoyer des notifications mail aux collaborateurs, assistantes et responsable
    /// </summary>
    public class Notification
    {
        #region Public
        /// <summary>
        /// Notifie le collaborateur par mail de l'état d'avancement de sa demande
        /// </summary>
        /// <param name="demande">la demande créée par le collaborateur</param>
        //TODO: Email Collab depuis getEmail de ITraiterCollaborateur
        public void NotifierCollaborateur(Demande demande)
        {
            Dictionary<String, String> dictionnaireTokens = new Dictionary<string, string>();
            dictionnaireTokens.Add("%typeAttestation%", demande.TypeAttestation.Label);
            dictionnaireTokens.Add("%civilite%", demande.Collaborateur.Civilite.Label);
            dictionnaireTokens.Add("%nom%",demande.Collaborateur.Nom);
            dictionnaireTokens.Add("%prenom%", demande.Collaborateur.Prenom);
            String contenuMail = EditTemplateText(dictionnaireTokens, demande.Statut.MailTemplate.Contenu);

            ITraiterCollaborateur collaborateurService = new TraiterCollaborateur();
            String destinataire = collaborateurService.GetEmail(demande.Collaborateur);

            this.Notifier(destinataire, demande.Statut.MailTemplate.Objet, contenuMail);
        }

        /// <summary>
        /// Notifie les assistantes par mail du nombre des demandes en attente
        /// </summary>
        public void NotifierAssistantesDemandesEnAttente()
        {
            var context = new Data.AGADataBaseContainer();
            MailTemplate mailTemplate = MailTemplateMapping.EntityToDto(context.MailTemplateSet.FirstOrDefault(i => i.Code == "AssistanteNotif"));
            String objet = mailTemplate.Objet;
            context.Dispose();

            ITraiterDemande demandeService = new TraiterDemande();
            Dictionary<String, String> dictionnaireTokens = new Dictionary<String, String>();
            dictionnaireTokens.Add("%nombre%", demandeService.GetNombreDemandesEnAttente().ToString());
            String contenuMail = EditTemplateText(dictionnaireTokens, mailTemplate.Contenu);

            ITraiterCollaborateur collaborateurService = new TraiterCollaborateur();
            List<String> destinatairesList = collaborateurService.GetEmailList(collaborateurService.GetAssistantesList());

            this.Notifier(destinatairesList,objet,contenuMail);
        }
        #endregion

        /// <summary>
        /// Notifie le responsable de la demande en attente de sa décision
        /// </summary>
        /// <param name="demande">La demande</param>
        //TODO: Mail du responsable
        public void NotifierResponsable(Demande demande)
        {
            var context = new Data.AGADataBaseContainer();
            MailTemplate mailTemplate = MailTemplateMapping.EntityToDto(context.MailTemplateSet.FirstOrDefault(i => i.Code == "ResponsableNotif"));
            String objet = mailTemplate.Objet;
            context.Dispose();

            Dictionary<String, String> dictionnaireTokens = new Dictionary<String, String>();
            dictionnaireTokens.Add("%typeAttestation%", demande.TypeAttestation.Label);
            dictionnaireTokens.Add("%nom%", demande.Collaborateur.Nom);
            dictionnaireTokens.Add("%prenom%", demande.Collaborateur.Prenom);

            String contenuMail = EditTemplateText(dictionnaireTokens,mailTemplate.Contenu);

            this.Notifier("",objet,contenuMail);
        }

        #region Private
        /// <summary>
        /// Remplace dans un text (string) des tokens (string) par d'autres.
        /// </summary>
        /// <param name="dictionnaireTokens">Dictionnaire des tokens (remplacé, remplaçant)</param>
        /// <param name="text">Le text ou aura lieu le remplacement</param>
        /// <returns>Le text resultat après remplacement</returns>
        private String EditTemplateText (Dictionary<String,String> dictionnaireTokens,String text)
        {
            for(int i=0; i< dictionnaireTokens.Count(); i++)
            {
                text = text.Replace(dictionnaireTokens.Keys.ElementAt(i),dictionnaireTokens.Values.ElementAt(i));
            }
            return text;
        }

        /// <summary>
        /// Envoie ne notification par mail à un groupe de destinataire
        /// </summary>
        /// <param name="destinatairesList">La liste des mails des destinataiire</param>
        /// <param name="objet">L'objet du mail</param>
        /// <param name="contenu">Le contenu du mail</param>
        private void Notifier(List<String> destinatairesList,String objet, String contenu)
        {
            destinatairesList.ForEach(d => this.Notifier(d, objet, contenu));
        }
        /// <summary>
        /// Envoie une notification par mail à un destinataire
        /// </summary>
        /// <param name="destinataire">L'adresse mail du destinataire</param>
        /// <param name="objet">L'objet du mail</param>
        /// <param name="contenu">Le contenu du mail</param>
        private void Notifier(String destinataire, String objet, String contenu)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("aga.sqli@gmail.com");
            mail.To.Add(destinataire);
            mail.Subject = objet;
            mail.Body = contenu;

            smtpServer.Port = 587;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpServer.EnableSsl = true;
            smtpServer.UseDefaultCredentials = false;
            smtpServer.Credentials = new System.Net.NetworkCredential("aga.sqli@gmail.com", "oscare*1");
            try
            {
                smtpServer.Send(mail);
            }
            catch
            {
                
            }
        }
        #endregion
    }
}
