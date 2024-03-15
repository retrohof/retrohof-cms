using System.Collections.Generic;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Providers
{
    public interface IServicesProvidedProvider
    {
        List<ServiceProvided> Services { get; }
    }

    public record ServiceProvided(string HRef, string DisplayName, string Title = "");

    public class ServicesProvider : IServicesProvidedProvider, ITransientDependency
    {
        public List<ServiceProvided> Services => new List<ServiceProvided> {
            new ServiceProvided("Curtain-Tracks", "Straight/Bay Tracks", "Straight/Bay Tracks"),
            new ServiceProvided("Curtain-Poles", "Curtain Poles", "Curtain Poles"),
            new ServiceProvided("", "Divider", ""),
            new ServiceProvided("Curtains", "Curtains", "Curtains"),
            new ServiceProvided("", "Divider", ""),
            new ServiceProvided("Roman-Blinds", "Roman Blinds", "Roman Blinds"),
            new ServiceProvided("Roller-Blinds", "Roller Blinds", "Roller Blinds")
        };
    }
}
