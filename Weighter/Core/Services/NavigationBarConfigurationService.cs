using System.Diagnostics.CodeAnalysis;
using Weighter.Core.Enums;
using Weighter.Core.Models.UI;
using Weighter.Core.Services.Interfaces;
using Weighter.Resources.Copy_Registers;

namespace Weighter.Core.Services
{
    public class NavigationBarConfigurationService : INavigationBarConfigurationService
    {
        public static NavigationBarConfiguration Configuration(NavigationBarActionType actionType)
        {
            switch (actionType)
            {
                case NavigationBarActionType.Close:
                    return Close();

                case NavigationBarActionType.Back:
                    return Back();

                case NavigationBarActionType.Next:
                    return Next();

                case NavigationBarActionType.Done:
                    return Done();

                case NavigationBarActionType.None:
                default:
                    return None();
            }
        }

        [ExcludeFromCodeCoverage]
        public NavigationBarConfiguration GetConfiguration(NavigationBarActionType actionType)
        {
            return Configuration(actionType);
        }

        private static NavigationBarConfiguration Close()
        {
            return new NavigationBarConfiguration(
                "ic_close",
                GlobalRegister.GLOBAL_003,
                GlobalRegister.GLOBAL_003,
                true);
        }

        private static NavigationBarConfiguration Back()
        {
            return new NavigationBarConfiguration(
                "ic_left_arrow",
                GlobalRegister.GLOBAL_004,
                GlobalRegister.GLOBAL_004,
                true);
        }

        private static NavigationBarConfiguration Next()
        {
            return new NavigationBarConfiguration(
                "ic_right_arrow",
                GlobalRegister.GLOBAL_002,
                GlobalRegister.GLOBAL_002,
                true);
        }

        private static NavigationBarConfiguration Done()
        {
            return new NavigationBarConfiguration(
                string.Empty,
                GlobalRegister.GLOBAL_005,
                GlobalRegister.GLOBAL_005,
                true);
        }

        private static NavigationBarConfiguration None()
        {
            return new NavigationBarConfiguration(
                string.Empty,
                string.Empty,
                string.Empty,
                false);
        }
    }
}