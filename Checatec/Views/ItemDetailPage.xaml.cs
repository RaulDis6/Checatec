using System.ComponentModel;
using Checatec.ViewModels;
using Xamarin.Forms;

namespace Checatec.Views
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