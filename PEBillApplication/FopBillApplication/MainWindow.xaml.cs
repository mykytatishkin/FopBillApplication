using Microsoft.IdentityModel.Logging;
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

namespace FopBillApplication
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

        private void MyCompanyRegistration(object sender, RoutedEventArgs e)
        {
            int id;
            bool isNum = int.TryParse(textBoxID.Text, out id);
            
            if (isNum)
            {
                string userID = textBoxID.Text.Trim();                                      // # USER ID
                textBoxID.Background = Brushes.White;
            }
            else
            {
                MessageBox.Show("This is not a ID, please enter correctly!");
                textBoxID.ToolTip = "This is not a ID, please enter correctly!";
                textBoxID.Background = Brushes.Red;
                Debugger.Launch();
            }
            
            string userName = textBoxName.Text;                                            // # USER NAME

            int code;
            isNum = int.TryParse(textBoxCode.Text, out code);
            
            if (isNum) 
            { 
                string userCode = textBoxCode.Text;                                        // # USER CODE
                textBoxCode.Background = Brushes.White;
            }
            else
            {
                // string codeError = LogHelper.Logger.Errors();
                // throw new Exception("This is not a code, please enter correctly");
                MessageBox.Show("This is not a code, please enter correctly!");
                textBoxCode.ToolTip = "This is not a code, please enter correctly!";
                textBoxCode.Background = Brushes.Red;
                Debugger.Launch();
            }
            string userAddress = textBoxAddress.Text.ToLower();                            // # USER ADDRESS


            /* Далее данные нужно отправить в БД */
        }

        private void BillGenerate(object sender, RoutedEventArgs e)
        {
            string itemName = textBoxItemName.Text;                                       // # ITEM NAME

            double price;
            bool isNum = double.TryParse(textBoxItemPrice.Text, out price);
            if (isNum) 
            { 
                double itemPrice = price;                                                // # ITEM PRICE
                textBoxItemPrice.Background = Brushes.White;
            }
            else
            {
                MessageBox.Show("This is not a price, please enter correctly!");
                textBoxItemPrice.ToolTip = "This is not a price, please enter correctly!";
                textBoxItemPrice.Background = Brushes.Red;
                Debugger.Launch();
            }
        }
    }
}
