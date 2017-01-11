using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) //TextBox 1
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) // textbox 2
        {
        }
        
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e) // answer box
        {
            //if you wish to make a clearscrean function, create a button and place
            //this code into the objects class. what this does is it sets the values of
            //either string or int in this case it should be int but i digress, the values will be 
            //reset to their default value on the screen which is blank or empty. 

           // txtAnsw.Text = "";
           // txt1.Text = "";
           // txt2.Text = "";

        }

        private void Button_Click(object sender, RoutedEventArgs e) // multiply
        {
            float num1 = float.Parse(txt1.Text);    // takes in the value of input 1 and parses it as a float (a decimal number)
            float num2 = float.Parse(txt2.Text);    // takes in the value of input 2 and parses it as a float (a decimal number)
            float result;                           // variable for setting result
            
            result = num1 * num2;                   // gets the first number and second number and uses the operand sign for multiplication
            txtAnsw.Text = result.ToString();       // displays the answer to the answer box. 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // divide
        {
            float num1 = float.Parse(txt1.Text);    // takes in the value of input 1 and parses it as a float (a decimal number)
            float num2 = float.Parse(txt2.Text);    // takes in the value of input 2 and parses it as a float (a decimal number)
            float result;                           // variable for setting result

            result = num1 / num2;                   // gets the first number and second number and uses the operand sign for division
            txtAnsw.Text = result.ToString();       // displays the answer to the answer box. 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // Addition
        {
            float num1 = float.Parse(txt1.Text);    // takes in the value of input 1 and parses it as a float (a decimal number)
            float num2 = float.Parse(txt2.Text);    // takes in the value of input 2 and parses it as a float (a decimal number)
            float result;                           // variable for setting result

            result = num1 + num2;                   // gets the first number and second number and uses the operand sign for addition
            txtAnsw.Text = result.ToString();       // displays the answer to the answer box. 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // subtract 
        {
            float num1 = float.Parse(txt1.Text);    // takes in the value of input 1 and parses it as a float (a decimal number)
            float num2 = float.Parse(txt2.Text);    // takes in the value of input 2 and parses it as a float (a decimal number)
            float result;                           // variable for setting result

            result = num1 - num2;                   // gets the first number and second number and uses the operand sign for subtraction
            txtAnsw.Text = result.ToString();       // displays the answer to the answer box. 
        }

    }
}
