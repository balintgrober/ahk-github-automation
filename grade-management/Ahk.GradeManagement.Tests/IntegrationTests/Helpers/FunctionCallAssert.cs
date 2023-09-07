using System;
using System.Threading.Tasks;
using Ahk.GradeManagement.ResultProcessing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ahk.GradeManagement.Tests.IntegrationTests
{
    internal static class FunctionCallAssert
    {
        public static Task<IActionResult> Invoke(this MockResultProcessingFunction function, Action<HttpRequest> configureRequest)
        {
            var context = new DefaultHttpContext();
            var req = context.Request;
            req.Scheme = "https";
            req.Method = "POST";
            req.Host = new HostString("api.something.com");
            req.Path = "/api/path-to-something";
            configureRequest(req);

            return function.Run(req, Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance);
        }

        public static async Task<TResponse> InvokeAndGetResponseAs<TResponse>(this MockResultProcessingFunction function, Action<HttpRequest> configureRequest)
            where TResponse : IActionResult
        {
            var result = await function.Invoke(configureRequest);
            Assert.IsInstanceOfType(result, typeof(TResponse));
            return (TResponse)result;
        }

        public static async Task<TResponse> InvokeWithContentAndGetResponseAs<TResponse>(this MockResultProcessingFunction function, SampleCallbackData data, IDateTimeProvider dateTimeProvider)
            where TResponse : IActionResult
        {
            var result = await function.Invoke(req => configureRequest(req, data, dateTimeProvider));
            Assert.IsInstanceOfType(result, typeof(TResponse));
            return (TResponse)result;
        }

        private static void configureRequest(HttpRequest req, SampleCallbackData data, IDateTimeProvider dateTimeProvider)
        {
            req.Headers.Add("X-Ahk-Token", data.Token);
            req.Headers.Add("X-Ahk-Sha256", data.Signature);
            req.Headers.Add("Date", dateTimeProvider.GetUtcNow().ToString("R"));

            var memStream = new System.IO.MemoryStream();
            using var writer = new System.IO.StreamWriter(memStream, leaveOpen: true);
            writer.Write(data.Body);
            writer.Flush();

            memStream.Position = 0;
            req.Body = memStream;
        }
    }
}
