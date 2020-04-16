using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TESTS.Model
{
    public abstract class Order
    {
        public Order()
        {
            OrderCreateDate = DateTime.Now;
        }

        public int OrderNo { get; set; }
        public DateTime OrderCreateDate { get; set; }
        public DateTime? OrderEditDate { get; set; }
    }


    public class SalesOrder : Order
    {
        public SalesOrder() : base() { }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }

    public class PurchaseOrder : Order
    {
        public PurchaseOrder() : base() { }

        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
