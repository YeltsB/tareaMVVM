using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaMVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tareaMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmpleadoView : ContentPage
    {
        public AddEmpleadoView()
        {
            InitializeComponent();
            this.BindingContext = new EmpleadoViewModel();
        }


        private void Btnver_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListEmpleadoView());

        }
    }
}