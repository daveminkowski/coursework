<%@ Page Title="Authentic Street Tacos" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 class="text-center" style="vertical-align: top">
            <span style="font-size: 28pt; text-align: justify;">Authentic Street Tacos </span>
        </h1>
        <h1 style="vertical-align: top; text-align: center;">
            <asp:Image ID="picTacos" runat="server" Height="299px" Width="485px" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/001_Tacos_de_carnitas%2C_carne_asada_y_al_pastor.jpg/1280px-001_Tacos_de_carnitas%2C_carne_asada_y_al_pastor.jpg" />
        &nbsp;</h1>
        <p class="lead">&nbsp;</p>
        <p class="lead" style="text-align: center">Delicious, authentic street tacos that will look nothing like this picture! We use fresh ingredients* from your trendy neighbor&#39;s &quot;salsa garden&quot;! <a runat="server" href="~/Order">Order Now!</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4" style="left: 0px; top: 0px">
        </div>
        <div class="col-md-4" style="font-size: 6pt">
            * Our authentic street tacos come with no guarantee that you will remain diarrhea-free, plan accordingly.</div>
    </div>

</asp:Content>
