using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace Session12Pro.TagHelpers
{
    public class Card2TagHelper : TagHelper
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserRole { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var card = new TagBuilder("div");
            card.AddCssClass("card");
            var header = new TagBuilder("div");
            header.AddCssClass("card-header");
            header.InnerHtml.Append(Name);

            var body= new TagBuilder("div");
            body.AddCssClass("card-body");
            body.InnerHtml.Append(Description);

            var footer = new TagBuilder("div");
            footer.AddCssClass("card-footer");
            footer.InnerHtml.Append(UserRole);

            card.InnerHtml.AppendHtml(header);
            card.InnerHtml.AppendHtml(body);
            card.InnerHtml.AppendHtml(footer);

            output.SuppressOutput();
            output.Content.AppendHtml(card);

        }
     



    }
}
