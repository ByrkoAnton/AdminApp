using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Text;
using AdminApp.Config;

namespace AdminApp.Middlewares
{
    //public class JwtMiddleware
    //{
    //    private readonly RequestDelegate _next;

    //    public TokenConfig Token { get; }

    //    public JwtMiddleware(RequestDelegate next, IOptions<TokenConfig> options)
    //    {
    //        _next = next;
    //        Token = options.Value;
    //    }

    //    public async Task InvokeAsync(HttpContext context)
    //    {
    //        await _next.Invoke(context);
    //    }
    //}
}
