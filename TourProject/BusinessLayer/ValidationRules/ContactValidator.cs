using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ContactValidator :AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactNameSurname).NotEmpty().WithMessage("Ad Soyad kısmı boş geçilemez!");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Mail adresi boş geçilemez!");
        }
    }
}
