using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace CustomHelpers
{
    [HtmlTargetElement("a",Attributes ="asp-active-link")]
    public class AspactivelinkTagHelper: TagHelper
    {

        public string CssClassName { get; set; }
        //private const string ActiveCssClass = "active";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.Attributes.SetAttribute("class",CssClassName);
        }
    }
}