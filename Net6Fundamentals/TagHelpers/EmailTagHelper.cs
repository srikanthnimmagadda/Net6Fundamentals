using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Net6Fundamentals.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string? Address { get; set; }
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(Content);
        }
    }
}
