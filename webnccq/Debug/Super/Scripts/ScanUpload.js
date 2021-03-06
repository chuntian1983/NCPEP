﻿Request = {
    QueryString: function (item) {
        var svalue = location.search.match(new RegExp("[\?\&]" + item + "=([^\&]*)(\&?)", "i"));
        return svalue ? svalue[1] : svalue;
    }
};
var p = Request.QueryString("p");
jQuery(function ($) {
    var p = Request.QueryString("p");
    $("#txtFK_LiceTranId").val(p);
    $('#txtFK_UploadTypeIndicatorId').combotree({
        url: '../Ashx/LiceOrTran.ashx?' + $.param({ action: "combo", LiceTranId: p }),
        required: true,
        onSelect: function (rec) {
            rec.id;
        }
    });
});
function msgShow(title, msgString, msgType) {
    $.messager.alert(title, msgString, msgType);
}
function slide(_title, _msg) {
    $.messager.show({
        title: _title,
        msg: _msg,
        timeout: 3500,
        showType: 'slide'
    });
};
jQuery(function ($) {
    $("#btnAdd").click(function () {
        $('#forms').form('submit', {
            url: '../Ashx/LiTrScan.ashx?action=add',
            async: false,
            onSubmit: function () {
                return $(this).form('validate');
            },
            success: function (data) {
                msgShow("提示", data, "info");
                $('#txtFK_UploadTypeIndicatorId').combotree('setValue', '');
                $("#txtScanUrl").val("");
                $('#txtFK_UploadTypeIndicatorId').combotree('reload');
            }
        });
    });
});
function OnCheckImg(ControlName) {
    var imgDom = document.getElementById(ControlName);
    var location = imgDom.value;
    if (location != "") {
        var point = location.lastIndexOf(".");
        var type = location.substr(point).toLowerCase();
        if (type == ".jpg" || type == ".gif" || type == ".jpeg" || type == ".png" || type == ".pdf") {
            var imgSize = 0;
            if (window.navigator.userAgent.indexOf("Firefox") >= 1) {
                imgSize = imgDom.files[0].fileSize;
            } else {
                imgSize = imgDom.fileSize;
            }
            if (imgSize > 10240000) {
                msgShow("提示", "附件大小请不要大于10m", "info");
                return false;
            }
        }
        else {
            var afile = $("#" + ControlName);
            afile.replaceWith(afile.clone());
            msgShow("提示", "只能上传jpg,jpge,gif,png,pdf格式的附件", "info");
            return false;
        }
    }
};