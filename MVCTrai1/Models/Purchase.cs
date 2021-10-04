using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTrai1.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public int ToyId { get; set; }

    }
}