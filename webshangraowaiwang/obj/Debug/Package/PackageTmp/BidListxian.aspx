﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Sitexian.Master" AutoEventWireup="true" CodeBehind="BidListxian.aspx.cs" Inherits="Web.BidListxian" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link type="text/css" href="Styles/pagination.css" rel="stylesheet" />
    <script src="Scripts/jquery.pagination.js" type="text/javascript" language="javascript"></script>
    <script src="Scripts/BidList.js" type="text/javascript" language="javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="showLoad" style="display: none; position: absolute; top: 0%; left: 0%; width: 100%;
        height: 100%; background-color: #F6F6F6; z-index: 1001; -moz-opacity: 0.8; opacity: 0.8;
        filter: alpha(opacity=80);">
        <div style="top: 50%; right: 40%; position: absolute; padding: 0px; margin: 0px;
            z-index: 999; border-color: #94BEE7; border-style: solid; border-width: 2px;">
            <img src="Images/ajax_loading.gif" alt="正在加载" align="middle" /><span style="color: Red;
                font-size: 16px; font-weight: bold;">正在加载数据中。。。。。。</span>
        </div>
    </div>
    <div class="list_wz top">
        位置：<a href="../Default.aspx">首页</a> >> 交易项目
    </div>
    <div class="list top">
        <div class="gplist">
            <table class="tr_list">
                <tr>
                    <th class="th3">
                        项目编号
                    </th>
                    <th class="th2">
                        标的名称
                    </th>
                    <th class="th1">
                        项目类型
                    </th>
                    <th class="th1">
                        挂牌时间
                    </th>
                    <th class="th1">
                        公告价格
                    </th>
                    <th class="th1">
                        截止时间
                    </th>
                </tr>
                
            </table>
            <table id="lblBidList" class="tr_list">
            </table>
            
        </div>
        <div>
            <div id="Pagination" class="flickr">
            </div>
        </div>
    </div>
</asp:Content>
