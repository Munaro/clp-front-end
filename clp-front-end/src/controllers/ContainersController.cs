using System;
using System.Net.Http;
using System.Threading.Tasks;
using clp_front_end.src.clients;
using clp_front_end.src.exceptions;
using clp_front_end.src.models;

namespace clp_front_end.src.controllers
{
    public class ContainersController
    {
        public static async Task Create(ContainersControllerModel.Create createParams)
        {
            try
            {
                await RestClient.SendRequest<object>(HttpMethod.Post, "/containers", createParams);
            }
            catch (RestClientException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task Update(ContainersControllerModel.Update updateParams)
        {
            try
            {
                await RestClient.SendRequest<object>(HttpMethod.Put, "/containers", updateParams);
            }
            catch (RestClientException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<ContainersControllerModel.Get[]> Get()
        {
            try
            {
                RestClientResponse<ContainersControllerModel.Get[]> response = await RestClient.SendRequest<ContainersControllerModel.Get[]>(HttpMethod.Get, "/containers");                

                return response.Data;
            }
            catch (RestClientException ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public static async Task<ContainersControllerModel.GetData> GetData()
        {
            try
            {
                RestClientResponse<ContainersControllerModel.GetData> response = await RestClient.SendRequest<ContainersControllerModel.GetData>(HttpMethod.Get, "/containers?data=true");                
                return response.Data;
            }
            catch (RestClientException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
