using FinalAPP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalAPP.ViewModel
{
    public class App_CategoryViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<App_Category> Categories { get; set; }

        public App_CategoryViewModel()
        {
            LoadTestData();
        }

        private void LoadTestData()
        {
            // Initialize the ObservableCollection
            Categories = new ObservableCollection<App_Category>();

            
        }

        public ICommand AddCategorySection => new Command(async () =>
        {
            string categoryName = await Application.Current.MainPage.DisplayPromptAsync("Add Category", "Enter the name of the new category:");
            if (!string.IsNullOrEmpty(categoryName))
            {
                Categories.Add(new App_Category { Name = categoryName });
                OnPropertyChanged(nameof(Categories));
            }
        });



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
