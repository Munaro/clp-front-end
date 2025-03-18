using System;
using System.Net.Http;
using System.Threading.Tasks;
using clp_front_end.src.clients;
using clp_front_end.src.exceptions;
using clp_front_end.src.models;


namespace clp_front_end.src.controllers
{
    public class LocationsController
    {
        public static async Task<LocationsControllerModel.Get[]> Get(bool isEmpty = false)
        {
            try
            {
                string urlParams = isEmpty ? "?isEmpty=true" : "";
                RestClientResponse<LocationsControllerModel.Get[]> response = await RestClient.SendRequest<LocationsControllerModel.Get[]>(HttpMethod.Get, $"/locations{urlParams}");

                return response.Data;
            }
            catch (RestClientException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
