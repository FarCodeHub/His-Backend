using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class PortalHisContext : DbContext
    {
        public PortalHisContext()
        {
        }

        public PortalHisContext(DbContextOptions<PortalHisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<BaseValue> BaseValues { get; set; }
        public virtual DbSet<BaseValueType> BaseValueTypes { get; set; }
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<BuyMessage> BuyMessages { get; set; }
        public virtual DbSet<CardCode> CardCodes { get; set; }
        public virtual DbSet<CenterLocation> CenterLocations { get; set; }
        public virtual DbSet<CenterService> CenterServices { get; set; }
        public virtual DbSet<CenterSpeciality> CenterSpecialities { get; set; }
        public virtual DbSet<CenterStaff> CenterStaffs { get; set; }
        public virtual DbSet<CenterType> CenterTypes { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DataTransferConvert> DataTransferConverts { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugForm> DrugForms { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<GenericDrug> GenericDrugs { get; set; }
        public virtual DbSet<GeoLocation> GeoLocations { get; set; }
        public virtual DbSet<GiftReason> GiftReasons { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<MedicalCenter> MedicalCenters { get; set; }
        public virtual DbSet<MedicalStaff> MedicalStaffs { get; set; }
        public virtual DbSet<MedicalStaffCertificate> MedicalStaffCertificates { get; set; }
        public virtual DbSet<MedicalStaffSpeciality> MedicalStaffSpecialities { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<OwnershipType> OwnershipTypes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientExtraInfo> PatientExtraInfos { get; set; }
        public virtual DbSet<PatientFile> PatientFiles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual DbSet<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
        public virtual DbSet<PrescriptionServiceResult> PrescriptionServiceResults { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<RequestService> RequestServices { get; set; }
        public virtual DbSet<Rh> Rhs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<ScheduleDetail> ScheduleDetails { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }
        public virtual DbSet<SmsGiftReason> SmsGiftReasons { get; set; }
        public virtual DbSet<SmsOperator> SmsOperators { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<StoregCondition> StoregConditions { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCardCode> UserCardCodes { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<WorkTimeType> WorkTimeTypes { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=144.76.219.132;Database=PortalHis;Persist Security Info=True;User ID=salehi;Password=Salehi##123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.SmsToken).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CardCode)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.CardCodeId)
                    .HasConstraintName("FK_AspNetUsers_CardCode");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_AspNetUsers_Person");
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BaseValue>(entity =>
            {
                entity.ToTable("BaseValue", "common");

                entity.Property(e => e.OldDbid).HasColumnName("OldDBId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.Property(e => e.UniqueName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.BaseValueType)
                    .WithMany(p => p.BaseValues)
                    .HasForeignKey(d => d.BaseValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BaseValue_BaseValueType");
            });

            modelBuilder.Entity<BaseValueType>(entity =>
            {
                entity.ToTable("BaseValueType", "common");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.SubSystem).HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.UniqueName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.ToTable("_BloodGroup", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BuyMessage>(entity =>
            {
                entity.ToTable("BuyMessage", "sms");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.BuyMessages)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_BuyMessage_MedicalCenter");
            });

            modelBuilder.Entity<CardCode>(entity =>
            {
                entity.ToTable("CardCode", "person");

                entity.Property(e => e.HealthNumber).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Serial).HasMaxLength(255);

                entity.Property(e => e.Token).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<CenterLocation>(entity =>
            {
                entity.ToTable("CenterLocation", "center");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.PostalCode).HasMaxLength(25);

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterLocations)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_CenterLocation_MedicalCenter");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CenterLocationCities)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_CenterLocation_GeoLocation3");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CenterLocationCountries)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CenterLocation_GeoLocation1");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.CenterLocationLocations)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_CenterLocation_GeoLocation");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.CenterLocationProvinces)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_CenterLocation_GeoLocation2");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.CenterLocationZones)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_CenterLocation_GeoLocation4");
            });

            modelBuilder.Entity<CenterService>(entity =>
            {
                entity.ToTable("_CenterService", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterServices)
                    .HasForeignKey(d => d.CenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterService_MedicalCenter");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.CenterServices)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterService_ServiceType");
            });

            modelBuilder.Entity<CenterSpeciality>(entity =>
            {
                entity.ToTable("CenterSpeciality", "center");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterSpecialities)
                    .HasForeignKey(d => d.CenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterSpeciality_MedicalCenter");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.CenterSpecialities)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterSpeciality_Speciality");
            });

            modelBuilder.Entity<CenterStaff>(entity =>
            {
                entity.ToTable("CenterStaff", "center");

                entity.Property(e => e.ActiveTime).HasColumnType("datetime");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterStaffs)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_CenterStaff_MedicalCenter");

                entity.HasOne(d => d.MedicalStaff)
                    .WithMany(p => p.CenterStaffs)
                    .HasForeignKey(d => d.MedicalStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterStaff_MedicalStaff");
            });

            modelBuilder.Entity<CenterType>(entity =>
            {
                entity.ToTable("_CenterType", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Translate).HasMaxLength(100);
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.ToTable("Certificate", "convert");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.TitleLang2).HasMaxLength(250);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("_City", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_City_Province");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company", "drug");

                entity.Property(e => e.Address).HasMaxLength(2500);

                entity.Property(e => e.Boss).HasMaxLength(100);

                entity.Property(e => e.BossPhone).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.NationalId).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Visitor).HasMaxLength(100);

                entity.Property(e => e.VisitorPhone).HasMaxLength(20);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("_Country", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<DataTransferConvert>(entity =>
            {
                entity.ToTable("DataTransferConvert", "convert");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TableId).HasMaxLength(500);

                entity.Property(e => e.TableName).HasMaxLength(500);

                entity.Property(e => e.TargetTableId).HasMaxLength(500);
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.ToTable("Drugs", "drug");

                entity.Property(e => e.ContentsOf).HasMaxLength(150);

                entity.Property(e => e.LocalCode).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Drugs_Company");

                entity.HasOne(d => d.DrugForm)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.DrugFormId)
                    .HasConstraintName("FK_Drugs_DrugForm");

                entity.HasOne(d => d.Generic)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.GenericId)
                    .HasConstraintName("FK_Drugs_GenericDrug");

                entity.HasOne(d => d.StoregConditon)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.StoregConditonId)
                    .HasConstraintName("FK_Drugs_BaseValue");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Drugs_Unit");
            });

            modelBuilder.Entity<DrugForm>(entity =>
            {
                entity.ToTable("DrugForm", "drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("_Education", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.ToTable("File", "common");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileFolderName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Type).HasComment("1= png\r\n2=jpg\r\n3=pdf\r\n4=folder");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_File_MedicalCenter");
            });

            modelBuilder.Entity<GenericDrug>(entity =>
            {
                entity.ToTable("GenericDrug", "drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.TitleLang2).HasMaxLength(250);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GenericDrugs)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_GenericDrug_Group");
            });

            modelBuilder.Entity<GeoLocation>(entity =>
            {
                entity.ToTable("GeoLocation", "common");

                entity.Property(e => e.Title).HasMaxLength(80);

                entity.Property(e => e.TitleLang2).HasMaxLength(80);

                entity.Property(e => e.Type).HasComment("Country : 1 , Province :2 , City : 3 , Zone : 4");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_GeoLocation_GeoLocation");
            });

            modelBuilder.Entity<GiftReason>(entity =>
            {
                entity.ToTable("GiftReason", "sms");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.GiftReasons)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_GitReason_Province");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group", "drug");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("_Job", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<MedicalCenter>(entity =>
            {
                entity.ToTable("MedicalCenter", "center");

                entity.Property(e => e.AnswerTime).HasMaxLength(20);

                entity.Property(e => e.Boss).HasMaxLength(100);

                entity.Property(e => e.BossPhone).HasMaxLength(100);

                entity.Property(e => e.CenterTypeId).HasComment("Hospital : 1 , Clinic :2 , Section :3 , Lab:4");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CostVisit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PhoneResponseHourse).HasMaxLength(20);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VisitorPhone).HasMaxLength(20);

                entity.HasOne(d => d.CenterType)
                    .WithMany(p => p.MedicalCenterCenterTypes)
                    .HasForeignKey(d => d.CenterTypeId)
                    .HasConstraintName("FK_MedicalCenter_BaseValue2");

                entity.HasOne(d => d.OwnerShipBase)
                    .WithMany(p => p.MedicalCenterOwnerShipBases)
                    .HasForeignKey(d => d.OwnerShipBaseId)
                    .HasConstraintName("FK_MedicalCenter_BaseValue");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_MedicalCenter_MedicalCenter1");

                entity.HasOne(d => d.WorkTimeBase)
                    .WithMany(p => p.MedicalCenterWorkTimeBases)
                    .HasForeignKey(d => d.WorkTimeBaseId)
                    .HasConstraintName("FK_MedicalCenter_BaseValue1");
            });

            modelBuilder.Entity<MedicalStaff>(entity =>
            {
                entity.ToTable("MedicalStaff", "center");

                entity.Property(e => e.EmployeeDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalSystemNo).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.TypeBaseId).HasComment("Doctor : 1 , Nurse : 2 , Experts :3");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MedicalStaffs)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalStaff_Person");

                entity.HasOne(d => d.TypeBase)
                    .WithMany(p => p.MedicalStaffs)
                    .HasForeignKey(d => d.TypeBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalStaff_BaseValue");
            });

            modelBuilder.Entity<MedicalStaffCertificate>(entity =>
            {
                entity.ToTable("MedicalStaffCertificate", "center");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.MedicalStaffCertificates)
                    .HasForeignKey(d => d.CertificateId)
                    .HasConstraintName("FK_MedicalStaffCertificate_Certificate");

                entity.HasOne(d => d.MedicalStaff)
                    .WithMany(p => p.MedicalStaffCertificates)
                    .HasForeignKey(d => d.MedicalStaffId)
                    .HasConstraintName("FK_MedicalStaffCertificate_MedicalStaff");
            });

            modelBuilder.Entity<MedicalStaffSpeciality>(entity =>
            {
                entity.ToTable("MedicalStaffSpeciality", "center");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalStaff)
                    .WithMany(p => p.MedicalStaffSpecialities)
                    .HasForeignKey(d => d.MedicalStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalStaffSpeciality_MedicalStaff");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.MedicalStaffSpecialities)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalStaffSpeciality_Speciality");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("MenuItems", "common");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IconUrl).HasMaxLength(150);

                entity.Property(e => e.MenuTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RoutePath)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.MenuItems)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_MenuItems_Permissions");
            });

            modelBuilder.Entity<OwnershipType>(entity =>
            {
                entity.ToTable("_OwnershipType", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient", "patient");

                entity.Property(e => e.Allergies).HasMaxLength(1500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileNo).HasMaxLength(20);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Hisno).HasColumnName("HISNo");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.BloodGroupBase)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.BloodGroupBaseId)
                    .HasConstraintName("FK_Patient_BaseValue2");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Patient_Person");
            });

            modelBuilder.Entity<PatientExtraInfo>(entity =>
            {
                entity.ToTable("PatientExtraInfo", "patient");

                entity.Property(e => e.ChronicIllnessId).HasComment("معرف");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.JobTypeId).HasComment("محل کار");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.PassportIssueDate).HasColumnType("datetime");

                entity.Property(e => e.PassportNumber).HasMaxLength(50);

                entity.Property(e => e.RhId).HasComment("فاکتوری در خون");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Word).HasMaxLength(250);

                entity.Property(e => e.WorkAddress).HasMaxLength(250);

                entity.Property(e => e.WorkPhone).HasMaxLength(12);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PaitientExtraInfo_Patient");
            });

            modelBuilder.Entity<PatientFile>(entity =>
            {
                entity.ToTable("PatientFile", "patient");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.PatientFiles)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientFile_File");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientFiles)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientFile_Patient");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permissions", "common");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PermissionTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person", "person");

                entity.Property(e => e.Address).HasMaxLength(350);

                entity.Property(e => e.Avatar).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.FullNameThree).HasMaxLength(100);

                entity.Property(e => e.GrandFatherName).HasMaxLength(100);

                entity.Property(e => e.GreatGrandFatherName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LatinName).HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(30);

                entity.Property(e => e.MotherName).HasMaxLength(100);

                entity.Property(e => e.NationalCode).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.ShNo).HasMaxLength(50);

                entity.HasOne(d => d.Expertise)
                    .WithMany(p => p.PersonExpertises)
                    .HasForeignKey(d => d.ExpertiseId)
                    .HasConstraintName("FK_Person_BaseValue1");

                entity.HasOne(d => d.MaritalBase)
                    .WithMany(p => p.PersonMaritalBases)
                    .HasForeignKey(d => d.MaritalBaseId)
                    .HasConstraintName("FK_Person_BaseValue");

                entity.HasOne(d => d.SexBase)
                    .WithMany(p => p.PersonSexBases)
                    .HasForeignKey(d => d.SexBaseId)
                    .HasConstraintName("FK_Person_BaseValue2");
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.ToTable("Prescription", "patient");

                entity.Property(e => e.Biography).HasMaxLength(4000);

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Diet).HasMaxLength(4000);

                entity.Property(e => e.InteractionsNote).HasMaxLength(4000);

                entity.Property(e => e.MainDoctorNote).HasMaxLength(4000);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.PharmacistNoteForNursing).HasMaxLength(4000);

                entity.Property(e => e.PostMedicalHistory).HasMaxLength(4000);

                entity.Property(e => e.PrescriptionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_Prescription_MedicalCenter");

                entity.HasOne(d => d.MedicalStaff)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.MedicalStaffId)
                    .HasConstraintName("FK_Prescription_MedicalStaff");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Prescription_Patient");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_Prescription_Reception");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Prescription_User");
            });

            modelBuilder.Entity<PrescriptionDetailDrug>(entity =>
            {
                entity.ToTable("PrescriptionDetailDrug", "patient");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Drugs");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Prescription");
            });

            modelBuilder.Entity<PrescriptionDetailService>(entity =>
            {
                entity.ToTable("PrescriptionDetailService", "patient");

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ شروع اقدام همچنین تاریخی که بخش مقصد این درخواست را میبیند در تناوب ها هم کاربرد دارد");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.PanelId).HasComment("در صورتی که سرویس ایدی خالی باشد");

                entity.Property(e => e.PrescriptionInstructionId).HasComment("دستور العمل انجام مثلا هر هشت ساعت یه بار");

                entity.Property(e => e.PrescriptionTypeId).HasComment("تشخیصی درمانی مراقبتی");

                entity.Property(e => e.RequestFromSectionId).HasComment("از چه بخشی درخواست شده اگر در خود بخش انجام شود ایدی بخش جاری می خورد");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailService_Prescription");
            });

            modelBuilder.Entity<PrescriptionServiceResult>(entity =>
            {
                entity.ToTable("PrescriptionServiceResult", "patient");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Result2).HasMaxLength(4000);

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionServiceResults)
                    .HasForeignKey(d => d.PrescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrescriptionServiceResult_Prescription");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("_Province", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Province_Country");
            });

            modelBuilder.Entity<Reception>(entity =>
            {
                entity.ToTable("Reception", "patient");

                entity.Property(e => e.Advice).HasMaxLength(2000);

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.ChiefComplaints).HasMaxLength(2000);

                entity.Property(e => e.ConsumeDrug).HasMaxLength(400);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfSign).HasColumnType("datetime");

                entity.Property(e => e.HospitalEnteryDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.RecoveryDate).HasColumnType("datetime");

                entity.Property(e => e.RefferDate).HasColumnType("datetime");

                entity.Property(e => e.ResultNote).HasMaxLength(2500);

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Receptions)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_Reception_MedicalCenter");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Receptions)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Reception_MedicalStaff");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Receptions)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Reception_Patient");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.Receptions)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .HasConstraintName("FK_Reception_ServiceType");
            });

            modelBuilder.Entity<RequestService>(entity =>
            {
                entity.ToTable("RequestService", "convert");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DoctorDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExtraPayment).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Note)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PatientShare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrescriptionShare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Providershare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SectionDiscount)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TechnicalShare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MedicalStaff)
                    .WithMany(p => p.RequestServices)
                    .HasForeignKey(d => d.MedicalStaffId)
                    .HasConstraintName("FK_RequestService_MedicalStaff");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.RequestServices)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_RequestService_Reception");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.RequestServices)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_RequestService_Schedule");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.RequestServices)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .HasConstraintName("FK_RequestService_ServiceType");
            });

            modelBuilder.Entity<Rh>(entity =>
            {
                entity.ToTable("Rh", "convert");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Roles", "common");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RoleTitle)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.UniqueName).HasMaxLength(50);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("RolePermissions", "common");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermissions_Permissions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermissions_Roles");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule", "convert");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.Property(e => e.VisitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_Schedule_MedicalCenter");

                entity.HasOne(d => d.MedicalStaff)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.MedicalStaffId)
                    .HasConstraintName("FK_Schedule_MedicalStaff");
            });

            modelBuilder.Entity<ScheduleDetail>(entity =>
            {
                entity.ToTable("ScheduleDetail", "convert");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalStaff)
                    .WithMany(p => p.ScheduleDetails)
                    .HasForeignKey(d => d.MedicalStaffId)
                    .HasConstraintName("FK_ScheduleDetail_MedicalStaff");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleDetails)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_ScheduleDetail_Schedule");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("_Services", "temp");

                entity.Property(e => e.AbbreviationTitle).HasMaxLength(255);

                entity.Property(e => e.BasePrice).HasColumnType("money");

                entity.Property(e => e.Component).HasMaxLength(255);

                entity.Property(e => e.FormulaExpr).HasMaxLength(200);

                entity.Property(e => e.HourToResponseEmergency).HasComment("روزانه را هم به صورت ساعت در این فیلد ذخیره می شود");

                entity.Property(e => e.HourToResponseNormal).HasComment("روزانه را هم به صورت ساعت در این فیلد ذخیره می شود");

                entity.Property(e => e.InterNationalCode).HasMaxLength(255);

                entity.Property(e => e.LabTypeId).HasComment("هر آزمایش در نوعی دیگر دسته¬بندی شده و بر اساس دسته بندی، در شرایط خاصی برای دریافت نمونه و جواب¬دهی با آن برخورد می-شود. این آزمایشات در ثبت و روش انجام با هم تفاوت دارند. به همین جهت، در ثبت آزمایش مهم است که نوع آزمایش مشخص شود.");

                entity.Property(e => e.LatinDescription)
                    .HasMaxLength(100)
                    .HasComment("abbreviation name in lab test");

                entity.Property(e => e.LocalCode).HasMaxLength(255);

                entity.Property(e => e.LongCommonName).HasMaxLength(255);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.OrderObservationId).HasColumnName("OrderOBServationId");

                entity.Property(e => e.RelatedNames).HasMaxLength(255);

                entity.Property(e => e.SampleSize).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.TitleLang2).HasMaxLength(100);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Services_ParentServices");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .HasConstraintName("FK_Service_ServiceType");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.ToTable("ServiceType", "convert");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.InternationalCode).HasMaxLength(50);

                entity.Property(e => e.LocalCode).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.ToTable("_Sex", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(80);

                entity.Property(e => e.Code2).HasMaxLength(80);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.NoteLang2).HasMaxLength(4000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.TitleLang2).HasMaxLength(25);
            });

            modelBuilder.Entity<SmsGiftReason>(entity =>
            {
                entity.ToTable("SmsGiftReason", "sms");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SmsOperator>(entity =>
            {
                entity.ToTable("SmsOperators", "sms");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("Speciality", "center");

                entity.Property(e => e.AbbreviationTitle).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<StoregCondition>(entity =>
            {
                entity.ToTable("StoregCondition", "drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit", "drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "person");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MacAddress).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.SmsToken).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.CardCode)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CardCodeId)
                    .HasConstraintName("FK_User_CardCode");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_User_Person");
            });

            modelBuilder.Entity<UserCardCode>(entity =>
            {
                entity.ToTable("UserCardCode", "person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.HasOne(d => d.CardCode)
                    .WithMany(p => p.UserCardCodes)
                    .HasForeignKey(d => d.CardCodeId)
                    .HasConstraintName("FK_UserCardCode_CardCode");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCardCodes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserCardCode_User");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRoles", "common");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_User");
            });

            modelBuilder.Entity<WorkTimeType>(entity =>
            {
                entity.ToTable("_WorkTimeType", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.ToTable("_Zone", "temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Zone_City");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Zone_Zone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
