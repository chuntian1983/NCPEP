﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Super
{
    public partial class Version : System.Web.UI.Page
    {
        /// <summary>
        /// 版本号
        /// </summary>
        /// <returns></returns>
        public static string Ver()
        {
            return "Ver:1.1110";
        }
        /// <summary>
        /// 版本升级说明
        /// </summary>
        protected void VersionExplain()
        {
            //Super\Scan上传附件的目录


            /*
             * 
             * 2017-1-17更新版本Ver:1.1110
             * 1.鉴证书预览修改部分对应属性字段
             * 2.添加市场受理中的流转交易申请的管理部门状态
             * 3.产权交易-协议交易中意向受让方按钮功能代码根本没实现的功能bug
             * 4.鉴证书打印调整属性显示字段
             * 
             * 
             * 
             * 
             * 2017-1-16更新版本Ver:1.1109
             * 1.添加出让申请中上传附件时如果没有指标对应关系的判断提示
             * 2.添加市场受理中的流转交易申请的管理部门状态
             * 3.产权交易-协议交易中意向受让方按钮功能代码根本没实现的功能bug
             * 4.产权交易-协议交易改为组织交易
             * 5.招标公告表T_BidPlacard添加字段fujian，fujianname
             * 6.招标公告添加附件上传功能
             * 
             * 
             * 
             * 
             * 
             * 2017-1-13更新版本Ver:1.1108
             * 1.调整数据汇总报表
             * 2.标的表T_Bid添加2个字段，是否再次流转sfzclz，受让方具备条件srfjbtj
             * 3.标的申请添加是否再次流转，受让方具备条件2个属性字段
             * 
             * 
             * 
             * 
             * 
             * 2017-1-12更新版本Ver:1.1107
             * 1.添加项目备案表
             * CREATE TABLE [dbo].[T_XmBeian](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [cqname] [varchar](150) NULL,
    [orgcode] [varchar](50) NULL,
    [cqleixing] [varchar](50) NULL,
    [guimo] [varchar](50) NULL,
    [danwei] [varchar](50) NULL,
    [cqquanshu] [varchar](50) NULL,
    [churangfang] [varchar](50) NULL,
    [churangfangxingzhi] [varchar](50) NULL,
    [shourangfang] [varchar](50) NULL,
    [shourangfangxingzhi] [varchar](50) NULL,
    [jiaoyifangshi] [varchar](50) NULL,
    [hetongksrq] [datetime] NOT NULL,
    [hetongjsrq] [datetime] NOT NULL,
    [chengjiaodanjia] [varchar](50) NULL,
    [changjiaozongjia] [nvarchar](50) NULL,
    [zhifufangshi] [varchar](50) NULL,
    [beizhu] [varchar](50) NULL,
    [beiyong] [varchar](50) NULL,
    [beiyongb] [nvarchar](50) NULL,
 CONSTRAINT [PK_T_XmBeian] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
             * 2.修改权限分配里类型选项里权限树已有权限不勾选的问题。
             * 3.前台受理添加项目备案信息管理功能。
             * 4.市场受理添加项目备案信息审核功能。
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 2017-1-11更新版本Ver:1.1106
             * 1.添加打印记录次数表
             * CREATE TABLE [dbo].[T_Dyjl](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [fid] [varchar](50) NULL,
    [dysj] [varchar](50) NULL,
    [dyr] [varchar](50) NULL,
    [dysqid] [varchar](50) NULL,
 CONSTRAINT [PK_T_Dyjl] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
             * 2.添加打印申请表
             * CREATE TABLE [dbo].[T_Dysq](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [fid] [varchar](50) NULL,
    [dycs] [varchar](50) NULL,
    [dysqnr] [varchar](500) NULL,
    [dysqsj] [varchar](50) NULL,
    [dyzt] [varchar](50) NULL,
    [beiyong] [varchar](50) NULL,
 CONSTRAINT [PK_T_Dysq] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
             * 3.添加打印状态表
             * CREATE TABLE [dbo].[T_Dyzt](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [binid] [varchar](50) NULL,
    [dyzt] [varchar](50) NULL,
 CONSTRAINT [PK_T_Dyzt] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
             * 4.产权交易鉴证书打印添加打印3次限制，超过三次需要申请。
             * 5.产权交易鉴证书打印添加打印次数超过3次的申请功能
             * 6.分管领导添加鉴证书再次打印审核通过功能
             * 7.主管领导添加鉴证书再次打印审核通过功能
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 2017-1-10更新版本Ver:1.1105
             *1.添加鉴证书修改记录表
             *CREATE TABLE [dbo].[T_Jzs](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [zcdate] [varchar](50) NULL,
    [zcdatez] [varchar](50) NULL,
    [cjje] [varchar](50) NULL,
    [htbh] [varchar](50) NULL,
    [binid] [varchar](50) NULL,
    [beizhu] [varchar](50) NULL,
    [beiyong] [varchar](50) NULL,
    [beiyong2] [varchar](50) NULL,
 CONSTRAINT [PK_T_Jzs] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
             * 2.鉴证书修改功能开发
             * 3.鉴证书生成预览功能
             * 
             * 
             * 
             * 2017-1-9更新版本Ver:1.1104
             * 1.添加附件标的出让方受让方申请表。
             * CREATE TABLE [dbo].[T_FujianBiao](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [fjname] [varchar](50) NULL,
    [fjpath] [nvarchar](150) NULL,
    [fid] [varchar](50) NULL,
    [fjlx] [varchar](50) NULL,
    [fjdynameid] [varchar](150) NULL,
 CONSTRAINT [PK_T_FujianBiao] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
             * 2.添加前台受理-标出让申请添加对应指标关系的附件进行上传功能。
             * 3.前台受理-标出让申请列表符合当前单位操作的用绿色背景醒目显示。
             * 4.添加前台受理-标意向受让申请根据指标对应关系进行附件上传功能。
             * 
             * 2017-1-5-2017-1-6更新版本Ver:1.1103
             * 1.修改前台受理-标出让申请添加功能验证的不好使的bug。
             * 2.前台受理-标出让申请添加规模和单位字段信息。
             * 3.前台受理-标出让申请列表显示所有状态信息并进行权限功能调整。
             * 4.后台添加业务办理和日常工作2个栏目对应网站首页的下载中心的2个内容模块。
             * 5.认证会员管理调整信息列表高度，调整修改添加信息窗口显示效果和大小。
             * 6.上传指标类型添加删除功能，添加显示所有信息出现滚动条。
             * 7.上传对应指标类型添加2个出让方申请，意向受让方申请2个类型，原类型出让方调整为出让备案，受让方调整为受让方备案。
             * 8.首页添加南昌市综合产权交易中微信公众号。
             * 9.修改通知公告显示政策法规的问题。
             * 10.新闻管理修改信息出现内容错位的问题。
             * 11.前台受理-出让/受让方添加反审核功能。
             * 
             * 
             * 
             * 
             * 2017-1-4更新版本Ver:1.1102
             * 1.用户管理调整代码可以看到下级组织单位的用户
             * 2.调整前台受理功能模块下面的列表因数据太少分页显示没靠下的问题
             * 3.去掉前台受理上传附件1m的文件限制。
             * 4.添加出让/受让方审核权限代码，审核成功后只能查看不能上传附件，未审核的可以上传附件。
             * 5.上传指标类型修改修改功能不好用的bug
             * 6.修改上传指标类型添加功能验证不好用的bug
             * 7.前台受理-标出让申请-录入窗口调整大小为根据分辨率自适应调整。
             * 8.调整前台受理-出让/受让方申请根据用户组织单位可以看到本级和所有下级的信息。
             * 9.网站首页兼容性bug问题调整。
             * 
             * 2016-12-30发布1.1101版本
             * 1.网站全新改版
             * 2.后台相关功能全新升级
             * 3.T_News添加ztbz，TZZT，UPDATE T_News SET ztbz='否',TZZT='否'
             * 4.添加T_Notice表
             * CREATE TABLE [dbo].[T_Notice](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [newsid] [varchar](50) NULL,
    [beizhu] [varchar](50) NULL,
 CONSTRAINT [PK_T_Notice] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
             * 5.添加试图View_notice
             * SELECT     dbo.T_News.Id, dbo.T_News.NewsTypeId, dbo.T_News.Keyword, dbo.T_News.[Content], dbo.T_News.OrgCode, dbo.T_News.NewsTitle, dbo.T_News.NewsSubheading, 
                      dbo.T_News.NewsSource, dbo.T_News.NewsContent, dbo.T_News.NewsImg, dbo.T_News.NewsFile, dbo.T_News.NumClicks, dbo.T_News.IsCheck, 
                      dbo.T_News.Editor, dbo.T_News.CreateDate, dbo.T_News.ztbz, dbo.T_News.TZZT, dbo.T_Notice.id AS noticeid
FROM         dbo.T_News INNER JOIN
                      dbo.T_Notice ON dbo.T_News.Id = dbo.T_Notice.newsid
             * 6.添加试图 View_guapai
             * SELECT     a.Id, b.OrgShortName AS OrgCode, a.OrgCode AS oCode, c.Name AS LiceTran, a.FK_LiceTranId, a.BidName, a.ListingPrice, a.StartDate, a.EndDate, a.BidBasic, 
                      a.Ownership, d.PropertyTypeName AS Properties, e.TurnOutTypeName AS TurnOut, a.RightsBodies, a.FeedingMechanism, a.WarrantNumber, 
                      f.StandardModeName AS StandardMode, g.StandardTypeName AS StandardType, a.LowTransaction, a.Turnover, a.ContractDate, a.ContractNo, a.Admissibility, 
                      a.NoAssurance, a.TradingCenterName, a.AreContract, a.RelatesNum, h.JobTypeName AS DepaStatus, a.DepaStatus AS DepaStatusId, a.ReturnStatus, a.UpManager, 
                      a.Publicity, a.Change, a.Cancel, a.Lost
FROM         dbo.T_Bid AS a LEFT OUTER JOIN
                      dbo.T_Organization AS b ON a.OrgCode = b.OrgCode LEFT OUTER JOIN
                      dbo.T_LiceTran AS c ON a.FK_LiceTranId = c.Id LEFT OUTER JOIN
                      dbo.T_PropertyType AS d ON a.Properties = d.Id LEFT OUTER JOIN
                      dbo.T_TurnOutType AS e ON a.TurnOut = e.Id LEFT OUTER JOIN
                      dbo.T_StandardMode AS f ON a.StandardMode = f.Id LEFT OUTER JOIN
                      dbo.T_StandardType AS g ON a.StandardType = g.Id LEFT OUTER JOIN
                      dbo.T_Job AS h ON a.DepaStatus = h.Id
             * 7.更新表 T_PropertyType，可以删除后执行这个生成语句
             * CREATE TABLE [dbo].[T_PropertyType](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [PropertyTypeName] [nvarchar](50) NULL,
    [Editor] [nvarchar](50) NULL,
    [CreateDate] [datetime] NULL,
 CONSTRAINT [PK_T_PropertyType] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[T_PropertyType] ON
INSERT [dbo].[T_PropertyType] ([Id], [PropertyTypeName], [Editor], [CreateDate]) VALUES (1, N'土地承包', N'SystemAdmin', CAST(0x0000A6EB009FEE22 AS DateTime))
INSERT [dbo].[T_PropertyType] ([Id], [PropertyTypeName], [Editor], [CreateDate]) VALUES (2, N'水林滩涂', N'SystemAdmin', CAST(0x0000A6EB00A002CA AS DateTime))
INSERT [dbo].[T_PropertyType] ([Id], [PropertyTypeName], [Editor], [CreateDate]) VALUES (3, N'四荒地', N'admin', CAST(0x0000A5FB011BA3FF AS DateTime))
INSERT [dbo].[T_PropertyType] ([Id], [PropertyTypeName], [Editor], [CreateDate]) VALUES (4, N'知识产权', N'SystemAdmin', CAST(0x0000A6EB00A0152A AS DateTime))
INSERT [dbo].[T_PropertyType] ([Id], [PropertyTypeName], [Editor], [CreateDate]) VALUES (5, N'其他', N'admin', CAST(0x0000A5FB011BBC8C AS DateTime))
SET IDENTITY_INSERT [dbo].[T_PropertyType] OFF

ALTER TABLE [dbo].[T_PropertyType] ADD  CONSTRAINT [DF_T_PropertyType_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 2016年11月24日 发布1.1002版本
             * 全部重新命名版本规则
             * 更新内容：受让方转让方添加pdf附件上传功能和下载查看功能
             * 
             * --------------------------------------------------------------
             * 2016年7月30日 发布0.1.0.0730_Alpha版本
             * --------------------------------------------------------------
             * 2016年7月7日 发布0.0.8.0707_Alpha版本
             * --------------------------------------------------------------
             * 2016年6月30日 发布0.0.8.0630_Alpha版本
             * --------------------------------------------------------------
             * 2016年5月30日 发布0.0.5.0530_Alpha版本
             * 1、System platform has not developed，A group of idiot eager for money。
             * --------------------------------------------------------------
             *  2016年5月1日发布 0.0.0.0版本
             * --------------------------------------------------------------
             */
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "reload", " <script>parent.location.reload();</script>");
        }
    }
}