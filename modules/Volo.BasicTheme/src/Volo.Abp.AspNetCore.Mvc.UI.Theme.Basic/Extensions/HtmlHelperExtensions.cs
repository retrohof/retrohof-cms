using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Extensions
{
	public static class HtmlHelperExtensions
	{
		public static IHtmlContent RenderImage(this IHtmlHelper helper, string attributes)
		{
			var result = attributes.Split(',')
				 .Select(x => x.Split(':'))
				 .ToDictionary(x => x[0], x => x[1]);

			var css = result["css"];
			var src = result["src"];
			var alt = result["alt"];
			var title = result["title"];

			return new HtmlString($"<img class=\"{css}\" src=\"{src}\" alt=\"{alt}\" title=\"{title}\">");
		}

		public static IHtmlContent RenderAnchor(this IHtmlHelper helper, string attributes)
		{
			var result = attributes.Split(',')
				 .Select(x => x.Split(':'))
				 .ToDictionary(x => x[0], x => x[1]);

			var css = result["css"];
			var href = result["href"];
			var title = result["title"];
			var text = result["text"];

			return new HtmlString($"<a class=\"{css}\" href=\"{href}\" title=\"{title}\">{text}</a>");
		}

        public static IHtmlContent RenderParagraph(this IHtmlHelper helper, string innerHtml)
        {
            return RenderTextTag(helper, "p", innerHtml);
        }

        public static IHtmlContent RenderH1(this IHtmlHelper helper, string innerHtml)
		{
			return RenderTextTag(helper, "h1", innerHtml);
		}

		public static IHtmlContent RenderH2(this IHtmlHelper helper, string innerHtml)
		{
			return RenderTextTag(helper, "h2", innerHtml);
		}

        public static IHtmlContent RenderH3(this IHtmlHelper helper, string innerHtml)
        {
            return RenderTextTag(helper, "h3", innerHtml);
        }

        public static IHtmlContent RenderTextTag(this IHtmlHelper helper, string tag, string innerHtml)
		{
			return new HtmlString($"<{tag}>{innerHtml}</{tag}>");
		}
	}
}
