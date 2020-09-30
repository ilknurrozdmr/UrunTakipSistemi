<%@ Page Title="" Language="C#" MasterPageFile="~/adminmaster.Master" AutoEventWireup="true" CodeBehind="urunler.aspx.cs" Inherits="ticarisite.urun.urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>MARKA</th>
            <th>KATEGORİ</th>
            <th>FİYAT</th>
            <th>STOK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("urunid") %></td>
                    <td><%#Eval("urunad") %></td>
                    <td><%#Eval("urunmarka") %></td>
                    <td><%#Eval("kategoriad") %></td>
                    <td><%#Eval("urunfiyat") %></td>
                    <td><%#Eval("urunstok") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/urun/urunsil.aspx?urunid="+Eval("urunid") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/urun/urunguncelle.aspx?urunid="+Eval("urunid") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="yeniurun.aspx" class="btn btn-info">Yeni Ürün</a>
</asp:Content>
