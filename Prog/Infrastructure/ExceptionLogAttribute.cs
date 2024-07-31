using Microsoft.AspNetCore.Mvc.Filters;
using Prog.Services;

namespace Prog.Infrastructure
{
	public class ExceptionLogAttribute: ExceptionFilterAttribute
	{
		private IMyLogger logger;
        public ExceptionLogAttribute(IMyLogger _logger)
        {
            logger = _logger;
			
        }
        public override void OnException(ExceptionContext context)
		{
			logger.WriteLog($"Exception message: {context.Exception.Message}");
			logger.WriteLog($"Trace: {context.Exception.StackTrace}");
		}
		public override async Task OnExceptionAsync(ExceptionContext context)
		{
			await logger.WriteLogAsync($"Exception message: {context.Exception.Message}");
			await logger.WriteLogAsync($"Trace: {context.Exception.StackTrace}");

		}

	}
}
