using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.DTO.Models
{
    public class MailTemplate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Objet { get; set; }
        public string Contenu { get; set; }
    }
}
