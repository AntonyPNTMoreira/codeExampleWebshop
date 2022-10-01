using Microsoft.AspNetCore.Mvc;

namespace Howest.DeVarens.Web.Areas.Admin.Models
{
    public class CheckboxHelper
    {
        public bool IsSelected { get; set; }
        [HiddenInput]
        public long Id { get; set; }
        [HiddenInput]
        public string Text { get; set; }
    }
}
