namespace Weighter.Core;

public interface IAlertService
{
    public Task ShowSnackbar(string message);
    public Task ShowToast(string message);
}