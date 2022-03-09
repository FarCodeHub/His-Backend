using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
    public class MenuItemModel : IModel
    {

        public string RoleTitle { get; set; }
        public int RoleId { get; set; }
        public int MenuItemId { get; set; }
        public string MenuTitle { get; set; }
        public List<MenuItemModel> Children { get; set; }
        public int? ParentId { get;  set; }
        public string IconUrl { get;  set; }
        public string RoutePath { get;  set; }

        public void CreateMap(Profile profile)
        {
            
        }

        public void Init()
        {
           
        }
    }
}
