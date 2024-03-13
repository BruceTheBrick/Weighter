using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Weighter.Core;

public class AlertService : IAlertService
{
    public Task ShowSnackbar(string message)
    {
        var snackbar = new Snackbar
        {
            Text = message,
            Duration = TimeSpan.FromHours(2),
            VisualOptions = GetDefaultOptions(),
        };
        return snackbar.Show();
    }

    public Task ShowToast(string message)
    {
        var toast = new Toast
        {
            Duration = ToastDuration.Long,
            Text = message,
        };
        return toast.Show();
    }

    private SnackbarOptions GetDefaultOptions()
    {
        var options = new SnackbarOptions { CornerRadius = 8, };
        return options;
    }
}