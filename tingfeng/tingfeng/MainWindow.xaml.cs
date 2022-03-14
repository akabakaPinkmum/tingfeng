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

namespace tingfeng
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] eat = new string[] {"乌龙肉桂鸡胸肉", "草莓", "西瓜味汽水", "黑糖碧根果仁", "鲜虾仁", "凉拌鸡丝面", "樱桃红烧肉"};
            string[] eat2 = new string[] { "海苔", "米线", "炸鸡", "螺狮粉", "茉莉蜜桃汽水", "素食植物肉双拼手卷", "排骨刀削面" };
            string[] adj = new string[] { "甜甜的", "凉凉的", "香香的", "冰冰的", "酸酸的"};
            string[] time = new string[] { "下午", "晚上", "早上", "中午" };
            string[] songs = new string[] { "周杰伦的《告白气球》", "下一次微笑", "刘琦瑞的房间", "余佳运的最好的都给你" };
            Random ran = new Random();

            string vareat = eat[ran.Next(0, 6)];
            string vareat2 = eat2[ran.Next(0, 5)];
            string varadj = adj[ran.Next(0, 4)];
            string vartime = time[ran.Next(0, 3)];
            string varsong = songs[ran.Next(0, 3)];

            string vartext = "大家" + vartime + "好呀听枫者们,刚刚吃了" + vareat + "和" + vareat2 +  "，味道" + varadj + "。" + "今天给大家推荐的歌是" + varsong +"。";
            txt1.Text = vartext;
        }
    }
}
