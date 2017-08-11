using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCPEP.Model;
using NCPEP.Dal;
using System.Data;


namespace NCPEP.Bll
{
    /// <summary>
	/// T_BidOneBaojia
	/// </summary>
	public partial class T_BidOneBaojia
    {
        private readonly NCPEP.Dal.T_BidOneBaojia dal = new Dal.T_BidOneBaojia();
        public T_BidOneBaojia()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bjid)
        {
            return dal.Exists(bjid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(NCPEP.Model.T_BidOneBaojia model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(NCPEP.Model.T_BidOneBaojia model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int bjid)
        {

            return dal.Delete(bjid);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string bjidlist)
        {
            return dal.DeleteList(bjidlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public NCPEP.Model.T_BidOneBaojia GetModel(int bjid)
        {

            return dal.GetModel(bjid);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public NCPEP.Model.T_BidOneBaojia GetModelByCache(int bjid)
        //{

        //    string CacheKey = "T_BidOneBaojiaModel-" + bjid;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(bjid);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (NCPEP.Model.T_BidOneBaojia)objModel;
        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<NCPEP.Model.T_BidOneBaojia> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<NCPEP.Model.T_BidOneBaojia> DataTableToList(DataTable dt)
        {
            List<NCPEP.Model.T_BidOneBaojia> modelList = new List<NCPEP.Model.T_BidOneBaojia>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                NCPEP.Model.T_BidOneBaojia model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
