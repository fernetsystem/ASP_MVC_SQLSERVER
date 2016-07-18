<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="testPrb01.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        *{
            font-family: 'Century Gothic',Arial;
            color: #454545;
        }
    </style>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Apellido paterno"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Apellido materno"></asp:Label><br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label><br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label><br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Save client" OnClick="Button1_Click" />
    </div>
        <asp:Label ID="myMsn" runat="server" Text="L"></asp:Label>
        <div>
              
        </div>
    </form>
  
    
</body>
</html>
