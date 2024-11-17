using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Utils
{
    internal class CustomHttpContextAccessor : IHttpContextAccessor
    {
        private static readonly HttpContext _httpContext;
        static CustomHttpContextAccessor()
        {
            _httpContext = new DefaultHttpContext
            {
                User = new ClaimsPrincipal(new ClaimsIdentity())
            };
        }

        public HttpContext HttpContext
        {
            get => _httpContext;
            set => throw new NotSupportedException();
        }
    }
}
