using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kulklanıcı adını giriniz  ")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz ")]

        public string password { get; set; }
    }
}
