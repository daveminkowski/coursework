<%@ Page Title="Authentic Street Tacos " Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Order.aspx.vb" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Order Form</h2>
    <table class="nav-justified">
        <tr>
            <td style="width: 200px">Name:</td>
            <td style="width: 270px">
                <asp:TextBox ID="txtName" runat="server"  Width="270px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="* Please enter a name for the order."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">Address:</td>
            <td style="width: 270px">
                <asp:TextBox ID="txtAddress" runat="server"  Width="270px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="* Please enter your address."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 200px; height: 24px;">Phone Number:</td>
            <td style="width: 270px; height: 24px;">
                <asp:TextBox ID="txtPhone" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td style="height: 24px">
                <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="* Please enter a phone number."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 200px"></td>
            <td style="width: 270px">
                &nbsp;</td>
            <td>
                <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="* Please enter a valid phone number, including area code, in the format (123)456-7890" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">Filling Choice:<br />
                </td>
            <td style="width: 270px">
                <asp:DropDownList ID="ddlFilling" runat="server" Height="24px" Width="270px">
                    <asp:ListItem Value="13.99">Carne Asada ($13.99)</asp:ListItem>
                    <asp:ListItem Value="8.99">Chipotle Chicken ($8.99)</asp:ListItem>
                    <asp:ListItem Value="9.99">Pastor Pork ($9.99)</asp:ListItem>
                    <asp:ListItem Value="12.99">Blackened Fish ($12.99)</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td style="width: 200px; height: 22px;"></td>
            <td style="width: 270px; height: 22px;"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 200px">Additional Toppings:<br />
                (<strong>$0.99 each)<br />
                </strong><em>cheese included with order</em></td>
            <td style="width: 270px">
                <asp:CheckBox ID="chkJalapeno" runat="server" Text="  Jalapeno" />
                <br />
                <asp:CheckBox ID="chkCilantro" runat="server" Text="  Cilantro" />
                <br />
                <asp:CheckBox ID="chkPico" runat="server" Text="  Pico de Gallo" />
                <br />
                <asp:CheckBox ID="chkSour" runat="server" Text="  Sour Cream" />
                <br />
                <asp:CheckBox ID="chkGuac" runat="server" Text="  Guacamole" />
            </td>
            <td>
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 200px; height: 22px;"></td>
            <td style="width: 270px; height: 22px;"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 200px; height: 22px;"></td>
            <td style="width: 270px; height: 22px;">
                <asp:Button ID="btnSubmit" runat="server" Height="39px" Text="Place Order" Width="274px" />
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 200px; height: 22px;"></td>
            <td style="width: 270px; height: 22px;"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 200px; height: 22px;"></td>
            <td style="width: 270px; height: 22px;">
                <asp:Label ID="lblConfirmation" runat="server"></asp:Label>
            </td>
            <td style="height: 22px"></td>
        </tr>
        
    </table>
</asp:Content>
