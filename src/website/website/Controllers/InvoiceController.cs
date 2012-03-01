using System.Web.Mvc;
using website.DataAccess;
using website.Models;

namespace website.Controllers
{
    public class InvoiceController : Controller
    {
        readonly IRepository<Carrier> _carrierRepo;

        public InvoiceController(IRepository<Carrier> carrierRepo)
        {
            _carrierRepo = carrierRepo;
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult GetCarriers()
        {
            return null;// _carrierRepo.Query();
        }

    }
}
