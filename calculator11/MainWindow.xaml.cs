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

namespace calculator11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float a = 0, b = 0, sum = 0;
        int count = 0;

        public void BaseA()
        {
            a = float.Parse(textBox.Text);
            textBox.Clear();
        }

        public void Switch()
        {
            switch (count)
            {
                case 1:
                    b = float.Parse(textBox.Text);
                    sum = a / b;
                    break;

                case 2:
                    b = float.Parse(textBox.Text);
                    sum = a * b;
                    break;

                case 3:
                    b = float.Parse(textBox.Text);
                    sum = a - b;
                    break;

                case 4:
                    b = float.Parse(textBox.Text);
                    sum = a + b;
                    break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string btn = button.Content.ToString();
            textBox.Text += btn;
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            int lenght = textBox.Text.Length - 1;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox.Text += text[i];
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BaseA();
            count = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BaseA();
            count = 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            BaseA();
            count = 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BaseA();
            count = 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switch();
            textBox.Text = sum.ToString();
        }
    }
}
