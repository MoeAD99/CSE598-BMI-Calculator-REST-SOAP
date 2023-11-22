<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" Text="SOAP Web Service"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Height:" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="heightText" runat="server" Height="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Weight:" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="weightText" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="BMI:" Font-Bold="True"></asp:Label>
&nbsp;<asp:TextBox ID="bmiResultText" runat="server" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Risk:" Font-Bold="True"></asp:Label>
&nbsp;<asp:TextBox ID="riskText" runat="server" BorderStyle="None" Width="210px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="More:" Font-Bold="True"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="moreText" runat="server" BorderStyle="None" Height="63px" TextMode="MultiLine" Width="497px"></asp:TextBox>
            <br />
&nbsp;<br />
            <asp:Button ID="myBmiButton" runat="server" OnClick="myBmiButton_Click" Text="myBMI" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="myHealthButton" runat="server" OnClick="myHealthButton_Click" Text="myHealth" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="X-Large" Text="RESTful Web Service"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Height:" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="heightText0" runat="server" Height="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Weight:" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="weightText0" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="BMI:" Font-Bold="True"></asp:Label>
&nbsp;<asp:TextBox ID="bmiResultText0" runat="server" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Risk:" Font-Bold="True"></asp:Label>
&nbsp;<asp:TextBox ID="riskText0" runat="server" BorderStyle="None" Width="210px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="More:" Font-Bold="True"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="moreText0" runat="server" BorderStyle="None" Height="63px" TextMode="MultiLine" Width="497px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="JSON Response:"></asp:Label>
            <br />
&nbsp;<asp:TextBox ID="jsonText" runat="server" Height="137px" TextMode="MultiLine" Width="540px" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="myBmiButton0" runat="server" OnClick="myBmiButton_Click2" Text="myBMI" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="myHealthButton0" runat="server" OnClick="myHealthButton_Click2" Text="myHealth" />
        </div>
    </form>
</body>
</html>
