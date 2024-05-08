using System.Collections.Generic;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Providers
{
    public interface ISocialMediaIconsProvider
    {
        List<SocialMediaIcon> Icons { get; }
    }

    public record SocialMediaIcon(string HRef, string Bg, string Fa);

    public class SocialMediaIconsProvider : ISocialMediaIconsProvider, ITransientDependency
    {
        public List<SocialMediaIcon> Icons => new List<SocialMediaIcon> {
            new SocialMediaIcon("#", "bg-facebook", "fa-facebook-f"),
            new SocialMediaIcon("#", "bg-instagram", "fa-instagram"),
            new SocialMediaIcon("#", "bg-x", "fa-x")
        };
    }
}
