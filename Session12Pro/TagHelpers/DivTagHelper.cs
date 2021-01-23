using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session12Pro.TagHelpers
{
    [HtmlTargetElement("div",Attributes = "active-primary")]
    public class DivTagHelper:TagHelper
    {
        public bool ActivePrimary { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (ActivePrimary)
            {
                output.TagName = "a";
                output.Attributes.Add("class", "btn btn-primary");
            }
           
        }
    }
}
