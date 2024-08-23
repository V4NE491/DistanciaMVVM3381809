using DistanciaMVVM3381809.ViewModels;

namespace DistanciaMVVM3381809
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new DistaciaViewModel();
        }
    }

}
