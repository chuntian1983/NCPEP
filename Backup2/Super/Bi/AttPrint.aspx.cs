using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Super.Bi
{
    public partial class AttPrint : System.Web.UI.Page
    {
        public string nian = string.Empty;
        public string yue = string.Empty;
        public string ri = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            nian = System.DateTime.Now.Year.ToString();
            yue = System.DateTime.Now.Month.ToString();
            ri = DateTime.Now.Day.ToString();
              
        }
    }
}