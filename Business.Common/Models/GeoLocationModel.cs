using AutoMapper;
using Business.Common.Models;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
    public class GeoLocationModel : IModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public List<GeoLocationModel> Childern { get; set; }
        public void CreateMap(Profile profile)
        {
            profile.CreateMap<GeoLocationModel, GeoLocation>();
            profile.CreateMap<GeoLocation, GeoLocationModel>();
        }
        public void Init()
        {
        }
    }
}
