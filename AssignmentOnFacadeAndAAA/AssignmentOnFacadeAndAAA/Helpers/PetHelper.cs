using RestSharp;
using AssignmentOnFacadeAndAAA.DataModels;
using AssignmentOnFacadeAndAAA.Resources;
using AssignmentOnFacadeAndAAA.Tests.TestData;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace AssignmentOnFacadeAndAAA.Helpers
{
    /// <summary>
    /// Send POST request to add new pet
    /// </summary>
    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new pet
        /// </summary>
        ///

        public static async Task<PetJsonModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.petDetails();
            var postRequest = new RestRequest(Endpoints.PostPet());

            //Send Post Request to add new user
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetJsonModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
