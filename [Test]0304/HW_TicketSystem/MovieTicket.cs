using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_TicketSystem
{
    class MovieTicket
    {
        public double Price { get; set; }

        public IDiscount Discount;
        
        public double Calculate(double price){
            if (Discount != null)
            {
                return Discount.Calculate(price);
            }
            else
                return price;
        }
    }
}
