using AppMusic.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppMusic.Views
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