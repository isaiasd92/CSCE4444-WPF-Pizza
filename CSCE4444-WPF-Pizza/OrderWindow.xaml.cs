using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PizzaBlendGrid {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window {

        // base state
        string qtyPizzaButton_display = "1";
        bool qtyPizzaButton_changed = false;

        public OrderWindow() {
            InitializeComponent();

            //clean this up
            qtyPizzaButton.Content = "1";
        }

        private void Show_Click(object sender, RoutedEventArgs e) {
            MyPopup.IsOpen = true;
        }

        private void Hide_Click(object sender, RoutedEventArgs e) {
            MyPopup.IsOpen = false;
        }

        private void Click_Digit1(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("1");
            //Debug.WriteLine("Button1");
        }

        private void Click_Digit2(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("2");
        }
        private void Click_Digit3(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("3");
        }
        private void Click_Digit4(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("4");
        }
        private void Click_Digit5(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("5");
        }
        private void Click_Digit6(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("6");
        }
        private void Click_Digit7(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("7");
        }
        private void Click_Digit8(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("8");
        }
        private void Click_Digit9(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("9");
        }

        private void Click_Digit0(object sender, RoutedEventArgs e) {
            QtyPizzaButton_update("0");
        }

        private void QtyPizzaButton_update(string numinput) {
            if (!qtyPizzaButton_changed) {
                if (numinput != "0") {
                    qtyPizzaButton.Content = numinput;
                    qtyPizzaButton_display = numinput;
                    qtyPizzaButton_changed = true;
                } 
            } else {
                qtyPizzaButton_display = qtyPizzaButton_display + numinput;
                qtyPizzaButton.Content = qtyPizzaButton_display;
            }
        }
    }

    

}
