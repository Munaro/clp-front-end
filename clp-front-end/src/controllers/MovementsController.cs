using System;
using System.Net.Http;
using System.Threading.Tasks;
using clp_front_end.src.clients;
using clp_front_end.src.exceptions;
using clp_front_end.src.models;
using Newtonsoft.Json;

namespace clp_front_end.src.controllers
{
    public class MovementsController
    {
        public static async Task<MovementsControllerModel.Get[]> Get(int id)
        {
            try
            {
                RestClientResponse<MovementsControllerModel.Get[]> response = await RestClient.SendRequest<MovementsControllerModel.Get[]>(HttpMethod.Get, $"/movements/{id}");

                return response.Data;
            }
            catch (RestClientException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static async Task ChangePosition(MovementsControllerModel.ChangePosition changePositionParams)
        {
            try
            {                
                await RestClient.SendRequest<object>(HttpMethod.Put, "/movements", changePositionParams);                
            }
            catch (RestClientException ex)
            {                
                throw new Exception(ex.Message);
            }
        }
    }
}
