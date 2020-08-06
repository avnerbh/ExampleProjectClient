<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="eMail" runat="server"></asp:TextBox>
            <asp:Label ID="eMailLbl" runat="server" Text="אימייל"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <asp:Label ID="passwordLbl" runat="server" Text="סיסמה"></asp:Label>
        </div>
        <p>
            <asp:Button ID="MySubmitButton" runat="server" OnClick="MySubmitButton_Click" Text="היכנס" />
        </p>
        <asp:Label style="color:burlywood" ID="messageLbl" runat="server"></asp:Label>
    </form>
</body>
</html>
