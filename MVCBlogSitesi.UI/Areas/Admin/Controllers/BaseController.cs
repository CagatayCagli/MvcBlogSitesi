using MVCBlogSitesi.Repository.UOW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogSitesi.UI.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected override void Dispose(bool disposing)
        {
            _unitOfWork.Dispose(disposing);
        }
    }
}