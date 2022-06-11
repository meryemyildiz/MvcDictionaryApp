using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Soyadını boş geçemezsiniz!");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("En fazla 20karakter eklenebilir!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz!");
            RuleFor(x => x.WriteTitle).NotEmpty().WithMessage("Ünvan kısmını boş geçemezsiniz!");
        }
    }
}
