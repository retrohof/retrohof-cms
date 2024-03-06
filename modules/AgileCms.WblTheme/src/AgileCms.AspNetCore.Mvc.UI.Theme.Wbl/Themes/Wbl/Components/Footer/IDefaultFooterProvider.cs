﻿namespace AgileCms.AspNetCore.Mvc.UI.Theme.Wbl.Themes.Wbl.Components.Footer
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