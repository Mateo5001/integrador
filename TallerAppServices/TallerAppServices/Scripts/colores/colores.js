
$(document).ready(function () {

    $('#detalle').css("display", "none");
    $("#btnCrearEncabezado").click(function () {
        $.post("../colores/Guardar", $("#formEncabezado").serialize())
                  .done(function (data) {
                      if (data != 0) {
                          $('#Encabezado').css("display", "none");
                          $('#detalle').html('');
                          $.get("../colorDetalles/create", function (data2) {
                              alert(data2);
                              $('#detalle').html(data2);
                              $('#detalle').css("display", "block");
                          });
                          $('#detalle').css("display", "block");

                      }
                  });
    });
    $("#btnAgregar").click(function () {


    });
});