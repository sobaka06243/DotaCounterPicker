using DotaCounterPicker.Services;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DotaCounterPicker.Wpf.Services;

public class DialogService : IDialogService
{
    private readonly ContentPresenter _element;
    public DialogService(ContentPresenter element)
    {
        _element = element;
    }

    public Task ShowDialogAsync(IDialogViewModel viewModel)
    {
        _element.Content = viewModel;
        var completionSource = new TaskCompletionSource();

        EventHandler closeEventHandler = null;
        closeEventHandler += (s, e) =>
        {
            viewModel.CloseRequsted -= closeEventHandler;
            _element.Content = null;
            completionSource.SetResult();
        };
        viewModel.CloseRequsted += closeEventHandler;


        return completionSource.Task;
    }
}
