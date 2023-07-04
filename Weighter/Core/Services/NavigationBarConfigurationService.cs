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

        public NavigationBarConfiguration GetConfiguration(NavigationBarActionType actionType)
        {
            return Configuration(actionType);
        }

        private static NavigationBarConfiguration Close()
        {
            return new NavigationBarConfiguration
            {
                IconSource = "ic_close", AccessibilityName = GlobalRegister.GLOBAL_003, Text = string.Empty,
            };
        }

        private static NavigationBarConfiguration Back()
        {
            return new NavigationBarConfiguration
            {
                IconSource = "ic_left_arrow", AccessibilityName = GlobalRegister.GLOBAL_004, Text = string.Empty,
            };
        }

        private static NavigationBarConfiguration Next()
        {
            return new NavigationBarConfiguration
            {
                IconSource = "ic_right_arrow", AccessibilityName = GlobalRegister.GLOBAL_002, Text = string.Empty,
            };
        }

        private static NavigationBarConfiguration Done()
        {
            return new NavigationBarConfiguration
            {
                IconSource = string.Empty, AccessibilityName = GlobalRegister.GLOBAL_005, Text = GlobalRegister.GLOBAL_005,
            };
        }

        private static NavigationBarConfiguration None()
        {
            return new NavigationBarConfiguration
            {
                IconSource = string.Empty, AccessibilityName = string.Empty, Text = string.Empty,
            };
        }
    }
}