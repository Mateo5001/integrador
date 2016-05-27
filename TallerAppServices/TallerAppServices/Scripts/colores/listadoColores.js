$(document).ready(function () {
    $("#idColor").change(function () {
        var data = $("#idColor").val();
        alert(data);
        $.get('../colorDetalles/lista/' + data, function (data3) {
            $('#detalleColores').html(data3);
        })
    })
})
