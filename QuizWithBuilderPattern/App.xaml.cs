using QuizWithBuilderPattern.View;

namespace QuizWithBuilderPattern;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new RegistrationPage());
	}
}
