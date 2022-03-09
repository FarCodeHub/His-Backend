using DataAccess.Entities.His.Entities;
using AutoMapper;
namespace Business.Common.Models
{
    public class PersonModel : Person,IModel
    {
        public void CreateMap(Profile profile)
        {
            profile.CreateMap<PersonModel, Person>();
            profile.CreateMap<Person, PersonModel>();
        }

        public void Init()
        {
            throw new System.NotImplementedException();
        }
    }
}
