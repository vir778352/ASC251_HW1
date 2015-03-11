using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_TicketSystem
{
    class 學生票優惠 : IDiscount
    {
        public double Calculate(double price)
        {       
            //System.Windows.MessageBox.Show("學生票優惠8折");
            return price*0.8;
        }
    }
}
