using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using System.Text;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {

        public APIResponse responseModel { get; set; }
        public IHttpClientFactory httpClient { get; set; }
        public object JsonConvert { get; private set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new();
            this.httpClient = httpClient;
        }

        public Task<T> SendAsync<T>(APIRequest apiRequest)
        {      
        }
    }
}
