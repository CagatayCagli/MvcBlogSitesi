using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminLayout.Areas.Admin.Models
{
    public class LoginModel
    {
        [EmailAddress(ErrorMessage ="E-Posta formatında giriş yapınız")]
        [Required(ErrorMessage ="E-Posta Boş Geçilemez")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage ="Parola Boş Geçilemez")]
        [MinLength(8,ErrorMessage ="En az 8 karakter olmalıdır")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }

    public class PasswordResetModel
    {
        [EmailAddress(ErrorMessage ="E-Posta formatında giriniz")]
        [Required(ErrorMessage ="E-posta zorunludur")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Parola zorulundur")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,12}$", ErrorMessage = "En az 1 harf, 1 numara girilmedir. Minimum 8 Maksimum 12 karakteri geçemezsiniz.")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Şifre uyuşmuyor")]
        public string PasswordConfirm { get; set; }

    }

    public class RegisterModel
    {
        [Required(ErrorMessage ="İsim Alanı Boş Geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Soyisim alanı boş geçilemez")]
        public string SurName { get; set; }

        [Required(ErrorMessage ="UserName Boş Geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Parola Boş geçilemez")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,12}$",ErrorMessage ="En az 1 harf, 1 numara girilmedir. Minimum 8 Maksimum 12 karakteri geçemezsiniz.")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Parolalar uyuşmuyor")]
        public string PasswordConfirm { get; set; }

        [EmailAddress(ErrorMessage ="E-Posta formatında giriniz")]
        [Required(ErrorMessage ="E-Posta boş geçilemez")]
        public string EmailAddress { get; set; }

    }
}