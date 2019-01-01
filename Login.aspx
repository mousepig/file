<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2._Default" %>

<!DOCTYPE html>

<html >
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
                  
<body style="height: 465px">
                  
    <form id="form" runat="server">

    <div style="text-align: center" >
       
        <br />
        登录<br />
        <br />
        <br />
        用户名：<asp:TextBox ID="userName" runat="server" MaxLength="20"  Width="95px"></asp:TextBox>
        <br />
        <br />
        密 码：
        <asp:TextBox ID="password" runat="server" MaxLength="20" TextMode="Password" Width="95px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnok" runat="server" Text=" 登  录 " OnClick="btn_Click" />&nbsp;
     </div>
    </form>
                  
</body>

</html>
