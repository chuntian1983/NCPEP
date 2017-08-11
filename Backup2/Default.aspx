<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.master" AutoEventWireup="true"
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
    </style>
    <script type="text/javascript">
        $(document).ready(function (e) {
            ScrollText($('#scrollText'), 33, 600, '<%=tzgg %>', 'left', 1, 20); //滚动字幕
        });
</script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<form runat="server">
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
                    var focus_width = 695;
                    var focus_height = 320;
                    var text_height = 40;
                    var swf_height = focus_height + text_height;
                    var pics = "<%=p %>";
                    var links = "<%=l%>";
                    var texts = "<%=t%>";
                    document.write('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" width="' + focus_width + '" height="' + swf_height + '">');
                    document.write('<param name="allowScriptAccess" value="sameDomain"><param name="movie" value="Images/focus.swf"><param name="quality" value="high"><param name="bgcolor" value="#F0F0F0">');
                    document.write('<param name="menu" value="false"><param name=wmode value="opaque">');
                    document.write('<param name="FlashVars" value="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height + '">');
                    document.write('<embed src="Images/focus.swf" wmode="opaque" FlashVars="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height
                        + '" menu="false" bgcolor="#F0F0F0" quality="high" width="' + focus_width + '" height="' + focus_height + '" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />');
                    document.write('</object>');                   
                </script>
            </div>
            <div class="h_new_b">
            </div>
        </div>
        <div class="new_tab">
            <div class="clearfix new_s">
                <a href="NewsList.aspx?ntid=1" class="new_s1">新闻资讯</a><a href="NewsList.aspx?ntid=9">通知公告</a><a href="PlacardList.aspx?t=5">项目公告</a>
            </div>
            <div class="new_c">
                <span id="lblNewsTop"></span>
                <asp:Repeater ID="repxinwen" runat=server>
                <ItemTemplate>
                <li><a href="NewsDetails.aspx?t=<%#Eval("NewsTypeId") %>&id=<%#Eval("id") %>"><%#Eval("NewsTitle").ToString().Length > 14 ? Eval("NewsTitle").ToString().Substring(0, 14) + ".." : Eval("NewsTitle").ToString()%></a>
                <span>[<%#DateTime.Parse(Eval("CreateDate").ToString()).ToString("yyyy-MM-dd")%>]</span>
                </li>
                </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
    <div class="jj1">
    </div>
    <div class="main">
        <ul class="sys">
            <li><span class="sys_s1">土地承包</span></li>
            <li><span class="sys_s2">水林滩涂</span></li>
            <li><span class="sys_s3">四荒地</span></li>
            <li><span class="sys_s4">知识产权</span></li>
            <li><span class="sys_s5">其它</span></li>
            <li><span class="sys_s6">分支机构</span></li>
            <li><span class="sys_s8">部门电话</span></li>
            <li><img src="images/login.jpg" alt="" border="0" usemap="#Map"  />
                <map name="Map" id="Map">
                  <area shape="rect" coords="17,5,114,73" href="Super/Default.aspx" target="_blank" />
                  <area shape="rect" coords="157,10,235,74" href="http://10.161.145.113:8002" target="_blank" />
                </map></li>
        </ul>
    </div>
    <!--挂牌公示-->
    <div class="jj1">
    </div>
    <div class="main">
        <div class="clearfix">
            <div class="tr_t">
            </div>
            <div class="tr_c">
                挂牌公示</div>
            <div class="tr_b">
            </div>
        </div>
        <div>
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
            <div id="divOut" style="height: 200px; overflow-y: scroll; width: 990px; border-bottom: 1px solid #d4ecfc">
                <%--<div id="ShowBidList">
                </div>--%>
                <table id="ShowBidList" class="tr_list">
            </table>
            </div>
        </div>
    </div>
    <div class="jj1">
    </div>
    <div class="main">
        <img src="../images/ban.jpg" />
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
                        <li class="check" id="strli1"><span class="or_tab_s1" id="strsp1"><a id="stra1" onmouseover="tabqh(1)" href="../IntenList.aspx?type=1" class="xz01">
                            意向受让信息</a></span>
                            </li>
                        <li   id="strli2"><span class="or_tab_s2_1" id="strsp2"><a id="stra2" onmouseover="tabqh(2)" href="../IntenList.aspx?type=2" >意向转让信息</a></span>
                        </li>
                        <li id="strli3"><span class="or_tab_s3_1" id="strsp3"><a id="stra3" onmouseover="tabqh(3)" href="../IntenList.aspx?type=3">抵押融资信息</a></span>
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



        </div>
        <div class="fr">
            <div class="or_Search">
                项目查询</div>
            <div class="or_sreach_c">
           
                <div>
                    <ul>
                        <li style=" display:none;">区域 :
                            <asp:DropDownList ID="ddlquyu" runat="server"  Width="195px">
                            </asp:DropDownList>
                            
                            </li>
                        <li style="display:none;" >类别 :
                            <asp:DropDownList ID="ddlleibie" runat="server"  Width="195px">
                            </asp:DropDownList>
                         </li>
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
        </div>



        
    <div class="main">
        <div class="jj1"></div>
        <div class="clearfix">
            <div class="tr_t"></div>
            <div class="tr_c">交易项目</div>
            <div class="tr_b"></div>
        </div>
        <div>
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
                    
                </tr>
                 <asp:Repeater runat=server ID="rep1"><ItemTemplate>
                                                           <tr>
                                                           <td>&nbsp;&nbsp;&nbsp;&nbsp;HJNS<%#Eval("Admissibility")%></td>
                                                           <td><a href='BidDetails.aspx?id=<%#Eval("id")%>' target="_blank"> <%#Eval("BidName")%></a></td>
                                                           <td><%#Eval("PropertyTypeName")%></td>
                                                           
                                                           </tr>
                                                           </ItemTemplate>
                                                           </asp:Repeater>
            </table>
        </div>
    </div>

    <div class="main">
                <div class="jj1"></div>
            <div class="clearfix">
                    <div class="tr_t"></div>
                    <div class="tr_c"><ul><li class="px16">分支机构</li>
                        <li class="frist">上饶市</li>
                    </ul></div>
                    <div class="tr_b"></div>
            </div>
            <div class="or_border">
                <div class="or_mech_list or_border">
                    <ul>
                    <%=sborg.ToString() %>
                        <%--<li ><a href="http://10.161.145.114:8002" target="_blank">信州区</a> </li>
                        <li ><a href="http://10.161.145.114:8003" target="_blank">广丰区</a> </li>
                        <li ><a href="http://10.161.145.114:8004" target="_blank">上饶县</a> </li>
                        <li ><a href="http://10.161.145.114:8005" target="_blank">玉山县</a> </li>
                        <li ><a href="http://10.161.145.114:8006" target="_blank">铅山县</a> </li>
                        <li ><a href="http://10.161.145.114:8007" target="_blank">弋阳县</a> </li>
                        <li ><a href="http://10.161.145.114:8008" target="_blank">横峰县</a> </li>
                        <li ><a href="http://10.161.145.114:8009" target="_blank">德兴市</a> </li>
                        <li ><a href="http://10.161.145.114:8010" target="_blank">婺源县</a> </li>
                        <li ><a href="http://10.161.145.114:8011" target="_blank">鄱阳县</a> </li>
                        <li ><a href="http://10.161.145.114:8012" target="_blank">余干县</a> </li>
                        <li ><a href="http://10.161.145.114:8013" target="_blank">万年县</a> </li>
                        <li ><a href="http://10.161.145.114:8014" target="_blank">经开区</a> </li>
                        <li style="width:90px;" ><a href="http://10.161.145.114:8015" target="_blank">三清山管委会</a> </li>--%>
                    </ul>
                </div>
                
            </div>
                <div class="or_mech_list or_border" style=" display:none;">
                    <ul>
                    <asp:Repeater ID="repxz" runat=server><ItemTemplate><li><a href=""><%#Eval("OrgShortName")%></a></li></ItemTemplate></asp:Repeater>
                       
                    </ul>
                </div>

    </div>


    </div>
    </form>
</asp:Content>
