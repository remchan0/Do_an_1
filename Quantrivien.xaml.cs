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

namespace Do_An_1
{
    /// <summary>
    /// Interaction logic for Quantrivien.xaml
    /// </summary>
    public partial class Quantrivien : Page
    {
        public Quantrivien()
        {
            InitializeComponent();
        }
        private void signupbutton_Click(object sender, RoutedEventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.Show();
        }
        

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            if (string.IsNullOrWhiteSpace(textboxUsername.Text) || string.IsNullOrWhiteSpace(textboxPassword.Password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo");
                return; // Không thực hiện đăng nhập nếu thông tin không đầy đủ
            }

            // Thực hiện kiểm tra đăng nhập
            bool loginSuccessful = CheckLogin(); // Thực hiện kiểm tra đăng nhập ở đây

            // Nếu đăng nhập thành công, hiển thị cửa sổ trang chính
            if (loginSuccessful)
            {
                // Gọi phương thức từ cửa sổ đăng nhập để hiển thị cửa sổ trang chính
                (Window.GetWindow(this) as frmLogin)?.ShowMainMenu();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng thử lại.");
            }
        }

        private bool CheckLogin()
        {
            // Thực hiện kiểm tra đăng nhập và trả về kết quả
            // Trong ví dụ này, tôi sẽ giả định rằng đăng nhập luôn thành công
            // Trong ứng dụng thực tế, bạn cần thay đổi phần này để thực hiện kiểm tra đăng nhập thực tế
            return true; // Đăng nhập luôn thành công (đây là ví dụ)
        }
    }
}
