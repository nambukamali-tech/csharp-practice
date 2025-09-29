using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataValidation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = 0;

            if(DropDownList1.SelectedIndex == 0)
            {
                TextBox1.Text = "";
                price = 0;
            }


           else if (DropDownList1.SelectedIndex == 1)
            {
                TextBox1.Text = "Chocolates";
                price = 100;
                
            
            }
            else if(DropDownList1.SelectedIndex == 2)
            {
                TextBox1.Text = "Biscuits";
                price = 30;
               

            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                TextBox1.Text = "Brownies";
                price = 200;
               

            }
            else if (DropDownList1.SelectedIndex == 4)
            {
                TextBox1.Text = "Milk";
                price = 20;

            }
            else if (DropDownList1.SelectedIndex == 5)
            {
                TextBox1.Text = "Chocos";
                price = 10;
              


            }
                else
                {
                    // No product selected or invalid selection
                    TextBox1.Text = "";
                    TextBox2.Text = "0"; // price
                    TextBox3.Text = "";  // quantity
                    TextBox4.Text = "";  // total bill
                }
            TextBox2.Text = price.ToString();
            TextBox4.Text = "";
          
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
        
            int price = 0;
            int quantity = 0;

            // Read price and quantity from textboxes
            int.TryParse(TextBox2.Text, out price);
            int.TryParse(TextBox3.Text, out quantity);

            // Calculate total
            int total = price * quantity;
            TextBox4.Text = total.ToString();
        }

    }
}

