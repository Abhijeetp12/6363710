using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Task_3_4.Filters
{
    public class CustomExceptionFilter:IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "logs.txt");
            File.AppendAllText(filePath, $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}");

            context.Result = new ObjectResult("An unexpected error occurred")
            {
                StatusCode = 500
            };
        }
    }
}
