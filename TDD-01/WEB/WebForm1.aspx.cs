using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using TDD_01.WEBDATA;



namespace TDD_01.WEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int iNum1 = 0;
        int iNum2 = 0;
        Cal cal = new Cal();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {        

            if (int.TryParse(TextBox1.Text.ToString(), out iNum1) == false)
            {
                iNum1 = int.Parse(TextBox1.Text.ToString());
            }
            if (int.TryParse(TextBox2.Text.ToString(), out iNum2) == false)
            {
                iNum2 = int.Parse(TextBox2.Text.ToString());
            }


            Label2.Text = cal.CalAdd(iNum1, iNum2).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox3.Text.ToString(), out iNum1) == false)
            {
                iNum1 = int.Parse(TextBox3.Text.ToString());
            }
            if (int.TryParse(TextBox4.Text.ToString(), out iNum2) == false)
            {
                iNum2 = int.Parse(TextBox4.Text.ToString());
            }

            Label3.Text = cal.CalMin(iNum1, iNum2).ToString();
        }
    }
}