using AutoMapper;
namespace Business.Common.Models
{
    public interface IModel
    {
        void CreateMap(Profile profile);

        void Init();
    }
}
