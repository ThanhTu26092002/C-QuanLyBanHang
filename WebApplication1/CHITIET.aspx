    <%@ Page Title="" Language="C#" MasterPageFile="~/MASTERPAGE_USER.Master" AutoEventWireup="true" CodeBehind="CHITIET.aspx.cs" Inherits="WebApplication1.CHITIET" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width="200px" height="300px" /><br />
           <h1>Tên Sản Phẩm: <%# Eval("TENSANPHAM") %> </h1><br /> 
           <%# Eval("MOTA") %><br />
           <h5><%# "Đơn Giá: " + Eval("DONGIA") %>VND</h5>
        </ItemTemplate>
    </asp:Repeater>
    <br />
    <asp:DropDownList ID="drlSOLUONG" runat="server">
    </asp:DropDownList>
    <asp:Button ID="bth_GioHang" runat="server" Text="Giỏ Hàng" OnClick="bth_GioHang_Click"/>
</asp:Content>
    