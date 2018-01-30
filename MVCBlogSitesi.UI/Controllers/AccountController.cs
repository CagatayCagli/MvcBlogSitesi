using System.Web.Mvc;
using MVCBlogSitesi.DAL.Entities;
using MVCBlogSitesi.BLL.Validations;
using System.Linq;
using MVCBlogSitesi.Repository.UOW.Abstract;
using System;
using MVCBlogSitesi.UI.Services;
using System.IO;

namespace MVCBlogSitesi.UI.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        IMessage _messageProvider;
        public AccountController(IUnitOfWork unitOfWork,IMessage messageProvider) : base(unitOfWork)
        {
            _messageProvider = messageProvider;
        }
        // GET: Admin/Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users model)
        {

            var validator = new LoginValidator().Validate(model);
            if (validator.IsValid)
            {
                var loginControl = _unitOfWork.GetRepo<Users>().Where(x => x.Email == model.Email && x.Password == model.Password);
                if (loginControl != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Msg = "Böyle bir kullanıcı kaydı yoktur!";
                    ModelState.Clear();
                    return View();
                }
            }
            else
            {
                var hataListesi = validator.Errors.ToList();
                foreach (var item in hataListesi)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(Users model)
        {
            model.RoleId = 2;
            //model.IsAccepted = true;
            //model.IsDeleted = false;
            //model.RememberMe = false;
            var validator = new RegisterValidator().Validate(model);
            if (validator.IsValid)
            {
                var registerControl = _unitOfWork.GetRepo<Users>().Where(x => x.Email == model.Email);
                if (registerControl != null)
                {
                    _unitOfWork.GetRepo<Users>().Add(model);
                    _unitOfWork.Commit();
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ViewBag.Msg = "Bu mail adresi daha önce kullanılmış!";
                    ModelState.Clear();
                    return View();
                }
            }
            else
            {
                var hataListesi = validator.Errors.ToList();
                foreach (var item in hataListesi)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public string _kod;

        public ActionResult PasswordConfirm(string kod)
        {
            if (_kod == kod)
            {
                var model = new Users {Email = "test@test.com"};
                return View(model);
            }
            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PasswordConfirm(Users model)
        {
            if (ModelState.IsValid)
            {
                model=_unitOfWork.GetRepo<Users>().Where(x => x.Email == model.Email).FirstOrDefault();
                if (model!=null)
                {
                    _unitOfWork.GetRepo<Users>().Update(model);
                    _unitOfWork.Commit();
                    
                }
                //email addresine göre kullanıcıyı databaseden bul
                //var user = repository.GetByEmail(model.Email);
                //user.password = hasher.hash(model.password);
                //repository.Update(user);
                //repository.save
                ViewBag.Message = "Parolanız Güncellendi";
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PasswordReset(string Email)
        {
            if (Email.Contains("@"))
            {
                //mail atma
                //inputu temizler
                _kod = Guid.NewGuid().ToString();
                string url = Path.Combine("http://localhost:47240/Account/PasswordConfirm/", "kod?=" + _kod);
                string htmlString = "<a href=" + url + ">Parolamı Resetle</a>";

                 var model = _unitOfWork.GetRepo<Users>().Where(x => x.Email == Email).FirstOrDefault();
                if (model!=null)
                {
                    var message = (NetMessage)_messageProvider;
                    message.To = Email;
                    bool Ok = message.SendMessage("Parola Değişikliği", htmlString);

                    ModelState.Clear();
                    ViewBag.Message = Ok ? "Gönderildi" : "Tekrar Deneyiniz";

                    return View();
                }
            }
            return View();
        }

        [AllowAnonymous]
        public ActionResult PasswordReset()
        {
            return View();
        }
    }
}