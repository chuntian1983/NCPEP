using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using NCPEP.Bll;
using NCPEP.Model;

namespace Web.Super.Ashx
{
    /// <summary>
    /// Org 的摘要说明
    /// </summary>
    public class Org : IHttpHandler, IReadOnlySessionState, IRequiresSessionState
    {
        private dynamic adminUser = null;
        public void ProcessRequest(HttpContext context)
        {
            string orgcode = System.Configuration.ConfigurationManager.AppSettings["orgcode"];
            string action = context.Request.QueryString["action"].ToString();
            try
            {
                adminUser = context.Session["SuperAdminUserSession"] as AdminUser;
                if (null == adminUser)
                {
                    if (!string.IsNullOrEmpty(context.Request.Cookies["AdminCookies"].Value))
                    {
                        adminUser = new GetUserCookiesPlug().GetUserCookies(context.Request.Cookies["AdminCookies"]["SuperAdminUserCookies"]);
                        context.Session["SuperAdminUserSession"] = adminUser;
                    }
                }
            }
            catch (Exception ex)
            {
                SystemErrorPlug.ErrorRecord("时间:[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]类名:[" + this.GetType().Name + "],行号:[" + Component.GetLineNum().ToString() + "行],错误信息:[" + ex.Message + "]");
                
            }
            if (action == "tree")
            {
                NCPEP.Bll.OrganizationBll bll = new OrganizationBll();
                context.Response.Write(bll.GetTree(orgcode));
            }
            else
            {
                context.Response.Write(new OrganizationBll().ProcessRequest(context));
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}