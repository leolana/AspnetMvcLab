using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using Castle.Core.Logging;

namespace LogHoras.Web.ActionFilters.ApiFilters
{
    public class LogUncaughtExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private ILogger _logger = NullLogger.Instance;

        [ExcludeFromCodeCoverage]
        public ILogger Logger
        {
            get { return _logger; }
            set { _logger = value; }
        }

        public override bool AllowMultiple
        {
            get { return false; }
        }

        public override void OnException(HttpActionExecutedContext context)
        {
            var ex = context.Exception;
            if (ex == null) return;

            Logger.Fatal(ex.Message, ex);
            context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }
    }
}