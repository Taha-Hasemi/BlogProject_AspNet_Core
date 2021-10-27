using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Metnini boş geçemezsiniz");
            RuleFor(x => x.BlogTitle).Length(2, 120).WithMessage("Blog başlığı uzunluğu 2 ve 120 karakter arasında olması gerekir");

        }
    }
}
