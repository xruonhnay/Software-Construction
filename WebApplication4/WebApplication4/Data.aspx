﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="WebApplication4.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 align="center" style="color:orangered;"> WELCOME Admin</h1>
        <table width="100%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="#EAEAEA" >
        <tr align="left" style="background-color:#004080;color:White;" >
            <td> ID </td>                        
            <td> Name </td>            
            <td>Age </td>
             <td>Email </td>
        </tr>

        <%=getWhileLoopData()%>

    </table>
    </form>
</body>
</html>
