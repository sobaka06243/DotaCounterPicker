using CommunityToolkit.Mvvm.Input;
using DotaCounterPicker.Services;
using System.Windows.Input;

namespace DotaCounterPicker.MVVM.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly IDialogService _dialogService;

    public MainViewModel(IDialogService dialogService)
    {
        _dialogService = dialogService;
        PickHeroCommand = new AsyncRelayCommand(PickHero);
    }

    public ICommand PickHeroCommand
    {
        get;
    }

    private async Task PickHero()
    {
        HeroPickerViewModel viewModel = new HeroPickerViewModel();
        await _dialogService.ShowDialogAsync(viewModel);
    }
}
