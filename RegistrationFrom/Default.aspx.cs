﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void btnCreateAccount_Click(object sender, EventArgs e) {
        ClientScript.RegisterStartupScript(GetType(), "onClick", "<script>alert('account created');</script>");
    }
}