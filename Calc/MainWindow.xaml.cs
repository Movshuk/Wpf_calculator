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

namespace Calc
{


   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      double num1, num2; // operands
      bool minusOrPlus = true; // minus or plus
      int oper = 0; // operations - / * +
      bool pressDot = false; // ,

      public MainWindow()
      {
         InitializeComponent();
      }

      private void btn_result_Click(object sender, RoutedEventArgs e)
      {
         if (txtDispl.Text != "")
         {
            switch (oper)
            {
               case 1: // "+"
                  num2 = num1 + double.Parse(txtDispl.Text);
                  txtDispl.Text = num2.ToString();
                  oper = 0;
                  break;
               case 2: // "-"
                  num2 = num1 - double.Parse(txtDispl.Text);
                  txtDispl.Text = num2.ToString();
                  oper = 0;
                  break;
               case 3: // "*"
                  num2 = num1 * double.Parse(txtDispl.Text);
                  txtDispl.Text = num2.ToString();
                  oper = 0;
                  break;
               case 4: // "/"
                  num2 = num1 / double.Parse(txtDispl.Text);
                  txtDispl.Text = num2.ToString();
                  oper = 0;
                  break;
               default:
                  break;
            }
            txtDisplTmp.Clear();
         }
      }

      private void btn_1_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 1;
      }

      private void btn_2_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 2;
      }

      private void btn_3_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 3;
      }

      private void btn_4_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 4;
      }

      private void btn_5_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 5;
      }

      private void btn_6_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 6;
      }

      private void btn_7_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 7;
      }

      private void btn_8_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 8;
      }

      private void btn_9_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 9;
      }

      private void btn_0_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text + 0;
      }

      private void btn_dot_Click(object sender, RoutedEventArgs e)
      {
         if (pressDot == false)
         {
            txtDispl.Text = txtDispl.Text + ",";
            pressDot = true;
         }
      }

      // operations
      private void btn_plus_Click(object sender, RoutedEventArgs e)
      {
         if (txtDispl.Text != "")
         {
            txtDisplTmp.Text = txtDispl.Text + " +";
            num1 = double.Parse(txtDispl.Text);
            txtDispl.Clear();
            oper = 1;
            minusOrPlus = true;
         }
         else
         {
            oper = 1;
            minusOrPlus = true;
         }
      }

      private void btn_multipl_Click(object sender, RoutedEventArgs e)
      {
         if (txtDispl.Text != "")
         {
            txtDisplTmp.Text = txtDispl.Text + " *";
            num1 = double.Parse(txtDispl.Text);
            txtDispl.Clear();
            oper = 3;
            minusOrPlus = true;
         }
         else
         {
            oper = 3;
            minusOrPlus = true;
         }
      }

      private void btn_minus_Click(object sender, RoutedEventArgs e)
      {
         if (txtDispl.Text != "")
         {
            txtDisplTmp.Text = txtDispl.Text + " -";
            num1 = double.Parse(txtDispl.Text);
            txtDispl.Clear();
            oper = 2;
            minusOrPlus = true;
         }
         else
         {
            oper = 2;
            minusOrPlus = true;
         }
      }

      private void btn_divide_Click(object sender, RoutedEventArgs e)
      {
         if (txtDispl.Text != "")
         {
            txtDisplTmp.Text = txtDispl.Text + " /";
            num1 = double.Parse(txtDispl.Text);
            txtDispl.Clear();
            oper = 4;
            minusOrPlus = true;
         }
         else
         {
            oper = 4;
            minusOrPlus = true;
         }
      }

      // clear 
      private void btn_clearAll_Click(object sender, RoutedEventArgs e)
      {
         num1 = 0;
         num2 = 0;
         minusOrPlus = true; // "+"
         pressDot = false; // without ","
         txtDispl.Clear();
      }

      private void btn_clearEntr_Click(object sender, RoutedEventArgs e)
      {
         if (oper == 0)
         {
            num1 = 0;
         }
         else
         {
            num2 = 0;
         }
         txtDispl.Clear();
      }

      private void btn_backspace_Click(object sender, RoutedEventArgs e)
      {
         txtDispl.Text = txtDispl.Text.Substring(0, txtDispl.Text.Length - 1);
      }

      private void btn_cos_Click(object sender, RoutedEventArgs e)
      {
         if (radio_Rad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Cos(num1);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Deg.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Cos( (num1 * Math.PI) / 180);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Grad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Cos((num1 * Math.PI) / 200);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
      }

      private void btn_sin_Click(object sender, RoutedEventArgs e)
      {
         if (radio_Rad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Sin(num1);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Deg.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Sin((num1 * Math.PI) / 180);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Grad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Sin((num1 * Math.PI) / 200);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
      }

      private void btn_tg_Click(object sender, RoutedEventArgs e)
      {
         if (radio_Rad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Tan(num1);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Deg.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Tan((num1 * Math.PI) / 180);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Grad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Tan((num1 * Math.PI) / 200);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
      }

      private void btn_ctg_Click(object sender, RoutedEventArgs e)
      {
         // num1 = Math.Cos(num1) / Math.Sin(num1);
         if (radio_Rad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Cos(num1) / Math.Sin(num1);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Deg.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Cos( (num1 * Math.PI) / 180) / Math.Sin((num1 * Math.PI) / 180);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
         else if (radio_Grad.IsChecked == true)
         {
            if (txtDispl.Text != "")
            {
               num1 = double.Parse(txtDispl.Text);
               oper = 0;
               minusOrPlus = true;
               num1 = Math.Cos((num1 * Math.PI) / 200) / Math.Sin((num1 * Math.PI) / 200);
               txtDispl.Text = num1.ToString();
            }
            else
            {
               oper = 0;
               minusOrPlus = true;
            }
         }
      }


      // minus or plus flag of number
      private void btn_positiv_negativ_Click(object sender, RoutedEventArgs e)
      {
         if (minusOrPlus == true)
         {
            txtDispl.Text = "-" + txtDispl.Text;
            minusOrPlus = false;
         }
         else if (minusOrPlus == false)
         {
            txtDispl.Text = txtDispl.Text.Replace("-", "");
            minusOrPlus = true;
         }
      }
   }
}
