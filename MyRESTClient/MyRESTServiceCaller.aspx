<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyRESTServiceCaller.aspx.cs" Inherits="MyRESTClient.MyRESTServiceCaller" %>
  <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<!DOCTYPE html>

<script src="/MyRESTServiceCaller.js" type="text/javascript"> </script>

<script type="text/javascript"> 

    alert("I am an alert box!");
    $(document).ready(function () {

        debugger;
        $.ajax({
            type: "GET",
            url: "http://localhost:12311/ProductRESTService.svc/GetProductList/",
            dataType: "xml",
            success: function (xml) {
                $(xml).find('Product').each(function () {
                    var id = $(this).find('ProductId').text();
                    var name = $(this).find('Name').text();
                    var price = $(this).find('Price').text();
                    varcategory = $(this).find('CategoryName').text();
                    $('<tr><td>' + id + '</td><td>' + name + '</td><td>' + price + '</td><td>' +
                        category + ").appendTo('#products');"
    });
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    });
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <table border='1' id="products">
        <!– Make a Header Row –>
        <tr>
            <td><b>Product Id</b></td>
            <td><b>Name</b></td>
            <td><b>Price</b></td>
            <td><b>Category</b></td>
        </tr>
    </table>
</body>
</html>
