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
    public class FileModel : IModel
    {
        public int Id { get; set; }
        public string FileFolderName { get; set; }
        public int Type { get; set; }
        public int? ParentFolderId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string ExtensionFile { get; set; }
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
