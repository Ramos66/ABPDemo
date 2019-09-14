using System.Threading.Tasks;
using AAC.ABPDemo.Configuration.Dto;

namespace AAC.ABPDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
