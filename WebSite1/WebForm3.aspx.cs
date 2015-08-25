using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder("<b>Username :</b>" + txtUserName.Text+"<br> <b>Password :</b>"+ txtPassword.Text);
        sb.Append("<br/><b>Address : </b>"+txtAddress.Text);
        lblSummary.Text = sb.ToString();
        
    }
}