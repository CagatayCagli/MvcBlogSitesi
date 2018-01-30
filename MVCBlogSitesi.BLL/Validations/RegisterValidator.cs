using FluentValidation;
using System.Linq;
using MVCBlogSitesi.DAL.Context;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.BLL.Validations
{
    public class RegisterValidator : AbstractValidator<Users>
    {
        
        public RegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez!");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad alanı boş geçilemez!");

            RuleFor(x => x.Email)
                .Must(EmailIsExist).WithMessage("Bu email daha önce kulanılmış!")
                .EmailAddress().WithMessage("Girdiğiniz format yanlıştır!")
                .NotEmpty().WithMessage("Email alanı boş geçilemez!");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre alanı boş geçilemez")
                .Equal(x => x.PasswordConfirm).WithMessage("Girilen şifreler birbirinden farklıdır!");

            RuleFor(x => x.Password)
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,12}$")
                .WithMessage("En az 1 harf, 1 numara girilmedir. Minimum 5 Maksimum 12 karakteri geçemezsiniz.");

        }
        public bool EmailIsExist(string Email)
        {
            using (ProjectContext db = new ProjectContext())
            {
                return !db.Users.Any(x => x.Email == Email);
            }

        }
    }
}
