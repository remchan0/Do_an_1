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
using System.Windows.Shapes;

namespace Do_An_1
{
    /// <summary>
    /// Interaction logic for Trangthi.xaml
    /// </summary>
    public partial class frmTrangthi : Window
    {
        public frmTrangthi()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, RoutedEventArgs e)
        {
            // Đóng cửa sổ trang chính
            this.Close();

            // Hiển thị cửa sổ đăng nhập nếu nó không tồn tại
            frmLogin loginWindow = Application.Current.Windows.OfType<frmLogin>().FirstOrDefault();
            if (loginWindow == null)
            {
                loginWindow = new frmLogin();
                loginWindow.Show();
            }
            else
            {
                loginWindow.Visibility = Visibility.Visible;
            }
        }
    }
}
