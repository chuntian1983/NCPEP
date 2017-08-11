using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace NCPEP.Dal
{
    /// <summary>
	/// 数据访问类:T_BidOneBaojia
	/// </summary>
	public partial class T_BidOneBaojia
    {
        public T_BidOneBaojia()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bjid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_BidOneBaojia");
            strSql.Append(" where bjid=@bjid");
            SqlParameter[] parameters = {
                    new SqlParameter("@bjid", SqlDbType.Int,4)
            };
            parameters[0].Value = bjid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(NCPEP.Model.T_BidOneBaojia model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_BidOneBaojia(");
            strSql.Append("bidid,binoneid,bjyhm,srfid,beizhu)");
            strSql.Append(" values (");
            strSql.Append("@bidid,@binoneid,@bjyhm,@srfid,@beizhu)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@bidid", SqlDbType.VarChar,50),
                    new SqlParameter("@binoneid", SqlDbType.VarChar,50),
                    new SqlParameter("@bjyhm", SqlDbType.NVarChar,50),
                    new SqlParameter("@srfid", SqlDbType.NVarChar,50),
                    new SqlParameter("@beizhu", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.bidid;
            parameters[1].Value = model.binoneid;
            parameters[2].Value = model.bjyhm;
            parameters[3].Value = model.srfid;
            parameters[4].Value = model.beizhu;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(NCPEP.Model.T_BidOneBaojia model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_BidOneBaojia set ");
            strSql.Append("bidid=@bidid,");
            strSql.Append("binoneid=@binoneid,");
            strSql.Append("bjyhm=@bjyhm,");
            strSql.Append("srfid=@srfid,");
            strSql.Append("beizhu=@beizhu");
            strSql.Append(" where bjid=@bjid");
            SqlParameter[] parameters = {
                    new SqlParameter("@bidid", SqlDbType.VarChar,50),
                    new SqlParameter("@binoneid", SqlDbType.VarChar,50),
                    new SqlParameter("@bjyhm", SqlDbType.NVarChar,50),
                    new SqlParameter("@srfid", SqlDbType.NVarChar,50),
                    new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
                    new SqlParameter("@bjid", SqlDbType.Int,4)};
            parameters[0].Value = model.bidid;
            parameters[1].Value = model.binoneid;
            parameters[2].Value = model.bjyhm;
            parameters[3].Value = model.srfid;
            parameters[4].Value = model.beizhu;
            parameters[5].Value = model.bjid;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int bjid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_BidOneBaojia ");
            strSql.Append(" where bjid=@bjid");
            SqlParameter[] parameters = {
                    new SqlParameter("@bjid", SqlDbType.Int,4)
            };
            parameters[0].Value = bjid;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string bjidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_BidOneBaojia ");
            strSql.Append(" where bjid in (" + bjidlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public NCPEP.Model.T_BidOneBaojia GetModel(int bjid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 bjid,bidid,binoneid,bjyhm,srfid,beizhu from T_BidOneBaojia ");
            strSql.Append(" where bjid=@bjid");
            SqlParameter[] parameters = {
                    new SqlParameter("@bjid", SqlDbType.Int,4)
            };
            parameters[0].Value = bjid;

            NCPEP.Model.T_BidOneBaojia model = new NCPEP.Model.T_BidOneBaojia();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public NCPEP.Model.T_BidOneBaojia DataRowToModel(DataRow row)
        {
            NCPEP.Model.T_BidOneBaojia model = new NCPEP.Model.T_BidOneBaojia();
            if (row != null)
            {
                if (row["bjid"] != null && row["bjid"].ToString() != "")
                {
                    model.bjid = int.Parse(row["bjid"].ToString());
                }
                if (row["bidid"] != null)
                {
                    model.bidid = row["bidid"].ToString();
                }
                if (row["binoneid"] != null)
                {
                    model.binoneid = row["binoneid"].ToString();
                }
                if (row["bjyhm"] != null)
                {
                    model.bjyhm = row["bjyhm"].ToString();
                }
                if (row["srfid"] != null)
                {
                    model.srfid = row["srfid"].ToString();
                }
                if (row["beizhu"] != null)
                {
                    model.beizhu = row["beizhu"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select bjid,bidid,binoneid,bjyhm,srfid,beizhu ");
            strSql.Append(" FROM T_BidOneBaojia ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" bjid,bidid,binoneid,bjyhm,srfid,beizhu ");
            strSql.Append(" FROM T_BidOneBaojia ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_BidOneBaojia ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.bjid desc");
            }
            strSql.Append(")AS Row, T.*  from T_BidOneBaojia T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_BidOneBaojia";
			parameters[1].Value = "bjid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
