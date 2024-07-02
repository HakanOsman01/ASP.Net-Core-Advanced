using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Asp.Net.CoreDemo_Advanced
{
    [HtmlTargetElement("h1")]
    public class HelloTagHelper : TagHelper
    {
        private const string MessageFormat = "Hello, {0}";
        public string TargetName { get; set; } = null!;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string formatMessage = string.Format(MessageFormat, TargetName);
            output.Content.SetContent(formatMessage);
          
        }


    }
}
