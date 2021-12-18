using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using tareaMVVM.Models;
using Xamarin.Forms;

namespace tareaMVVM.ViewModels
{
    class EmpleadoViewModel:Empleados
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }


        public EmpleadoViewModel()
        {
            Nuevo = new Command(() => {

                Nombre = "";
                Apellido = "";
                Direccion = "";
                Edad = 0;
                Puesto = "";

            });


            Guardar = new Command(() => {
                Empleados modelo = new Empleados()
                {
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Direccion = Direccion,
                    Edad = Edad,
                    Puesto = Puesto
                };

                using (var contexto = new CRUD())
                {
                    contexto.Insertar(modelo);
                }
            }
             );
            Modificar = new Command(() => {
                Empleados modelo = new Empleados()
                {
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Direccion = Direccion,
                    Edad = Edad,
                    Puesto = Puesto,
                    Id_empleado = Id_empleado

                };

                using (var contexto = new CRUD())
                {
                    contexto.Actualizar(modelo);
                }
            }
            );

            Eliminar = new Command(() => {
                Empleados modelo = new Empleados()
                {
                    Id_empleado = Id_empleado
                };

                using (var contexto = new CRUD())
                {
                    contexto.Eliminar(modelo);
                }
            }

           );

        }
    }
}
