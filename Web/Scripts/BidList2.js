jQuery(function ($) {
    OnLoadBidListClick(0);
});

var count = 0;
function OnLoadBidListClick(pageindex) {
    $.ajax({
        url: "Handler/WebSite.ashx?action=BidList",
        data: "page=" + pageindex + "&rows=20",
        type: "post",
        cache: "false",
        dataType: "json",
        beforeSend: function () { $("#showLoad").show(); },
        complete: function () { $("#showLoad").hide(); },
        error: function (XMLHttpRequest, textStatus, errorThrown) { $("#showLoad").hide(); },
        success: function (json) {
            var tbidList = "";
            if (null != json) {
                var productData = json.T;
                count = json.page.pagecount;
                $.each(productData, function (i, n) {
                    tbidList += "<tr><td class=\"th3\">HJNJ" + n.Admissibility + "</td><td class=\"th2\"><a href=\"BidDetails.aspx?t=" + n.FK_LiceTranId + "&id=" + n.Id + "\">" + n.BidName + "</a></td><td class=\"th1\">" + n.Properties + "</td><td class=\"th1\">" + n.StartDate.substring(0, 10) + "</td><td class=\"th1\">" + n.ListingPrice + "</td><td class=\"th1\">挂牌中</td><td class=\"th1\"><a href=\"\"><!--<img src=\"images/nc_30.jpg\">--></a></td></tr>";
                });
                if (0 == productData.length) { tbidList = "<li>暂无数据!</li>"; }
                $("#lblBidList").html(tbidList);
            }
            $("#Pagination").pagination(count, {
                callback: pageselectCallback,
                prev_text: '<<上一页',
                next_text: '下一页>>',
                items_per_page: 20,
                num_display_entries: 6,
                current_page: pageindex,
                num_edge_entries: 2
            });
        }
    });
};
function pageselectCallback(page_id, jq) {
    OnLoadBidListClick(page_id);
};