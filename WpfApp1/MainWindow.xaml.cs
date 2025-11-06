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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Xem_Click(object sender, RoutedEventArgs e)
        {
            String strMessage, strHoTen, strTitle, strNgoaiNgu = "";
            strHoTen = txtHodem.Text + txtTen.Text;
            if (radNam.IsChecked == true)
                strTitle = "Mr.";
            else
            {
                strTitle = "Mrs.";
            }
            strMessage = "Xin chao " + strTitle + " " + strHoTen;
            if (chkAnh.IsChecked == true)
            {
                strNgoaiNgu = "Tieng Anh";
            }
            if(chkAnh.IsChecked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Tieng Trung" : (strNgoaiNgu + " va Tieng Trung");
            }
            strMessage += "\nNgoai ngu: " + strNgoaiNgu;
            if(cboQue.SelectedIndex >= 0)
            {
                strMessage += "\nQue quan: " + cboQue.Text;
            }
            MessageBox.Show(strMessage);
        }

        private void Nhap_Click(object sender, RoutedEventArgs e)
        {
            txtHodem.Text = "";txtTen.Text = "";
            radNam.IsChecked = true;radNu.IsChecked = false;
            chkAnh.IsChecked = false;chkTrung.IsChecked = false;
            cboQue.SelectedIndex = 0;
        }
    }
}
