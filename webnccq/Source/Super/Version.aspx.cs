﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Super
{
    public partial class Version : System.Web.UI.Page
    {
        /// <summary>
        /// 版本号
        /// </summary>
        /// <returns></returns>
        public static string Ver()
        {
            return "Ver:1.1002";
        }
        /// <summary>
        /// 版本升级说明
        /// </summary>
        protected void VersionExplain()
        {
            /*
             * 2016年11月24日 发布1.1002版本
             * 全部重新命名版本规则
             * 更新内容：受让方转让方添加pdf附件上传功能和下载查看功能
             * 
             * --------------------------------------------------------------
             * 2016年7月30日 发布0.1.0.0730_Alpha版本
             * --------------------------------------------------------------
             * 2016年7月7日 发布0.0.8.0707_Alpha版本
             * --------------------------------------------------------------
             * 2016年6月30日 发布0.0.8.0630_Alpha版本
             * --------------------------------------------------------------
             * 2016年5月30日 发布0.0.5.0530_Alpha版本
             * 1、System platform has not developed，A group of idiot eager for money。
             * --------------------------------------------------------------
             *  2016年5月1日发布 0.0.0.0版本
             * --------------------------------------------------------------
             */
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "reload", " <script>parent.location.reload();</script>");
        }
    }
}