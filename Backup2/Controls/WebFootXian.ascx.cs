using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Xml;
using NCPEP.Bll;
using System.Data;

namespace Web.Controls
{
    public partial class WebFootXian : System.Web.UI.UserControl
    {
        public string OrgShortName = string.Empty;
        int num = 0;
        public string strtitle;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Maticsoft.DBUtility.DESEncrypt.Decrypt(Request.QueryString["id"], "wztou");
                    NCPEP.Bll.T_Wztou bll = new NCPEP.Bll.T_Wztou();
                    DataTable dt = bll.GetList("zzcode='" + id + "'").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                       
                        strtitle = dt.Rows[0]["beizhu"].ToString();
                        lblHost.Text = strtitle + Component.ReadXml("AllTitle").InnerText;
                    }

                }
            }
        }
    }
}