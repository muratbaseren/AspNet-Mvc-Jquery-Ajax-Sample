using AspNetMvcJqueryAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcJqueryAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // $.load();
            return View();
        }

        public ActionResult Index2()
        {
            // $.get(); - Get & POST
            return View();
        }


        public ActionResult Index3()
        {
            // $.ajax();
            return View();
        }

        public ActionResult Index4()
        {
            // $.ajax(); GetJSon
            return View();
        }

        private List<string> datas = new List<string>() { "kadir", "murat", "başeren" };


        public PartialViewResult GetData()
        {
            System.Threading.Thread.Sleep(3000);

            return PartialView("_DataItemPartialView", datas);
        }

        public PartialViewResult GetData2(string veri)
        {
            System.Threading.Thread.Sleep(3000);

            datas.Add(veri);

            return PartialView("_DataItemPartialView", datas);
        }

        [HttpPost, ActionName("GetData2")]
        public PartialViewResult GetData2Post(string veri)
        {
            System.Threading.Thread.Sleep(3000);

            datas.Add(veri);

            return PartialView("_DataItemPartialView", datas);
        }


        public JsonResult GetData3()
        {
            System.Threading.Thread.Sleep(3000);

            return Json(datas, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetData4(Nesne nesne)
        {
            System.Threading.Thread.Sleep(3000);

            nesne.veri += "...";

            return Json(nesne, JsonRequestBehavior.AllowGet);
        }
    }
}