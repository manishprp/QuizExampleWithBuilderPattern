using CommunityToolkit.Mvvm.ComponentModel;
using QuizWithBuilderPattern.Common;
using System.ComponentModel;

namespace QuizWithBuilderPattern.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isBusy;
        [ObservableProperty]
        private string _errorMessage;

        public event EventHandler<PageEnum> NextPageCall;

        public void InvokeNextPageEvent(PageEnum pageEnum)
        {
            NextPageCall?.Invoke(this, pageEnum);
        }
    }
}
