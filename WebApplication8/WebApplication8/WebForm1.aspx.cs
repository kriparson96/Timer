﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8

{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int hh, mm, ss;

        static double TimeAllSecondes = 10;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (TimeAllSecondes > 0)
            {
                TimeAllSecondes = TimeAllSecondes - 1;
                     TimeSpan time_Span = TimeSpan.FromSeconds(TimeAllSecondes);
                hh = time_Span.Hours;
                mm = time_Span.Minutes;
                ss = time_Span.Seconds;

                Label2.Text = "  " + hh + ":" + mm + ":" + ss;

            }
            else
            {
                Label2.Text = "Time's up!!";
            }
           
           
        }
           
    }
}