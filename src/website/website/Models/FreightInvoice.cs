using System;

namespace website.Models
{
    public class FreightInvoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int LocationId { get; set; }
        public int CarrierId { get; set; }
        public Carrier Carrier { get; set; }
        public decimal Amount { get; set; }
        public int CarrierInvoiceId { get; set; }
        public CarrierInvoice CarrierInvoice { get; set; }
    }
}