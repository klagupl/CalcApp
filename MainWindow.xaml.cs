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

namespace CalcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> numbers = new List<string>();
        List<String> operators = new List<string>();

        List<String> input = new List<String>();

         void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            var Content = b.Content.ToString();
            input.Add(Content);
            textbox.AppendText(Content);
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
