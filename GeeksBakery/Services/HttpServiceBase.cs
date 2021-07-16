using GeeksBakery.Utilities.SystemConstants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Services
{
    public class HttpServiceBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        protected HttpServiceBase(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        protected async Task<HttpResponseMessage> HttpPostAsync(string uri, StringContent content)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new Exception("Uri request cannot null");
            }
            var sessions = GetToken();
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.ApiAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            return await client.PostAsync(uri, content);
        }

        protected async Task<HttpResponseMessage> HttpGetAsync(string uri)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new Exception("Uri request cannot null");
            }
            var sessions = GetToken();

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.ApiAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            return await client.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> HttpDeleteAsync(string uri)
        {
            var sessions = GetToken();
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.ApiAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            return await client.DeleteAsync(uri);
        }

        private string GetToken()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);

            return token;
        }
    }
}