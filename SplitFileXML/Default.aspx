<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SplitFileXML.Default" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>App to split an XML File into multiple XML Files  </h1>
            <table>
                <tr>
                    <td><asp:TextBox ID="TxtFile" runat="server" TextMode="MultiLine" Rows="40" Width="500px" ></asp:TextBox></td>
               
                    <td><asp:TextBox ID="TxtFileSplit" runat="server" TextMode="MultiLine" Rows="40" Width="500px"></asp:TextBox></td>
                </tr>
            </table>
          
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Give the tag for the divison:"></asp:Label>
            <asp:TextBox ID="TxtTag" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSplit" runat="server" Text="Split" OnClick="BtnSplit_Click" /> <br /><br />
                <br /><br />

            &nbsp; &nbsp;   <asp:Label ID="LblShowMessage" runat="server" ForeColor="Blue" Visible="False"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
