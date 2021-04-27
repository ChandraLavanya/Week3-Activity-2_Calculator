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

namespace DPS_Activity_2_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double First, Second, Result;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            First = Convert.ToDouble(FirstNumberTxtBox.Text);
            Second = Convert.ToDouble(SecondNumberTxtBox.Text);
            Result = First + Second;
            AnswerLabel.Content = Result.ToString();
            AnswerLabel.Visibility = Visibility.Visible;
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            First = Convert.ToDouble(FirstNumberTxtBox.Text);
            Second = Convert.ToDouble(SecondNumberTxtBox.Text);
            Result = First - Second;
            AnswerLabel.Content = Result.ToString();
            AnswerLabel.Visibility = Visibility.Visible;
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            First = Convert.ToDouble(FirstNumberTxtBox.Text);
            Second = Convert.ToDouble(SecondNumberTxtBox.Text);
            Result = First * Second;
            AnswerLabel.Content = Result.ToString();
            AnswerLabel.Visibility = Visibility.Visible;
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            First = Convert.ToDouble(FirstNumberTxtBox.Text);
            Second = Convert.ToDouble(SecondNumberTxtBox.Text);
            Result = First / Second;
            AnswerLabel.Content = Result.ToString();
            AnswerLabel.Visibility = Visibility.Visible;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
