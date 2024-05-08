using System.Collections.Generic;
using System.Linq;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Providers
{
    public interface IContactInformationProvider
    {
        string TagLine { get; }

        KeyValuePair<string, string> GetAddressLine(int index);
        KeyValuePair<string, string> GetContact(int index);
    }

    public record ContactInfo(string Title, string Value);

    public class ContactInformationProvider : IContactInformationProvider, ITransientDependency
    {
        public virtual string TagLine => @"I believe in Simple, Creative & Flexible Design Standards.";

        private IDictionary<string, string> Contacts => new Dictionary<string, string>{
            { "Office", "0207 112 7588" },
            { "Mobile", "07777 123456" },
            { "Email", "erindontrack@gmail.com" }
        };

        private IDictionary<string, string> AddressLines => new Dictionary<string, string>{
            { "Office", "Office"},
            { "Line1", "Twickenham Trading Estate" },
            { "Line2", "Rugby road, London, TW1 1DQ" }
        };

        public KeyValuePair<string, string> GetContact(int index)
        {
            return Contacts.Skip(index).First();
        }

        public KeyValuePair<string, string> GetAddressLine(int index)
        {
            return AddressLines.Skip(index).First();
        }
    }
}
