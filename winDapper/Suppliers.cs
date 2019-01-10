using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winDapper
{
    class Suppliers
    {
        private int supplierId;

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

    }
}
