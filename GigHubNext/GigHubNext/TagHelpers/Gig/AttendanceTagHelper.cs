using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GigHubNext.TagHelpers.Gig
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("attendance")]
    public class AttendanceTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            output.Content.SetHtmlContent("Going?");

            output.Attributes.Add("class", "btn btn-default btn-sm pull-right");

            
        }
    }
}
