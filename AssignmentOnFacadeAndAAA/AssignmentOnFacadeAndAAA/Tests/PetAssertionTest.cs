using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentOnFacadeAndAAA.DataModels;
using AssignmentOnFacadeAndAAA.Resources;
using AssignmentOnFacadeAndAAA.Helpers;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AssignmentOnFacadeAndAAA.Tests
{
    [TestClass]
    public class PetAssertionTest : APIBaseTest
    {
        private static List<PetJsonModel> petCleanUpList = new List<PetJsonModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task GetPet()
        {
            //Arrange
            var getRequest = new RestRequest(Endpoints.GetPedById(PetDetails.Id));
            petCleanUpList.Add(PetDetails);

            //Act
            var getResponse = await RestClient.ExecuteGetAsync<PetJsonModel>(getRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, getResponse.StatusCode, "Failed due to wrong status code.");
            Assert.AreEqual(PetDetails.Name, getResponse.Data.Name);
            Assert.AreEqual(PetDetails.PhotoUrls[0], getResponse.Data.PhotoUrls[0]);
            Assert.AreEqual(PetDetails.Tags[0].Id, getResponse.Data.Tags[0].Id);
            Assert.AreEqual(PetDetails.Tags[0].Name, getResponse.Data.Tags[0].Name);
            Assert.AreEqual(PetDetails.Status, getResponse.Data.Status);
        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deleteRequest = new RestRequest(Endpoints.GetPedById(data.Id));
                var deleteResponse = await RestClient.DeleteAsync(deleteRequest);
            }
        }
    }
}
