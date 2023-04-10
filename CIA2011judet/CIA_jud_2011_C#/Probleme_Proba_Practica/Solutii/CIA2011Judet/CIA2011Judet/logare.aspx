<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logare.aspx.cs" Inherits="CIA2011Judet.logare" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" onload="Label2_Load"></asp:Label>
        <table class="style1">
            <tr>
                <td class="style2">
                    User 
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Parola&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Logare" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT utilizator, parola, Tip FROM utilizatori WHERE (utilizator = @utilizator) AND (parola = @parola)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="utilizator" 
                    PropertyName="Text" />
                <asp:ControlParameter ControlID="TextBox2" Name="parola" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\utilizatori.mdf;Integrated Security=True;User Instance=True" 
            InsertCommand="INSERT INTO logari(Utilizator, Datalogarii) VALUES ( @user , @datalogarii)">
            <InsertParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="user" PropertyName="Text" />
                <asp:ControlParameter ControlID="Label2" Name="datalogarii" 
                    PropertyName="Text" />
            </InsertParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
