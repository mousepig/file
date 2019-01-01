<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication2.useradd" %>

<!DOCTYPE html>
<html >
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加用户</title>
</head>
<body>
    <form id="form" runat="server">
    <div>  
       
        <table><tr><td>
     
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 注册<br />
        <br />
          用 户 名 ： <asp:TextBox ID="userName" runat="server" MaxLength="20" Width="127px"></asp:TextBox><br />
<br />
         密   码：&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtUpwd" runat="server" MaxLength="20" TextMode="Password" Width="127px" style="margin-left: 0px"></asp:TextBox>
            &nbsp;
            <br /><br />
            <br /><br />
       
        <br />
        <asp:Button ID="btnok" runat="server" Text=" 确  定 " OnClick="btn_Click" />&nbsp;
        <asp:Button ID="btn" runat="server" Text=" 返  回 " OnClick="btn_Click3" style="width: 82px"  />
            </td>
           
        </tr></table>
         </div>
    </form>
</body>
</html>

