<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="lab7IsHere.MainForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Лабораторна робота 7</title>
    <style>
        body { font-family: Arial, sans-serif; padding: 20px; }
        .result-box { margin-top: 20px; padding: 15px; border: 1px solid #ccc; background-color: #f9f9f9; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Анкета</h2>
            
            Прізвище: <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox> <br /><br />
            
            Ім&#39;я: <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox> <br /><br />
            
            По-батькові: <br />
            <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox> <br /><br />
            
            Email адреса:<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox> <br /><br />
            
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Перевірити дані" Height="30px" /> <br />
            
            <div class="result-box">
                <strong>Результат:</strong><br /><br />
                <asp:Label ID="Label1" runat="server" ForeColor="DarkBlue"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>