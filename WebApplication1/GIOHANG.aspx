<%@ Page Title="" Language="C#" MasterPageFile="~/MASTERPAGE_USER.Master" AutoEventWireup="true" CodeBehind="GIOHANG.aspx.cs" Inherits="WebApplication1.GIOHANG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    <asp:GridView ID="grvCART" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MASANPHAM" HeaderText="Mã Sản Phẩm" />
            <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên Sản Phẩm" />
            <asp:BoundField DataField="SOLUONG" HeaderText="Số Lượng" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn Giá" />
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành Tiền" />
            <asp:ImageField DataImageUrlField="HINHANH" HeaderText="Ảnh" DataAlternateTextField="HINHANH" DataImageUrlFormatString="IMAGES/{0}">
            </asp:ImageField>
            <asp:TemplateField HeaderText="Trả Hàng">
                <ItemTemplate>
                    <asp:CheckBox ID="ckbREMOVEITEM" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btn_RemoveItem" runat="server" Text="Trả Hàng" OnClick="btn_RemoveItem_Click1"/>
    
</asp:Content>
