using QuizWithBuilderPattern.ViewModel;

namespace QuizWithBuilderPattern.View;

public partial class WelcomePage : ContentPage
{
	private WelcomeViewModel viewModel;
	public WelcomePage()
	{
		InitializeComponent();
		viewModel = (WelcomeViewModel)BindingContext;
        viewModel.NextPageCall += ViewModel_NextPageCall;

    }

    private async void ViewModel_NextPageCall(object sender, Common.PageEnum e)
    {
        if(e == Common.PageEnum.WelcomePage)
        {
            await Navigation.PushAsync(new WelcomePage());
        }
    }
}