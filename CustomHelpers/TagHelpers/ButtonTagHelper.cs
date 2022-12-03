using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomHelpers
{
    [HtmlTargetElement("commandbutton")]
    public class ButtonTagHelper:TagHelper
    {
        public string Type { get; set; } = "Submit";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName= "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("type", Type);
            output.Content.SetContent("Custom Command Button");
        }
    }
}
