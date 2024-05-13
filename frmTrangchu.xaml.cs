using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Do_An_1.style;

namespace Do_An_1
{
    /// <summary>
    /// Interaction logic for Trangchu.xaml
    /// </summary>
    public partial class frmTrangchu : Window
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }
        private bool isSidebarExpanded = true;
        private Button selectedButton;
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
        private void NavigateAndHighlight(Button button, string pageUri)
        {
            Maincontent.Navigate(new Uri(pageUri, UriKind.Relative));
            if (button != null)
            {
                if (selectedButton != null)
                {
                    selectedButton.SetValue(IsSelectedStyle.IsSelectedProperty, false);
                }
                button.SetValue(IsSelectedStyle.IsSelectedProperty, true);
                selectedButton = button;
            }
        }

        private void buttonPanel_Click(object sender, RoutedEventArgs e)
        {
            if (isSidebarExpanded)
            {
                // Thu gọn thanh sidebar và di chuyển frame Maincontent sang phải
                AnimateSidebar(90);
                AnimateMaincontent(1);
            }
            else
            {
                // Mở rộng thanh sidebar và di chuyển frame Maincontent về vị trí ban đầu
                AnimateSidebar(240);
                AnimateMaincontent(0);
            }

            isSidebarExpanded = !isSidebarExpanded;
        }

        private void AnimateSidebar(double width)
        {
            var animation = new DoubleAnimation
            {
                To = width,
                Duration = TimeSpan.FromSeconds(0.5) // Thời gian thực hiện hiệu ứng
            };

            Sidebar.BeginAnimation(WidthProperty, animation);
        }

        private void AnimateMaincontent(int column)
        {
            var animation = new ThicknessAnimation
            {
                To = new Thickness(column == 0 ? 0 : 0, 0, 0, 0), // Thiết lập vị trí của frame Maincontent
                Duration = TimeSpan.FromSeconds(0.5) // Thời gian thực hiện hiệu ứng
            };

            Maincontent.BeginAnimation(MarginProperty, animation);
        }

        private void buttonInfor_Click(object sender, RoutedEventArgs e)
        {
            NavigateAndHighlight(sender as Button, "Thongtin.xaml");
        }

        private void buttonQuiz_Click(object sender, RoutedEventArgs e)
        {
            NavigateAndHighlight(sender as Button, "Cauhoi.xaml");
        }

        private void buttonExam_Click(object sender, RoutedEventArgs e)
        {
            NavigateAndHighlight(sender as Button, "Quanlythi.xaml");
        }

        private void buttonStats_Click(object sender, RoutedEventArgs e)
        {
            NavigateAndHighlight(sender as Button, "Thongke.xaml");
        }
    }
}
