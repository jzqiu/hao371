/**  版本信息模板在安装目录下，可自行修改。
* Enterprise.cs
*
* 功 能： N/A
* 类 名： Enterprise
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/11/15 23:11:32   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Hot371.Model
{
	/// <summary>
	/// Enterprise:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Enterprise
	{
		#region Model
		/// <summary>
		/// PK 自增
		/// </summary>
		public int EId
		{
			set;
			get;
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string EName
		{
			set;
			get;
		}
		/// <summary>
		/// 类型：10直招，20中介
		/// </summary>
		public int? ETypeId
		{
			set;
			get;
		}
		/// <summary>
		/// 省
		/// </summary>
		public int? ProvinceId
		{
			set;
			get;
		}
		/// <summary>
		/// 市
		/// </summary>
		public int? CityId
		{
			set;
			get;
		}
		/// <summary>
		/// 区
		/// </summary>
		public int? AreaId
		{
			set;
			get;
		}
		/// <summary>
		/// 详细地址
		/// </summary>
		public string Address
		{
			set;
			get;
		}
		/// <summary>
		/// 行业
		/// </summary>
		public int? IndustryId
		{
			set;
			get;
		}
		/// <summary>
		/// 规模
		/// </summary>
		public int? Scale
		{
			set;
			get;
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string Contact
		{
			set;
			get;
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Telephone
		{
			set;
			get;
		}
		/// <summary>
		/// 简介
		/// </summary>
		public string Introduction
		{
			set;
			get;
		}
		/// <summary>
		/// 营业执照/合作协议 地址
		/// </summary>
		public string LicenseImgUrl
		{
			set;
			get;
		}
		/// <summary>
		/// logo地址
		/// </summary>
		public string LogoUrl
		{
			set;
			get;
		}
		/// <summary>
		/// 限定发布职位数
		/// </summary>
		public int? PublishNumbers
		{
			set;
			get;
		}
		/// <summary>
		/// 企业等级
		/// </summary>
		public int? ELevel
		{
			set;
			get;
		}
		/// <summary>
		/// 挂靠父企业
		/// </summary>
		public int? ParentId
		{
			set;
			get;
		}
		/// <summary>
		/// 是否名企
		/// </summary>
		public int? IsFamous
		{
			set;
			get;
		}
		/// <summary>
		/// 名企排序
		/// </summary>
		public int? FamousSort
		{
			set;
			get;
		}
		/// <summary>
		/// 状态：0 草稿，5 等待审批，10 申请不通过，50 申请通过
		/// </summary>
		public int? Status
		{
			set;
			get;
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set;
			get;
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpateTime
		{
			set;
			get;
		}
		#endregion Model

	}
}

