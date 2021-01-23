using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace Session12Pro.TagHelpers
{
    public class CardTagHelper : TagHelper
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserRole { get; set; }

       
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "Card";
            output.TagMode = TagMode.StartTagAndEndTag;
            var content = new StringBuilder();
            content.Append($"<div class=\"card\"><div class=\"card-header\">{Name}</div><div class=\"card-body\">{Description}</div><div class=\"card-footer\">{UserRole}</div></div>");

            output.PreContent.SetHtmlContent(content.ToString());


        }


    }
}
