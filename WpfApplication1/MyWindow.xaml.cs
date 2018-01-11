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
    /// MyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MyWindow : MetroWindow
    {
        public MyWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            masterEntities me = new masterEntities();
            List<users> ulist = me.users.Where(a => a.qq == qq.Text && a.pwd == pwd.Text).ToList();
            if (ulist != null)
            {
                QQlist lis = new QQlist();
                lis.Show();
                this.Close();
            }
            else
            {
                qq.Text = "";
                pwd.Text = "";
            }

            
            
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
