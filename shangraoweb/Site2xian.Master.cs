using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.DBUtility;
using System.Data;

namespace Web
{
    public partial class Site2xian : System.Web.UI.MasterPage
    {
        public string strtitle = "";
        public string strcode = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"]!=null)
            {
                try
                {
                    string id = "";
                    id =Maticsoft.DBUtility.DESEncrypt.Decrypt( Request.QueryString["id"],"wztou");
                    strcode = Request.QueryString["id"];
                    NCPEP.Bll.T_Wztou bll = new NCPEP.Bll.T_Wztou();
                    DataTable dt = bll.GetList("zzcode='" + id + "'").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        imgtou.Attributes.Add("src", "upload/touimage/" + dt.Rows[0]["wztou"]);
                        strtitle = dt.Rows[0]["beizhu"].ToString();
                    }

                }
                catch { Response.Redirect("default.aspx"); }
            }
        }
    }
}