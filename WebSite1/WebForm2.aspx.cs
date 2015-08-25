using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            lblError.Text = "";
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);
            int c = a + b;

            txtResult.Text = c.ToString();
        }
        catch (Exception ex)
        {
            lblError.Text = "Invalid Inputs";
        }
    }
    protected void btnSubtract_Click(object sender, EventArgs e)
    {
        try
        {
            lblError.Text = "";
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);
            int c = a - b;

            txtResult.Text = c.ToString();
        }
        catch (Exception ex)
        {
            lblError.Text = "Invalid Inputs";
        }
    }
}