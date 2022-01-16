using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Order
  {
    public Order()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
      this.Recurring = false;
    }

    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public string Vendor { get; set; }

    public string VendorAddress { get; set; }

    public string Days { get; set; }

    public bool Recurring { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }

    public virtual ApplicationUser User { get; set; }
  }
}