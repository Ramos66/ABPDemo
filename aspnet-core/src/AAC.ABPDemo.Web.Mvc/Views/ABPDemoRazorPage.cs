using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AAC.ABPDemo.Web.Views
{
    public abstract class ABPDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPDemoRazorPage()
        {
            LocalizationSourceName = ABPDemoConsts.LocalizationSourceName;
        }
    }
}
