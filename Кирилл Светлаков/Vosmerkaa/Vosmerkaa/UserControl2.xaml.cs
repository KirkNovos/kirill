using System;
using System.Collections.Generic;
using System.Data;
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

namespace Vosmerkaa
{
    /// <summary>
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        Connect con = new Connect();
        BitmapImage image;
        DataTable dr;
        VosemNovKA tm = new VosemNovKA();
        string pr;
        string spr = null;
        public UserControl2()
        {
            InitializeComponent();
        }
        private void LL(int mi, int ma)
        {
            dr = tm.ForList(mi, ma);
            for (int i = 0; i < 20; i++)
            {
                pr = dr.Rows[i][1].ToString();
                spr = dr.Rows[i][2].ToString() + " " + dr.Rows[i][3].ToString() + " " + dr.Rows[i][4].ToString()
                + " " + dr.Rows[i][5].ToString() + "\n " + dr.Rows[i][6].ToString();
                int id = (int)dr.Rows[i][0];
                if (pr == "нет" || pr == "не указано" || pr == "отсутствует") image = null;
                else image = new BitmapImage(new Uri(Environment.CurrentDirectory + pr));
                if (id == 1)
                {
                    SP1.Children.Add(new Image { Source = image, Height = 70 });
                    SP1.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 2)
                {
                    SP2.Children.Add(new Image { Source = image, Height = 70 });
                    SP2.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 3)
                {
                    SP3.Children.Add(new Image { Source = image, Height = 70 });
                    SP3.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 4)
                {
                    SP4.Children.Add(new Image { Source = image, Height = 70 });
                    SP4.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 5)
                {
                    SP5.Children.Add(new Image { Source = image, Height = 70 });
                    SP5.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 6)
                {
                    SP6.Children.Add(new Image { Source = image, Height = 70 });
                    SP6.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 7)
                {
                    SP7.Children.Add(new Image { Source = image, Height = 70 });
                    SP7.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 8)
                {
                    SP8.Children.Add(new Image { Source = image, Height = 70 });
                    SP8.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 9)
                {
                    SP9.Children.Add(new Image { Source = image, Height = 70 });
                    SP9.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 10)
                {
                    SP10.Children.Add(new Image { Source = image, Height = 70 });
                    SP10.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 11)
                {
                    SP11.Children.Add(new Image { Source = image, Height = 70 });
                    SP11.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 12)
                {
                    SP12.Children.Add(new Image { Source = image, Height = 70 });
                    SP12.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (i == 13)
                {
                    SP13.Children.Add(new Image { Source = image, Height = 70 });
                    SP13.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 14)
                {
                    SP14.Children.Add(new Image { Source = image, Height = 70 });
                    SP14.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 15)
                {
                    SP15.Children.Add(new Image { Source = image, Height = 70 });
                    SP15.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 16)
                {
                    SP16.Children.Add(new Image { Source = image, Height = 70 });
                    SP16.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 17)
                {
                    SP17.Children.Add(new Image { Source = image, Height = 70 });
                    SP17.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 18)
                {
                    SP18.Children.Add(new Image { Source = image, Height = 70 });
                    SP18.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 19)
                {
                    SP19.Children.Add(new Image { Source = image, Height = 70 });
                    SP19.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
                if (id == 20)
                {
                    SP20.Children.Add(new Image { Source = image, Height = 70 });
                    SP20.Children.Add(new TextBlock { Text = spr, FontSize = 16 });
                }
            }
        }
            private void ListView_Loaded(object sender, RoutedEventArgs e)
            {
                LL(1, 21);
            }
            private void ListView_Clear()
            {
                SP1.Children.Clear();
                SP2.Children.Clear();
                SP3.Children.Clear();
                SP4.Children.Clear();
                SP5.Children.Clear();
                SP6.Children.Clear();
                SP7.Children.Clear();
                SP8.Children.Clear();
                SP9.Children.Clear();
                SP10.Children.Clear();
                SP11.Children.Clear();
                SP12.Children.Clear();
                SP13.Children.Clear();
                SP14.Children.Clear();
                SP15.Children.Clear();
                SP16.Children.Clear();
                SP17.Children.Clear();
                SP18.Children.Clear();
                SP19.Children.Clear();
                SP20.Children.Clear();
            }
            private void Button_Click1(object sender, RoutedEventArgs e)
            {
                ListView_Clear();
                LL(1, 21);
            }
            private void Button_Click2(object sender, RoutedEventArgs e)
            {
                ListView_Clear();
                LL(21, 41);
            }
            private void Button_Click3(object sender, RoutedEventArgs e)
            {
                ListView_Clear();
                LL(41, 61);
            }
            private void Button_Click4(object sender, RoutedEventArgs e)
            {
                ListView_Clear();
                LL(61, 81);
            }
        }
    }
    


/*
        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            string s = "SELECT * from products_k_import";
            grid.ItemsSource = con.ConDT(s).DefaultView;
            // или con.ConDT(s).AsDataView();//result1;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
*/
