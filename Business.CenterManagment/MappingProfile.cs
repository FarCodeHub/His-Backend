using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Common.Models;

namespace Business.CenterManagment
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            var type = typeof(IModel);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToList();


            //  CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConverter());
            foreach (var t in types)
                t.GetMethod("CreateMap").Invoke(t.Assembly.CreateInstance(t.FullName), new object[] { this });

        }
    }
}
