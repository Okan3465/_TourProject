using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage="Lütfen adınızı soyadınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }


        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Lütfen mail adresinizi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi tekrar giriniz ")]
        [Compare("Password",ErrorMessage ="şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }


    }
}
