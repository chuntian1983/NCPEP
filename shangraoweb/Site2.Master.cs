using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.DBUtility;

namespace Web
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        public string strcode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"]!=null)
            {
                try
                {
                    strcode = Maticsoft.DBUtility.DESEncrypt.Decrypt(Request.QueryString["id"], "wztou");
                }
                catch { Response.Redirect("default.aspx"); }
            }
        }
    }
}