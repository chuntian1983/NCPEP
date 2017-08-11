using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web
{
    public partial class Sitexian : System.Web.UI.MasterPage
    {
        public string strcode = "0";
        public string strtitle = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                string id = "";
                id = Request.QueryString["id"];
                strcode = Request.QueryString["id"];
                try
                {
                    string strid = "";
                    strid = Maticsoft.DBUtility.DESEncrypt.Decrypt(Request.QueryString["id"], "wztou");

                    NCPEP.Bll.T_Wztou bll = new NCPEP.Bll.T_Wztou();
                    DataTable dt = bll.GetList("zzcode='" + strid + "'").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        imgtou.Attributes.Add("src", "upload/touimage/" + dt.Rows[0]["wztou"]);
                        strtitle = dt.Rows[0]["beizhu"].ToString();
                    }

                }
                catch { Response.Redirect("defaultxian.aspx?id=" + id + ""); }
                stra2.Attributes.Add("href", "NewsListxian.aspx?ntid=7&t=2&id=" + strcode + "");
                stra3.Attributes.Add("href", "NewsListxian.aspx?ntid=1&t=3&id=" + strcode + "");
                stra4.Attributes.Add("href", "BidListxian.aspx?t=4&id=" + strcode + "");
                stra5.Attributes.Add("href", "PlacardListxian.aspx?t=5&id=" + strcode + "");
                stra6.Attributes.Add("href", "NewsListxian.aspx?ntid=2&t=6&id=" + strcode + "");
                stra7.Attributes.Add("href", "NewsListxian.aspx?ntid=4&t=7&id=" + strcode + "");
            }
        
            if (Request.QueryString["t"] != null)
            {
                string t = Request.QueryString["t"];
                switch (t)
                {
                    case "2":
                        strli2.Attributes.Add("class", "menu_nav_ligb");
                        stra2.Attributes.Add("class", "menu_nav_white menus2");
                        
                        break;
                    case "3":
                        strli3.Attributes.Add("class", "menu_nav_ligb");
                        stra3.Attributes.Add("class", "menu_nav_white menus3");
                       
                        break;
                    case "4":
                        strli4.Attributes.Add("class", "menu_nav_ligb");
                        stra4.Attributes.Add("class", "menu_nav_white menus4");
                       
                        break;
                    case "5":
                        strli5.Attributes.Add("class", "menu_nav_ligb");
                        stra5.Attributes.Add("class", "menu_nav_white menus5");
                        
                        break;
                    case "6":
                        strli6.Attributes.Add("class", "menu_nav_ligb");
                        stra6.Attributes.Add("class", "menu_nav_white menus6");
                        
                        break;
                    case "7":
                        strli7.Attributes.Add("class", "menu_nav_ligb");
                        stra7.Attributes.Add("class", "menu_nav_white menus7");
                       
                        break;


                    default:
                        break;
                }
            }
        }
    }
}