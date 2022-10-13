using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using AssignmentOnFacadeAndAAA.DataModels;

namespace AssignmentOnFacadeAndAAA.Tests
{
    public class APIBaseTest
    {
        public RestClient RestClient { get; set; }

        public PetJsonModel PetDetails { get; set; }

        [TestInitialize]
        public void Initilize()
        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
