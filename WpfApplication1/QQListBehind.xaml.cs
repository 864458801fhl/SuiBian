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
    /// QQListBehind.xaml 的交互逻辑
    /// </summary>
    public partial class QQListBehind : MetroWindow
    {
        public QQListBehind()
        {
            InitializeComponent();
            AddHeard(4, "我的好友");
            AddHeard(2, "中原五霸");
        }
        public void AddHeard(int count,string name)
        {
            StackPanel sp = new StackPanel();
            sp.MouseLeftButtonDown += sp_MouseLeftButtonDown;
            sp.Margin = new Thickness(10, 0, 0, 0);
            sp.Orientation = Orientation.Horizontal;

            //列表图标
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("./img/arrow.png", UriKind.Relative));
            img.Width = 9;
            sp.Children.Add(img);

            //好友列表
            TextBlock tb = new TextBlock();
            tb.Text = name+""+count+"/108";
            tb.Margin = new Thickness(3, 0, 0, 0);
            sp.Children.Add(tb);

            content.Children.Add(sp);
            for (int i = 1; i <= count; i++)
            {
                AddItem();
            }
            
        }

        void sp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel sour = sender as StackPanel;
            
            Image tubiao = sour.Children[0] as Image;

            StackPanel psp = sour.Parent as StackPanel;

            //int tag = Convert.ToInt32(sour.Tag);
            StackPanel qquser = new StackPanel();
            qquser = psp.Children[1] as StackPanel;

            if (qquser.Visibility == System.Windows.Visibility.Collapsed)
            {
                qquser.Visibility = System.Windows.Visibility.Visible;
                tubiao.RenderTransform = new RotateTransform(0);
                tubiao.Margin = new Thickness(0, 0, 0, 0);
            }
            else
            {
                qquser.Visibility = System.Windows.Visibility.Collapsed;
                tubiao.RenderTransform = new RotateTransform(-90);
                tubiao.Margin = new Thickness(0, 13, 0, 0);
            }
        }
        public void AddItem()
        {
            //最外层
            StackPanel userOut = new StackPanel();
            userOut.Margin = new Thickness(0, 5, 0, 0);

            //中层
            StackPanel userCenter = new StackPanel();
            userCenter.Orientation = Orientation.Horizontal;
            userCenter.Margin=new Thickness(20, 0, 0, 0);
            userCenter.MouseEnter += userCenter_MouseEnter;
            userCenter.MouseLeave += userCenter_MouseLeave;

            //里层(图片容器)
            StackPanel imgInside = new StackPanel();
            imgInside.Orientation = Orientation.Horizontal;
            Image imgHead = new Image();
            imgHead.Source = new BitmapImage(new Uri("./img/h1.bmp", UriKind.Relative));
            imgHead.Width = 45;

            //文字
            StackPanel TextInside = new StackPanel();
            TextBlock tb = new TextBlock();
            tb.Text = "独孤愁 VIP";
            tb.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff0000"));
            tb.Margin = new Thickness(5, 0, 0, 0);
            TextInside.Children.Add(tb);

            TextBlock tb2 = new TextBlock();
            tb2.Text = "一杯清酒泯恩仇~";

            tb2.Margin = new Thickness(5, 8, 0, 0);
            TextInside.Children.Add(tb2);

            imgInside.Children.Add(imgHead);
            
            userCenter.Children.Add(imgInside);
            userCenter.Children.Add(TextInside);
            userOut.Children.Add(userCenter);

            content.Children.Add(userOut);

        }

        void userCenter_MouseLeave(object sender, MouseEventArgs e)
        {
            StackPanel sp = sender as StackPanel;
            sp.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#fff"));
        }

        void userCenter_MouseEnter(object sender, MouseEventArgs e)
        {
            StackPanel sp = sender as StackPanel;
            sp.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
        }
    }
}
