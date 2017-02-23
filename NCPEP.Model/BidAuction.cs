﻿/**
* BidAuction.cs
*
* 类 名： BidAuction
*
* Ver    变更日期            负责人           变更内容
* ───────────────────────────────────
* V0.01  2016-4-27 18:11:19   N/A      wanghao
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
	/// BidAuction:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BidAuction
	{
		public BidAuction()
		{}
		#region Model
		private int _id;
		private int _fk_bidid=0;
		private int _licetranid=0;
		private int _severalbid=0;
		private decimal _price=0;
		private DateTime _auctiondate= DateTime.Now;
        private string _editor = string.Empty;
        private DateTime _createdate = DateTime.Now;
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
		public int LiceTranId
		{
			set{ _licetranid=value;}
			get{return _licetranid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SeveralBid
		{
			set{ _severalbid=value;}
			get{return _severalbid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AuctionDate
		{
			set{ _auctiondate=value;}
			get{return _auctiondate;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string Editor
        {
            set { _editor = value; }
            get { return _editor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
		#endregion Model

	}
}
