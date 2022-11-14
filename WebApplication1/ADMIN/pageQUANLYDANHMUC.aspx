<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageQUANLYDANHMUC.aspx.cs" Inherits="WebApplication1.ADMIN.pageQUANLYDANHMUC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 262px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Mã Danh Mục</td>
                <td>
                    <asp:TextBox ID="txtMaDanhMuc" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Tên Danh Mục </td>
                <td>
                    <asp:TextBox ID="txtTenDanhMuc" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btn_luu" runat="server" OnClick="btn_luu_Click" Text="Lưu" />
                    <asp:Button ID="btnXoa_Click" runat="server" OnClick="btnXoa_Click_Click" Text="Xóa" />
                    <asp:Button ID="btnSua_Click" runat="server" OnClick="btnSua_Click_Click" Text="Sửa" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:GridView ID="grvDANHMUC" runat="server" AllowPaging="True" OnPageIndexChanging="grvDANHMUC_PageIndexChanging" PageSize="3">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
