﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Attributes.Add("onClick", "ExibeMensagem()");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}