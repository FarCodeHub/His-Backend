using Business.Common.IServices;
using Business.Common.Models;
using Core.His.Models;
using DataAccess.Repositories.His;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Common.Services
{
    public class MainService : IMainService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRoleRepository roleRepository;
        private readonly IUserRoleRepository userRoleRepository;
        private readonly IUserRepository userRepository;
        private readonly IRolePermissionRepository rolePermissionRepository;
        private readonly IPermissionRepository permissionRepository;
        private readonly IMenuItemRepository menuItemRepository;

        public MainService(IUnitOfWork unitOfWork,
            IRoleRepository roleRepository,
            IUserRoleRepository userRoleRepository,
            IUserRepository userRepository,
            IRolePermissionRepository rolePermissionRepository,
            IPermissionRepository permissionRepository,
            IMenuItemRepository menuItemRepository)
        {
            this.unitOfWork = unitOfWork;

            this.roleRepository = roleRepository;
            this.roleRepository.UnitOfWork = unitOfWork;

            this.rolePermissionRepository = rolePermissionRepository;
            this.rolePermissionRepository.UnitOfWork = unitOfWork;

            this.permissionRepository = permissionRepository;
            this.permissionRepository.UnitOfWork = unitOfWork;

            this.menuItemRepository = menuItemRepository;
            this.menuItemRepository.UnitOfWork = unitOfWork;

            this.userRepository = userRepository;
            this.userRepository.UnitOfWork = unitOfWork;

            this.userRoleRepository = userRoleRepository;
            this.userRoleRepository.UnitOfWork = unitOfWork;


        }



        public async Task<ResponseResult> GetMenuItems(UserModel userModel)
        {

            var menus = await (from ur in userRoleRepository.GetAll()
                                      join r in roleRepository.GetAll() on ur.RoleId equals r.Id
                                      join rp in rolePermissionRepository.GetAll() on r.Id equals rp.RoleId
                                      join p in permissionRepository.GetAll() on rp.PermissionId equals p.Id
                                      join m in menuItemRepository.GetAll() on p.Id equals m.PermissionId
                                      where ur.UserId == userModel.Id
                                      select new MenuItemModel
                                      {
                                        MenuItemId = m.Id,
                                        MenuTitle = m.MenuTitle,
                                        IconUrl = m.IconUrl,
                                          RoutePath = m.RoutePath

                                      }).ToListAsync();

            var menuIds = menus.Select(x => x.MenuItemId).ToList();

            var children = await (from m in menuItemRepository.GetAll()
                                  where menuIds.Contains((int)m.ParentId)
                                  select new MenuItemModel
                                  {
                                      MenuItemId = m.Id,
                                      MenuTitle = m.MenuTitle,
                                      ParentId = m.ParentId,
                                      IconUrl = m.IconUrl,
                                      RoutePath = m.RoutePath
                                  }).ToListAsync();

            foreach (var item in menus)
                item.Children = children.Where(x => x.ParentId == item.MenuItemId).ToList();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = menus
            };
        }



    }
}
