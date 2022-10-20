using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.CommentTitle).NotEmpty().WithMessage("Yorum başlığını boş geçemezsiniz");
            RuleFor(x => x.CommenUserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz ");
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Yorum içeriğii boş geçemezsiniz");
            RuleFor(x => x.CommentTitle).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapınız");
            RuleFor(x => x.CommentTitle).MinimumLength(5).WithMessage("Lütfen 4 karakterden daha fazla veri girişi yapınız");
        }
    }
}
