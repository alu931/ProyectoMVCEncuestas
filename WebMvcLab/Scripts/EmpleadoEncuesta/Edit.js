var Entity = $("model").data("entity");


console.log(Entity);

var NuevoEmpleadoEncuesta = new Vue({
//Data
    data: {
        model: Entity,
        formulario: "#FormEmpleadoEncuesta",
        ddlCanton: [],
        ddlDistrito:[]
    },
//Metodos
    methods: {

        Save: function () {
            

            if (BValidateData(this.formulario)) {

                Loading.fire("Guardando...");
                axios.post("EmpleadoEncuesta/Save", this.model).then(function (get) {
                    Loading.close();
                    var result = get.data;

                    if (result.CodeError == 0) {
                        Toast.fire({
                            icon: 'success',
                            title: 'Registro Guardado'
                        });
                        setTimeout(function () {
                            window.location.href = "../EmpleadoEncuesta"
                        }, 1500)
                    } else {
                        Toast.fire({
                            icon: 'error',
                            title: result.MsgError
                        });
                    }

                });

            } else {
                
                Toast.fire({
                    icon: "error",
                    title: "Porfavor Complete los campos requeridos!"
                });
            }
        },//Fin de guardar

        OnChangeProvincia: function () {
            var $this = this;
          
            Loading.fire("Cargando Cantones..");
            axios.post('EmpleadoEncuesta/ddlCanton', this.model).then(function (get) {
                $this.ddlCanton = [];
                Loading.close();
                var result = get.data;
                $this.ddlCanton = result;
                
            });


        },//FinOnChangeProvincia

        OnChangeCanton: function () {
            var $this = this;
            
            Loading.fire("Cargando Distritos..");
            axios.post('EmpleadoEncuesta/ddlDistrito', this.model).then(function (get) {
                $this.ddlDistrito = [];
                Loading.close();
                var result = get.data;
                $this.ddlDistrito = result;

            });


        },//Fin OnChangeCanton


    },

    mounted: function () {
        CreateValidator(this.formulario);
    }
//create


});


NuevoEmpleadoEncuesta.$mount("#NuevoEmpleadoEncuesta");



