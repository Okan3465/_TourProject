using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public  class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string CustomerNameSurname { get; set; }

        public string CustomerUserName { get; set; }
        public string CustomerMail { get; set; }

        public string CustomerPassword { get; set; }
        public string ConfirmPassword { get; set; }

        public string CustomerImage { get; set; }

        public List<Comment> Comments { get; set; }

        public bool CustomerStatus { get; set; }


    }
}
