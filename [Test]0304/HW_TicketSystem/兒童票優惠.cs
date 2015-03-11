using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_TicketSystem
{
    class 兒童票優惠 : IDiscount
    {
        public double Calculate(double price)
        {
            return price * 0.3;
        }
    }
}
