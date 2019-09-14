using Abp.AspNetCore.Mvc.ViewComponents;

namespace AAC.ABPDemo.Web.Views
{
    public abstract class ABPDemoViewComponent : AbpViewComponent
    {
        protected ABPDemoViewComponent()
        {
            LocalizationSourceName = ABPDemoConsts.LocalizationSourceName;
        }
    }
}
