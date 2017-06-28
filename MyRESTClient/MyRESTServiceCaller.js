$(document).ready(function () {
    alert("I am an alert box!");

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