using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaMVVM.Models;
using tareaMVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tareaMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEmpleadoView : ContentPage
    {
        public int id = 0;
        Empleados obj;
        public ListEmpleadoView()
        {
            InitializeComponent();
            lista.ItemsSource = new ListViewModel().ListaEmpleados1;
            //this.BindingContext = new EmpleadoViewModel();
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            CRUD c = new CRUD();
            Empleados obj = new Empleados()
            {
                Id_empleado = id
            };

            if (c.Eliminar(obj) > 0)
            {

                lista.ItemsSource = new ListViewModel().ListaEmpleados1;
            }

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Models.Empleados)e.SelectedItem;
            id = item.Id_empleado;

            obj = new Empleados
            {
                id_empleado = item.Id_empleado,
                edad = item.Edad,
                nombre = item.Nombre,
                apellido = item.Apellido,
                puesto = item.Puesto,
                direccion = item.Direccion
            };
        }
        private void btnModificar_Clicked(object sender, EventArgs e)
        {
           //((NavigationPage)this.Parent).PushAsync(new UpdateEmpleadoView());
           // Navigation.PushModalAsync(new UpdateEmpleadoView());

            var view = new UpdateEmpleadoView();
            view.BindingContext = obj;
            Navigation.PushAsync(view);
        }
    }
}