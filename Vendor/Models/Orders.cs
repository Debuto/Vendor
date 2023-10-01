using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string OrderTitle {get; set;}
    public string OrderPrice {get; set;}
    public string OrderDescription{get; set;}
    public string OrderDate {get; set;}
    public int Id {get; }
    private static List<Order> _instances = new List<Order> { };
  }
}