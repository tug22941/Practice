<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HFC1.aspx.cs" Inherits="Practice.HFC1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HFC1</title>
    <style>
        body{
            background-color: paleturquoise;
        }
    </style>
</head>
<body>
    <h3>Submit form for server-side processing using an HTML Form "Button" control. <br />
        The HTML Form control (HFC) is intercepted for client-processing.
    </h3>

    <form id="theForm" runat="server">
        Enter your name <br />
        <input  type="text" id="txtName" name="txtName" size="50" /> <br />
        <input  type="button" id="btnProcess" name="btnProcess"
                value="Submit Name" onclick="ValidateForm()"/>
    </form>

    <script type="text/javascript" lang="javascript">
        function ValidateForm() {
            var strName;
            strName = document.getElementById("txtName").value;

            if (strName == "") {
                //don't submit form; give warning
                alert("Empty Name!");
            }
            else {
                //submit form for server-side processing
                document.getElementById("theForm").submit();
            }
        }
    </script>
</body>
</html>
