<%@ Page Title="" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Displayposts.aspx.cs"
    Inherits="GestionLivres.Web.DisplayPosts" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent"
    runat="server">
    <asp:Button runat="server" Text="Dispaly Posts"
        OnClick="DisplayPost_Click" />
    <asp:GridView ID="postsresult" runat="server">
    </asp:GridView>
</asp:Content>
