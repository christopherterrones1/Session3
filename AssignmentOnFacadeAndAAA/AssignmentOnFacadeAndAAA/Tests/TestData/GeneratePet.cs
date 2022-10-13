using AssignmentOnFacadeAndAAA.DataModels;
using System;

namespace AssignmentOnFacadeAndAAA.Tests.TestData
{
    public class GeneratePet
    {
        public static PetJsonModel petDetails()
        {
            Random rnd = new Random();
            int randomId = rnd.Next(10000000, 99999999);
            int randomPetId = rnd.Next(1, 99);
            int randomPetTagId = rnd.Next(1, 99);

            Category category = new Category();
            category.Id = randomPetId;
            category.Name = "Dog";

            Category tag = new Category();
            tag.Id = randomPetTagId;
            tag.Name = "Siberian Husky";

            List<string> photoUrls = new List<string>();
            photoUrls.Add("www.google.com");

            List<Category> tags = new List<Category>();
            tags.Add(tag);

            return new PetJsonModel
            {
                Id = randomId,
                Category = category,
                Name = "Saber",
                PhotoUrls = photoUrls,
                Tags = tags,
                Status = "Available"
            };
        }
    }
}
