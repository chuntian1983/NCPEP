using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NCPEP.Bll;
using System.Text;
using Maticsoft.Common;

namespace Web
{
    public partial class defaultxian : System.Web.UI.Page
    {
        public string p = string.Empty;
        public string l = string.Empty;
        public string t = string.Empty;
        public string tzgg;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                string id = "0";
                id = Maticsoft.DBUtility.DESEncrypt.Decrypt(Request.QueryString["id"], "wztou");
                hdcode.Value = id;
                DataTable dataTable = new WebSiteBll().GetImgList();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    p += "../newsImg/max/" + dataTable.Rows[i]["NewsImg"];
                    l += "NewsDetails.aspx?t=" + dataTable.Rows[i]["NewsTypeId"] + "&id=" + dataTable.Rows[i]["Id"];
                    t += dataTable.Rows[i]["NewsTitle"];
                    if (i < dataTable.Rows.Count - 1)
                    {
                        p += "|";
                        l += "|";
                        t += "|";
                    }
                }
                BindDll();
                BindGpRep();
                Bindxz();
                Bindzc();
                Bindbszn();
            }
        }
        protected void BindDll()
        {
            NCPEP.Bll.OrganizationBll orgbll = new OrganizationBll();
            DataTable dt = orgbll.GetAllList();
            this.ddlquyu.DataSource = dt;
            this.ddlquyu.DataTextField = "OrgShortName";
            this.ddlquyu.DataValueField = "OrgCode";
            this.ddlquyu.DataBind();
            this.ddlquyu.Items.Insert(0, new ListItem("全部"));
            NCPEP.Bll.PropertyTypeBll pbll = new PropertyTypeBll();
            DataTable dtp = pbll.GetList("");
            this.ddlleibie.DataSource = dtp;
            this.ddlleibie.DataTextField = "PropertyTypeName";
            this.ddlleibie.DataValueField = "id";
            this.ddlleibie.DataBind();
            this.ddlleibie.Items.Insert(0, new ListItem("全部"));

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string quyu, leibie, mianji, jiage;
            quyu = leibie = mianji = jiage = string.Empty;
            if (this.ddlquyu.SelectedValue != "全部")
            {
                quyu = HttpUtility.HtmlEncode(this.ddlquyu.SelectedValue);
            }
            if (this.ddlleibie.SelectedValue != "全部")
            {
                leibie = HttpUtility.HtmlEncode(this.ddlleibie.SelectedValue);
            }
            if (!string.IsNullOrEmpty(this.txtmj.Text))
            {
                mianji = HttpUtility.HtmlEncode(this.txtmj.Text);
            }
            else
            {
                MessageBox.Show(this, "请填写信息进行查询");
                return;
            }
            if (!string.IsNullOrEmpty(this.txtje.Text))
            {
                jiage = HttpUtility.HtmlEncode(this.txtje.Text);
            }
            Response.Redirect("searchlist.aspx?quyu=" + quyu + "&leibie=" + leibie + "&mianji=" + mianji + "&jiage=" + jiage + "");
        }
        protected void BindGpRep()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(" 1=1");

            NCPEP.Bll.BidBll bll = new NCPEP.Bll.BidBll();
            if (Request.QueryString["id"]!=null)
            {
                try
                {
                    string id = "";
                    id = Maticsoft.DBUtility.DESEncrypt.Decrypt(Request.QueryString["id"], "wztou");


                    DataTable ds = bll.GetListby(" DepaStatus='7' and orgcode='" + id + "'");
                    PagedDataSource ps = new PagedDataSource();
                    ps.AllowPaging = true;
                    ps.PageSize = 5;
                    ps.DataSource = ds.DefaultView;
                    ps.CurrentPageIndex = 0;
                    this.rep1.DataSource = ps;
                    this.rep1.DataBind();
                }
                catch { }
            }
        }
        protected void Bindxz()
        {
            NCPEP.Bll.OrganizationBll orgbll = new OrganizationBll();
            DataTable dt = orgbll.GetAllList();
            this.repxz.DataSource = dt;
            this.repxz.DataBind();
        }
        protected void Bindzc()
        {
            NCPEP.Bll.T_News newsbll = new T_News();
            string id = "0";
            id = Maticsoft.DBUtility.DESEncrypt.Decrypt(Request.QueryString["id"], "wztou");
            DataTable dt = newsbll.GetList(6, " NewsTypeId=2 and orgcode='"+id+"'", "CreateDate").Tables[0];
            this.repzcfg.DataSource = dt;
            this.repzcfg.DataBind();

        }
        protected void Bindbszn()
        {
            NCPEP.Bll.T_News newsbll = new T_News();
            string id = "0";
            id = Maticsoft.DBUtility.DESEncrypt.Decrypt(Request.QueryString["id"], "wztou");
            DataTable dt = newsbll.GetList(6, " NewsTypeId=4 and orgcode='"+id+"'", "CreateDate").Tables[0];
            this.repbszn.DataSource = dt;
            this.repbszn.DataBind();
            DataTable dtxw = newsbll.GetList(8, "NewsTypeId=1 and IsCheck='1' and orgcode='" + id + "'", "CreateDate").Tables[0];
            this.repxinwen.DataSource = dtxw;
            this.repxinwen.DataBind();
            DataTable dtgz = newsbll.GetList(2, "NewsTypeId=9 and orgcode='" + id + "'", "CreateDate").Tables[0];
            StringBuilder sb = new StringBuilder();
            if (dtgz.Rows.Count > 0)
            {
                for (int i = 0; i < dtgz.Rows.Count; i++)
                {
                    sb.Append("<a href=\"NewsDetails.aspx?t=9&id=" + dtgz.Rows[i]["id"] + "\">");
                    sb.Append("" + dtgz.Rows[i]["NewsTitle"] + "    ");
                    sb.Append("</a>");
                }
            }
            tzgg = sb.ToString();//"<a href=\"\">dddd</a>";
        }
    }
}