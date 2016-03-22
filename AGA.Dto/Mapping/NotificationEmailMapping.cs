using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto.Mapping
{
    public static class NotificationEmailMapping
    {
        public static Dto.NotificationEmail EntityToDto(Data.NotificationEmail notificationMail)
        {
            Dto.NotificationEmail notificationMailDto = new NotificationEmail();

            notificationMailDto.Contenu = notificationMail.Contenu;
            notificationMailDto.Id = notificationMail.Id;
            notificationMailDto.Objet = notificationMail.Objet;

            return notificationMailDto;
        }
    }
}
