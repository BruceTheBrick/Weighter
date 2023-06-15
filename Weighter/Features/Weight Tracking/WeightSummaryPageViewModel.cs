using Weighter.Core.Services.Interfaces;

namespace Weighter.Features.Weight_Tracking
{
    public class WeightSummaryPageViewModel : BasePageViewModel
    {
        public WeightSummaryPageViewModel(IBaseService baseService) 
            : base(baseService)
        {
        }
    }
}