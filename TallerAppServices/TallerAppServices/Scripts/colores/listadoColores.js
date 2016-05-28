$(document).ready(function () {
    $("#idColor").change(function () {
        var data = $("#idColor").val();
        $.get('../colorDetalles/lista/' + data, function (data3) {
            $('#detalleColores').html(data3);
        })
    })
})
