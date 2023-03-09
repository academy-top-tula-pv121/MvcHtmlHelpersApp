using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcHtmlHelpersApp.Views.Helpers
{
    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper htmlHelper, string[] items)
        {
            string htmlList = "<ul>";
            foreach (var item in items)
                htmlList += $"<li>{item}</li>";
            htmlList += "</ul>";
            return new HtmlString(htmlList);
        }
    }
}
