﻿function msgShow(title, msgString, msgType) {
    $.messager.alert(title, msgString, msgType);
};
function slide(_title, _msg) {
    $.messager.show({
        title: _title,
        msg: _msg,
        timeout: 3500,
        showType: 'slide'
    });
};
jQuery(function ($) {
    GridView();
    $('#newAdd').window('close');
});
function GridView() {
    $('#tdg').datagrid({
        title: '转出方式信息列表',
        iconCls: 'icon-save',
        nowrap: true,
        striped: true,
        url: '../ashx/TurnOutType.ashx?action=paging',
        remoteSort: false,
        sortName: 'Id',
        singleSelect: true,
        sortOrder: 'asc',
        fit: true,
        fitColumns: true,
        rownumbers: true,
        frozenColumns: [[
{ title: '编号', field: 'Id', width: 50, align: 'left', sortable: true },
{ field: 'TurnOutTypeName', title: '转出方式名称', width: 150, align: 'left', sortable: true },
{ field: 'CreateDate', title: '创建时间', width: 150, align: 'left', sortable: true }
]],
        toolbar: [{
            id: 'btnadd',
            text: '新建',
            iconCls: 'icon-add',
            handler: function () {
                $('#newAdd').window({ title: "添加转出方式信息" });
                $("#newAdd").window("open");
                $("#btnAdd").show();
                $("#btnEdit").hide();
                EmptyTextClick();
            }
        }, '-', {
            id: 'btncut',
            text: '修改',
            iconCls: 'icon-cut',
            handler: function () {
                var rows = $('#tdg').datagrid('getSelections');
                if (rows.length > 0) {
                    if (rows.length > 1) {
                        msgShow("提示", "修改信息只能选中一条！", "warning");
                        return;
                    }
                    $('#newAdd').window({ title: "修改转出方式信息" });
                    $('#newAdd').window('open');
                    EmptyTextClick();
                    $.get("../ashx/TurnOutType.ashx?action=by", { Id: rows[0].Id }, function (data) {
                        $("#txtId").val(data.Id);
                        $("#txtTurnOutTypeName").val(data.TurnOutTypeName);
                    }, "json");
                    $("#btnAdd").hide();
                    $("#btnEdit").show();
                } else {
                    msgShow("提示", "您还没有选中要修改的列信息？", "warning");
                }
            }
        }
],
        pagination: false
    });
    var p = $('#tdg').datagrid('getPager');
    $(p).pagination({
        onBeforeRefresh: function () {
        }
    });
};
function EmptyTextClick() {
    $("#txtId").val("");
    $("#txtTurnOutTypeName").val("");
};
jQuery(function ($) {
    $("#btnCancel").click(function () {
        EmptyTextClick();
        $('#newAdd').window('close');
    });
});
jQuery(function ($) {
    $("#btnEdit").click(function () { OnUpdateClick(); });
});
function OnUpdateClick() {
    $('#forms').form('submit', {
        url: '../ashx/TurnOutType.ashx?action=up',
        async: false,
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (data) {
            msgShow("提示", data, "info");
            $('#tdg').datagrid('reload');
        }
    });
    EmptyTextClick();
    $('#newAdd').window('close');
};
jQuery(function ($) {
    $("#btnAdd").click(function () { OnCreateClick(); });
});
function OnCreateClick() {
    $('#forms').form('submit', {
        url: '../ashx/TurnOutType.ashx?action=add',
        async: false,
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (data) {
            msgShow("提示", data, "info");
            $('#tdg').datagrid('reload');
        }
    });
    EmptyTextClick();
    $('#newAdd').window('close');
};