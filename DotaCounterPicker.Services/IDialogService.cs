namespace DotaCounterPicker.Services;

public interface IDialogService 
{
    Task ShowDialogAsync(IDialogViewModel viewModel);
}
