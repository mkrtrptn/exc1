<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="viewengineapp.Views.Home.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <%  for (int j = 1; j < 10; j++)
                {
                    if (j % 2 == 0)
                    {
            %>
            <h3 style="color: green">Even : <% =j%></h3>
            <%
                }
                else
                {
            %>

        <h1 style="background-color:red">Odd :  <%=j %> </h1>
            
            <%
                    }
                }

            %>


            

        </div>
    </form>
</body>
</html>
