using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AAC.ABPDemo.Controllers;

namespace AAC.ABPDemo.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class MyPagesController : ABPDemoControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}