<%@ Page Title="" Language="C#" MasterPageFile="~/NorthwindSite.Master" AutoEventWireup="true" CodeBehind="ProductsByCategory.aspx.cs" Inherits="Northwind.ProductsByCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">

    <asp:DropDownList ID="DrpCategory" runat="server" AppendDataBoundItems="True" AutoPostBack="True" Width="160px" OnSelectedIndexChanged="DrpCategory_SelectedIndexChanged">
        <asp:ListItem Value="-1">Choose a Category</asp:ListItem>
</asp:DropDownList>
 
    <br />
    <br />
    <asp:GridView ID="GridProducts" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
 
</asp:Content>
