using FinalAPP.Model;

namespace FinalAPP.View;

public partial class TaskApp : ContentPage
{
	public TaskApp()
	{
		InitializeComponent();
		collectionView.ItemsSource = GetCategories();
	}

   
	private List<App_Category> GetCategories()
	{
		return new List<App_Category>
		{ new App_Category { Name = "Work", ProgressBar = 0.6, Fraction = "3/5" },


		new App_Category { Name = "Work", ProgressBar = 0.6, Fraction = "3/5" },

        new App_Category { Name = "Work", ProgressBar = 0.6, Fraction = "3/5" }
        };
    }
	
    

   
}