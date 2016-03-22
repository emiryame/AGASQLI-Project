using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGA.Dto
{
    public class NotificationEmail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
  
        public int Id { get; set; }
        public string Objet { get; set; }
        public string Contenu { get; set; }

    }
}
