<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <label>Name</label>
    <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ID="rfv" ControlToValidate="txtName" ErrorMessage="required"></asp:RequiredFieldValidator>
    <br>
    <label>ID</label>
    <asp:TextBox runat="server" ID="txtID"></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ID="rfvID" ControlToValidate="txtID" ErrorMessage="required" Display="Dynamic"></asp:RequiredFieldValidator>

    <br>
    <label>Email</label>

    <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
    <br>
    <label>FavColor</label>
    <asp:DropDownList runat="server" ID="color">
        <asp:ListItem Text ="Chosse a Color" Value=""></asp:ListItem>
        <asp:ListItem Text ="blue" Value="blue"></asp:ListItem>
        <asp:ListItem Text ="red" Value="red"></asp:ListItem>
        <asp:ListItem Text ="green" Value="green"></asp:ListItem>
        <asp:ListItem Text ="black" Value="black"></asp:ListItem>
    </asp:DropDownList>
    <div>
        <asp:Calendar ID="cal" runat="server">

        </asp:Calendar>
    </div>
    <br>
    <asp:Button ID="BtnActive" runat="server" Text="Done" OnClick="BtnActive_Click"  />
    <br>
    <asp:Repeater ID="rpt" runat="server">
        <ItemTemplate>

        </ItemTemplate>
    </asp:Repeater>

    <address>
        <div runat="server" id="divmess" class="message" >welcome to contact page </div>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
