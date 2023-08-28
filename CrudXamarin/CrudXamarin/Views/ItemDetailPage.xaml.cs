using CrudXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CrudXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}