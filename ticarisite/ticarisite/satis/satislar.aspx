<%@ Page Title="" Language="C#" MasterPageFile="~/adminmaster.Master" AutoEventWireup="true" CodeBehind="satislar.aspx.cs" Inherits="ticarisite.satis.satislar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>SATIŞ ID</th>
            <th>ÜRÜN</th>
            <th>PERSONEL</th>
            <th>MÜŞTERİ</th>
            <th>FİYAT</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("satisid") %></td>
                    <td><%#Eval("urunad") %></td>
                    <td><%#Eval("perdoneladsoyad") %></td>
                    <td><%#Eval("musteri") %></td>
                    <td><%#Eval("fiyat") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="yenisatis.aspx" class="btn btn-info">Yeni Satış</a>

</asp:Content>
