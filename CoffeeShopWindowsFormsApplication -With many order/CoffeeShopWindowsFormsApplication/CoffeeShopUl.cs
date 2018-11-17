using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeShopWindowsFormsApplication
{
    public partial class CoffeeShopUl : Form
    {
        public CoffeeShopUl()
        {
            InitializeComponent();
        }
      
        List<Item> items = new List<Item>();
        double unitPrice = 0.0;        
        double total = 0;
        double total_ = 0;
        private void saveOrderButton_Click(object sender, EventArgs e)
        {
                        
            int flag = 0;                        
            string coffeeName = selectCoffeeListcomboBox.Text;
            double unit = Convert.ToDouble(unitTextBox.Text);
            

            if (selectCoffeeListcomboBox.SelectedIndex == 0)
            {
                unitPrice = 175;
            }
            if (selectCoffeeListcomboBox.SelectedIndex == 1)
            {
                unitPrice = 120;

            }
            if (selectCoffeeListcomboBox.SelectedIndex == 2)
            {
                unitPrice = 130;
            }
            if (selectCoffeeListcomboBox.SelectedIndex == 3)
            {
                unitPrice = 200;
            }
            Item addItem = new Item();          
            addItem.CoffeeName = coffeeName;
            addItem.Unit = unit;
            addItem.UnitPrice = unitPrice;            
            foreach (var item in items)
            {
                if (item.CoffeeName == coffeeName)
                {
                    flag = 1;
                    item.Unit += unit;
                    break;
                }
            }
            if (flag == 0)
            {
                items.Add(addItem);

            }
            if (items.Count == 0)
            {
                items.Add(addItem);
            }
                        
        }
                            
              private void showOrderButton_Click(object sender, EventArgs e)
        {

            string output = "Sl" + ":   " + "Item Name" + "\t" + " Unit" + "\t" + "Unit Price" + "\t" + "Sub Total" + "\n";
            output += "---------------------------------------------------------------------------" + "\n";
            int s1 = 1;           
            int contactnocount = 0;
            int coofeeitemcount = 0;
            int qtycount = 0;
            foreach (var name in items)
            {

                total_ = (name.Unit * name.UnitPrice);
                output += s1 + ":   " + name.CoffeeName+ "\t  " + name.Unit + "\t  " + name.UnitPrice + "\t                " + total_ + "\n";           
                s1++;
                contactnocount++;
                coofeeitemcount++;
                qtycount++;
            }
            total += total_;
            output += "---------------------------------------------------------------------------" + "\n" +
                        "\t\t\t" + "                Total Beli : " + total + "  /="+"\n";
            outputrichTextBox.Text = output;
                  
                  
           
            try
            {

                string customerName = customerNameTextBox.Text;
                string contactNo = contactNoTextBox.Text;
                string address = addressRichTextBox.Text;



                receptRichTextBox.Text = "JB COFFEE SHOP " + "\n" +
                                        "------------------------------ " + "\n" + "\n" + "\n" +

                                        "Customar Information :  " + "\n" +
                                        "------------------------------------ " + "\n" +

                                        "Customar Name :  " + customerName + "\n" +
                                        "Contact No :  " + contactNo + "\n" +
                                        "Address :  " + address + "\n" + "\n" +

                                        "Shopping Details :  " + "\n" +
                                        "------------------------------------" + "\n" +
                                        output+ "\n"+
                                        "--------------------------------------------------------------" + "\n\n" +

                                        "Thanks for shopping. Have a nice day".ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

   
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receptRichTextBox.Text, new Font("Arial Rounded MT Bold", 16, FontStyle.Bold),
                                                                  Brushes.Black, new PointF(100, 100));
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Text
            = contactNoTextBox.Text
            = addressRichTextBox.Text
            = selectCoffeeListcomboBox.Text
            = unitTextBox.Text 
            = receptRichTextBox.Text
            = outputrichTextBox.Text
            = " ";
        }

       

      
        
       


      

       

       

     
    }
}
