using GlamGoApp.Models;
using GlamGoApp.PageModels;

namespace GlamGoApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}