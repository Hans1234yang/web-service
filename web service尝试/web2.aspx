<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web2.aspx.cs" Inherits="web_service尝试.web2" %>




<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.0.js">
</script>


<script type="text/javascript"></script>

<script type="text/javascript">
    $(function () {
        debugger
        $.ajax({
            type: 'post',
            url: 'WebService1.asmx/GetWeek',
            data: '{day:4}',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                debugger
                alert(data.d);
            }
        });
    });
</script>
