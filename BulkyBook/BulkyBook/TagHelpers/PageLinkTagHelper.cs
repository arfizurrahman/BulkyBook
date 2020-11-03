using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BulkyBook.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public bool PageClassesEnabled { get; set; }
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder result = new TagBuilder("div");

            TagBuilder prevTag = new TagBuilder("a");
            string prevUrl = PageModel.UrlParam.Replace(":", (PageModel.CurrentPage - 1).ToString());
            prevTag.AddCssClass(PageClass);
            prevTag.AddCssClass(PageClassNormal);
            if (PageModel.CurrentPage > 1)
            {
                prevTag.Attributes["href"] = prevUrl;
            }
            prevTag.InnerHtml.Append("Prev");
            result.InnerHtml.AppendHtml(prevTag);

            for (int i = 1; i <= PageModel.TotalPage; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                string url = PageModel.UrlParam.Replace(":", i.ToString());
                tag.Attributes["href"] = url;
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }

                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            }
            TagBuilder nextTag = new TagBuilder("a");
            string nextUrl = PageModel.UrlParam.Replace(":", (PageModel.CurrentPage+1).ToString());
            nextTag.AddCssClass(PageClass);
            nextTag.AddCssClass(PageClassNormal);
            if (PageModel.CurrentPage + 1 <= PageModel.TotalPage)
            {
                nextTag.Attributes["href"] = nextUrl;
            }
            nextTag.InnerHtml.Append("Next");
            result.InnerHtml.AppendHtml(nextTag);

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
