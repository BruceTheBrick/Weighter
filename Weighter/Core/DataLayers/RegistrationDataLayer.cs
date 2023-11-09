using Weighter.Core.Databases.Interfaces;
using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Registration._ViewModels;

namespace Weighter.Core.DataLayers;

public class RegistrationDataLayer : IRegistrationDataLayer
{
    private readonly IWeighterDatabase _weighterDatabase;
    private readonly ILoggerService _logger;
    public RegistrationDataLayer(
        IWeighterDatabase weighterDatabase,
        ILoggerService loggerService)
    {
        _weighterDatabase = weighterDatabase;
        _logger = loggerService;
    }

    public bool Register(RegistrationDetailsViewModel registrationDetailsViewModel)
    {
        try
        {
            _weighterDatabase.Add(registrationDetailsViewModel.User);
            registrationDetailsViewModel.LinkSettingsToUser();
            _weighterDatabase.Add(registrationDetailsViewModel.Settings);
            return true;
        }
        catch (Exception e)
        {
            _logger.LogException(e);
            return false;
        }
    }
}