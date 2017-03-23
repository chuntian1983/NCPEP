<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="Scripts/Default.js" type="text/javascript" language="javascript"></script>
    <style type="text/css">
        .gs {
            line-height:40px;width:125px;
        }
        .gs2 {
            line-height:40px;width:250px;
        }
        .gsys {
            color:#e74c3c;
        }
        .tablegp {
            border-collapse:collapse;
            width:891px;
        }
        .tablegp td{
            border:0px;

        }

        .demo {width: 655px;height: 400px;font-size: 14px;position:relative;}
.demo a.control {position:absolute;display: block;top: 50%;margin-top: -78px;width: 76px;height: 112px;cursor: pointer;z-index: 2;background: url(../images/buttons.png) no-repeat}
.demo a.prev {left: 0;background-position: 0 0}
.demo a.next {right: 0;background-position: -76px 0}
.demo a.prev:hover {background-position: 0 -112px}
.demo a.next:hover {background-position: -76px -112px}
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="tz">
        <a href="NewsList.aspx?ntid=9">站点公告</a>
    </div>
    <!--热点新闻-->
    <div class="hotnews clearfix">
        <div class="hot_news_tu">
             <div class="demo">
	<a class="control prev"></a><a class="control next abs"></a><!--自定义按钮，移动端可不写-->
	<div class="slider"><!--主体结构，请用此类名调用插件，此类名可自定义-->
		<ul>
			<%=strxw %>
		</ul>
	</div>
</div>
<script src="scripts/jquery.min.js"></script>
<script src="scripts/YuxiSlider.jQuery.min.js"></script>
<script>
$(".slider").YuxiSlider({
	width:655, //容器宽度
	height:400, //容器高度
	control:$('.control'), //绑定控制按钮
	during:4000, //间隔4秒自动滑动
	speed:800, //移动速度0.8秒
	mousewheel:true, //是否开启鼠标滚轮控制
	direkey:true //是否开启左右箭头方向控制
});
</script>
            <%--<script type="text/javascript">
                var focus_width = 650;
                var focus_height = 330;
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
            </script>--%>
        </div>
        <div class="hot_news_list">
            <div class="hot_news_list_c ">
                <ul>
                    <span id="lblNewsTop"></span>
                </ul>
                <div class="more">
                    <a href="../NewsList.aspx?ntid=1">更多动态 +</a></div>
            </div>
        </div>
    </div>
    <!--系统按钮-->
    <div class="anniu clearfix">
        <ul>
            <li><a href="#" class="tdcb">土地承包</a></li>
            <li><a href="#" class="jsydjy" title="建设用地经营">建设用地</a></li>
            <li><a href="#" class="yangz">养殖</a></li>
            <li><a href="#" class="yut">鱼塘</a></li>
            <li><a href="#" class="jjdi">宅基地</a></li>
            <li><a href="#" class="jsyd">建设用地</a></li>
            <li><a href="#" class="shd">四荒地</a></li>
            <li><a href="#" class="hhld">花卉林地</a></li>
            <li><a href="#" class="zscq">知识产权</a></li>
            <li><a href="#" class="fachan">农房</a></li>
            <li><a href="#" class="nyss">农业设施</a></li>
            <li><a href="#" class="zzzm">种子种苗</a></li>
        </ul>
    </div>
    <!--挂牌公示-->
    <div class="guapai clearfix">
        <div class="guapai_list">
            <div class="guapai_tt font1 ">
                挂牌公示 <span>></span></div>
            <%--<div class="guapai_list_c1 clearfix">
                <ul>
                    <li>项目编号</li>
                    <li>标的名称</li>
                    <li>项目类型</li>
                    <li>挂牌时间</li>
                    <li>价格公告</li>
                    <li>截止时间</li>
                </ul>
            </div>
            <div id="divOut" style="overflow-y: scroll; border-bottom: 1px solid #d4ecfc">
                <div id="ShowBidList" class="tr_list">
                </div>
            </div>--%>
            <div style="width:891px; height:405px;">
                <table class="tablegp">
                    <tr style="background-color:#ebe8e8;">
                        <td  class="gs gsys">项目编号</td>
                        <td class="gs2 gsys">标的名称</td>
                        <td class="gs gsys">项目类型</td>
                        <td class="gs gsys">挂牌时间</td>
                        <td class="gs gsys">公告价格</td>
                        <td class="gs gsys">截止时间</td>
                    </tr>
                    
                    <asp:Repeater ID="repgpgs" runat="server">
                        <ItemTemplate>
                            <tr>
                        <td  class="gs">HJNS<%#Eval("Admissibility") %></td>
                        <td class="gs2"><a href="BidDetails.aspx?t=<%#Eval("FK_LiceTranId") %>&id=<%#Eval("id") %>"> <%#Eval("BidName").ToString().Length>15?Eval("bidname").ToString().Substring(0,15):Eval("bidname").ToString() %></a></td>
                                <td class="gs"><%#GetLXname(Eval("Properties").ToString()) %></td>
                        <td class="gs"><%#DateTime.Parse( Eval("StartDate").ToString()).ToString("yyyy-MM-dd") %></td>
                        
                        <td class="gs"><%#Eval("ListingPrice") %></td>
                        <td class="gs"><%#DateTime.Parse( Eval("EndDate").ToString()).ToString("yyyy-MM-dd") %></td>
                    </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
        <div class="guapai_xitong">
            <ul>
                <li><a href="<%=url1 %>" target="_blank">集体资产权属管理系统</a></li>
                <li class="cq"><a href="<%=url2 %>" target="_blank">综合产权交易系统</a></li>
                <li class="gf"><a href="<%=url3 %>" target="_blank">农村股份权能改革系统</a></li>
                <li class="fh"><a href="<%=url4 %>" target="_blank">股权分配分红查询系统</a></li>
            </ul>
            <div class="sreach">
                <p>
                    快速搜索</p>
                <div class="forms">
                    <input class="words" type="text" id="txtAdmissibility" value="请输入受审号" /><input type="button"
                        class="button" value="快速搜索" onclick="OnSelAdmissibility();" />
                </div>
            </div>
        </div>
    </div>
    <!--ad-->
    <div class="banner">
        <img src="images/banner.jpg" alt=""/>
    </div>
    <!--ad-->
    <div class="news clearfix">
        <div class="ggnews">
            <div class="guapai_tt">
                股份权能改革 <span>></span>
            </div>
            <div class="ggnews_img">
                <img src="images/ad.jpg"></div>
            <div class="ggnews_list">
                <ul>
                    <span id="lblgqgg"></span>
                </ul>
            </div>
        </div>
        <div class="yxnews">
            <div class="ggnews_tt" id="dt1" onmouseover="yxtab('dt','dtcontent','3','1')">
                意向受让信息 <span>></span>
            </div>
            <div class="yxnews_list" id="dtcontent1">
                <ul>
                    <div id="lblIntention">
                    </div>
                </ul>
            </div>
            <div class="jianju">
            </div>
            <div class="ggnews_tt" id="dt2" onmouseover="yxtab('dt','dtcontent','3','2')">
                意向转让信息 <span>></span>
            </div>
            <div class="yxnews_list" id="dtcontent2" style="display: none;">
                <ul>
                    <div id="lblIntention2">
                    </div>
                </ul>
            </div>
            <div class="jianju">
            </div>
            <div class="ggnews_tt" id="dt3" onmouseover="yxtab('dt','dtcontent','3','3')">
                抵押融资信息 <span>></span>
            </div>
            <div class="yxnews_list" id="dtcontent3" style="display: none;">
                <ul>
                    <div id="lblIntention3">
                    </div>
                </ul>
            </div>
        </div>
        <div class="banshinews">
            <div>
                办事指南</div>
                <div class="banshi">
                <ul>
                <asp:Repeater ID="repbanshi" runat="server"><ItemTemplate>
                <li><a href='NewsDetails.aspx?t=4&id=<%#Eval("id") %>'><%#Eval("NewsTitle")%></a></li>
                </ItemTemplate></asp:Repeater>
                
                </ul>
                </div>
        </div>
    </div>
    <!--分支机构-->
    <div class="jigou">
        <div class="jigou_name clearfix" id="tabs">
            <ul>
                <li>分支机构</li>
                <li id="jg1" onmouseover="shitabs('jg','jgc','3','1','choose')">
                    <% =Application["OrgShortName"] %></li>
            </ul>
        </div>
        <div class="jigou_list ">
            <div id="jgc1">
                <ul>
                    <%=fzjg %>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
