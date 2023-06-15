using System.Diagnostics.CodeAnalysis;
using Weighter.Features.Dashboard;

namespace Weighter.Core.Services
{
    public partial class NavigationService
    {
        public const string Startup = $"{nameof(NavigationPage)}/{nameof(DashboardPage)}";
    }
}