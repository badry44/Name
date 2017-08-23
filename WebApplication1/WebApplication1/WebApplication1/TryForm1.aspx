<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryForm1.aspx.cs" Inherits="WebApplication1.TryForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>trythisone</title>
    <script src="Scripts/tinymce/tinymce.min.js"></script>
    <script>tinymce.init({
    selector: '.conTiny'
});

        function Changed(textControl) {
            alert(textControl.value);
        }
        function change_isGood() {

            alert("hi");


        }


    </script>
</head>
<body>
                        
                
                
 
    
</body>
</html>