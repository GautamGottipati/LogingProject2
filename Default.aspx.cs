﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elmah;

namespace LogingProject2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
                /*ErrorLog.GetDefault(null).Log(new Error(ex))*/;
                ErrorSignal.FromCurrentContext().Raise(ex);

            }
        }
    }
}