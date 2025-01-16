using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo1
{
    public partial class multiview_controll : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(view2);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(view1);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(view3);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(view2);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}