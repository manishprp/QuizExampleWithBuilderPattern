using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizWithBuilderPattern.Builder;
using QuizWithBuilderPattern.Common;

namespace QuizWithBuilderPattern.ViewModel
{
    public partial class WelcomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _name;
        private MainUniversalBuilder<AllInputVariables> _builder;
        public WelcomeViewModel()
        {
            _builder = new MainUniversalBuilder<AllInputVariables>().
            Execute();
            _name = _builder.AllInputVariables.Name;
        }
        [RelayCommand]
        private void NextPage()
        {
            InvokeNextPageEvent(PageEnum.QuizgamePage);
        }
    }
}
