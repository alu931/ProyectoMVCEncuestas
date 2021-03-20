var ClickNew = function () {
    window.location.href = "EmpleadoEncuesta/NuevaEncuesta";
}



Loading.fire("Cargando Datos..");

$(document).ready(function () {

    $("#GridEmpleadoEncuesta").DataTable();
    setTimeout(function () {
        Loading.close();
    },500)
});

