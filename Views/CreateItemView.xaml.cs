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

namespace AppDevPro.Views
{
    public partial class CreateItemView : UserControl
    {
        public CreateItemView()
        {
            InitializeComponent();
        }

        private void txtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && txtTitle.Text.Length > 0)
            {
                textTitle.Visibility = Visibility.Collapsed;
            }
            else
            {
                textTitle.Visibility = Visibility.Visible;
            }
        }

        private void textTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtTitle.Focus();
        }

        private void txtSubject_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubject.Text) && txtSubject.Text.Length > 0)
            {
                textSubject.Visibility = Visibility.Collapsed;
            }
            else
            {
                textSubject.Visibility = Visibility.Visible;
            }
        }

        private void textSubject_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtSubject.Focus();
        }

        private void txtKeyword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKeyword.Text) && txtKeyword.Text.Length > 0)
            {
                textKeyword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textKeyword.Visibility = Visibility.Visible;
            }
        }

        private void textKeyword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtKeyword.Focus();
        }

        private void txtInformation_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInformation.Text) && txtInformation.Text.Length > 0)
            {
                textInformation.Visibility = Visibility.Collapsed;
            }
            else
            {
                textInformation.Visibility = Visibility.Visible;
            }
        }

        private void textInformation_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtInformation.Focus();
        }


        

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
