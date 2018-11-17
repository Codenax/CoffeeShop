using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeOderWindowsFormsApplication
{
    public partial class CoffeeOrderUl : Form
    {
        public CoffeeOrderUl()
        {
            InitializeComponent();
        }


        List<string> customarNameList = new List<string>();
        List<string> uniteList = new List<string>();
        private void oderButton_Click(object sender, EventArgs e)
        {
            string cusName = coffeeNamecomboBox.Text;
            customarNameList.Add(cusName);
            string unite_L= unitTextBox.Text;
            uniteList.Add(unite_L);
        }
            
       
        private void buyButton_Click(object sender, EventArgs e)
        {

            string result = "Name";
            int unite = 0;
           
            
            foreach (string cusName in customarNameList)
            {
                result += cusName + "\t" + uniteList[unite] + "\n";
                unite++;
            }
            receptRichTextBox.Text = result;                   
         }

    }
}
