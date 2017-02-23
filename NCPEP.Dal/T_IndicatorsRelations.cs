﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;//Please add references
using NCPEP.Model;
using System.Data.SqlClient;
using System.Data;

namespace NCPEP.Dal
{
    /// <summary>
    /// 数据访问类:T_IndicatorsRelations
    /// </summary>
    public partial class T_IndicatorsRelations
    {
        public T_IndicatorsRelations()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(NCPEP.Model.T_IndicatorsRelations model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_IndicatorsRelations(");
            strSql.Append("ApplicationType,FK_MemberTypeCertificationId,FK_TypeIndicatorNameId,Editor,CreateDate)");
            strSql.Append(" values (");
            strSql.Append("@ApplicationType,@FK_MemberTypeCertificationId,@FK_TypeIndicatorNameId,@Editor,@CreateDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ApplicationType", SqlDbType.Int,4),
					new SqlParameter("@FK_MemberTypeCertificationId", SqlDbType.Int,4),
					new SqlParameter("@FK_TypeIndicatorNameId", SqlDbType.Int,4),
					new SqlParameter("@Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateDate", SqlDbType.DateTime)};
            parameters[0].Value = model.ApplicationType;
            parameters[1].Value = model.FK_MemberTypeCertificationId;
            parameters[2].Value = model.FK_TypeIndicatorNameId;
            parameters[3].Value = model.Editor;
            parameters[4].Value = model.CreateDate;

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
        public bool Update(NCPEP.Model.T_IndicatorsRelations model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_IndicatorsRelations set ");
            strSql.Append("ApplicationType=@ApplicationType,");
            strSql.Append("FK_MemberTypeCertificationId=@FK_MemberTypeCertificationId,");
            strSql.Append("FK_TypeIndicatorNameId=@FK_TypeIndicatorNameId,");
            strSql.Append("Editor=@Editor,");
            strSql.Append("CreateDate=@CreateDate");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@ApplicationType", SqlDbType.Int,4),
					new SqlParameter("@FK_MemberTypeCertificationId", SqlDbType.Int,4),
					new SqlParameter("@FK_TypeIndicatorNameId", SqlDbType.Int,4),
					new SqlParameter("@Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.ApplicationType;
            parameters[1].Value = model.FK_MemberTypeCertificationId;
            parameters[2].Value = model.FK_TypeIndicatorNameId;
            parameters[3].Value = model.Editor;
            parameters[4].Value = model.CreateDate;
            parameters[5].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_IndicatorsRelations ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_IndicatorsRelations ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public NCPEP.Model.T_IndicatorsRelations GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,ApplicationType,FK_MemberTypeCertificationId,FK_TypeIndicatorNameId,Editor,CreateDate from T_IndicatorsRelations ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            NCPEP.Model.T_IndicatorsRelations model = new NCPEP.Model.T_IndicatorsRelations();
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
        public NCPEP.Model.T_IndicatorsRelations DataRowToModel(DataRow row)
        {
            NCPEP.Model.T_IndicatorsRelations model = new NCPEP.Model.T_IndicatorsRelations();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["ApplicationType"] != null && row["ApplicationType"].ToString() != "")
                {
                    model.ApplicationType = int.Parse(row["ApplicationType"].ToString());
                }
                if (row["FK_MemberTypeCertificationId"] != null && row["FK_MemberTypeCertificationId"].ToString() != "")
                {
                    model.FK_MemberTypeCertificationId = int.Parse(row["FK_MemberTypeCertificationId"].ToString());
                }
                if (row["FK_TypeIndicatorNameId"] != null && row["FK_TypeIndicatorNameId"].ToString() != "")
                {
                    model.FK_TypeIndicatorNameId = int.Parse(row["FK_TypeIndicatorNameId"].ToString());
                }
                if (row["Editor"] != null)
                {
                    model.Editor = row["Editor"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
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
            strSql.Append("select Id,ApplicationType,FK_MemberTypeCertificationId,FK_TypeIndicatorNameId,Editor,CreateDate ");
            strSql.Append(" FROM T_IndicatorsRelations ");
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
            strSql.Append(" Id,ApplicationType,FK_MemberTypeCertificationId,FK_TypeIndicatorNameId,Editor,CreateDate ");
            strSql.Append(" FROM T_IndicatorsRelations ");
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
            strSql.Append("select count(1) FROM T_IndicatorsRelations ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from T_IndicatorsRelations T ");
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
            parameters[0].Value = "T_IndicatorsRelations";
            parameters[1].Value = "Id";
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