using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace iOBC.ActionFilters
{
    internal class CamelJsonFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
                return;

            var result = (JsonResult) filterContext.Result;

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            var serialized = JsonConvert.SerializeObject(result.Data, settings);

            filterContext.Result = new ContentResult
            {
                Content = serialized,
                ContentType = "application/json"
            };
        }
    }
}