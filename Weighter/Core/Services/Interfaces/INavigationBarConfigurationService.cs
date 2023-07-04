using Weighter.Core.Enums;
using Weighter.Core.Models.UI;

namespace Weighter.Core.Services.Interfaces
{
    public interface INavigationBarConfigurationService
    {
        NavigationBarConfiguration GetConfiguration(NavigationBarActionType actionType);
    }
}