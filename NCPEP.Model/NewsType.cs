﻿/**
* NewsType.cs
*
* 类 名： NewsType
*
* Ver    变更日期            负责人           变更内容
* ───────────────────────────────────
* V0.01  2016-4-27 18:11:32   N/A      wanghao
*
* Copyright (c) wanghao Corporation. All rights reserved.
*┌───────────────────────────────────┐
*│　此代码信息为机密信息             │
*│  未经书面同意禁止向第三方披露     │
*│　设计研发：wanghao　　　　　　　　 │
*└───────────────────────────────────┘
*/
using System;
namespace NCPEP.Model
{
	/// <summary>
	/// NewsType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NewsType
	{
		public NewsType()
		{}
		#region Model
		private int _id;
		private string _newstypename= string.Empty;
		private string _editor= string.Empty;
		private DateTime _createdate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsTypeName
		{
			set{ _newstypename=value;}
			get{return _newstypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Editor
		{
			set{ _editor=value;}
			get{return _editor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		#endregion Model

	}
}
