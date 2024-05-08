namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components
{
    public interface IDefaultFooterProvider
    {
        string Title { get; }
        string Contact1 { get; }
        string Contact2 { get; }
        string Contact3 { get; }
        string Line1 { get; }
        string Line2 { get; }
    }
}