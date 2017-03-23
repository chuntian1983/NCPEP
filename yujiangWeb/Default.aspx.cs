using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NCPEP.Bll;
using System.Configuration;

namespace Web
{
    public partial class _Default : System.Web.UI.Page
    {
        public string p = string.Empty;
        public string l = string.Empty;
        public string t = string.Empty;
        public string url1, url2, url3, url4;
        public string fzjg;
        public string strxw = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            url1 = System.Configuration.ConfigurationManager.AppSettings["url1"];
            url2 = System.Configuration.ConfigurationManager.AppSettings["url2"];
            url3 = System.Configuration.ConfigurationManager.AppSettings["url3"];
            url4 = System.Configuration.ConfigurationManager.AppSettings["url4"];
            if (!IsPostBack)
            {
                DataTable dataTable = new WebSiteBll().GetImgList();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    //p += "../newsImg/max/" + dataTable.Rows[i]["NewsImg"];
                    //l += "NewsDetails.aspx?t=" + dataTable.Rows[i]["NewsTypeId"] + "&id=" + dataTable.Rows[i]["Id"];
                    //t += dataTable.Rows[i]["NewsTitle"];
                    if (i < dataTable.Rows.Count - 1)
                    {
                        //p += "|";
                        //l += "|";
                        //t += "|";
                        string strimg = "../newsImg/max/" + dataTable.Rows[i]["NewsImg"];
                        strxw += "<li><a target=\"_blank\" href=\"NewsDetails.aspx?t=" + dataTable.Rows[i]["NewsTypeId"] + "&id=" + dataTable.Rows[i]["Id"] + "\"><img src=\"" + strimg + "\" alt=\"" + dataTable.Rows[i]["NewsTitle"] + "\" /></a></li>";
                    }
                }
                BindBanshi();
               
            }
            BindGp();
            Getfzjg();
        }
        protected void BindBanshi()
        {
            NCPEP.Bll.T_News bllnews = new T_News();
            DataTable dt = bllnews.GetList(9, " NewsTypeId='4' and IsCheck=1", "id").Tables[0];

            this.repbanshi.DataSource = dt;
            this.repbanshi.DataBind();
        }
        protected void BindGp()
        {
            NCPEP.Bll.T_Bid bll = new T_Bid();
            DataTable dt = bll.GetList(6," DepaStatus='3'"," id desc").Tables[0];
            if (dt.Rows.Count>0)
            {
                this.repgpgs.DataSource = dt;
                this.repgpgs.DataBind();
            }
        }
        public string GetLXname(string lxid)
        {
            NCPEP.Bll.T_PropertyType bll = new T_PropertyType();
            NCPEP.Model.T_PropertyType model = new NCPEP.Model.T_PropertyType();
            model = bll.GetModel(int.Parse(lxid));
            return model.PropertyTypeName;
        }
        protected void Getfzjg()
        {
            fzjg = "";
            string strcode = System.Configuration.ConfigurationManager.AppSettings["orgcode"];
            NCPEP.Bll.T_Organization bll = new T_Organization();
            DataTable dt = bll.GetList("uporgcode='"+strcode +"'").Tables[0];
            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    fzjg += "<li><span>·</span><a href=\"#\">" + dr["orgshortname"] + "</a></li>";
                }
            }
            
        }
    }
}
