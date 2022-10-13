using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOnFacadeAndAAA.Resources
{
    /// <summary>
    /// Class containing all endpoints used in API tests
    /// </summary>
    public class Endpoints
    {
        //Base URL
        public const string baseURL = "https://petstore.swagger.io/v2";

        public static string GetPedById(long petId) => $"{baseURL}/pet/{petId}";

        public static string PostPet() => $"{baseURL}/pet";

        public static string DeletePetByPetId(long petId) => $"{baseURL}/pet/{petId}";
    }
}
