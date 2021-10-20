using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buesiness.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Name can't be null");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail can't be null");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password can't be null");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Image can't be null");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Name has to include min 2 character");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Name has to include max 50 character");
        }
    }
}
