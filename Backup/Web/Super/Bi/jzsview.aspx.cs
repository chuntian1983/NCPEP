using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NCPEP.Bll;
using NCPEP.Model;

namespace Web.Super.Bi
{
    public partial class jzsview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["p"]!=null)
            {
                NCPEP.Bll.T_Bid bllbid = new NCPEP.Bll.T_Bid();
                NCPEP.Model.T_Bid modelbid = new NCPEP.Model.T_Bid();
                modelbid = bllbid.GetModel(int.Parse(Request.QueryString["p"]));
                if (modelbid!=null)
                {
                    NCPEP.Bll.T_LiceTran blltr = new NCPEP.Bll.T_LiceTran();
                    NCPEP.Model.T_LiceTran modeltr = new NCPEP.Model.T_LiceTran();
                    modeltr = blltr.GetModel(modelbid.FK_LiceTranId);
                    lbjycp.Text = modelbid.BidName;
                    lbxmbh.Text = modelbid.Admissibility;
                    this.lbzcf.Text = modeltr.Name;
                    this.lbsyqr.Text = modeltr.Owner;
                    NCPEP.Bll.T_MemberTypeCertification bllmem = new NCPEP.Bll.T_MemberTypeCertification();
                    NCPEP.Model.T_MemberTypeCertification modelmem = new NCPEP.Model.T_MemberTypeCertification();
                    modelmem = bllmem.GetModel(modeltr.MemberTypeId);
                    if (modelmem!=null)
                    {
                        this.lbzcxwpzjg.Text = modelmem.TypeCertificationName;
                    }
                   // this.lbzcxwpzjg.Text = modeltr.MemberTypeId;
                    this.lbzcfdb.Text = modeltr.Name;
                    this.lbzcfsfz.Text = modeltr.IDCard;
                    this.lbcqlx.Text = modelbid.Properties;
                    NCPEP.Bll.T_PropertyType bllpro = new NCPEP.Bll.T_PropertyType();
                    NCPEP.Model.T_PropertyType modelpro = new NCPEP.Model.T_PropertyType();
                    modelpro = bllpro.GetModel(int.Parse(lbcqlx.Text));
                    if (modelpro!=null)
                    {
                        this.lbcqlx.Text = modelpro.PropertyTypeName;
                    }

                    NCPEP.Bll.T_BidTrans blltrans = new NCPEP.Bll.T_BidTrans();
                    DataTable dt = blltrans.GetList("FK_BidId='"+modelbid.Id+"'").Tables[0];
                    if (dt.Rows.Count>0)
                    {
                        modeltr = new NCPEP.Model.T_LiceTran();
                        modeltr = blltr.GetModel(int.Parse(dt.Rows[0]["FK_LiceTranId"].ToString()));
                        if (modeltr!=null)
                        {
                            lbsrf.Text = modeltr.Name;
                            lbsrffddbr.Text = modeltr.Owner;
                            modelmem = new NCPEP.Model.T_MemberTypeCertification();
                            modelmem=bllmem.GetModel(modeltr.MemberTypeId);
                            if (modelmem!=null)
                            {
                                lbgsxz.Text = modelmem.TypeCertificationName;
                            }
                           
                            lbzczb.Text = modeltr.Capital;
                            lbsrfsfz.Text = modeltr.IDCard;
                        }

                    }
                    lbbdjbqk.Text = modelbid.BidBasic;
                    lbzcqx.Text = "自" + DateTime.Parse(modelbid.StartDate.ToString()).ToString("yyyy年MM月dd日") + "起  至" + DateTime.Parse(modelbid.EndDate.ToString()).ToString("yyyy年MM月dd日")+"止";
                    lbqqjg.Text = modelbid.TradingCenterName;
                    lbguimo.Text = modelbid.guimo + modelbid.danwei;
                    NCPEP.Bll.T_TurnOutType bllout = new NCPEP.Bll.T_TurnOutType();
                    NCPEP.Model.T_TurnOutType modelout = new NCPEP.Model.T_TurnOutType();
                    modelout = bllout.GetModel(int.Parse(modelbid.TurnOut.ToString()));
                    if (modelout != null)
                    {
                        lbzcfs.Text = modelout.TurnOutTypeName;
                    }
                    else
                    {
                        lbzcfs.Text = modelbid.TurnOut.ToString();//转出方式
                    }
                    lbjydj.Text = "";
                    lbjyfs.Text = "";
                    DataTable dtjzs = new DataTable();
                    NCPEP.Bll.T_Jzs blljzs = new NCPEP.Bll.T_Jzs();
                    dtjzs = blljzs.GetList("binid='"+modelbid.Id+"'").Tables[0];
                    if (dtjzs.Rows.Count>0)
                    {
                        lbcjje.Text = dtjzs.Rows[0]["cjje"].ToString();
                        lbhtbh.Text = dtjzs.Rows[0]["htbh"].ToString();
                        lbbeizhu.Text = dtjzs.Rows[0]["beizhu"].ToString();
                        try
                        {
                            lbhtqsrq.Text = dtjzs.Rows[0]["beiyong"].ToString();
                        }
                        catch { }
                    }
                    lbnian.Text = System.DateTime.Now.Year.ToString();
                    lbyue.Text = System.DateTime.Now.Month.ToString();
                    lbri.Text = System.DateTime.Now.Day.ToString();
                    
                }
            }
        }
    }
}