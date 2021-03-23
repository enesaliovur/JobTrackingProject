using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.Entities.Concrete;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.TagHelpers
{
    [HtmlTargetElement("getDutyAppUserId")]
    public class DutyAppUserIdTagHelper : TagHelper
    {
        private readonly IDutyService _dutyService;

        public DutyAppUserIdTagHelper(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        public int AppUserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            List<Duty> duties = _dutyService.GetDutyOfAppUser(AppUserId);
            int Finished = duties.Where(I => I.Condition).Count();
            int Unfinished = duties.Where(I => !I.Condition).Count();

            string HtmlString = $"<strong>Tamamladığı görev sayısı :</strong>  { Finished }<br>" +
                $"<strong>Aktif görev sayısı:</strong>{Unfinished}";

            output.Content.SetHtmlContent(HtmlString);
        }
    }
}
