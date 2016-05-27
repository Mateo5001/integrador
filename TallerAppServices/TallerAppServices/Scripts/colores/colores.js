
$(document).ready(function () {

    $('#detalle').css("display", "none");
    $("#btnCrearEncabezado").click(function () {
        $.post("../colores/Guardar", $("#formEncabezado").serialize())
                  .done(function (data) {
                      if (data != 0) {
                          $('#Encabezado').css("display", "none");
                          $('#detalle').html('');
                          $.get("../colorDetalles/create", function (data2) {

                              $('#detalle').html(data2);
                              $('#idColor').val(data);
                              $('#detalle').css("display", "block");
                              $('#btnAgregar').click(function () {
                                  $('#listaTintas').html('');

                                  $.post("../colorDetalles/Guardar", $("#FromDetalle").serialize())
                                  $('#cantidadPorcentaje').val('');
                                  $.get('../colorDetalles/lista/'+data, function (data3) {
                                      $('#listaTintas').html(data3);
                                  })


                              })
                          });
                          $('#detalle').css("display", "block");

                      }
                  });
    });
    $("#btnAgregar").click(function () {


    });
});