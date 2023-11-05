using FinalAPP.View;
using Microsoft.Maui.Platform;

namespace FinalAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TaskApp());
        }
    }
}