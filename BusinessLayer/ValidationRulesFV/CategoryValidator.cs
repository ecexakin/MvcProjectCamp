using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRulesFV
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("kategori adı boş olamaz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("açıklama boş olamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("en az 3 karakter");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("max 20 name char");
        }
    }
}
