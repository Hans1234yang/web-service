using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_service尝试
{
    public partial class web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //调用方法
            ServiceReference1.WebService1SoapClient test = new ServiceReference1.WebService1SoapClient();
            int i = int.Parse(TextBox1.Text);
            int j = int.Parse(TextBox2.Text);


            int result = test.Add(i, j);

            TextBox3.Text = result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(TextBox4.Text);
            int j = int.Parse(TextBox5.Text);
            ServiceReference1.WebService1SoapClient test = new ServiceReference1.WebService1SoapClient();

            int result = test.JianFa(i,j);
            TextBox6.Text = result.ToString();
               
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int i  = int.Parse( TextBox7.Text);
            int j = int.Parse(TextBox8.Text);
            ServiceReference1.WebService1SoapClient test = new ServiceReference1.WebService1SoapClient();
            int reslut = test.ChengFa(i, j);

            TextBox9.Text = reslut.ToString();
        }
    }
}