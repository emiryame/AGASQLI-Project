using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.DTO.Models
{
    public class Statut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        
        public Statut()
        {
            MailTemplate = new MailTemplate();
        }
        public int Id { get; set; }
        public string Label { get; set; }
        public virtual MailTemplate MailTemplate { get; set; }
    }
}
