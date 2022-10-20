using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CustomerValidator  :AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerNameSurname).NotEmpty().WithMessage("Ad soyad kısmı boş geçilemez");
            RuleFor(x => x.CustomerMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.CustomerPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Lütfen şifreyi tekrar giriniz");
            RuleFor(x => x.CustomerNameSurname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.CustomerNameSurname).MaximumLength(50).WithMessage("Ad soyad kısmı en fazla 50 karakterden oluşabilir ");

        }
    }
}
