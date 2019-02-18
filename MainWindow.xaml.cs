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
       // List<String> numbers = new List<string>()
        List<String> operators = new List<string>() {"+","-" };

        List<String> input = new List<String>();

         void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            var Content = b.Content.ToString();
            input.Add(Content);
            textbox.AppendText(Content);
        }
        void Submit(object sender, RoutedEventArgs e)
        {
            List<int> numbers = new List<int>();
            List<String> localOperators = new List<String>();
            String number = "";
            Console.WriteLine(input.Count());
            foreach(string el in input)
            {
                if (!operators.Contains(el))
                {
                    number += el;
                    Console.WriteLine(number);
                    if(input.IndexOf(el) + 1 == input.Count())
                    {
                        numbers.Add(int.Parse(number));
                        Console.WriteLine(numbers);
                    }
                }
                else
                {
                    localOperators.Add(el);
                    numbers.Add(int.Parse(number));
                    number = "";
                    Console.WriteLine(numbers);
                }

            }

        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
