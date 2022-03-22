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

namespace WPFhello
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

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.txtName.Text.Length > 2)
            {
                MessageBox.Show("Hello " + this.txtName.Text + "!");

            }
            else
            {
                MessageBox.Show("Put a longer name");

            }
        }
    }
}
