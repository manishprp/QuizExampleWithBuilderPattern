using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizWithBuilderPattern.Builder;
using QuizWithBuilderPattern.Common;

namespace QuizWithBuilderPattern.ViewModel
{
    public partial class RegistrationViewModel : BaseViewModel
    {
        private MainUniversalBuilder<AllInputVariables> _mainUniversalBuilder;
        public RegistrationViewModel()
        {
            _mainUniversalBuilder = new MainUniversalBuilder<AllInputVariables>();
        }
        [ObservableProperty]
        private string _name;

        [RelayCommand]
        private void NextPage(object commandParam)
        {
            if(IsBusy)
                return;
            try
            {
                IsBusy = true;
                var temp = AllUiVariablesEnum.Name.ToString();
                _mainUniversalBuilder.StoreUserInput(AllUiVariablesEnum.Name.ToString(),Name)
                                     .Execute();
                InvokeNextPageEvent(PageEnum.WelcomePage);
            }
            catch (Exception ex) 
            {
                ErrorMessage = ex.ToString();
            }
            finally 
            { IsBusy = false; }
        }
    }
}
