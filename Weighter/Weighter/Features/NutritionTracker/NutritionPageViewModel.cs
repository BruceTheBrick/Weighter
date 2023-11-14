using Weighter.Core;

namespace Weighter.Features;

public class NutritionPageViewModel : BaseTabbedPageViewModel
{
    public NutritionPageViewModel(IBaseService baseService)
        : base("Nutrition", "ic_food", baseService)
    {
    }
}