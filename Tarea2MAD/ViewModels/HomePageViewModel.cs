using System;
using System.Collections.Generic;
using System.Text;
using Tarea2MAD.Views;
using System.Windows.Input;
using Xamarin.Forms;
using Tarea2MAD.Models;
using System.ComponentModel;

namespace Tarea2MAD.ViewModels
{
    class HomePageViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string WelcomeLabel { get; set; }
        public HomePageViewModel(User user)
        {
            WelcomeLabel = $"Welcome {user.Name}, this is DounApp Bakery Shop!";


        }
    }
}
