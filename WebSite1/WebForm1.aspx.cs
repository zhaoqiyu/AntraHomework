using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox txt = new TextBox();
        txt.ID = "mytxt";
       
        txt.Width= 300;
        txt.Text="Dynamically added";
        this.Page.Form.Controls.Add(txt);
    }

    protected void Page_Init(object sender, EventArgs e)
    { 
    
    }
}