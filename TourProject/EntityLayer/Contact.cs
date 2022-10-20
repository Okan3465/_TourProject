using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  
        public class Contact
        {
            [Key]
            public int ContactID { get; set; }

             public string ContactNameSurname { get; set; }

             public string ContactUserName { get; set; }
            public string ContactMail { get; set; }

            public string ContactSubject { get; set; }
            public string ContactMessage { get; set; }
             public string ContactPassword { get; set; }

            public string  ContactImage { get; set; }

            public DateTime ContactDate { get; set; }
            public bool ContactStatus { get; set; }
             //public List<Comment> Comments { get; set; }




    }
}

