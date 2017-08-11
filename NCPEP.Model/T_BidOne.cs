using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCPEP.Model
{
    /// <summary>
	/// T_BidOne:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public partial class T_BidOne
    {
        public T_BidOne()
        { }
        #region Model
        private int _oneid;
        private string _binid;
        private string _jssj;
        private string _beizhu;
        /// <summary>
        /// 
        /// </summary>
        public int oneid
        {
            set { _oneid = value; }
            get { return _oneid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string binid
        {
            set { _binid = value; }
            get { return _binid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string jssj
        {
            set { _jssj = value; }
            get { return _jssj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beizhu
        {
            set { _beizhu = value; }
            get { return _beizhu; }
        }
        #endregion Model

    }
}
