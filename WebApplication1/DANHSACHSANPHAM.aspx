<%@ Page Title="" Language="C#" MasterPageFile="~/MASTERPAGE_USER.Master" AutoEventWireup="true" CodeBehind="DANHSACHSANPHAM.aspx.cs" Inherits="WebApplication1.DANHSACHSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
    </asp:DataList>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href ="CHITIET.aspx?MSP=<%# Eval("MASANPHAM") %>">
                <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width="200px" height="300px" />
            </a>
           Tên sản phẩm: <%# Eval("TENSANPHAM") %> <br />
           <h5>Giá bán: <%# Eval("DONGIA") %>VND</h5>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
