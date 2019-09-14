using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AAC.ABPDemo.Controllers;

namespace AAC.ABPDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ABPDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
