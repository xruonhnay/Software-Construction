<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task1.aspx.cs" Inherits="WebApplication4.Task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 align="center" style="color:orangered;"> WELCOME to USER World</h1>
        <h1>Add Your Data</h1>

         ID   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
        UserName   <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        </p>
        <p>
        Age  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
        <p>
            Email  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Add_Click" />
    </form>
</body>
</html>
