using System.Data.Entity;
using website.Models;

namespace website.DataAccess
{
    public class GrainSystemDataContext : DbContext
    {
        public IDbSet<FreightInvoice> FreightInvoices { get; set; }
        public IDbSet<Carrier> Carriers { get; set; }
 
        protected override void Dispose(bool disposing)
        {
            SaveChanges();
            base.Dispose(disposing);
        }
    }
}