using System;
using System.Collections.Generic;
using System.Text;

namespace svu
{
  public  class Cart
    {
        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public List<Order> Orders { set; get; }
    }
}
