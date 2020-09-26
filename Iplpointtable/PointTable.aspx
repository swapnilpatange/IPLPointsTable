<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PointTable.aspx.cs" Inherits="PointTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="point_list" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="team_name" HeaderText="Team Name" />
                <asp:BoundField DataField="Played" HeaderText="Played" />
                <asp:BoundField DataField="Won" HeaderText="Won" />
                <asp:BoundField DataField="Lost" HeaderText="Lost" />
            </Columns>

        </asp:GridView>
    </div>
    </form>
</body>
</html>
