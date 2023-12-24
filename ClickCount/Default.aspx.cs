using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DummyProject
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int cnt = Convert.ToInt32(TextBox1.Text);
            //cnt ++;
            //TextBox1.Text = cnt.ToString();
            
            if(ViewState["clicks"]!=null)
            {
                TextBox1.Text = Convert.ToString(Convert.ToInt32(ViewState["clicks"]) + 1);
            }
            else
            {
                TextBox1.Text = "1";
            }
            ViewState["clicks"] = TextBox1.Text;
        }
    }
}