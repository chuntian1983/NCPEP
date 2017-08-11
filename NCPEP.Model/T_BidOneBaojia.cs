using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCPEP.Model
{
    /// <summary>
	/// T_BidOneBaojia:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public partial class T_BidOneBaojia
    {
        public T_BidOneBaojia()
        { }
        #region Model
        private int _bjid;
        private string _bidid;
        private string _binoneid;
        private string _bjyhm;
        private string _srfid;
        private string _beizhu;
        /// <summary>
        /// 
        /// </summary>
        public int bjid
        {
            set { _bjid = value; }
            get { return _bjid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bidid
        {
            set { _bidid = value; }
            get { return _bidid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string binoneid
        {
            set { _binoneid = value; }
            get { return _binoneid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bjyhm
        {
            set { _bjyhm = value; }
            get { return _bjyhm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string srfid
        {
            set { _srfid = value; }
            get { return _srfid; }
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
