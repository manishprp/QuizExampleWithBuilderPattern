using QuizWithBuilderPattern.Common;
using QuizWithBuilderPattern.ViewModel;

namespace QuizWithBuilderPattern.View;

public partial class RegistrationPage : ContentPage
{
	private  RegistrationViewModel _viewModel;
	public RegistrationPage()
	{
		InitializeComponent();
		_viewModel = (RegistrationViewModel)BindingContext;
        _viewModel.NextPageCall += ViewModel_NextPageCall;
    }

    private async void ViewModel_NextPageCall(object sender, Common.PageEnum e)
    {
        if (e == PageEnum.WelcomePage)
        {
            await Navigation.PushAsync(new WelcomePage());
        }
    }
}