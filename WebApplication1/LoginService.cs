using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace WebApplication1
{
    public class LoginService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public void Login()
        {
            var client = _httpClientFactory.CreateClient("webtest");

            client.GetAsync("account/login");
        }
    }
}
