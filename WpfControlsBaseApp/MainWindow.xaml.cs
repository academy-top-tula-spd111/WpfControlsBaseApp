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

namespace WpfControlsBaseApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //btn1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));

            //Button btn2 = new Button();
            //btn2.Width = 200;
            //btn2.Height = 100;
            //btn2.Content = new TextBlock() { Text = "Hello" };
            //btn2.Click += Button_Click2;


            //panel.Children.Add(btn2);

            CheckBox check2 = new();
            check2.IsThreeState = true;
            check2.Checked += CheckBox_Checked;

            uniGrid.Children.Add(check2);

            RadioButton rbtn4 = new();
            rbtn4.Content = "Шарф";
            rbtn4.GroupName = "g2";
            rbtn4.Checked += RadioButton_Checked;

            uniGrid2.Children.Add(rbtn4);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello People!");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            txtNum.Text = (Int32.Parse(txtNum.Text) - 1).ToString();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            txtNum.Text = (Int32.Parse(txtNum.Text) + 1).ToString();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Checked");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Unchecked");
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Indeterminate");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            MessageBox.Show(rbtn.Content.ToString());
        }
    }
}
