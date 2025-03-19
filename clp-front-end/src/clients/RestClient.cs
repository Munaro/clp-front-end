using clp_front_end.src.exceptions;
using clp_front_end.src.models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace clp_front_end.src.clients
{
    public static class RestClient
    {
        private static readonly HttpClient _client = new HttpClient();
        static RestClient()
        {
            _client.BaseAddress = new Uri("http://localhost:3000");
            _client.Timeout = TimeSpan.FromSeconds(30);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        private static string GetSuccessMessage(System.Net.HttpStatusCode StatusCode, HttpMethod Method)
        {
            if (StatusCode == System.Net.HttpStatusCode.OK)
            {
                switch (Method.Method.ToUpper())
                {
                    case "DELETE":
                        return "Registro excluído!";
                    case "PUT":
                    case "PATCH":
                        return "Registro alterado!";
                    case "POST":
                        return "Registro criado!";
                    default:
                        return "Ok!";
                }
            }
            else if (StatusCode == System.Net.HttpStatusCode.Created && Method.Method.ToUpper() == "POST")
            {
                return "Registro criado!";
            }
            return "Ok!";
        }
        private static string GetErrorMessage(HttpResponseMessage RepsonseMessage)
        {
            string ErrorMessage = RepsonseMessage.Content.ReadAsStringAsync().Result;
            dynamic JsonResponse = JsonConvert.DeserializeObject(ErrorMessage);            
            return JsonResponse?.message ?? $"{(int)RepsonseMessage.StatusCode} - Falha na comunicação!";
        }
        public static async Task<RestClientResponse<T>> SendRequest<T>(HttpMethod method, string endpoint, object payload = null)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, endpoint);

            if (payload != null)
            {
                string jsonPayload = JsonConvert.SerializeObject(payload);
                request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            }
            try
            {
                HttpResponseMessage response = await _client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    string message = GetSuccessMessage(response.StatusCode, method);
                    return new RestClientResponse<T>
                    {
                        StatusCode = response.StatusCode,
                        Data = !string.IsNullOrWhiteSpace(responseBody) ? JsonConvert.DeserializeObject<T>(responseBody) : default(T),
                        Message = message
                    };
                }
                else
                {
                    string errorMessage = GetErrorMessage(response);                    
                    throw new RestClientException(response.StatusCode, errorMessage);
                }
            }
            catch (Exception ex)
            {
                throw new RestClientException(System.Net.HttpStatusCode.ServiceUnavailable, $"{ex.Message}", ex);
            }
        }
    }
}
