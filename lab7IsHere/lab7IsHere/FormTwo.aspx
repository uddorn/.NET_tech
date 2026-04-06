<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormTwo.aspx.cs" Inherits="lab7IsHere.FormTwo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Завдання 2 - Реєстрація</title>
    <style>
        body { font-family: Arial, sans-serif; padding: 20px; }
        .form-container { width: 300px; padding: 20px; border: 1px solid #ccc; background-color: #f9f9f9; }
        .form-group { margin-bottom: 15px; }
        .form-group label { display: block; margin-bottom: 5px; }
        .form-group input { width: 100%; padding: 5px; box-sizing: border-box; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Реєстрація</h2>
            
            <div class="form-group">
                <label>Прізвище:</label>
                <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Ім'я:</label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </div>
            
            <hr />

            <div class="form-group">
                <label>Логін:</label>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Пароль:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            
            <asp:Button ID="btnSubmit" runat="server" Text="Зареєструватися" OnClick="btnSubmit_Click" Height="30px" Width="100%" />
            
            <br /><br />
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
