using Weighter.Features.Registration._ViewModels;

namespace Weighter.Core.DataLayers.Interfaces;

public interface IRegistrationDataLayer
{
    bool Register(RegistrationDetailsViewModel registrationDetailsViewModel);
}