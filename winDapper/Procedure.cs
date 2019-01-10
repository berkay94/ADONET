using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winDapper
{
    class Procedure
    {

       

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        private string orderDate;

        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal price;

        public decimal UnitPrice
        {
            get { return price; }
            set { price = value; }
        }

    }
}
