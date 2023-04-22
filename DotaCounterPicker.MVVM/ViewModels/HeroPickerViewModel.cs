using CommunityToolkit.Mvvm.Input;
using DotaCounterPicker.Services;
using System.Windows.Input;

namespace DotaCounterPicker.MVVM.ViewModels;

public class HeroPickerViewModel : ViewModelBase, IDialogViewModel
{
    public HeroPickerViewModel()
    {
        CloseCommand = new RelayCommand(Close);
    } 

    public ICommand CloseCommand
    {
        get;
    }

    public event EventHandler? CloseRequsted;

    private void Close()
    {
        CloseRequsted?.Invoke(this, new EventArgs());
    }
}
