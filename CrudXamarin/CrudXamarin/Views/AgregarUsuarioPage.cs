using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CrudXamarin.Views
{
    public class AgregarUsuarioPage : ContentPage
    {
        private Entry _nombresEntry;
        private Entry _apellidosEntry;
        private Entry _dniEntry;
        private Entry _celularEntry;
        private Entry _correoEntry;
        Button _guaradarButton;

        public AgregarUsuarioPage()
        {
            this.Title = "Agregar Usuario";
            StackLayout stackLayout = new StackLayout();
        }
    }
}