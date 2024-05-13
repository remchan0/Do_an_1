using System.Text;
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
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void signupbutton_Click(object sender, RoutedEventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.Show();
        }

        private void comboboxUsertype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboboxUsertype.SelectedItem != null)
            {
                string selectedUserType = (comboboxUsertype.SelectedItem as ComboBoxItem)?.Content as string;
                if (selectedUserType == "Thí sinh")
                {
                    {
                        iconLogin.Visibility = Visibility.Collapsed;
                    }
                    // Chuyển đến trang của Thí sinh
                    MainFrame.Content = new Thisinh();
                }
                else if (selectedUserType == "Quản trị viên")
                {
                    {
                        iconLogin.Visibility = Visibility.Collapsed;
                    }
                    // Chuyển đến trang của Quản trị viên
                    MainFrame.Content = new Quantrivien();
                }
            }
        }
        public void ShowMainMenu()
        {
            // Tạo một thể hiện của cửa sổ trang chính và hiển thị nó
            frmTrangchu mainMenu = new frmTrangchu();
            mainMenu.Show();

            // Ẩn cửa sổ đăng nhập
            this.Hide();
        }
    }
}