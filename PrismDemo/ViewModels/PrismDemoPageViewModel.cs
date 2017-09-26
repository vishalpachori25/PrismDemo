using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace PrismDemo.ViewModels
{
    public class PrismDemoPageViewModel : BindableBase, INavigationAware
    {
        IPageDialogService dialogService;
        public DelegateCommand clickmeCmd
        {
            get;
            set;
        }
        public PrismDemoPageViewModel(IPageDialogService pageDialogService)
        {
            dialogService = pageDialogService;
            clickmeCmd = new DelegateCommand(HandleAction);
        }

        void HandleAction()
        {
            dialogService.DisplayAlertAsync("Hello", "Clicked button", "OK", "Cancel");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}
