using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Mdw.Components.Footer
{
    public class DefaultFooterProvider : IDefaultFooterProvider, ITransientDependency
    {
        public virtual string Title => @"Address|Title";
        public virtual string Contact1 => @"Address|Contact|1";
        public virtual string Contact2 => @"Address|Contact|2";
        public virtual string Contact3 => @"Address|Contact|3";

        public string Line1 => @"Address|Line|1";
        public string Line2 => @"Address|Line|2";
    }
}
