using Business.CenterManagment.IServices;
using Business.CenterManagment.Services;
using Business.Common;
using Business.Common.IServices;
using Business.Common.Services;
using Business.DoctorManagment.IServices;
using Business.DoctorManagment.Services;
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.EF.His;
using DataAccess.Repositories.His;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace PortalHisApi
{
    public class ServiceRegistry
    {

        
        public static void RegisterServices(IServiceCollection services,string connectionString, IConfiguration Configuration)
        {

            // ---- Connection string
            
            services.AddDbContext<PortalHisContext>(x => x.UseSqlServer(connectionString,opt=>opt.EnableRetryOnFailure()));

            // ----- Auto Mapper
            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(MappingProfile).Assembly,typeof(Business.CenterManagment.MappingProfile).Assembly);



            RegisterRepositories(services);

            RegisterServices(services);

            RegisterJWT(services, Configuration);

        }
        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, EFUnitOfWork>();


            //// --- Repositories
            ///


            services.AddTransient<IBaseValueRepository, BaseValueRepository>();
            services.AddTransient<IBaseValueTypeRepository, BaseValueTypeRepository>();
            services.AddTransient<ICenterLocationRepository, CenterLocationRepository>();
            services.AddTransient<ICenterServiceRepository, CenterServiceRepository>();

            services.AddTransient<ICenterSpecialityRepository, CenterSpecialityRepository>();
            services.AddTransient<ICenterStaffRepository, CenterStaffRepository>();
            services.AddTransient<IGeoLocationRepository, GeoLocationRepository>();
            services.AddTransient<IMedicalStaffRepository, MedicalStaffRepository>();
            services.AddTransient<IMedicalStaffSpecialityRepository, MedicalStaffSpecialityRepository>();
            services.AddTransient<IPatientRepository, PatientRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IReceptionRepository, ReceptionRepository>();
            services.AddTransient<IRequestServiceRepository, RequestServiceRepository>();
            services.AddTransient<IScheduleDetailRepository, ScheduleDetailRepository>();
            services.AddTransient<IScheduleRepository, ScheduleRepository>();
            services.AddTransient<IServiceTypeRepository, ServiceTypeRepository>();
            services.AddTransient<ISpecialityRepository, SpecialityRepository>();
            services.AddTransient<IMedicalCenterRepository, MedicalCenterRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();

            services.AddTransient<IOwnershipTypeRepository, OwnershipTypeRepository>();
            services.AddTransient<ICenterTypeRepository, CenterTypeRepository>();
            services.AddTransient<IMenuItemRepository, MenuItemRepository>();
            services.AddTransient<IPermissionRepository, PermissionRepository>();
            services.AddTransient<IRolePermissionRepository, RolePermissionRepository>();
            services.AddTransient<IDrugRepository, DrugRepository>();
            services.AddTransient<IPrescriptionRepository, PrescriptionRepository>();
            services.AddTransient<IPrescriptionDetailDrugRepository, PrescriptionDetailDrugRepository>();
            services.AddTransient<IPatientFileRepository, PatientFileRepository>();
            services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
        }

        private static void RegisterServices(IServiceCollection services)
        {

            //// --- Services

            services.AddTransient<IDoctorManagmentService, DoctorManagmentService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IMedicalCenterService, MedicalCenterService>();
            services.AddTransient<ICommonService, CommonService>();
            services.AddTransient<IMedicalStaffService, MedicalStaffService>();
            services.AddTransient<IMedicalSpecialityService, MedicalSpecialityService>();
            services.AddTransient<IMainService, MainService>();
            services.AddTransient<IPatientService, PatientService>();
        }
        private static void RegisterJWT(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });
        }

    }
}
