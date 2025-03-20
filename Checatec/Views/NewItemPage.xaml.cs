using System;
using System.Collections.Generic;
using System.ComponentModel;
using Checatec.Models;
using Checatec.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Checatec.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}