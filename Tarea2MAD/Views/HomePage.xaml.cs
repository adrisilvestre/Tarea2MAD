using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2MAD.Models;
using Tarea2MAD.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2MAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage(User User)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new HomePageViewModel(User);
        }
    }
}