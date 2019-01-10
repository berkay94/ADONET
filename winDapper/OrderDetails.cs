using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winDapper
{
    class OrderDetails
    {
        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int ProductId { get; set; }
        public decimal UnitPrice{ get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }


    }
}
