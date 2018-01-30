using FluentValidation;
using MVCBlogSitesi.DAL.Context;
using MVCBlogSitesi.DAL.Entities;
using System.Linq;

namespace MVCBlogSitesi.BLL.Validations
{
    public class LoginValidator:AbstractValidator<Users>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email alanı boş geçilemez!")
                .EmailAddress().WithMessage("Girdiğiniz format yanlıştır!");
        }
    }
}
