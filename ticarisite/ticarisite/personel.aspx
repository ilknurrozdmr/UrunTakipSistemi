<%@ Page Title="" Language="C#" MasterPageFile="~/adminmaster.Master" AutoEventWireup="true" CodeBehind="personel.aspx.cs" Inherits="ticarisite.personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>PERSONEL ID</th>
            <th>PERSONEL ADI SOYADI</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("personelid") %></td>
                    <td><%#Eval("perdoneladsoyad") %></td>
                    <%--<td><asp:HyperLink NavigateUrl='<%#"~/kategorisil.aspx?kategoriid="+Eval("kategoriid") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/kategoriguncelle.aspx?kategoriid="+Eval("kategoriid") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>--%>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <%--<a href="kategoriekle.aspx" class="btn btn-info">Yeni Kategori</a>--%>
</asp:Content>
