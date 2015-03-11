using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_TicketSystem
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            張數TextBox.Text = "1";
            清單TextBlock.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MovieTicket 電影票 = new MovieTicket();
            
            if (ticketComboBox.SelectedIndex == 0){
                電影票.Price = 250;
                if (adultDiscountComboBox.SelectedIndex == 1)
                    電影票.Discount = new 花旗卡優惠();
                
                清單TextBlock.Text += string.Format("一張全票 原價:{0} 特價:{1} 共{2}張，小計:{3}元\n",
                電影票.Price, 電影票.Calculate(電影票.Price), int.Parse(張數TextBox.Text),
                電影票.Calculate(電影票.Price) * int.Parse(張數TextBox.Text));
            }
            else if (ticketComboBox.SelectedIndex == 1){
                電影票.Price = 200;
                if (studentDiscountComboBox.SelectedIndex == 0)
                    電影票.Discount = new 學生票優惠();
                else if (studentDiscountComboBox.SelectedIndex == 1)
                    電影票.Discount = new 花旗卡優惠();
                
                清單TextBlock.Text += string.Format("一張學生票 原價:{0} 特價:{1} 共{2}張，小計:{3}元\n", 
                    電影票.Price, 電影票.Calculate(電影票.Price), int.Parse(張數TextBox.Text), 
                    電影票.Calculate(電影票.Price) * int.Parse(張數TextBox.Text));

            }
            else if (ticketComboBox.SelectedIndex == 2)
            {
                電影票.Price = 150;
                電影票.Discount = new 兒童票優惠();
                清單TextBlock.Text += string.Format("一張兒童票 原價:{0} 特價:{1} 共{2}張，小計:{3}元\n",
                    電影票.Price, 電影票.Calculate(電影票.Price), int.Parse(張數TextBox.Text),
                    電影票.Calculate(電影票.Price) * int.Parse(張數TextBox.Text));
            }
            //System.Windows.MessageBox.Show(string.Format("價格:{0}", 電影票.Calculate(電影票.Price)));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            清單TextBlock.Text = "";
        }
    }
}
