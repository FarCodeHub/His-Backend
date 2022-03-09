using AutoMapper;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
    public class FileModel : File, IModel
    {
        public void CreateMap(Profile profile)
        {
            profile.CreateMap<FileModel, File>();
            profile.CreateMap<File, FileModel>();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
