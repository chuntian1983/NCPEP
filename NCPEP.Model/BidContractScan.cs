﻿/**
* BidContractScan.cs
*
* 类 名： BidContractScan
*
* Ver    变更日期            负责人           变更内容
* ───────────────────────────────────
* V0.01  2016-4-27 18:11:21   N/A      wanghao
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
	/// BidContractScan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BidContractScan
	{
		public BidContractScan()
		{}
		#region Model
		private int _id;
		private int _fk_bidid= 0;
		private string _scanname= string.Empty;
		private string _scanurl= string.Empty;
		private string _uploadname= string.Empty;
		private DateTime _uploaddate= DateTime.Now;
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
		public int FK_BidId
		{
			set{ _fk_bidid=value;}
			get{return _fk_bidid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ScanName
		{
			set{ _scanname=value;}
			get{return _scanname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ScanUrl
		{
			set{ _scanurl=value;}
			get{return _scanurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UploadName
		{
			set{ _uploadname=value;}
			get{return _uploadname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UploadDate
		{
			set{ _uploaddate=value;}
			get{return _uploaddate;}
		}
		#endregion Model

	}
}
