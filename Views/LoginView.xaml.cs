using BLOGSOCIALUDLA.ViewModels;

namespace BLOGSOCIALUDLA.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();	}

  
}