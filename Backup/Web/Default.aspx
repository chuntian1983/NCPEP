﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="Super/Scripts/easyUI/themes/default/easyui.css" rel="stylesheet" type="text/css" />
<link href="Super/Scripts/easyUI/themes/icon.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/Default.js" type="text/javascript" language="javascript"></script>
    <script src="Super/Scripts/easyUI/jquery.easyui.min.js" type="text/javascript" language="javascript"></script>
    <script src="Super/Scripts/easyUI/jquery.min.js" type="text/javascript" language="javascript"></script>
    <script src="Scripts/gundong.js" type="text/javascript" language="javascript"></script>
    <style>
        #scrollText {
 width: 800px;
 margin-right: auto;
 margin-left: auto;
 display:block;
 float:left;
  
}
.list_lh li{ padding-left:5px; height:32px; width:990px; line-height:35px;}
.list_lh li.lieven{ background:#F0F2F3;}
.sp2{ width:420px; display:inline-block;  text-align:center;}
.sp1{ width:10%; display:inline-block;  text-align:center;}
.sp5{ width:15%;display:inline-block;  text-align:center;}


.floating_ck{position:fixed;right:20px;top:30%;}
.floating_ck dl dd{position:relative;width:80px;height:80px;background-color:#646577;border-bottom:solid 1px #555666;text-align:center;background-repeat:no-repeat;background-position:center 20%;cursor:pointer;}
.floating_ck dl dd:hover{background-color:#e40231;border-bottom:solid 1px #a40324;}
.floating_ck dl dd:hover .floating_left{display:block;}
.consult,.words{background-image:url(images/icon0701/zxicon.png);}
.quote{background-image:url(images/icon0701/kficon.png);}
.qrcord{background-image:url(images/icon0701/erweima.png);}
.return{background-image:url(images/icon0701/fanhui.png);}
.floating_ck dd span{color:#fff;display:block;padding-top:54px;}
.floating_left{position:absolute;left:-160px;top:0px;width:160px;height:80px;background-color:#e40231;border-bottom:solid 1px #a40324;display:none;}
.floating_left a{color:#fff;line-height:80px;}
.floating_ewm{height:260px;top:-180px;}
.floating_ewm i{background-image:url(images/erweima2.jpg);display:block;width:145px;height:145px;margin:auto;margin-top:7px;}
.floating_ewm p{color:#fff;margin-top:5px;}
.floating_ewm .qrcord_p01{font-size:12px;line-height:20px;}
.floating_ewm .qrcord_p02{font-size:18px;}
    </style>
    <script type="text/javascript" src="Scripts/top.js"></script>
    <script type="text/javascript">
        $(document).ready(function (e) {
            ScrollText($('#scrollText'), 33, 600, '<%=tzgg %>', 'left', 1, 20); //滚动字幕
        });
		
function shitabs(fid,sid,num,active,c) {


    for (i = 1; i <= num; i++) {

	if (i==active)
	{
        document.getElementById(fid + i).className = c;
        document.getElementById(sid+ i).style.display = 'block';
		
    }
	else{
    document.getElementById(fid + i).className = "";
    document.getElementById(sid + i).style.display = 'none';
    
	 }
}
}
		
</script>

<script type="text/javascript" src="Scripts/js/jquery.js"></script>
<script type="text/javascript" src="Scripts/js/scroll.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        //$('.list_lh li:even').addClass('lieven');
    })
    $(function () {
        
        $("div.list_lh").myScroll({
            speed: 60, //数值越大，速度越慢
            rowHeight: 40 //li的高度
        });
    });
</script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <form runat="server">
 <!--服务中心-->
    <div class="sv"  id="divfuwu">
    	<div class="sv_fl">
    		<a class="sv_a" href="">业务办理（下载）</a>
    		<ul>
    			<%=zcfg %>
               
    		</ul>
    				
    	</div>
    	<div class="sv_bg"></div>
    	<div class="sv_fl fr">
    		<a class="sv_a" href="">日常工作（下载）</a>
    		<ul>
    			<%=jygz %>
    		</ul>
    		<%--<div class="sv_img"><img src="images/01.jpg"></div>--%>
    	</div>
    </div>
    <!--专题-->
     <div class="sv" style=" display:none;" id="divzhuanti">
    	<div class="zt">
    		<a class="sv_a" href="">最新专题</a>
            <div class="clearfix">
                    <%=zxzt1%>
    		</div>
    		<div>
    				<%=zxzt2%>
    		</div>
    	</div>
		<div class="sv_bg"></div>
        <div class="zt fr zt_old">
    		<a class="sv_a" href="newslist.aspx?ntid=5">往期专题</a>
    		<div class="clearfix">
    				<%=wqzt%>
    		</div>
    		<div>
    				<%=wqzt2%>
    		</div>
    	</div>
    </div> 

    <div class="main">
        <div class="tzhi">
            <a href="NewsList.aspx?ntid=9" style=" display:block; width:150px; float:left;">通知公告</a>
            <div id="scrollText"></div>
        </div>
        <div class="jj1">
        </div>
        <div class="fl">
            <div class="h_new_t">
            </div>
            <div class="h_new_c">
                <script type="text/javascript">
                    var focus_width = 640;
                    var focus_height = 340;
                    var text_height = 20;
                    var swf_height = focus_height + text_height;
                    var pics = "<%=p %>";
                    var links = "<%=l%>";
                    var texts = "<%=t%>";
                    document.write('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" width="' + focus_width + '" height="' + swf_height + '">');
                    document.write('<param name="allowScriptAccess" value="sameDomain"><param name="movie" value="Images/focus.swf"><param name="quality" value="high"><param name="bgcolor" value="#F0F0F0">');
                    document.write('<param name="menu" value="false"><param name=wmode value="opaque">');
                    document.write('<param name="FlashVars" value="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height + '">');
                    document.write('<embed src="Images/focus.swf" wmode="opaque" FlashVars="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height
                        + '" menu="false" bgcolor="#F0F0F0" quality="high" width="' + focus_width + '" height="' + swf_height + '" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />');
                    document.write('</object>');                   
                </script>
            </div>
            <div class="h_new_b">
            </div>
        </div>
        <div class="new_tab">
            <div class="clearfix new_s">
                <a href="NewsList.aspx?ntid=1" class="new_s1" id="dt1" onmouseover="shitabs('dt','dtcontent','3','1','new_s1')">新闻资讯</a><a href="NewsList.aspx?ntid=9" id="dt2" onmouseover="shitabs('dt','dtcontent','3','2','new_s1')">通知公告</a><a href="PlacardList.aspx?t=5" id="dt3" onmouseover="shitabs('dt','dtcontent','3','3','new_s1')">项目公告</a>
            </div>
            <div class="new_c" id="dtcontent1">
                <span id="lblNewsTop"></span>
                <asp:Repeater ID="repxinwen" runat=server>
                <ItemTemplate>
                <li><a target="_blank" href="NewsDetails.aspx?t=<%#Eval("NewsTypeId") %>&id=<%#Eval("id") %>"><%#Eval("NewsTitle").ToString().Length > 14 ? Eval("NewsTitle").ToString().Substring(0, 14) + ".." : Eval("NewsTitle").ToString()%></a>
                <span>[<%#DateTime.Parse(Eval("CreateDate").ToString()).ToString("yyyy-MM-dd")%>]</span>
                </li>
                </ItemTemplate>
                </asp:Repeater>
            </div>
			   <div class="new_c"  id="dtcontent2" style="display:none;">
                
                <asp:Repeater ID="repnotice" runat=server>
                <ItemTemplate>
                <li><a target="_blank" href="NewsDetails.aspx?t=<%#Eval("NewsTypeId") %>&id=<%#Eval("id") %>"><%#Eval("NewsTitle").ToString().Length > 14 ? Eval("NewsTitle").ToString().Substring(0, 14) + ".." : Eval("NewsTitle").ToString()%></a>
                <span>[<%#DateTime.Parse(Eval("CreateDate").ToString()).ToString("yyyy-MM-dd")%>]</span>
                </li>
                </ItemTemplate>
                </asp:Repeater>
             
            </div>            
            <div class="new_c"  id="dtcontent3" style="display:none;">
              <asp:Repeater ID="Repeater1" runat=server>
                <ItemTemplate>
                <li><a target="_blank" href="NewsDetails.aspx?t=<%#Eval("NewsTypeId") %>&id=<%#Eval("id") %>"><%#Eval("NewsTitle").ToString().Length > 14 ? Eval("NewsTitle").ToString().Substring(0, 14) + ".." : Eval("NewsTitle").ToString()%></a>
                <span>[<%#DateTime.Parse(Eval("CreateDate").ToString()).ToString("yyyy-MM-dd")%>]</span>
                </li>
                </ItemTemplate>
                </asp:Repeater>
            </div>
			<div><img src="images/anniu.jpg" border="0" usemap="#Map">
              <map name="Map" id="Map">
                <area shape="rect" coords="7,8,144,53" href="User/UsLogin.aspx" target="_blank" />
                <area shape="rect" coords="171,8,312,54" href="#" />
              </map>
			</div>
        </div>
    </div>
    <div class="jj1">
    </div>
    <div class="main">
        <ul class="sys">


        </ul>
    </div>
    <!--挂牌公示-->

    <div class="main">
        <div class="clearfix">
            <div class="tr_t">
            </div>
            <div class="tr_c">
                挂牌公示  <a href="BidList.aspx?t=4" target="_blank"><span class="span">更多 >></span></a></div>
            <div class="tr_b">
            </div>
        </div>
		<div class="guapai_list">
			<ul class="sys">
				<li onmouseover="shitabs('gp','divOut','5','1','choose')" id="gp1" class="choose"><span class="sys_s1" >土地承包</span></li>
				<li onmouseover="shitabs('gp','divOut','5','2','choose')" id="gp2"><span class="sys_s2">农村集体经营性资产</span></li>
				<li onmouseover="shitabs('gp','divOut','5','3','choose')" id="gp3"><span class="sys_s3">四荒地</span></li>
				<li onmouseover="shitabs('gp','divOut','5','4','choose')" id="gp4"><span class="sys_s4">知识产权</span></li>
				<li onmouseover="shitabs('gp','divOut','5','5','choose')" id="gp5"><span class="sys_s5">其它</span></li>
	
			</ul>
          
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
            <div id="divOut1"  class="list_lh" style="height: 200px;  overflow:hidden; width: 990px; border-bottom: 1px solid #d4ecfc">
               
        <ul class="ulneirong"   style=" display:block;">

        </ul>
        
            </div>
             <div id="divOut2"  class="list_lh" style="height: 200px;display:none;  overflow:hidden; width: 990px; border-bottom: 1px solid #d4ecfc">
                
        <ul class="ulneirong1"   >

        </ul>
        
            </div>
            <div id="divOut3"  class="list_lh" style="height: 200px;display:none;  overflow:hidden; width: 990px; border-bottom: 1px solid #d4ecfc">
               
       <ul   class="ulneirong2"></ul>	
        
            </div>
            <div id="divOut4"  class="list_lh" style="height: 200px;display:none;  overflow:hidden; width: 990px; border-bottom: 1px solid #d4ecfc">
               
       <ul  class="ulneirong3"></ul>
        
            </div>
           	<div id="divOut5"  class="list_lh" style="height: 200px;display:none;  overflow:hidden; width: 990px; border-bottom: 1px solid #d4ecfc">
               
       <ul  class="ulneirong4"></ul>
        
            </div>
					
			
			
        </div>
    </div>
    <div class="jj1">
    </div>
    <div class="main">
        <%=zttp %>
        
    </div>
	<div class="jj1">
    </div>
 <!--
		<div class="main">
	      <div class="fl or_c_zc1">
		     <div class="clearfix">
                <div class="tr_t">                </div>
                <div class="or_c or_c_zc">                    政策法规<a href="NewsList.aspx?ntid=2" class="zc_more">更多 ></a></div>
                <div class="tr_b">                </div>
				</div>
				 <div class="or_border2">
				     <ul>
                     <asp:Repeater ID="repzcfg" runat="server">
                     <ItemTemplate>
                     <li><a href="NewsDetails.aspx?t=2&id=<%#Eval("id") %>">· <%#Eval("NewsTitle").ToString().Length > 14 ? Eval("NewsTitle").ToString().Substring(0, 14) + ".." : Eval("NewsTitle").ToString()%></a></li>
                     </ItemTemplate>
                     </asp:Repeater>
					 
					 </ul>
				 </div>
				 
            </div>
	       <div class="fr or_c_zc1">
		       <div class="clearfix">
                <div class="tr_t">           </div>
                <div class="or_c or_c_zc">  办事指南 <a href="NewsList.aspx?ntid=4" class="zc_more">更多 ></a></div>
                <div class="tr_b">           </div>				
               </div>
			 <div class="or_border2">
				     <ul>
					<asp:Repeater ID="repbszn" runat="server">
                     <ItemTemplate>
                     <li><a href="NewsDetails.aspx?t=4&id=<%#Eval("id") %>">· <%#Eval("NewsTitle").ToString().Length > 14 ? Eval("NewsTitle").ToString().Substring(0, 14) + ".." : Eval("NewsTitle").ToString()%></a></li>
                     </ItemTemplate>
                     </asp:Repeater>
					 </ul>
				 </div>
	       </div>
	</div>
	   <div class="jj1">    </div>-->
    <div class="main">
        <div class="or">
            <div class="clearfix">
                <div class="tr_t">
                </div>
                <div class="or_c">
                    交易信息</div>
                <div class="tr_b">
                </div>
            </div>
            <div class="or_border">
                <div class="or_tab">
                    <ul>
                        <li onmouseover="tabqh(1)" class="check" id="strli1"><span class="or_tab_s1" id="strsp1"><a id="stra1"  href="../IntenList.aspx?type=1" class="xz01">
                            意向受让信息</a></span>
                            </li>
                        <li onmouseover="tabqh(2)"   id="strli2"><span class="or_tab_s2_1" id="strsp2"><a id="stra2" href="../IntenList.aspx?type=2" >意向转让信息</a></span>
                        </li>
                        <li onmouseover="tabqh(3)" id="strli3"><span class="or_tab_s3_1" id="strsp3"><a id="stra3"  href="../IntenList.aspx?type=3">抵押融资信息</a></span>
                        </li>
                    </ul>
                </div>
                <div class="or_list fl" id="strdiv1">
                    <ul><li class="bgcolor"><span class="Orange">时间</span>标题</li>
                        <div id="lblIntention">
                        </div>
                    </ul>
                </div>
                <div class="or_list fl" id="strdiv2" style=" display:none;">
                    <ul><li class="bgcolor"><span class="Orange">时间</span>标题</li>
                        <div id="lblIntention2">
                        </div>
                    </ul>
                </div>
                <div class="or_list fl" id="strdiv3" style=" display:none;">
                    <ul><li class="bgcolor"><span class="Orange">时间</span>标题</li>
                        <div id="lblIntention3">
                        </div>
                    </ul>
                </div>
            </div>
          
		  
		  <!-- 组织机构 -->
		   <div class="jj1"></div>
            <div class="clearfix">
                    <div class="tr_t"></div>
                    <div class="or_c"><ul><li class="px16">分支机构</li>
                        <li class="frist" id="jg1" onmouseover="shitabs('jg','jgc','3','1','frist')">南昌市</li> 
                        <%=fzjg1 %>
                        <%--<li id="jg2" onmouseover="shitabs('jg','jgc','3','2','frist')">南昌市1</li>
                        <li id="jg3" onmouseover="shitabs('jg','jgc','3','3','frist')">南昌市2</li>--%>
                    </ul></div>
                    <div class="tr_b"></div>
            </div>

                <div class="or_mech_list or_border">
                    <ul id="jgc1">
                    <asp:Repeater ID="repxz" runat=server><ItemTemplate><li><a href=""><%#Eval("OrgShortName")%></a></li></ItemTemplate></asp:Repeater>
                    </ul>
                    <%=fzjg2 %>
								<%--<ul  id="jgc2"  style="display:none; ">
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li><li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>
				<li><a href="">余江县</a></li>


			</ul>--%>
			
                </div>
		  
		  <!-- 组织机构结束 -->
		  
		  


        </div>
        <div class="fr">
            <div class="or_Search">
                项目查询</div>
            <div class="or_sreach_c">
           
                <div>
                    <ul>
                <!--         <li style=" display:none;">区域 :
                            <asp:DropDownList ID="ddlquyu" runat="server"  Width="195px">
                            </asp:DropDownList>
                            
                            </li>
                        <li style="display:none;" >类别 :
                            <asp:DropDownList ID="ddlleibie" runat="server"  Width="195px">
                            </asp:DropDownList>
                         </li> -->
                        <li>项目编号 : 
                            <asp:TextBox ID="txtmj" runat="server" Width="165px"></asp:TextBox></li>
                        <li>鉴证书号 :
                        <asp:TextBox ID="txtje" runat="server" Width="165px"></asp:TextBox>
                        </li>
                        <li class="center">
                            <asp:Button ID="Button1" runat="server" Text="" CssClass="button" 
                                onclick="Button1_Click" />
                                </li>
                            
                    </ul>
                </div>
            </div>
            <div class="anniu">
                <a href="User/UsLogin.aspx">意向转让申请</a></div>
            <div class="anniu">
                <a href="User/UsLogin.aspx">意向受让申请</a></div>
            <div class="anniu">
                <a href="User/UsLogin.aspx">抵押融资申请</a></div>
			<div><a href="map.aspx" target="_blank"><img src="images/map.jpg" /></a> </div>
        </div>


    <div class="main">
               

    </div>


    </div>
    <div class="floating_ck">
	<dl>
    	<dt></dt>
        
        <dd class="qrcord">
        	<span>扫一扫</span>
            <div class="floating_left floating_ewm">
            	<i></i>
                <p class="qrcord_p01">扫一扫</p>
                <p class="qrcord_p02">南昌市农村综合产权交易中心</p>
            </div>
        </dd>
        <dd class="return">
        	<span  onclick="gotoTop();return false;">返回顶部</span>
        </dd>
    </dl>
</div>
    </form>
</asp:Content>