using MahApps.Metro.Controls;
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

namespace WpfApplication1
{
    /// <summary>
    /// QQlist.xaml 的交互逻辑
    /// </summary>
    public partial class QQlist : MetroWindow
    {
        public QQlist()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (qquser.Visibility == System.Windows.Visibility.Collapsed)
            {
                qquser.Visibility = System.Windows.Visibility.Visible;
                tubiao.RenderTransform = new RotateTransform(0);
                tubiao.Margin = new Thickness(0,0,0,0);
            }
            else
            {
                qquser.Visibility = System.Windows.Visibility.Collapsed;
                tubiao.RenderTransform = new RotateTransform(-90);
                tubiao.Margin = new Thickness(0, 13, 0, 0);
            }
        }
    }
}
