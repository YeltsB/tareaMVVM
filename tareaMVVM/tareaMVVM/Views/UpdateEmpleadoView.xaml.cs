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
    public partial class UpdateEmpleadoView : ContentPage
    {
        public UpdateEmpleadoView()
        {
            InitializeComponent();
            this.BindingContext = new EmpleadoViewModel();

        }


        private void btnguardar_Clicked(object sender, EventArgs e)
        {
            CRUD c = new CRUD();

            Empleados modelo = new Empleados()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Edad = Convert.ToInt32(txtEdad.Text),
                Puesto = txtPuesto.Text,
                Id_empleado = Convert.ToInt32(txtID.Text)
            };

            if (c.Actualizar(modelo) > 0)
            {
                try
                {
                    ((NavigationPage)this.Parent).PushAsync(new ListEmpleadoView());

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}