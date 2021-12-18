using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using tareaMVVM.Models;
namespace tareaMVVM.ViewModels
{
   public class ListViewModel:Empleados
    {

        private ObservableCollection<Empleados> ListaEmpleados;

        public ListViewModel()
        {

        }

        public ObservableCollection<Empleados> ListaEmpleados1
        {
            get
            {
                if (ListaEmpleados == null)
                {
                    ObtenerEmpleados();
                }

                return ListaEmpleados;
            }

            set
            {
                ListaEmpleados = value;
            }
        }

        public void ObtenerEmpleados()
        {
            using (var contexto = new CRUD())
            {
                ObservableCollection<Empleados> modelo = new ObservableCollection<Empleados>(contexto.Consultar());
                ListaEmpleados = modelo;
            }



        }
    }
}
