using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PortalContext : DbContext
    {
        public PortalContext()
        {
        }

        public PortalContext(DbContextOptions<PortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<Allergy> Allergies { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Answer1> Answers1 { get; set; }
        public virtual DbSet<AnswerService> AnswerServices { get; set; }
        public virtual DbSet<AppointmentType> AppointmentTypes { get; set; }
        public virtual DbSet<AspNetUsersOk> AspNetUsersOks { get; set; }
        public virtual DbSet<BackupT> BackupTs { get; set; }
        public virtual DbSet<BagBlood> BagBloods { get; set; }
        public virtual DbSet<BasketDrug> BasketDrugs { get; set; }
        public virtual DbSet<Bed> Beds { get; set; }
        public virtual DbSet<BedReception> BedReceptions { get; set; }
        public virtual DbSet<BedReserveStatus> BedReserveStatuses { get; set; }
        public virtual DbSet<BedStatus> BedStatuses { get; set; }
        public virtual DbSet<BedType> BedTypes { get; set; }
        public virtual DbSet<BloodBankLabelStyle> BloodBankLabelStyles { get; set; }
        public virtual DbSet<BloodBankLabeling> BloodBankLabelings { get; set; }
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<BloodProductType> BloodProductTypes { get; set; }
        public virtual DbSet<BloodStatus> BloodStatuses { get; set; }
        public virtual DbSet<BloodStatusHistory> BloodStatusHistories { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BuyMessage> BuyMessages { get; set; }
        public virtual DbSet<CardCode> CardCodes { get; set; }
        public virtual DbSet<CardCode210308> CardCode210308s { get; set; }
        public virtual DbSet<CashStatus> CashStatuses { get; set; }
        public virtual DbSet<CauseBloodNeed> CauseBloodNeeds { get; set; }
        public virtual DbSet<Center> Centers { get; set; }
        public virtual DbSet<CenterExamPlace> CenterExamPlaces { get; set; }
        public virtual DbSet<CenterSellingType> CenterSellingTypes { get; set; }
        public virtual DbSet<CenterService> CenterServices { get; set; }
        public virtual DbSet<CenterType> CenterTypes { get; set; }
        public virtual DbSet<CenterWorkItem> CenterWorkItems { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ClearanceType> ClearanceTypes { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAndType> CompanyAndTypes { get; set; }
        public virtual DbSet<CompanyPersonality> CompanyPersonalities { get; set; }
        public virtual DbSet<CompanyType> CompanyTypes { get; set; }
        public virtual DbSet<ConsumptionInstruction> ConsumptionInstructions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DataTransferConvert> DataTransferConverts { get; set; }
        public virtual DbSet<DataTransferConvertDoctor> DataTransferConvertDoctors { get; set; }
        public virtual DbSet<DataType> DataTypes { get; set; }
        public virtual DbSet<DefineRoutine> DefineRoutines { get; set; }
        public virtual DbSet<DefineRoutineTest> DefineRoutineTests { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Diagnosis> Diagnoses { get; set; }
        public virtual DbSet<DiagnosisStatus> DiagnosisStatuses { get; set; }
        public virtual DbSet<Diet> Diets { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorAppointment> DoctorAppointments { get; set; }
        public virtual DbSet<DoctorAppointmentDetail> DoctorAppointmentDetails { get; set; }
        public virtual DbSet<DoctorAppointmentDetailStatus> DoctorAppointmentDetailStatuses { get; set; }
        public virtual DbSet<DoctorCertificate> DoctorCertificates { get; set; }
        public virtual DbSet<DoctorDayOff> DoctorDayOffs { get; set; }
        public virtual DbSet<DoctorDegree> DoctorDegrees { get; set; }
        public virtual DbSet<DoctorService> DoctorServices { get; set; }
        public virtual DbSet<DoctorVisitType> DoctorVisitTypes { get; set; }
        public virtual DbSet<DoctorsOk> DoctorsOks { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugForm> DrugForms { get; set; }
        public virtual DbSet<DrugInteraction> DrugInteractions { get; set; }
        public virtual DbSet<DrugStoregCondition> DrugStoregConditions { get; set; }
        public virtual DbSet<DurationType> DurationTypes { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Examplace> Examplaces { get; set; }
        public virtual DbSet<Expertise> Expertises { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileGroup> FileGroups { get; set; }
        public virtual DbSet<FileTag> FileTags { get; set; }
        public virtual DbSet<Frequency> Frequencies { get; set; }
        public virtual DbSet<GeneralStatus> GeneralStatuses { get; set; }
        public virtual DbSet<GenericDrug> GenericDrugs { get; set; }
        public virtual DbSet<GiftReason> GiftReasons { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupAnswer> GroupAnswers { get; set; }
        public virtual DbSet<GroupAnswer1> GroupAnswers1 { get; set; }
        public virtual DbSet<GroupReadyAnswer> GroupReadyAnswers { get; set; }
        public virtual DbSet<GroupReadyAnswer1> GroupReadyAnswers1 { get; set; }
        public virtual DbSet<Illness> Illnesses { get; set; }
        public virtual DbSet<ImportedDicom> ImportedDicoms { get; set; }
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<Interaction> Interactions { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Kit> Kits { get; set; }
        public virtual DbSet<LabType> LabTypes { get; set; }
        public virtual DbSet<LabelBloodBag> LabelBloodBags { get; set; }
        public virtual DbSet<LabelSampleTest> LabelSampleTests { get; set; }
        public virtual DbSet<LabelSampleTestStyle> LabelSampleTestStyles { get; set; }
        public virtual DbSet<LogPortal> LogPortals { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MethodType> MethodTypes { get; set; }
        public virtual DbSet<MobileActivation> MobileActivations { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<OwnershipType> OwnershipTypes { get; set; }
        public virtual DbSet<PackagingType> PackagingTypes { get; set; }
        public virtual DbSet<PanelType> PanelTypes { get; set; }
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientExtraInfo> PatientExtraInfos { get; set; }
        public virtual DbSet<PatientHistoryBloodTransfusion> PatientHistoryBloodTransfusions { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Pcr> Pcrs { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionSectionField> PermissionSectionFields { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Pharmacy> Pharmacies { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<PregnancySeason> PregnancySeasons { get; set; }
        public virtual DbSet<PrescribtionType> PrescribtionTypes { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionAllergy> PrescriptionAllergies { get; set; }
        public virtual DbSet<PrescriptionChartActionType> PrescriptionChartActionTypes { get; set; }
        public virtual DbSet<PrescriptionChartCancelationReason> PrescriptionChartCancelationReasons { get; set; }
        public virtual DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public virtual DbSet<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual DbSet<PrescriptionDetailDrugHistory> PrescriptionDetailDrugHistories { get; set; }
        public virtual DbSet<PrescriptionDetailPharmacistNote> PrescriptionDetailPharmacistNotes { get; set; }
        public virtual DbSet<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
        public virtual DbSet<PrescriptionDetailServiceHistory> PrescriptionDetailServiceHistories { get; set; }
        public virtual DbSet<PrescriptionDiet> PrescriptionDiets { get; set; }
        public virtual DbSet<PrescriptionDrugChart> PrescriptionDrugCharts { get; set; }
        public virtual DbSet<PrescriptionDrugRoutine> PrescriptionDrugRoutines { get; set; }
        public virtual DbSet<PrescriptionGroupItem> PrescriptionGroupItems { get; set; }
        public virtual DbSet<PrescriptionGroupSetting> PrescriptionGroupSettings { get; set; }
        public virtual DbSet<PrescriptionHistoryStatus> PrescriptionHistoryStatuses { get; set; }
        public virtual DbSet<PrescriptionInstruction> PrescriptionInstructions { get; set; }
        public virtual DbSet<PrescriptionPanel> PrescriptionPanels { get; set; }
        public virtual DbSet<PrescriptionRoutine> PrescriptionRoutines { get; set; }
        public virtual DbSet<PrescriptionServiceChart> PrescriptionServiceCharts { get; set; }
        public virtual DbSet<PrescriptionServiceResult> PrescriptionServiceResults { get; set; }
        public virtual DbSet<PrescriptionServiceRoutine> PrescriptionServiceRoutines { get; set; }
        public virtual DbSet<PrescriptionSetting> PrescriptionSettings { get; set; }
        public virtual DbSet<PrescriptionShare> PrescriptionShares { get; set; }
        public virtual DbSet<PrescriptionSign> PrescriptionSigns { get; set; }
        public virtual DbSet<PrescriptionType> PrescriptionTypes { get; set; }
        public virtual DbSet<Presenter> Presenters { get; set; }
        public virtual DbSet<PriceTypeMethod> PriceTypeMethods { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<ProceedFromBagNumber> ProceedFromBagNumbers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProhibitedUsage> ProhibitedUsages { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual DbSet<PurposeRequestBlood> PurposeRequestBloods { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<ReadyAnswer> ReadyAnswers { get; set; }
        public virtual DbSet<ReadyAnswer1> ReadyAnswers1 { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<Reception1> Receptions1 { get; set; }
        public virtual DbSet<ReceptionAnswer> ReceptionAnswers { get; set; }
        public virtual DbSet<ReceptionDetail> ReceptionDetails { get; set; }
        public virtual DbSet<ReceptionDiagnosis> ReceptionDiagnoses { get; set; }
        public virtual DbSet<ReceptionDiagnosisHistory> ReceptionDiagnosisHistories { get; set; }
        public virtual DbSet<ReceptionDrug> ReceptionDrugs { get; set; }
        public virtual DbSet<ReceptionHistory> ReceptionHistories { get; set; }
        public virtual DbSet<ReceptionSectionDoctor> ReceptionSectionDoctors { get; set; }
        public virtual DbSet<ReceptionService> ReceptionServices { get; set; }
        public virtual DbSet<ReceptionServiceStatus> ReceptionServiceStatuses { get; set; }
        public virtual DbSet<ReceptionSign> ReceptionSigns { get; set; }
        public virtual DbSet<ReceptionType> ReceptionTypes { get; set; }
        public virtual DbSet<RefferFrom> RefferFroms { get; set; }
        public virtual DbSet<RefferReason> RefferReasons { get; set; }
        public virtual DbSet<RelatedTest> RelatedTests { get; set; }
        public virtual DbSet<RelationShip> RelationShips { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestDetail> RequestDetails { get; set; }
        public virtual DbSet<RequestDetail1> RequestDetails1 { get; set; }
        public virtual DbSet<RequestHistory> RequestHistories { get; set; }
        public virtual DbSet<RequestStatus> RequestStatuses { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        public virtual DbSet<RespiratoryService> RespiratoryServices { get; set; }
        public virtual DbSet<Rh> Rhs { get; set; }
        public virtual DbSet<RichLongAnswer> RichLongAnswers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleGroup> RoleGroups { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<SampleType> SampleTypes { get; set; }
        public virtual DbSet<SamplerType> SamplerTypes { get; set; }
        public virtual DbSet<Sampling> Samplings { get; set; }
        public virtual DbSet<SamplingHistory> SamplingHistories { get; set; }
        public virtual DbSet<SamplingStatus> SamplingStatuses { get; set; }
        public virtual DbSet<ScaleType> ScaleTypes { get; set; }
        public virtual DbSet<Scientificlevel> Scientificlevels { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SectionEssentialsDrug> SectionEssentialsDrugs { get; set; }
        public virtual DbSet<SectionEssentialsGenericDrug> SectionEssentialsGenericDrugs { get; set; }
        public virtual DbSet<SectionField> SectionFields { get; set; }
        public virtual DbSet<SectionKind> SectionKinds { get; set; }
        public virtual DbSet<SectionProperty> SectionProperties { get; set; }
        public virtual DbSet<SectionPropertyList> SectionPropertyLists { get; set; }
        public virtual DbSet<SectionService> SectionServices { get; set; }
        public virtual DbSet<SectionStatus> SectionStatuses { get; set; }
        public virtual DbSet<SectionStore> SectionStores { get; set; }
        public virtual DbSet<SectionType> SectionTypes { get; set; }
        public virtual DbSet<SellingType> SellingTypes { get; set; }
        public virtual DbSet<SendSmsStatus> SendSmsStatuses { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceCoding> ServiceCodings { get; set; }
        public virtual DbSet<ServiceLevel> ServiceLevels { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Setting1> Settings1 { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }
        public virtual DbSet<ShiftHour> ShiftHours { get; set; }
        public virtual DbSet<ShortLink> ShortLinks { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<Sign> Signs { get; set; }
        public virtual DbSet<SmsCenterBalance> SmsCenterBalances { get; set; }
        public virtual DbSet<SmsCenterCharge> SmsCenterCharges { get; set; }
        public virtual DbSet<SmsGiftReason> SmsGiftReasons { get; set; }
        public virtual DbSet<SmsOperator> SmsOperators { get; set; }
        public virtual DbSet<SmsPrice> SmsPrices { get; set; }
        public virtual DbSet<SmsReception> SmsReceptions { get; set; }
        public virtual DbSet<SpecialIllness> SpecialIllnesses { get; set; }
        public virtual DbSet<SpecialIllnessReception> SpecialIllnessReceptions { get; set; }
        public virtual DbSet<StoreDrug> StoreDrugs { get; set; }
        public virtual DbSet<StoreEntery> StoreEnteries { get; set; }
        public virtual DbSet<StoreEntry> StoreEntries { get; set; }
        public virtual DbSet<StoreEntryDetail> StoreEntryDetails { get; set; }
        public virtual DbSet<StoreTransfer> StoreTransfers { get; set; }
        public virtual DbSet<StoreTransferDetail> StoreTransferDetails { get; set; }
        public virtual DbSet<StoregCondition> StoregConditions { get; set; }
        public virtual DbSet<SubSystem> SubSystems { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<TempPationlist> TempPationlists { get; set; }
        public virtual DbSet<TempReceptions08> TempReceptions08s { get; set; }
        public virtual DbSet<TempUserRolePermission07> TempUserRolePermission07s { get; set; }
        public virtual DbSet<TemperatureType> TemperatureTypes { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TestAnswerTime> TestAnswerTimes { get; set; }
        public virtual DbSet<TestAnswerType> TestAnswerTypes { get; set; }
        public virtual DbSet<TestLabeling> TestLabelings { get; set; }
        public virtual DbSet<TestRange> TestRanges { get; set; }
        public virtual DbSet<TimeAspct> TimeAspcts { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Unit1> Units1 { get; set; }
        public virtual DbSet<Unit2> Units2 { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCardCode> UserCardCodes { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRolePermission> UserRolePermissions { get; set; }
        public virtual DbSet<ValidityPeriod> ValidityPeriods { get; set; }
        public virtual DbSet<VisitType> VisitTypes { get; set; }
        public virtual DbSet<VitalSign> VitalSigns { get; set; }
        public virtual DbSet<WayOfPrescription> WayOfPrescriptions { get; set; }
        public virtual DbSet<WorkTimeType> WorkTimeTypes { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Portal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActionType>(entity =>
            {
                entity.ToTable("ActionType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.ToTable("Allergy");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Answer_Question");
            });

            modelBuilder.Entity<Answer1>(entity =>
            {
                entity.ToTable("Answer", "Lab");

                entity.Property(e => e.Comment).HasMaxLength(2500);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.HasOne(d => d.ReadyAnswer)
                    .WithMany(p => p.Answer1s)
                    .HasForeignKey(d => d.ReadyAnswerId)
                    .HasConstraintName("FK_Answer_ReadyAnswer");

                entity.HasOne(d => d.ReceptionService)
                    .WithMany(p => p.Answer1s)
                    .HasForeignKey(d => d.ReceptionServiceId)
                    .HasConstraintName("FK_Answer_ReceptionService");
            });

            modelBuilder.Entity<AnswerService>(entity =>
            {
                entity.ToTable("AnswerService");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.IsOutSystem).HasComment("ارسال جواب از سیستم خارجی");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Nhsnumber)
                    .HasMaxLength(50)
                    .HasColumnName("NHSNumber");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.PatientStatus).HasMaxLength(50);

                entity.Property(e => e.RefferFrom).HasMaxLength(250);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.HasOne(d => d.InsertUser)
                    .WithMany(p => p.AnswerServiceInsertUsers)
                    .HasForeignKey(d => d.InsertUserId)
                    .HasConstraintName("FK_AnswerService_Users1");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AnswerServices)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_AnswerService_Patient");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.AnswerServices)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_AnswerService_Section");

                entity.HasOne(d => d.SendsmsStatus)
                    .WithMany(p => p.AnswerServices)
                    .HasForeignKey(d => d.SendsmsStatusId)
                    .HasConstraintName("FK_AnswerService_SendSmsStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AnswerServiceUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AnswerService_Users");
            });

            modelBuilder.Entity<AppointmentType>(entity =>
            {
                entity.ToTable("AppointmentType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetUsersOk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AspNetUsersOk");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<BackupT>(entity =>
            {
                entity.HasKey(e => e.BackupId);

                entity.ToTable("Backup_t", "bck");

                entity.Property(e => e.Errors).HasMaxLength(4000);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.FirstFileOnLocal).HasMaxLength(250);

                entity.Property(e => e.Notice).HasMaxLength(4000);

                entity.Property(e => e.SecondFileOnNetwork).HasMaxLength(250);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BagBlood>(entity =>
            {
                entity.ToTable("BagBlood", "Lab");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DonationCode).HasMaxLength(50);

                entity.Property(e => e.DonationDate).HasColumnType("datetime");

                entity.Property(e => e.Doner).HasMaxLength(50);

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Volume).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BloodProductType)
                    .WithMany(p => p.BagBloods)
                    .HasForeignKey(d => d.BloodProductTypeId)
                    .HasConstraintName("FK_BagBlood_BloodProductType");

                entity.HasOne(d => d.ProceedFromBagNumber)
                    .WithMany(p => p.BagBloods)
                    .HasForeignKey(d => d.ProceedFromBagNumberId)
                    .HasConstraintName("FK_BagBlood_ProceedFromBagNumber");
            });

            modelBuilder.Entity<BasketDrug>(entity =>
            {
                entity.ToTable("BasketDrug", "Drug");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.HasOne(d => d.PrescriptionDetailDrug)
                    .WithMany(p => p.BasketDrugs)
                    .HasForeignKey(d => d.PrescriptionDetailDrugId)
                    .HasConstraintName("FK_BasketDrug_PrescriptionDetailDrug");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.BasketDrugs)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_BasketDrug_Receptions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.BasketDrugs)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_BasketDrug");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasketDrugs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BasketDrug_Drugs");
            });

            modelBuilder.Entity<Bed>(entity =>
            {
                entity.ToTable("Bed");

                entity.Property(e => e.BedNo).HasMaxLength(20);

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.BedType)
                    .WithMany(p => p.Beds)
                    .HasForeignKey(d => d.BedTypeId)
                    .HasConstraintName("FK_Bed_BedType");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Beds)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Bed_Room");
            });

            modelBuilder.Entity<BedReception>(entity =>
            {
                entity.ToTable("BedReception");

                entity.Property(e => e.Createdate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromId).HasComment("بعد از در ج جدید از ایدی جدول قبلی پر می شود");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasComment("بعد از درج ستر جدید ستر قبلی نسبت به تاریخ ان اپدیت می شود");

                entity.HasOne(d => d.Bed)
                    .WithMany(p => p.BedReceptions)
                    .HasForeignKey(d => d.BedId)
                    .HasConstraintName("FK_BedReception_Bed");

                entity.HasOne(d => d.BedReserveStatus)
                    .WithMany(p => p.BedReceptions)
                    .HasForeignKey(d => d.BedReserveStatusId)
                    .HasConstraintName("FK_BedReception_BedReserveStatus");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.BedReceptions)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_BedReception_Receptions");
            });

            modelBuilder.Entity<BedReserveStatus>(entity =>
            {
                entity.ToTable("BedReserveStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BedStatus>(entity =>
            {
                entity.ToTable("BedStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BedType>(entity =>
            {
                entity.ToTable("BedType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BloodBankLabelStyle>(entity =>
            {
                entity.ToTable("BloodBankLabelStyle", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BloodBankLabeling>(entity =>
            {
                entity.ToTable("BloodBankLabeling", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.ToTable("BloodGroup");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BloodProductType>(entity =>
            {
                entity.ToTable("BloodProductType", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BloodStatus>(entity =>
            {
                entity.ToTable("BloodStatus", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BloodStatusHistory>(entity =>
            {
                entity.ToTable("BloodStatusHistory", "Lab");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.HasOne(d => d.BagBlood)
                    .WithMany(p => p.BloodStatusHistories)
                    .HasForeignKey(d => d.BagBloodId)
                    .HasConstraintName("FK_BloodStatusHistory_BagBlood");

                entity.HasOne(d => d.BloodStatus)
                    .WithMany(p => p.BloodStatusHistories)
                    .HasForeignKey(d => d.BloodStatusId)
                    .HasConstraintName("FK_BloodStatusHistory_BloodStatus");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.BloodStatusHistories)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_BloodStatusHistory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BloodStatusHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BloodStatusHistory_Users");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<BuyMessage>(entity =>
            {
                entity.ToTable("BuyMessage");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.BuyMessages)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_BuyMessage_Center");

                entity.HasOne(d => d.GitReason)
                    .WithMany(p => p.BuyMessages)
                    .HasForeignKey(d => d.GitReasonId)
                    .HasConstraintName("FK_BuyMessage_GiftReason");
            });

            modelBuilder.Entity<CardCode>(entity =>
            {
                entity.ToTable("CardCode");

                entity.Property(e => e.HealthNumber).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Serial).HasMaxLength(255);

                entity.Property(e => e.Token).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<CardCode210308>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardCode_21_03_08");

                entity.Property(e => e.HealthNumber).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Serial).HasMaxLength(255);

                entity.Property(e => e.Token).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<CashStatus>(entity =>
            {
                entity.ToTable("CashStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<CauseBloodNeed>(entity =>
            {
                entity.ToTable("CauseBloodNeed", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Center>(entity =>
            {
                entity.ToTable("Center");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.AnswerTime).HasMaxLength(50);

                entity.Property(e => e.AreaCode).HasMaxLength(20);

                entity.Property(e => e.Boss).HasMaxLength(100);

                entity.Property(e => e.BossPhone).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ExamTime).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Latitude).HasMaxLength(20);

                entity.Property(e => e.Longitude).HasMaxLength(20);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PhoneResponseHourse).HasMaxLength(20);

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.VisitorOrManaging).HasMaxLength(50);

                entity.Property(e => e.VisitorPhone).HasMaxLength(20);

                entity.Property(e => e.WorkingHours).HasMaxLength(200);

                entity.HasOne(d => d.CenterType)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.CenterTypeId)
                    .HasConstraintName("FK_CenterType_Center");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Center_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Center_Country");

                entity.HasOne(d => d.OwnershipType)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.OwnershipTypeId)
                    .HasConstraintName("FK_Center_OwnershipType");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Center_Province");

                entity.HasOne(d => d.WorkTimeType)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.WorkTimeTypeId)
                    .HasConstraintName("FK_Center_WorkTimeType");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_Center_Zone");
            });

            modelBuilder.Entity<CenterExamPlace>(entity =>
            {
                entity.ToTable("CenterExamPlace");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterExamPlaces)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_CenterExamPlace_Center");

                entity.HasOne(d => d.Examplace)
                    .WithMany(p => p.CenterExamPlaces)
                    .HasForeignKey(d => d.ExamplaceId)
                    .HasConstraintName("FK_CenterExamPlace_Examplace");
            });

            modelBuilder.Entity<CenterSellingType>(entity =>
            {
                entity.ToTable("CenterSellingType");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterSellingTypes)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_CenterSellingType_Center");

                entity.HasOne(d => d.SellingType)
                    .WithMany(p => p.CenterSellingTypes)
                    .HasForeignKey(d => d.SellingTypeId)
                    .HasConstraintName("FK_CenterSellingType_SellingType");
            });

            modelBuilder.Entity<CenterService>(entity =>
            {
                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterServices)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_CenterService_Center");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.CenterServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_CenterService_Services");
            });

            modelBuilder.Entity<CenterType>(entity =>
            {
                entity.ToTable("CenterType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<CenterWorkItem>(entity =>
            {
                entity.ToTable("CenterWorkItem");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterWorkItems)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_CenterWorkItem_Center");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.CenterWorkItems)
                    .HasForeignKey(d => d.WorkItemId)
                    .HasConstraintName("FK_CenterWorkItem_WorkTimeType");
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.ToTable("Certificate");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.TitleLang2).HasMaxLength(250);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

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

            modelBuilder.Entity<ClearanceType>(entity =>
            {
                entity.ToTable("ClearanceType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company", "Drug");

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

                entity.HasOne(d => d.ComponyPersonality)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.ComponyPersonalityId)
                    .HasConstraintName("FK_Company_ComponyPersonality");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Company_Country");
            });

            modelBuilder.Entity<CompanyAndType>(entity =>
            {
                entity.ToTable("CompanyAndType", "Drug");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyAndTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Company_CompanyAndType");

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.CompanyAndTypes)
                    .HasForeignKey(d => d.CompanyTypeId)
                    .HasConstraintName("FK_CompanyType_CompanyAndType");
            });

            modelBuilder.Entity<CompanyPersonality>(entity =>
            {
                entity.ToTable("CompanyPersonality", "Drug");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<CompanyType>(entity =>
            {
                entity.ToTable("CompanyType", "Drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<ConsumptionInstruction>(entity =>
            {
                entity.ToTable("ConsumptionInstruction", "Drug");

                entity.Property(e => e.Code)
                    .HasMaxLength(250)
                    .HasComment("ممکن است بخواهیم قسمت انگلیسی دستور مصرف را از قسمت فارسی جدا کنیم");

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.TitleLang2).HasMaxLength(250);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<DataTransferConvert>(entity =>
            {
                entity.ToTable("DataTransferConvert");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TableId).HasMaxLength(500);

                entity.Property(e => e.TableName).HasMaxLength(500);

                entity.Property(e => e.TargetTableId).HasMaxLength(500);
            });

            modelBuilder.Entity<DataTransferConvertDoctor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TableId).HasMaxLength(500);

                entity.Property(e => e.TableName).HasMaxLength(500);

                entity.Property(e => e.TargetTableId).HasMaxLength(500);
            });

            modelBuilder.Entity<DataType>(entity =>
            {
                entity.ToTable("DataType");

                entity.Property(e => e.CsharpType).HasMaxLength(20);

                entity.Property(e => e.SqlType).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<DefineRoutine>(entity =>
            {
                entity.ToTable("DefineRoutine", "Lab");

                entity.Property(e => e.Title).HasMaxLength(150);
            });

            modelBuilder.Entity<DefineRoutineTest>(entity =>
            {
                entity.ToTable("DefineRoutineTest", "Lab");

                entity.HasOne(d => d.DefineRoutine)
                    .WithMany(p => p.DefineRoutineTests)
                    .HasForeignKey(d => d.DefineRoutineId)
                    .HasConstraintName("FK_DefineRoutineTest_DefineRoutine");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.DefineRoutineTests)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_DefineRoutineTest_Services");
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.ToTable("Degree");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.ToTable("Diagnosis");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.TitleLang2).HasMaxLength(4000);
            });

            modelBuilder.Entity<DiagnosisStatus>(entity =>
            {
                entity.ToTable("DiagnosisStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Diet>(entity =>
            {
                entity.ToTable("Diet");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.AddressClinic).HasMaxLength(100);

                entity.Property(e => e.CooperationDate).HasColumnType("datetime");

                entity.Property(e => e.CostVisit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreditDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalSystemNo).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.PhoneClinic).HasMaxLength(20);

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_Doctors_Center");

                entity.HasOne(d => d.DoctorDegree)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DoctorDegreeId)
                    .HasConstraintName("FK_DoctorDegree_Doctors");

                entity.HasOne(d => d.Expertise)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.ExpertiseId)
                    .HasConstraintName("FK_Doctors_Expertise");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Doctors_Person");

                entity.HasOne(d => d.Scientificlevel)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.ScientificlevelId)
                    .HasConstraintName("FK_Doctors_Scientificlevel");
            });

            modelBuilder.Entity<DoctorAppointment>(entity =>
            {
                entity.ToTable("DoctorAppointment");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AppointmentType)
                    .WithMany(p => p.DoctorAppointments)
                    .HasForeignKey(d => d.AppointmentTypeId)
                    .HasConstraintName("FK_DoctorAppointment_AppointmentType");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorAppointments)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorAppointment_Doctors");

                entity.HasOne(d => d.DurationType)
                    .WithMany(p => p.DoctorAppointments)
                    .HasForeignKey(d => d.DurationTypeId)
                    .HasConstraintName("FK_DoctorAppointment_DurationType");
            });

            modelBuilder.Entity<DoctorAppointmentDetail>(entity =>
            {
                entity.ToTable("DoctorAppointmentDetail");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.DoctorAppointmentDetailStatus)
                    .WithMany(p => p.DoctorAppointmentDetails)
                    .HasForeignKey(d => d.DoctorAppointmentDetailStatusId)
                    .HasConstraintName("FK_DoctorAppointmentDetail_DoctorAppointmentDetail");

                entity.HasOne(d => d.DoctorAppointment)
                    .WithMany(p => p.DoctorAppointmentDetails)
                    .HasForeignKey(d => d.DoctorAppointmentId)
                    .HasConstraintName("FK_DoctorAppointmentDetail_DoctorAppointment");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.DoctorAppointmentDetails)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_DoctorAppointmentDetail_Receptions");
            });

            modelBuilder.Entity<DoctorAppointmentDetailStatus>(entity =>
            {
                entity.ToTable("DoctorAppointmentDetailStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<DoctorCertificate>(entity =>
            {
                entity.ToTable("DoctorCertificate");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.DoctorCertificates)
                    .HasForeignKey(d => d.CertificateId)
                    .HasConstraintName("FK_Certificate_DoctorCertificate");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorCertificates)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Doctors_DoctorCertificate");
            });

            modelBuilder.Entity<DoctorDayOff>(entity =>
            {
                entity.ToTable("DoctorDayOff");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.DoctorAppointment)
                    .WithMany(p => p.DoctorDayOffs)
                    .HasForeignKey(d => d.DoctorAppointmentId)
                    .HasConstraintName("FK_DoctorDayOff_DoctorAppointment");
            });

            modelBuilder.Entity<DoctorDegree>(entity =>
            {
                entity.ToTable("DoctorDegree");

                entity.Property(e => e.DateOfIssue).HasColumnType("datetime");

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.DoctorDegrees)
                    .HasForeignKey(d => d.DegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Degree_DoctorDegree");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorDegrees)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctors_DoctorDegree");
            });

            modelBuilder.Entity<DoctorService>(entity =>
            {
                entity.ToTable("DoctorService");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DoctorVisitType>(entity =>
            {
                entity.ToTable("DoctorVisitType");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorVisitTypes)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorVisitType_Doctors");

                entity.HasOne(d => d.VisitType)
                    .WithMany(p => p.DoctorVisitTypes)
                    .HasForeignKey(d => d.VisitTypeId)
                    .HasConstraintName("FK_DoctorVisitType_VisitType");
            });

            modelBuilder.Entity<DoctorsOk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoctorsOk");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Arcertificates1).HasColumnName("arcertificates_1");

                entity.Property(e => e.Arcertificates2).HasColumnName("arcertificates_2");

                entity.Property(e => e.Arcertificates3).HasColumnName("arcertificates_3");

                entity.Property(e => e.Arname).HasColumnName("arname");

                entity.Property(e => e.Arspecialty).HasColumnName("arspecialty");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Encertificates1).HasColumnName("encertificates_1");

                entity.Property(e => e.Encertificates2).HasColumnName("encertificates_2");

                entity.Property(e => e.Encertificates3).HasColumnName("encertificates_3");

                entity.Property(e => e.Enspecialty).HasColumnName("enspecialty");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.Visitfee).HasColumnName("visitfee");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.ToTable("Drugs", "Drug");

                entity.Property(e => e.BrokenConsumptionId).HasComment("بیس این ایدی هم همان یونیت است");

                entity.Property(e => e.ContentsOf).HasMaxLength(150);

                entity.Property(e => e.LocalCode).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BrokenConsumption)
                    .WithMany(p => p.DrugBrokenConsumptions)
                    .HasForeignKey(d => d.BrokenConsumptionId)
                    .HasConstraintName("FK_Drug_Unit1");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Drug_Company");

                entity.HasOne(d => d.DrugForm)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.DrugFormId)
                    .HasConstraintName("FK_Drugs_DrugForm");

                entity.HasOne(d => d.Generic)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.GenericId)
                    .HasConstraintName("FK_Drug_GenericDrug");

                entity.HasOne(d => d.StoregConditon)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.StoregConditonId)
                    .HasConstraintName("FK_Drug_StoregConditon");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DrugUnits)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Drug_Unit");
            });

            modelBuilder.Entity<DrugForm>(entity =>
            {
                entity.ToTable("DrugForm", "Drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<DrugInteraction>(entity =>
            {
                entity.ToTable("DrugInteractions", "Drug");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.HasOne(d => d.FirstGenericDrug)
                    .WithMany(p => p.DrugInteractionFirstGenericDrugs)
                    .HasForeignKey(d => d.FirstGenericDrugId)
                    .HasConstraintName("FK_DrugInteractions_FirstGenericDrug");

                entity.HasOne(d => d.FirstGroup)
                    .WithMany(p => p.DrugInteractionFirstGroups)
                    .HasForeignKey(d => d.FirstGroupId)
                    .HasConstraintName("FK_DrugInteractions_FirstGroup");

                entity.HasOne(d => d.SecondGenericDrug)
                    .WithMany(p => p.DrugInteractionSecondGenericDrugs)
                    .HasForeignKey(d => d.SecondGenericDrugId)
                    .HasConstraintName("FK_DrugInteractions_SecondGenericDrug");

                entity.HasOne(d => d.SecondGroup)
                    .WithMany(p => p.DrugInteractionSecondGroups)
                    .HasForeignKey(d => d.SecondGroupId)
                    .HasConstraintName("FK_DrugInteractions_SecondGroup");
            });

            modelBuilder.Entity<DrugStoregCondition>(entity =>
            {
                entity.ToTable("DrugStoregCondition", "Drug");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.DrugStoregConditions)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_DrugStoregCondition_Drugs");

                entity.HasOne(d => d.StoregConditon)
                    .WithMany(p => p.DrugStoregConditions)
                    .HasForeignKey(d => d.StoregConditonId)
                    .HasConstraintName("FK_DrugStoregCondition_StoregCondition");
            });

            modelBuilder.Entity<DurationType>(entity =>
            {
                entity.ToTable("DurationType");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Education");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.EmploymentStartDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Employee_Person");
            });

            modelBuilder.Entity<Examplace>(entity =>
            {
                entity.ToTable("Examplace");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Expertise>(entity =>
            {
                entity.ToTable("Expertise");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileGroupId).HasColumnName("FileGroupID");

                entity.Property(e => e.FileName).HasMaxLength(150);

                entity.Property(e => e.PrimeryKey).HasMaxLength(150);

                entity.Property(e => e.RefferKey)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TableName).HasMaxLength(150);

                entity.HasOne(d => d.FileGroup)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.FileGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Files_FileGroup");
            });

            modelBuilder.Entity<FileGroup>(entity =>
            {
                entity.ToTable("FileGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .HasComment("Patient,Person,Drugs...");

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<FileTag>(entity =>
            {
                entity.ToTable("FileTag");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TagName).HasMaxLength(100);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.FileTags)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_FileTag_Files");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.FileTags)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_FileTag_Patient");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FileTags)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_FileTag_Users");
            });

            modelBuilder.Entity<Frequency>(entity =>
            {
                entity.ToTable("Frequency");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<GeneralStatus>(entity =>
            {
                entity.ToTable("GeneralStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<GenericDrug>(entity =>
            {
                entity.ToTable("GenericDrug", "Drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.TitleLang2).HasMaxLength(250);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GenericDrugs)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Group_GenericDrug");
            });

            modelBuilder.Entity<GiftReason>(entity =>
            {
                entity.ToTable("GiftReason");

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
                entity.ToTable("Group", "Drug");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<GroupAnswer>(entity =>
            {
                entity.ToTable("GroupAnswer");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasComment("هر آزمایش در نوعی دیگر دسته¬بندی شده و بر اساس دسته بندی، در شرایط خاصی برای دریافت نمونه و جواب¬دهی با آن برخورد می-شود. این آزمایشات در ثبت و روش انجام با هم تفاوت دارند. به همین جهت، در ثبت آزمایش مهم است که نوع آزمایش مشخص شود.");

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<GroupAnswer1>(entity =>
            {
                entity.ToTable("GroupAnswer", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasComment("هر آزمایش در نوعی دیگر دسته¬بندی شده و بر اساس دسته بندی، در شرایط خاصی برای دریافت نمونه و جواب¬دهی با آن برخورد می-شود. این آزمایشات در ثبت و روش انجام با هم تفاوت دارند. به همین جهت، در ثبت آزمایش مهم است که نوع آزمایش مشخص شود.");

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<GroupReadyAnswer>(entity =>
            {
                entity.ToTable("GroupReadyAnswer");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.HasOne(d => d.GroupAnswer)
                    .WithMany(p => p.GroupReadyAnswers)
                    .HasForeignKey(d => d.GroupAnswerId)
                    .HasConstraintName("FK_GroupReadyAnswer_GroupAnswer");

                entity.HasOne(d => d.ReadyAnswer)
                    .WithMany(p => p.GroupReadyAnswers)
                    .HasForeignKey(d => d.ReadyAnswerId)
                    .HasConstraintName("FK_GroupReadyAnswer_ReadyAnswer");
            });

            modelBuilder.Entity<GroupReadyAnswer1>(entity =>
            {
                entity.ToTable("GroupReadyAnswer", "Lab");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.HasOne(d => d.GroupAnswer)
                    .WithMany(p => p.GroupReadyAnswer1s)
                    .HasForeignKey(d => d.GroupAnswerId)
                    .HasConstraintName("FK_GroupReadyAnswer_GroupAnswer");

                entity.HasOne(d => d.ReadyAnswer)
                    .WithMany(p => p.GroupReadyAnswer1s)
                    .HasForeignKey(d => d.ReadyAnswerId)
                    .HasConstraintName("FK_GroupReadyAnswer_ReadyAnswer");
            });

            modelBuilder.Entity<Illness>(entity =>
            {
                entity.ToTable("Illness");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLange2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(4000);

                entity.Property(e => e.TitleLang2).HasMaxLength(4000);
            });

            modelBuilder.Entity<ImportedDicom>(entity =>
            {
                entity.ToTable("ImportedDicom", "FileM");
            });

            modelBuilder.Entity<Instruction>(entity =>
            {
                entity.ToTable("Instruction", "Lab");

                entity.Property(e => e.FromAge).HasComment("بر حسب روز");

                entity.Property(e => e.SexId).HasComment("نامشخص یعنی هر دو");

                entity.Property(e => e.Title)
                    .HasMaxLength(2500)
                    .HasComment("متن همان دستور العمل است");

                entity.Property(e => e.TitleLang2).HasMaxLength(2500);

                entity.Property(e => e.ToAge).HasComment("بر حسب روز");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Instructions)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_Instruction_Services");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.Instructions)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_Instruction_Sex");
            });

            modelBuilder.Entity<Interaction>(entity =>
            {
                entity.ToTable("Interaction", "Drug");

                entity.Property(e => e.FirstDrugId).HasComment("احتمالا کاربردی نداشته باشد");

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.SecondDrugId).HasComment("احتمالا کاربردی نداشته باشد");

                entity.HasOne(d => d.FirstDrug)
                    .WithMany(p => p.InteractionFirstDrugs)
                    .HasForeignKey(d => d.FirstDrugId)
                    .HasConstraintName("FK_Interaction_FirstDrug");

                entity.HasOne(d => d.FirstGenericDrug)
                    .WithMany(p => p.InteractionFirstGenericDrugs)
                    .HasForeignKey(d => d.FirstGenericDrugId)
                    .HasConstraintName("FK_Interaction_FirstGenericDrug");

                entity.HasOne(d => d.FirstGroup)
                    .WithMany(p => p.InteractionFirstGroups)
                    .HasForeignKey(d => d.FirstGroupId)
                    .HasConstraintName("FK_Interaction_FirstGroup");

                entity.HasOne(d => d.SecondDrug)
                    .WithMany(p => p.InteractionSecondDrugs)
                    .HasForeignKey(d => d.SecondDrugId)
                    .HasConstraintName("FK_Interaction_SecondDrug");

                entity.HasOne(d => d.SecondGenericDrug)
                    .WithMany(p => p.InteractionSecondGenericDrugs)
                    .HasForeignKey(d => d.SecondGenericDrugId)
                    .HasConstraintName("FK_Interaction_SecondGenericDrug");

                entity.HasOne(d => d.SecondGroup)
                    .WithMany(p => p.InteractionSecondGroups)
                    .HasForeignKey(d => d.SecondGroupId)
                    .HasConstraintName("FK_Interaction_SecondGroup");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.ToTable("JobType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Kit>(entity =>
            {
                entity.ToTable("Kit", "Lab");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LotNumber).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Kits)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Kit_Unit");
            });

            modelBuilder.Entity<LabType>(entity =>
            {
                entity.ToTable("LabType", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasComment("هر آزمایش در نوعی دیگر دسته¬بندی شده و بر اساس دسته بندی، در شرایط خاصی برای دریافت نمونه و جواب¬دهی با آن برخورد می-شود. این آزمایشات در ثبت و روش انجام با هم تفاوت دارند. به همین جهت، در ثبت آزمایش مهم است که نوع آزمایش مشخص شود.");

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<LabelBloodBag>(entity =>
            {
                entity.ToTable("LabelBloodBag", "Lab");

                entity.HasOne(d => d.BloodBankLabelStyle)
                    .WithMany(p => p.LabelBloodBags)
                    .HasForeignKey(d => d.BloodBankLabelStyleId)
                    .HasConstraintName("FK_LabelBloodBag_LabelSampleTestStyle");

                entity.HasOne(d => d.BloodBankLabeling)
                    .WithMany(p => p.LabelBloodBags)
                    .HasForeignKey(d => d.BloodBankLabelingId)
                    .HasConstraintName("FK_LabelBloodBag_BloodBankLabeling");
            });

            modelBuilder.Entity<LabelSampleTest>(entity =>
            {
                entity.ToTable("LabelSampleTest", "Lab");

                entity.HasOne(d => d.LabelSampleTestStyle)
                    .WithMany(p => p.LabelSampleTests)
                    .HasForeignKey(d => d.LabelSampleTestStyleId)
                    .HasConstraintName("FK_LabelSampleTest_LabelSampleTestStyle");

                entity.HasOne(d => d.TestLabeling)
                    .WithMany(p => p.LabelSampleTests)
                    .HasForeignKey(d => d.TestLabelingId)
                    .HasConstraintName("FK_LabelSampleTest_TestLabling");
            });

            modelBuilder.Entity<LabelSampleTestStyle>(entity =>
            {
                entity.ToTable("LabelSampleTestStyle", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<LogPortal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LogPortal");

                entity.Property(e => e.Action).HasMaxLength(4000);

                entity.Property(e => e.Body).HasMaxLength(4000);

                entity.Property(e => e.Callsite).HasMaxLength(4000);

                entity.Property(e => e.Controller).HasMaxLength(4000);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Host).HasMaxLength(250);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ip)
                    .HasMaxLength(200)
                    .HasColumnName("IP");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logger).HasMaxLength(250);

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.ServerName).HasMaxLength(4000);

                entity.Property(e => e.SiteName).HasMaxLength(250);

                entity.Property(e => e.ThreadName).HasMaxLength(4000);

                entity.Property(e => e.Url).HasMaxLength(250);

                entity.Property(e => e.UserAgent).HasMaxLength(4000);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasMaxLength(50);

                entity.Property(e => e.Language).HasMaxLength(10);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("MaritalStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.IconName).HasMaxLength(100);

                entity.Property(e => e.Link).HasMaxLength(100);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.MenuType).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_Menu_Permissions");
            });

            modelBuilder.Entity<MethodType>(entity =>
            {
                entity.ToTable("MethodType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<MobileActivation>(entity =>
            {
                entity.ToTable("MobileActivation");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.VerifyCode).HasMaxLength(15);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<OwnershipType>(entity =>
            {
                entity.ToTable("OwnershipType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<PackagingType>(entity =>
            {
                entity.ToTable("PackagingType", "Drug");

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.DrugForm)
                    .WithMany(p => p.PackagingTypes)
                    .HasForeignKey(d => d.DrugFormId)
                    .HasConstraintName("FK_PackagingType_DrugForm");
            });

            modelBuilder.Entity<PanelType>(entity =>
            {
                entity.ToTable("PanelType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Passport>(entity =>
            {
                entity.ToTable("Passport");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.FlightDate).HasColumnType("datetime");

                entity.Property(e => e.FlightNumber).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Passports)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Passport_Passport");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileNo).HasMaxLength(20);

                entity.Property(e => e.Hisno).HasColumnName("HISNo");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.HasOne(d => d.BloodGroup)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.BloodGroupId)
                    .HasConstraintName("FK_Paitient_BloodGroup");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Paitient_Person");
            });

            modelBuilder.Entity<PatientExtraInfo>(entity =>
            {
                entity.ToTable("PatientExtraInfo");

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

                entity.HasOne(d => d.Allergy)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.AllergyId)
                    .HasConstraintName("FK_PatientExtraInfo_Allergy");

                entity.HasOne(d => d.ChronicIllness)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.ChronicIllnessId)
                    .HasConstraintName("FK_PaitientExtraInfo_ChronicIIlness");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("FK_PaitientExtraInfo_Education");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_PaitientExtraInfo_Job");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.JobTypeId)
                    .HasConstraintName("FK_PatientExtraInfo_JobType");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_PatientExtraInfo_Nationality");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PaitientExtraInfo_Patient");

                entity.HasOne(d => d.PregnancySeason)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.PregnancySeasonId)
                    .HasConstraintName("FK_PatientExtraInfo_PregnancySeason");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_PatientExtraInfo_Religion");

                entity.HasOne(d => d.Rh)
                    .WithMany(p => p.PatientExtraInfos)
                    .HasForeignKey(d => d.RhId)
                    .HasConstraintName("FK_PatientExtraInfo_Rh");
            });

            modelBuilder.Entity<PatientHistoryBloodTransfusion>(entity =>
            {
                entity.ToTable("PatientHistoryBloodTransfusion", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentNo)
                    .HasMaxLength(10)
                    .HasComment("شناسه پرداخت تولید خودکار");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_PrePayment_PaymentType");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_PrePayment_Receptions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_Payment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PrePayment_Users");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Pcr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pcr");

                entity.Property(e => e.AgeRange).HasMaxLength(100);

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(4000);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.ModuleName).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.NoteLang2).HasMaxLength(100);

                entity.Property(e => e.PageAddress).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<PermissionSectionField>(entity =>
            {
                entity.ToTable("PermissionSectionField");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionSectionFields)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_PermissionSectionField_Permissions");

                entity.HasOne(d => d.SectionField)
                    .WithMany(p => p.PermissionSectionFields)
                    .HasForeignKey(d => d.SectionFieldId)
                    .HasConstraintName("FK_PermissionSectionField_SectionField");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.GrandFatherName).HasMaxLength(100);

                entity.Property(e => e.GreatGrandFatherName)
                    .HasMaxLength(100)
                    .HasComment("پدر پدر بزرگ");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LatinName)
                    .HasMaxLength(100)
                    .HasComment("نام  انگلیسی");

                entity.Property(e => e.Mobile).HasMaxLength(200);

                entity.Property(e => e.MotherName).HasMaxLength(100);

                entity.Property(e => e.NationalCode).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.Phone).HasMaxLength(200);

                entity.Property(e => e.ShNo).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Person_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Person_Country");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Person_MaritalStatus");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Person_Province");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_Person_Sex");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_Person_Zone");
            });

            modelBuilder.Entity<Pharmacy>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.ToTable("Place");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<PregnancySeason>(entity =>
            {
                entity.ToTable("PregnancySeason");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<PrescribtionType>(entity =>
            {
                entity.ToTable("PrescribtionType", "Drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.ToTable("Prescription");

                entity.Property(e => e.Biography).HasMaxLength(4000);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .HasComment("کد تجویز ");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ ثبت سیستمی");

                entity.Property(e => e.Diet).HasMaxLength(4000);

                entity.Property(e => e.InteractionsNote).HasMaxLength(4000);

                entity.Property(e => e.MainDoctorNote).HasMaxLength(4000);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.PharmacistNoteForNursing).HasMaxLength(4000);

                entity.Property(e => e.PostMedicalHistory).HasMaxLength(4000);

                entity.Property(e => e.PrescriptionDate)
                    .HasColumnType("datetime")
                    .HasComment("از کابر گرفته میشه");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Prescription_Doctors");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_Prescription_Receptions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Prescription_Role");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Prescription_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Prescription_Users");

                entity.HasOne(d => d.VisitType)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.VisitTypeId)
                    .HasConstraintName("FK_Prescription_VisitType");
            });

            modelBuilder.Entity<PrescriptionAllergy>(entity =>
            {
                entity.ToTable("PrescriptionAllergy");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Allergy)
                    .WithMany(p => p.PrescriptionAllergies)
                    .HasForeignKey(d => d.AllergyId)
                    .HasConstraintName("FK_PrescriptionAllergy_Allergy");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionAllergies)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionAllergy_Prescription");
            });

            modelBuilder.Entity<PrescriptionChartActionType>(entity =>
            {
                entity.ToTable("PrescriptionChartActionType");

                entity.Property(e => e.ActionTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<PrescriptionChartCancelationReason>(entity =>
            {
                entity.ToTable("PrescriptionChartCancelationReason");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<PrescriptionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PrescriptionDetails");
            });

            modelBuilder.Entity<PrescriptionDetailDrug>(entity =>
            {
                entity.ToTable("PrescriptionDetailDrug");

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ شروع اقدام همچنین تاریخی که بخش مقصد این درخواست را میبیند در تناوب ها هم کاربرد دارد");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.GenericDrugId).HasComment("به جنریک دراگ میخورد نه دراگ در زمان تجویز جنریک دراگ مهم است نه دراگ");

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.PrescriptionInstructionId).HasComment("دستور العمل انجام مثلا هر هشت ساعت یه بار");

                entity.Property(e => e.PrescriptionTypeId).HasComment("تشخیصی درمانی مراقبتی");

                entity.Property(e => e.RequestFromSectionId).HasComment("از چه بخشی درخواست شده اگر در خود بخش انجام شود ایدی بخش جاری می خورد");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WayOfPrescriptionId).HasComment("خوراکی تزریق مالیدنی");

                entity.HasOne(d => d.DrugForm)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.DrugFormId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_DrugForm");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Drugs");

                entity.HasOne(d => d.DurationType)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.DurationTypeId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_DurationType");

                entity.HasOne(d => d.Frequency)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.FrequencyId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Frequency");

                entity.HasOne(d => d.GenericDrug)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.GenericDrugId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_GenericDrug");

                entity.HasOne(d => d.Panel)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.PanelId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_PrescriptionPanel");

                entity.HasOne(d => d.PrescriberNurse)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.PrescriberNurseId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Nurse");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Prescription");

                entity.HasOne(d => d.PrescriptionInstruction)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.PrescriptionInstructionId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_PrescriptionInstruction");

                entity.HasOne(d => d.PrescriptionType)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.PrescriptionTypeId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_PrescriptionTypeId");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.PriorityId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Priority");

                entity.HasOne(d => d.RequestFromSection)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.RequestFromSectionId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_Section");

                entity.HasOne(d => d.WayOfPrescription)
                    .WithMany(p => p.PrescriptionDetailDrugs)
                    .HasForeignKey(d => d.WayOfPrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailDrug_WayOfPrescription");
            });

            modelBuilder.Entity<PrescriptionDetailDrugHistory>(entity =>
            {
                entity.ToTable("PrescriptionDetailDrugHistory");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StopDate).HasColumnType("datetime");

                entity.HasOne(d => d.PrescriptionDetailDrug)
                    .WithMany(p => p.PrescriptionDetailDrugHistories)
                    .HasForeignKey(d => d.PrescriptionDetailDrugId)
                    .HasConstraintName("FK_PrescriptionDetailDrugHistory_PrescriptionDetailDrug");

                entity.HasOne(d => d.PrescriptionHistoryStatus)
                    .WithMany(p => p.PrescriptionDetailDrugHistories)
                    .HasForeignKey(d => d.PrescriptionHistoryStatusId)
                    .HasConstraintName("FK_PrescriptionDetailDrugHistory_PrescriptionHistoryStatus");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDetailDrugHistories)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailDrugHistory_Prescription");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PrescriptionDetailDrugHistories)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_PrescriptionDetailDrugHistory_Role");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.PrescriptionDetailDrugHistories)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_PrescriptionDetailDrugHistory_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PrescriptionDetailDrugHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PrescriptionDetailDrugHistory_Users");
            });

            modelBuilder.Entity<PrescriptionDetailPharmacistNote>(entity =>
            {
                entity.ToTable("PrescriptionDetailPharmacistNote");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.NoteForNurse).HasMaxLength(4000);

                entity.Property(e => e.NoteForTrainingPatient).HasMaxLength(4000);

                entity.Property(e => e.PrescriptionDetailDrugId).HasComment("مشخص می‌کند نکات دکتر داروساز مربوط به کدام قلم تجویز دارویی بیمار است");

                entity.HasOne(d => d.PrescriptionDetailDrug)
                    .WithMany(p => p.PrescriptionDetailPharmacistNotes)
                    .HasForeignKey(d => d.PrescriptionDetailDrugId)
                    .HasConstraintName("FK_PrescriptionDetailPharmacistNote_PrescriptionDetailDrug");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDetailPharmacistNotes)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailPharmacistNote_Prescription");
            });

            modelBuilder.Entity<PrescriptionDetailService>(entity =>
            {
                entity.ToTable("PrescriptionDetailService");

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

                entity.HasOne(d => d.Frequency)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.FrequencyId)
                    .HasConstraintName("FK_PrescriptionDetailService_Frequency");

                entity.HasOne(d => d.Panel)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.PanelId)
                    .HasConstraintName("FK_PrescriptionDetailService_PrescriptionPanel");

                entity.HasOne(d => d.PrescriberNurse)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.PrescriberNurseId)
                    .HasConstraintName("FK_PrescriptionDetailService_Nurse");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailService_Prescription");

                entity.HasOne(d => d.PrescriptionType)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.PrescriptionTypeId)
                    .HasConstraintName("FK_PrescriptionDetailService_PrescriptionTypeId");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.PriorityId)
                    .HasConstraintName("FK_PrescriptionDetailService_Priority");

                entity.HasOne(d => d.RequestFromSection)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.RequestFromSectionId)
                    .HasConstraintName("FK_PrescriptionDetailService_Section");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.PrescriptionDetailServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_PrescriptionDetailService_Services");
            });

            modelBuilder.Entity<PrescriptionDetailServiceHistory>(entity =>
            {
                entity.ToTable("PrescriptionDetailServiceHistory");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StopDate).HasColumnType("datetime");

                entity.HasOne(d => d.PrescriptionDetailService)
                    .WithMany(p => p.PrescriptionDetailServiceHistories)
                    .HasForeignKey(d => d.PrescriptionDetailServiceId)
                    .HasConstraintName("FK_PrescriptionDetailServiceHistory_PrescriptionDetailService");

                entity.HasOne(d => d.PrescriptionHistoryStatus)
                    .WithMany(p => p.PrescriptionDetailServiceHistories)
                    .HasForeignKey(d => d.PrescriptionHistoryStatusId)
                    .HasConstraintName("FK_PrescriptionDetailServiceHistory_PrescriptionHistoryStatus");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDetailServiceHistories)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDetailServiceHistory_Prescription");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PrescriptionDetailServiceHistories)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_PrescriptionDetailServiceHistory_Role");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.PrescriptionDetailServiceHistories)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_PrescriptionDetailServiceHistory_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PrescriptionDetailServiceHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PrescriptionDetailServiceHistory_Users");
            });

            modelBuilder.Entity<PrescriptionDiet>(entity =>
            {
                entity.ToTable("PrescriptionDiet");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.HasOne(d => d.Diet)
                    .WithMany(p => p.PrescriptionDiets)
                    .HasForeignKey(d => d.DietId)
                    .HasConstraintName("FK_PrescriptionDiet_Diet");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionDiets)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionDiet_Prescription");
            });

            modelBuilder.Entity<PrescriptionDrugChart>(entity =>
            {
                entity.ToTable("PrescriptionDrugChart");

                entity.Property(e => e.DoneDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.PrescriptionDoDate).HasColumnType("datetime");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.PrescriptionDrugCharts)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_PrescriptionDrugChart_Drugs");

                entity.HasOne(d => d.Functor)
                    .WithMany(p => p.PrescriptionDrugChartFunctors)
                    .HasForeignKey(d => d.FunctorId)
                    .HasConstraintName("FK_PrescriptionDrugChart_Users_Functor");

                entity.HasOne(d => d.PrescriptionChartActionType)
                    .WithMany(p => p.PrescriptionDrugCharts)
                    .HasForeignKey(d => d.PrescriptionChartActionTypeId)
                    .HasConstraintName("FK_PrescriptionDrugChart_PrescriptionChartActionType");

                entity.HasOne(d => d.PrescriptionChartCancelationReason)
                    .WithMany(p => p.PrescriptionDrugCharts)
                    .HasForeignKey(d => d.PrescriptionChartCancelationReasonId)
                    .HasConstraintName("FK_PrescriptionDrugChart_PrescriptionChartCancelationReason");

                entity.HasOne(d => d.PrescriptionDetailDrug)
                    .WithMany(p => p.PrescriptionDrugCharts)
                    .HasForeignKey(d => d.PrescriptionDetailDrugId)
                    .HasConstraintName("FK_PrescriptionDrugChart_PrescriptionDetailDrug");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PrescriptionDrugCharts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_PrescriptionDrugChart");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PrescriptionDrugChartUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PrescriptionDrugChart_Users_User");

                entity.HasOne(d => d.Witness)
                    .WithMany(p => p.PrescriptionDrugChartWitnesses)
                    .HasForeignKey(d => d.WitnessId)
                    .HasConstraintName("FK_PrescriptionDrugChart_Users_Witness");
            });

            modelBuilder.Entity<PrescriptionDrugRoutine>(entity =>
            {
                entity.ToTable("PrescriptionDrugRoutine");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.Period).HasComment("بر حسب دقیقه");

                entity.Property(e => e.WayOfPrescriptionId).HasComment("نحوه مصرف");

                entity.HasOne(d => d.GenericDrug)
                    .WithMany(p => p.PrescriptionDrugRoutines)
                    .HasForeignKey(d => d.GenericDrugId)
                    .HasConstraintName("FK_PrescriptionDrugRoutine_GenericDrug");

                entity.HasOne(d => d.PrescriptionRoutine)
                    .WithMany(p => p.PrescriptionDrugRoutines)
                    .HasForeignKey(d => d.PrescriptionRoutineId)
                    .HasConstraintName("FK_PrescriptionDrugRoutine_PrescriptionRoutine");

                entity.HasOne(d => d.WayOfPrescription)
                    .WithMany(p => p.PrescriptionDrugRoutines)
                    .HasForeignKey(d => d.WayOfPrescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrescriptionDrugRoutine_PrescriptionDrugRoutine");
            });

            modelBuilder.Entity<PrescriptionGroupItem>(entity =>
            {
                entity.ToTable("PrescriptionGroupItem");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<PrescriptionGroupSetting>(entity =>
            {
                entity.ToTable("PrescriptionGroupSetting");

                entity.HasOne(d => d.GroupService)
                    .WithMany(p => p.PrescriptionGroupSettings)
                    .HasForeignKey(d => d.GroupServiceId)
                    .HasConstraintName("FK_PrescriptionGroupSetting_Services");

                entity.HasOne(d => d.PrescriptionGroupItem)
                    .WithMany(p => p.PrescriptionGroupSettings)
                    .HasForeignKey(d => d.PrescriptionGroupItemId)
                    .HasConstraintName("FK_PrescriptionGroupSetting_PrescriptionGroupItem");

                entity.HasOne(d => d.VisitType)
                    .WithMany(p => p.PrescriptionGroupSettings)
                    .HasForeignKey(d => d.VisitTypeId)
                    .HasConstraintName("FK_PrescriptionGroupSetting_VisitType");
            });

            modelBuilder.Entity<PrescriptionHistoryStatus>(entity =>
            {
                entity.ToTable("PrescriptionHistoryStatus");

                entity.Property(e => e.StatusTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<PrescriptionInstruction>(entity =>
            {
                entity.ToTable("PrescriptionInstruction");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Duration).HasComment("بر اساس دقیقه");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<PrescriptionPanel>(entity =>
            {
                entity.ToTable("PrescriptionPanel");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionPanels)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_PrescriptionPanel_Prescription");
            });

            modelBuilder.Entity<PrescriptionRoutine>(entity =>
            {
                entity.ToTable("PrescriptionRoutine");

                entity.Property(e => e.IsDrugType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.HasOne(d => d.PanelType)
                    .WithMany(p => p.PrescriptionRoutines)
                    .HasForeignKey(d => d.PanelTypeId)
                    .HasConstraintName("FK_PrescriptionRoutine_PanelType");
            });

            modelBuilder.Entity<PrescriptionServiceChart>(entity =>
            {
                entity.ToTable("PrescriptionServiceChart");

                entity.Property(e => e.DoneDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.PrescriptionChartDate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.ResultDate).HasColumnType("datetime");

                entity.HasOne(d => d.Functor)
                    .WithMany(p => p.PrescriptionServiceChartFunctors)
                    .HasForeignKey(d => d.FunctorId)
                    .HasConstraintName("FK_PrescriptionServiceChart_Users_Functor");

                entity.HasOne(d => d.PrescriptionChartActionType)
                    .WithMany(p => p.PrescriptionServiceCharts)
                    .HasForeignKey(d => d.PrescriptionChartActionTypeId)
                    .HasConstraintName("FK_PrescriptionServiceChart_PrescriptionChartActionType");

                entity.HasOne(d => d.PrescriptionChartCancelationReason)
                    .WithMany(p => p.PrescriptionServiceCharts)
                    .HasForeignKey(d => d.PrescriptionChartCancelationReasonId)
                    .HasConstraintName("FK_PrescriptionServiceChart_PrescriptionChartCancelationReason");

                entity.HasOne(d => d.PrescriptionDetailService)
                    .WithMany(p => p.PrescriptionServiceCharts)
                    .HasForeignKey(d => d.PrescriptionDetailServiceId)
                    .HasConstraintName("FK_PrescriptionServiceChart_PrescriptionDetailService");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PrescriptionServiceCharts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_PrescriptionServiceChart");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PrescriptionServiceCharts)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_PrescriptionServiceChart_Unit");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PrescriptionServiceChartUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PrescriptionServiceChart_Users");

                entity.HasOne(d => d.Witness)
                    .WithMany(p => p.PrescriptionServiceChartWitnesses)
                    .HasForeignKey(d => d.WitnessId)
                    .HasConstraintName("FK_PrescriptionServiceChart_Users_Witness");
            });

            modelBuilder.Entity<PrescriptionServiceResult>(entity =>
            {
                entity.ToTable("PrescriptionServiceResult");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Result2).HasMaxLength(4000);

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionServiceResults)
                    .HasForeignKey(d => d.PrescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrescriptionServiceResult_Prescription");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.PrescriptionServiceResults)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_PrescriptionServiceResult_Services");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PrescriptionServiceResults)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_PrescriptionServiceResult_Unit");
            });

            modelBuilder.Entity<PrescriptionServiceRoutine>(entity =>
            {
                entity.ToTable("PrescriptionServiceRoutine");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.HasOne(d => d.PrescriptionRoutine)
                    .WithMany(p => p.PrescriptionServiceRoutines)
                    .HasForeignKey(d => d.PrescriptionRoutineId)
                    .HasConstraintName("FK_PrescriptionServiceRoutine_PrescriptionRoutine");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.PrescriptionServiceRoutines)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_PrescriptionServiceRoutine_Services");
            });

            modelBuilder.Entity<PrescriptionSetting>(entity =>
            {
                entity.ToTable("PrescriptionSetting");

                entity.Property(e => e.ServiceGroupId).HasComment("ای دی سطرهای پدر سطح اول بهش وصل میشه");

                entity.Property(e => e.ServiceId).HasComment("خدمات سطح اول جدول");

                entity.Property(e => e.VisitTypeId).HasComment("وزیت اولیه و عادی");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.PrescriptionSettings)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_PrescriptionSetting_Section");

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(p => p.PrescriptionSettingServiceGroups)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .HasConstraintName("FK_PrescriptionSetting_Services1");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.PrescriptionSettingServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_PrescriptionSetting_Services");

                entity.HasOne(d => d.VisitType)
                    .WithMany(p => p.PrescriptionSettings)
                    .HasForeignKey(d => d.VisitTypeId)
                    .HasConstraintName("FK_PrescriptionSetting_VisitType");
            });

            modelBuilder.Entity<PrescriptionShare>(entity =>
            {
                entity.ToTable("PrescriptionShare");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.HasOne(d => d.Prescriptoin)
                    .WithMany(p => p.PrescriptionShares)
                    .HasForeignKey(d => d.PrescriptoinId)
                    .HasConstraintName("FK_PrescriptoinShare_Prescription");
            });

            modelBuilder.Entity<PrescriptionSign>(entity =>
            {
                entity.ToTable("PrescriptionSign");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionSigns)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_Table_1_Prescription");

                entity.HasOne(d => d.Sign)
                    .WithMany(p => p.PrescriptionSigns)
                    .HasForeignKey(d => d.SignId)
                    .HasConstraintName("FK_Table_1_Sign");
            });

            modelBuilder.Entity<PrescriptionType>(entity =>
            {
                entity.ToTable("PrescriptionType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Presenter>(entity =>
            {
                entity.ToTable("Presenter");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<PriceTypeMethod>(entity =>
            {
                entity.ToTable("PriceTypeMethod");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.TitleLang2).HasMaxLength(100);
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.ToTable("Priority");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<ProceedFromBagNumber>(entity =>
            {
                entity.ToTable("ProceedFromBagNumber", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasComment("هر آزمایش در نوعی دیگر دسته¬بندی شده و بر اساس دسته بندی، در شرایط خاصی برای دریافت نمونه و جواب¬دهی با آن برخورد می-شود. این آزمایشات در ثبت و روش انجام با هم تفاوت دارند. به همین جهت، در ثبت آزمایش مهم است که نوع آزمایش مشخص شود.");

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Enname)
                    .HasMaxLength(256)
                    .HasColumnName("enname");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(256)
                    .HasColumnName("fullname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.OnlineId).HasColumnName("online_id");
            });

            modelBuilder.Entity<ProhibitedUsage>(entity =>
            {
                entity.ToTable("ProhibitedUsage", "Drug");

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.ProhibitedUsages)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_ProhibitedUsage_Drugs");

                entity.HasOne(d => d.GenericDrug)
                    .WithMany(p => p.ProhibitedUsages)
                    .HasForeignKey(d => d.GenericDrugId)
                    .HasConstraintName("FK_ProhibitedUsage_GenericDrug");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ProhibitedUsages)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_ProhibitedUsage_Group");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

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

            modelBuilder.Entity<PurchaseInvoice>(entity =>
            {
                entity.ToTable("PurchaseInvoice", "Drug");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .HasComment("Purchase Invoice Number\r\nکدسیستمی داخلی");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ ثبت فاکتور");

                entity.Property(e => e.Delivery)
                    .HasMaxLength(50)
                    .HasComment("فرد تحویل دهنده");

                entity.Property(e => e.Note)
                    .HasMaxLength(4000)
                    .HasComment("سایر توضیحات");

                entity.Property(e => e.OtherDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("تخفیفی که به صورت دستی می‌تواند فرد وارد کند");

                entity.Property(e => e.OutInvoiceCode)
                    .HasMaxLength(20)
                    .HasComment("شناسه فاکتور بیرونی مربوط به شرکت ارائه دهنده کالا و فاکتور");

                entity.Property(e => e.PaymentablePrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("مبلغ قابل پرداخت و پرداخت شده");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ خرید");

                entity.Property(e => e.PurchaserId).HasComment("کد پرسنلی خریدار یا کارپرداز مربوطه متصل به جدول کارمندان");

                entity.Property(e => e.StoreId).HasComment("شناسه انبار متصل به جدول بخش ها");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("فیلد محاسباتی تخفیف کل");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("فلید محاسبانی قیمت کل");

                entity.Property(e => e.TotalTax)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("فیلد محاسباتی مالیات کل");

                entity.Property(e => e.TransfereeId).HasComment("شناسه پرسنلی فرد تحویل گیرنده دارو متصل به جدول کارمندان");

                entity.Property(e => e.UserId).HasComment("شناسه فرد ثبت‌کننده فاکتور متصل به جدول کاربران");

                entity.HasOne(d => d.DistributionCompany)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.DistributionCompanyId)
                    .HasConstraintName("FK_PurchaseInvoice_Company");

                entity.HasOne(d => d.Purchaser)
                    .WithMany(p => p.PurchaseInvoicePurchasers)
                    .HasForeignKey(d => d.PurchaserId)
                    .HasConstraintName("FK_Employee_PurchaseInvoicePurchaser");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_PurchaseInvoice");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_PurchaseInvoice_Section");

                entity.HasOne(d => d.Transferee)
                    .WithMany(p => p.PurchaseInvoiceTransferees)
                    .HasForeignKey(d => d.TransfereeId)
                    .HasConstraintName("FK_Employee_PurchaseInvoiceTransferee");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Users_PurchaseInvoice");
            });

            modelBuilder.Entity<PurchaseInvoiceDetail>(entity =>
            {
                entity.ToTable("PurchaseInvoiceDetails", "Drug");

                entity.Property(e => e.Award).HasComment("تعداد داروهایی که به عنوان اشانتیون دریافت شده");

                entity.Property(e => e.AwardProfit)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("مقدار سود براساس تعداد داروهای دریافتی اشانتیون");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .HasComment("کد سیستمی داخلی");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("تخفیف");

                entity.Property(e => e.DrugId).HasComment("شناسه دارو متصل  جدول داروها");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ انقضا دارو");

                entity.Property(e => e.PackagingQuantity).HasComment("تعداد بسته‌های انتخابی دارو");

                entity.Property(e => e.PackagingTypeId).HasComment("شناسه بسته بندی دارو متصل به جدول بسته‌بندی");

                entity.Property(e => e.PurchaseInvoiceId).HasComment("شناسه اتصال به جدول پدر (هدر) بنام پورچیس اینویس");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("قیمت خرید");

                entity.Property(e => e.Quantity).HasComment("تعداد دارو");

                entity.Property(e => e.Returned).HasComment("مرجوعی");

                entity.Property(e => e.SalesPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("قیمت فروش");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("مالیات");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("فیلد محاسباتی قیمت کل");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.PurchaseInvoiceDetails)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_Drugs_PurchaseInvoiceDetails");

                entity.HasOne(d => d.PackagingType)
                    .WithMany(p => p.PurchaseInvoiceDetails)
                    .HasForeignKey(d => d.PackagingTypeId)
                    .HasConstraintName("FK_PackagingType_PurchaseInvoiceDetails");

                entity.HasOne(d => d.PurchaseInvoice)
                    .WithMany(p => p.PurchaseInvoiceDetails)
                    .HasForeignKey(d => d.PurchaseInvoiceId)
                    .HasConstraintName("FK_PurchaseInvoice_PurchaseInvoiceDetails");
            });

            modelBuilder.Entity<PurposeRequestBlood>(entity =>
            {
                entity.ToTable("PurposeRequestBlood", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<ReadyAnswer>(entity =>
            {
                entity.ToTable("ReadyAnswer");

                entity.Property(e => e.Code1).HasMaxLength(255);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasComment("هر آزمایش در نوعی دیگر دسته¬بندی شده و بر اساس دسته بندی، در شرایط خاصی برای دریافت نمونه و جواب¬دهی با آن برخورد می-شود. این آزمایشات در ثبت و روش انجام با هم تفاوت دارند. به همین جهت، در ثبت آزمایش مهم است که نوع آزمایش مشخص شود.");

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<ReadyAnswer1>(entity =>
            {
                entity.ToTable("ReadyAnswer", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(255);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasComment("هر آزمایش در نوعی دیگر دسته¬بندی شده و بر اساس دسته بندی، در شرایط خاصی برای دریافت نمونه و جواب¬دهی با آن برخورد می-شود. این آزمایشات در ثبت و روش انجام با هم تفاوت دارند. به همین جهت، در ثبت آزمایش مهم است که نوع آزمایش مشخص شود.");

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Reception>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reception");
            });

            modelBuilder.Entity<Reception1>(entity =>
            {
                entity.ToTable("Receptions");

                entity.Property(e => e.Advice).HasMaxLength(2000);

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.ChiefComplaints).HasMaxLength(2000);

                entity.Property(e => e.ConsumeDrug)
                    .HasMaxLength(400)
                    .HasComment("داروهای خاص");

                entity.Property(e => e.DateOfSign)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ علائم");

                entity.Property(e => e.HospitalEnteryDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ ورود به بیمارستان");

                entity.Property(e => e.IsHaveSign).HasComment("ایا علائمی دارد یا نه");

                entity.Property(e => e.IsResult).HasComment("فعلا برای کوید 19 جواب");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasComment("برای اینکه بدانیم شخصی که این کوید را ثبت کرد چه کسی است . فعلا به جدول پرسن مرتب میکنیم");

                entity.Property(e => e.ReceptionDate).HasColumnType("datetime");

                entity.Property(e => e.RecoveryDate)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ بهبودی");

                entity.Property(e => e.RefferDate).HasColumnType("datetime");

                entity.Property(e => e.ResultNote).HasMaxLength(2500);

                entity.HasOne(d => d.CurrentIllness)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.CurrentIllnessId)
                    .HasConstraintName("FK_Receptions_Illness");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Reception1Doctors)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Reception_Doctors");

                entity.HasOne(d => d.GeneralStatus)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.GeneralStatusId)
                    .HasConstraintName("FK_Reception_GeneralStatus");

                entity.HasOne(d => d.HospitalizationDoctor)
                    .WithMany(p => p.Reception1HospitalizationDoctors)
                    .HasForeignKey(d => d.HospitalizationDoctorId)
                    .HasConstraintName("FK_Reception_Doctors1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Receptions_Person");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Reciption_Paitient");

                entity.HasOne(d => d.Presenter)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.PresenterId)
                    .HasConstraintName("FK_Receptions_Presenter");

                entity.HasOne(d => d.ReceptionType)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.ReceptionTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Reciption_ReceptionType");

                entity.HasOne(d => d.RefferFrom)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.RefferFromId)
                    .HasConstraintName("FK_Receptions_RefferFrom");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.RelationId)
                    .HasConstraintName("FK_Receptions_RelationShip");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Reception1s)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Reciption_Section");
            });

            modelBuilder.Entity<ReceptionAnswer>(entity =>
            {
                entity.ToTable("ReceptionAnswer");

                entity.Property(e => e.InfoDate).HasColumnType("datetime");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.ReceptionAnswers)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK_ReceptionAnswer_Answer");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ReceptionAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_ReceptionAnswer_Question");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionAnswers)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_ReceptionAnswer_Receptions");
            });

            modelBuilder.Entity<ReceptionDetail>(entity =>
            {
                entity.ToTable("ReceptionDetail", "Lab");

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.LmpDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PrescriptionDate).HasColumnType("datetime");

                entity.Property(e => e.ReceptionDate).HasColumnType("datetime");

                entity.HasOne(d => d.PatoDoctor)
                    .WithMany(p => p.ReceptionDetailPatoDoctors)
                    .HasForeignKey(d => d.PatoDoctorId)
                    .HasConstraintName("FK_ReceptionDetail_Doctors");

                entity.HasOne(d => d.PrescriptionDoctor)
                    .WithMany(p => p.ReceptionDetailPrescriptionDoctors)
                    .HasForeignKey(d => d.PrescriptionDoctorId)
                    .HasConstraintName("FK_ReceptionDetail_Doctors1");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionDetails)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_LabReceptionDetail_Receptions");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ReceptionDetails)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_ReceptionDetail_Section");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ReceptionDetails)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_ReceptionDetail_ReceptionServiceStatus");
            });

            modelBuilder.Entity<ReceptionDiagnosis>(entity =>
            {
                entity.ToTable("ReceptionDiagnosis");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.ReceptionDiagnoses)
                    .HasForeignKey(d => d.DiagnosisId)
                    .HasConstraintName("FK_ReceptionDiagnosis_Diagnosis");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.ReceptionDiagnoses)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_ReceptionDiagnosis_Prescription");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionDiagnoses)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_ReceptionDiagnosis_Receptions");
            });

            modelBuilder.Entity<ReceptionDiagnosisHistory>(entity =>
            {
                entity.ToTable("ReceptionDiagnosisHistory");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.HasOne(d => d.DiagnosisStatus)
                    .WithMany(p => p.ReceptionDiagnosisHistories)
                    .HasForeignKey(d => d.DiagnosisStatusId)
                    .HasConstraintName("FK_ReceptionDiagnosisHistory_DiagnosisStatus");

                entity.HasOne(d => d.ReceptionDiagnosis)
                    .WithMany(p => p.ReceptionDiagnosisHistories)
                    .HasForeignKey(d => d.ReceptionDiagnosisId)
                    .HasConstraintName("FK_ReceptionDiagnosisHistory_ReceptionDiagnosis");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ReceptionDiagnosisHistories)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_ReceptionDiagnosisHistory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReceptionDiagnosisHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ReceptionDiagnosisHistory_Users");
            });

            modelBuilder.Entity<ReceptionDrug>(entity =>
            {
                entity.ToTable("ReceptionDrug", "Drug");

                entity.Property(e => e.ConsumerSectionId).HasComment("این دارو در چه بخشی مصرف شده");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraPayment)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("پرداخت اضافی حق فنی داروخانه");

                entity.Property(e => e.FinalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.NurseId).HasComment("شخص دومی که از تجویز دارو سود می برد");

                entity.Property(e => e.PatientShare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrescriptionId).HasComment("این دارو از کدام تجویز امده یا نسخه");

                entity.Property(e => e.PrescriptionShare)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("حق نسخه ");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceMethodTypeId).HasComment("تعرفه ازاد تعرفه دولتی");

                entity.Property(e => e.Providershare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RequestId).HasComment("این دارو از کدام درخواست امده");

                entity.Property(e => e.SectionDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SectionId).HasComment("داروخانه ای که دارو را اعطا کرده است");

                entity.Property(e => e.TechnicalShare)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("حق فنی");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.ConsumerSection)
                    .WithMany(p => p.ReceptionDrugConsumerSections)
                    .HasForeignKey(d => d.ConsumerSectionId)
                    .HasConstraintName("FK_ReceptionDrug_Consumer_Section");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ReceptionDrugs)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_ReceptionDrug_Doctors");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.ReceptionDrugs)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_ReceptionDrug_Drugs");

                entity.HasOne(d => d.PriceMethodType)
                    .WithMany(p => p.ReceptionDrugs)
                    .HasForeignKey(d => d.PriceMethodTypeId)
                    .HasConstraintName("FK_ReceptionDrug_PriceTypeMethod");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionDrugs)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_ReceptionDrug_Receptions");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ReceptionDrugs)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_ReceptionDrug_Request");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ReceptionDrugSections)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_ReceptionDrug_Section_Section");
            });

            modelBuilder.Entity<ReceptionHistory>(entity =>
            {
                entity.ToTable("ReceptionHistory");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.PatientStatusId).HasComment("وضعیت خود بیمار");

                entity.Property(e => e.SectionId).HasComment("احتیاطا برای جدرج وضعیت در بخش های مجازی");

                entity.Property(e => e.SectionStatusId).HasComment("وضعیت بیمار در بخش مثل (ترخیص- خروج -پذیرش) ");

                entity.HasOne(d => d.ClearanceType)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.ClearanceTypeId)
                    .HasConstraintName("FK_RecepiotnHistory_ClearanceType");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_RecepiotnHistory_Doctors");

                entity.HasOne(d => d.PatientStatus)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.PatientStatusId)
                    .HasConstraintName("FK_RecepiotnHistory_GeneralStatus");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_RecepiotnHistory_Receptions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_ReceptionHistory");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_RecepiotnHistory_Section");

                entity.HasOne(d => d.SectionStatus)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.SectionStatusId)
                    .HasConstraintName("FK_RecepiotnHistory_SectionStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReceptionHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RecepiotnHistory_Users");
            });

            modelBuilder.Entity<ReceptionSectionDoctor>(entity =>
            {
                entity.ToTable("ReceptionSectionDoctor");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ReceptionSectionDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_ReceptionSectionDoctor_Doctors");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionSectionDoctors)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_ReceptionSectionDoctor_Receptions");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ReceptionSectionDoctors)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_ReceptionSectionDoctor_Section");
            });

            modelBuilder.Entity<ReceptionService>(entity =>
            {
                entity.ToTable("ReceptionService");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DoctorDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExtraPayment).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PatientShare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrescriptionDetailServiceId).HasComment("برای رسیدن به سرویس از طریق تجویز");

                entity.Property(e => e.PrescriptionShare)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("حق نسخه ");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Providershare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SectionDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TechnicalShare)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("حق فنی");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.AnswerUser)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.AnswerUserId)
                    .HasConstraintName("FK_ReceptionService_Users");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_ReceptionService_Doctors");

                entity.HasOne(d => d.PrescriptionDetailService)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.PrescriptionDetailServiceId)
                    .HasConstraintName("FK_ReceptionService_PrescriptionDetailService");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_ReceptionService_Prescription");

                entity.HasOne(d => d.PriceMethodType)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.PriceMethodTypeId)
                    .HasConstraintName("FK_ReceptionService_PriceMethodType");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_ReceptionService_Reception");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_ReceptionService_Request");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_ReceptionService_Section");

                entity.HasOne(d => d.ServiceChild)
                    .WithMany(p => p.ReceptionServiceServiceChildren)
                    .HasForeignKey(d => d.ServiceChildId)
                    .HasConstraintName("FK_ReceptionService_Services");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ReceptionServiceServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_ReceptionService_Service");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .HasConstraintName("FK_ReceptionService_ServiceType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ReceptionServices)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_ReceptionService_ReceptionServiceStatusId");
            });

            modelBuilder.Entity<ReceptionServiceStatus>(entity =>
            {
                entity.ToTable("ReceptionServiceStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.TitleLang2).HasMaxLength(100);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ReceptionServiceStatuses)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_ReceptionServiceStatus_Section");
            });

            modelBuilder.Entity<ReceptionSign>(entity =>
            {
                entity.ToTable("ReceptionSign");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionSigns)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_ReceptionSign_Receptions");

                entity.HasOne(d => d.Sign)
                    .WithMany(p => p.ReceptionSigns)
                    .HasForeignKey(d => d.SignId)
                    .HasConstraintName("FK_ReceptionSign_Sign");
            });

            modelBuilder.Entity<ReceptionType>(entity =>
            {
                entity.ToTable("ReceptionType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<RefferFrom>(entity =>
            {
                entity.ToTable("RefferFrom");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<RefferReason>(entity =>
            {
                entity.ToTable("RefferReason");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_RefferReason_RefferReason");
            });

            modelBuilder.Entity<RelatedTest>(entity =>
            {
                entity.ToTable("RelatedTest", "Lab");

                entity.HasOne(d => d.MainService)
                    .WithMany(p => p.RelatedTestMainServices)
                    .HasForeignKey(d => d.MainServiceId)
                    .HasConstraintName("FK_RelatedTest_Services");

                entity.HasOne(d => d.SubService)
                    .WithMany(p => p.RelatedTestSubServices)
                    .HasForeignKey(d => d.SubServiceId)
                    .HasConstraintName("FK_RelatedTest_Services1");
            });

            modelBuilder.Entity<RelationShip>(entity =>
            {
                entity.ToTable("RelationShip");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("Religion");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("Request");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DoneDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PrescriptionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Request_Doctors");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.PrescriptionId)
                    .HasConstraintName("FK_Request_Prescription");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_Request_Receptions");

                entity.HasOne(d => d.RequestType)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestTypeId)
                    .HasConstraintName("FK_Request_RequestType");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_Request");

                entity.HasOne(d => d.SourceSection)
                    .WithMany(p => p.RequestSourceSections)
                    .HasForeignKey(d => d.SourceSectionId)
                    .HasConstraintName("FK_Request_Source_Section");

                entity.HasOne(d => d.TargetSection)
                    .WithMany(p => p.RequestTargetSections)
                    .HasForeignKey(d => d.TargetSectionId)
                    .HasConstraintName("FK_Request_Tareget_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Request_Users");
            });

            modelBuilder.Entity<RequestDetail>(entity =>
            {
                entity.ToTable("RequestDetail", "Drug");

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasComment("احتیاطا اگر بخواهد دارو را از ساخت خاصی شروع کند");

                entity.Property(e => e.StatusId).HasComment("درحال بررسی - تایید شده - ابطال");

                entity.HasOne(d => d.DrugForm)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.DrugFormId)
                    .HasConstraintName("FK_RequestDetail_DrugForm");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_RequestDetail_Drugs1");

                entity.HasOne(d => d.GenericDrug)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.GenericDrugId)
                    .HasConstraintName("FK_RequestDetail_GenericDrug");

                entity.HasOne(d => d.PrescriptionInstruction)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.PrescriptionInstructionId)
                    .HasConstraintName("FK_RequestDetail_PrescriptionInstruction");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_RequestDetail_RequestStatus");

                entity.HasOne(d => d.WayOfPrescription)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.WayOfPrescriptionId)
                    .HasConstraintName("FK_RequestDetail_WayOfPrescription");
            });

            modelBuilder.Entity<RequestDetail1>(entity =>
            {
                entity.ToTable("RequestDetails", "Lab");

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Note).HasMaxLength(2000);
            });

            modelBuilder.Entity<RequestHistory>(entity =>
            {
                entity.ToTable("RequestHistory");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.RequestHistoryDeliveries)
                    .HasForeignKey(d => d.DeliveryId)
                    .HasConstraintName("FK_RequestHistory_DeliveryUsers");

                entity.HasOne(d => d.Receive)
                    .WithMany(p => p.RequestHistoryReceives)
                    .HasForeignKey(d => d.ReceiveId)
                    .HasConstraintName("FK_RequestHistory_ReceiveUsers");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestHistories)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_RequestHistory_Request");

                entity.HasOne(d => d.RequestStatus)
                    .WithMany(p => p.RequestHistories)
                    .HasForeignKey(d => d.RequestStatusId)
                    .HasConstraintName("FK_RequestHistory_RequestStatus");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RequestHistories)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_RequestHistory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RequestHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RequestHistory_Users");
            });

            modelBuilder.Entity<RequestStatus>(entity =>
            {
                entity.ToTable("RequestStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<RequestType>(entity =>
            {
                entity.ToTable("RequestType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<RespiratoryService>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AbbreviationTitle).HasMaxLength(255);

                entity.Property(e => e.InterNationalCode).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Rh>(entity =>
            {
                entity.ToTable("Rh");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<RichLongAnswer>(entity =>
            {
                entity.ToTable("RichLongAnswer");

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.RichLongAnswers)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_RichLongAnswer_Services");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.RoleGroup)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.RoleGroupId)
                    .HasConstraintName("FK_Role_RoleGroup");
            });

            modelBuilder.Entity<RoleGroup>(entity =>
            {
                entity.ToTable("RoleGroup");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("RolePermission");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_RolePermission_Permissions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RolePermission_Role");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_RolePermission_Section");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.RoomNo).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.RoomType)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.RoomTypeId)
                    .HasConstraintName("FK_Room_RoomType");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Room_Section");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.ToTable("RoomType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<SampleType>(entity =>
            {
                entity.ToTable("SampleType", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<SamplerType>(entity =>
            {
                entity.ToTable("SamplerType", "Lab");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Sampling>(entity =>
            {
                entity.ToTable("Sampling", "Lab");

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsPatientIdentificationByQuestion).HasComment("شناسایی بیمار از طریق سوال");

                entity.Property(e => e.IsPatientIdentificationByWrist).HasComment("شناسایی بیمار از طریق مچ بند");

                entity.Property(e => e.LabReceptionId).HasComment("به ریسپشن ازمایشگاه متصل است");

                entity.Property(e => e.OtherSampler).HasMaxLength(100);

                entity.Property(e => e.SampleSizeTaken).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SamplerTypeId).HasComment("نمونه گیری توسط چه کسی یا کجا");

                entity.HasOne(d => d.LabReception)
                    .WithMany(p => p.Samplings)
                    .HasForeignKey(d => d.LabReceptionId)
                    .HasConstraintName("FK_Sampling_ReceptionDetail");

                entity.HasOne(d => d.SampleType)
                    .WithMany(p => p.Samplings)
                    .HasForeignKey(d => d.SampleTypeId)
                    .HasConstraintName("FK_SamplingPatient_SampleType");

                entity.HasOne(d => d.SamplerType)
                    .WithMany(p => p.Samplings)
                    .HasForeignKey(d => d.SamplerTypeId)
                    .HasConstraintName("FK_SamplingPatient_SamplerType");

                entity.HasOne(d => d.SamplingPerson)
                    .WithMany(p => p.Samplings)
                    .HasForeignKey(d => d.SamplingPersonId)
                    .HasConstraintName("FK_SamplingPatient_Users");
            });

            modelBuilder.Entity<SamplingHistory>(entity =>
            {
                entity.ToTable("SamplingHistory", "Lab");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SamplingHistories)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_SamplingHistory");

                entity.HasOne(d => d.Sampling)
                    .WithMany(p => p.SamplingHistories)
                    .HasForeignKey(d => d.SamplingId)
                    .HasConstraintName("FK_SamplingHistory_Sampling");

                entity.HasOne(d => d.SamplingStatus)
                    .WithMany(p => p.SamplingHistories)
                    .HasForeignKey(d => d.SamplingStatusId)
                    .HasConstraintName("FK_SamplingHistory_SamplingStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SamplingHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SamplingHistory_Users");
            });

            modelBuilder.Entity<SamplingStatus>(entity =>
            {
                entity.ToTable("SamplingStatus", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<ScaleType>(entity =>
            {
                entity.ToTable("ScaleType");

                entity.HasComment("--مقیاس(Scale): انواع کمیتها. کمی (یک اندازه گیری واقعی)؛ ترتیب (مجموعه ای از گزینه ها) اسمی (پاسخ هایی که ترتیب طبیعی ندارند ، مانند نام باکتری ها)؛ و روایت ، (توضیحات ، مانند نتایج دیکته ناشی از اشعه X).");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Scientificlevel>(entity =>
            {
                entity.ToTable("Scientificlevel");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.LocalCode).HasMaxLength(50);

                entity.Property(e => e.No).HasMaxLength(10);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.SectionFieldId).HasComment(" جنس کلی بخش از نظر اینکه ازمایشگاه است یا اتاق عمل یا کلینیک");

                entity.Property(e => e.SectionKindId).HasComment("جنس بخش از نظر انبار بودن و نوع انبار");

                entity.Property(e => e.SectionTypeId).HasComment("جنس بخش از نظر بخش یا واحد بودن");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);

                entity.HasOne(d => d.Boss)
                    .WithMany(p => p.SectionBosses)
                    .HasForeignKey(d => d.BossId)
                    .HasConstraintName("FK_Section_Employee1");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Section_BranchId");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_Section_Center");

                entity.HasOne(d => d.SectionField)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.SectionFieldId)
                    .HasConstraintName("FK_Section_SectionField");

                entity.HasOne(d => d.SectionKind)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.SectionKindId)
                    .HasConstraintName("FK_Section_SectionKind");

                entity.HasOne(d => d.SectionType)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.SectionTypeId)
                    .HasConstraintName("FK_Section_SectionType");

                entity.HasOne(d => d.SuperVisorPersonel)
                    .WithMany(p => p.SectionSuperVisorPersonels)
                    .HasForeignKey(d => d.SuperVisorPersonelId)
                    .HasConstraintName("FK_Section_Employee");

                entity.HasOne(d => d.TemperatureType)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.TemperatureTypeId)
                    .HasConstraintName("FK_Section_TemperatureType");
            });

            modelBuilder.Entity<SectionEssentialsDrug>(entity =>
            {
                entity.ToTable("SectionEssentialsDrug", "Drug");

                entity.Property(e => e.DrugId).HasComment("در مورد انبار مرکزی ملزومات دارویی به صورت ملزومات تجاری هم ممکن است لازم شود.");

                entity.Property(e => e.OrderPoint).HasComment("نقطه سفارش اگر به تعداد خاصی رسید باید دارو خریداری شود");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.SectionEssentialsDrugs)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_SectionEssentialsDrug_Drugs");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SectionEssentialsDrugs)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_SectionEssentialsDrug_Section");
            });

            modelBuilder.Entity<SectionEssentialsGenericDrug>(entity =>
            {
                entity.ToTable("SectionEssentialsGenericDrug", "Drug");

                entity.Property(e => e.GenericDrugId).HasComment("در بیشتر مواقع ملزومات دارویی به صورت جنریک ذخیره میشود.");

                entity.Property(e => e.OrderPoint).HasComment("نقطه سفارش اگر به تعداد خاصی رسید باید دارو خریداری شود");

                entity.HasOne(d => d.DrugForm)
                    .WithMany(p => p.SectionEssentialsGenericDrugs)
                    .HasForeignKey(d => d.DrugFormId)
                    .HasConstraintName("FK_SectionEssentialsGenericDrug_DrugForm");

                entity.HasOne(d => d.GenericDrug)
                    .WithMany(p => p.SectionEssentialsGenericDrugs)
                    .HasForeignKey(d => d.GenericDrugId)
                    .HasConstraintName("FK_SectionEssentialsGenericDrug_GenericDrug");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SectionEssentialsGenericDrugs)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_SectionEssentialsGenericDrug_Section");
            });

            modelBuilder.Entity<SectionField>(entity =>
            {
                entity.ToTable("SectionField");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SectionKind>(entity =>
            {
                entity.ToTable("SectionKind");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SectionProperty>(entity =>
            {
                entity.ToTable("SectionProperty");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SectionPropertyList>(entity =>
            {
                entity.ToTable("SectionPropertyList");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SectionPropertyLists)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_SectionPropertyList_Section");

                entity.HasOne(d => d.SectionProperty)
                    .WithMany(p => p.SectionPropertyLists)
                    .HasForeignKey(d => d.SectionPropertyId)
                    .HasConstraintName("FK_SectionPropertyList_SectionProperty");
            });

            modelBuilder.Entity<SectionService>(entity =>
            {
                entity.ToTable("SectionService");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SectionServices)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_SectinService_Section");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.SectionServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_SectinService_Services");
            });

            modelBuilder.Entity<SectionStatus>(entity =>
            {
                entity.ToTable("SectionStatus");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<SectionStore>(entity =>
            {
                entity.ToTable("SectionStore");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SectionStoreSections)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_SectionStore_SectionStore");

                entity.HasOne(d => d.SectionKind)
                    .WithMany(p => p.SectionStores)
                    .HasForeignKey(d => d.SectionKindId)
                    .HasConstraintName("FK_SectionStore_SectionKind");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.SectionStoreStores)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_SectionStore_Section");
            });

            modelBuilder.Entity<SectionType>(entity =>
            {
                entity.ToTable("SectionType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SellingType>(entity =>
            {
                entity.ToTable("SellingType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<SendSmsStatus>(entity =>
            {
                entity.ToTable("SendSmsStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Service>(entity =>
            {
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

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.DataTypeId)
                    .HasConstraintName("FK_Services_DataType");

                entity.HasOne(d => d.GroupAnswer)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.GroupAnswerId)
                    .HasConstraintName("FK_Services_GroupAnswer");

                entity.HasOne(d => d.MethodType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.MethodTypeId)
                    .HasConstraintName("FK_Services_MethodType");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Services_ParentServices");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Services_Property");

                entity.HasOne(d => d.RichLongAnswer)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.RichLongAnswerId)
                    .HasConstraintName("FK_Services_RichLongAnswer");

                entity.HasOne(d => d.ScaleType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ScaleTypeId)
                    .HasConstraintName("FK_Services_ScaleType");

                entity.HasOne(d => d.ServiceLevel)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ServiceLevelId)
                    .HasConstraintName("FK_Service_ServiceLevel");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .HasConstraintName("FK_Service_ServiceType");

                entity.HasOne(d => d.TestAnswerType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.TestAnswerTypeId)
                    .HasConstraintName("FK_Services_TestAnswerType");

                entity.HasOne(d => d.TimeAspct)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.TimeAspctId)
                    .HasConstraintName("FK_Services_TimeAspct");
            });

            modelBuilder.Entity<ServiceCoding>(entity =>
            {
                entity.ToTable("ServiceCoding");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceCodings)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_ServiceCoding_Services");
            });

            modelBuilder.Entity<ServiceLevel>(entity =>
            {
                entity.ToTable("ServiceLevel");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.ToTable("ServiceType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Setting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(150);

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Settings)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_Center_VisitType");
            });

            modelBuilder.Entity<Setting1>(entity =>
            {
                entity.ToTable("Setting", "Lab");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KeyName).HasMaxLength(150);

                entity.Property(e => e.KeyValue)
                    .HasMaxLength(150)
                    .HasColumnName("keyValue");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.ToTable("Sex");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<ShiftHour>(entity =>
            {
                entity.ToTable("ShiftHour");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<ShortLink>(entity =>
            {
                entity.ToTable("ShortLink", "Link");

                entity.Property(e => e.Id).HasMaxLength(5);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Link).HasMaxLength(200);

                entity.HasOne(d => d.SubSystem)
                    .WithMany(p => p.ShortLinks)
                    .HasForeignKey(d => d.SubSystemId)
                    .HasConstraintName("FK_ShortLink_SubSystem");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SideEffects", "Drug");

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.SideEffects)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_SideEffects_Drug");

                entity.HasOne(d => d.GenericDrug)
                    .WithMany(p => p.SideEffects)
                    .HasForeignKey(d => d.GenericDrugId)
                    .HasConstraintName("FK_SideEffects_GenericDrug");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SideEffects)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_SideEffects_Group");
            });

            modelBuilder.Entity<Sign>(entity =>
            {
                entity.ToTable("Sign");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLange2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(4000);

                entity.Property(e => e.TitleLang2).HasMaxLength(4000);
            });

            modelBuilder.Entity<SmsCenterBalance>(entity =>
            {
                entity.ToTable("SmsCenterBalance");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.SmsCenterBalances)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_SmsCenterBalance_Center");
            });

            modelBuilder.Entity<SmsCenterCharge>(entity =>
            {
                entity.ToTable("SmsCenterCharge");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.SmsCenterCharges)
                    .HasForeignKey(d => d.CenterId)
                    .HasConstraintName("FK_SmsCenter_Center");

                entity.HasOne(d => d.GiftReason)
                    .WithMany(p => p.SmsCenterCharges)
                    .HasForeignKey(d => d.GiftReasonId)
                    .HasConstraintName("FK_SmsCenter_SmsGiftReason");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SmsCenterCharges)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SmsCenter_Users");
            });

            modelBuilder.Entity<SmsGiftReason>(entity =>
            {
                entity.ToTable("SmsGiftReason");

                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SmsOperator>(entity =>
            {
                entity.Property(e => e.LocalCode).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SmsPrice>(entity =>
            {
                entity.ToTable("SmsPrice");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CostFromDate).HasColumnType("datetime");

                entity.Property(e => e.CostToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.SmsPrices)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_SmsPrice_SmsPrice");
            });

            modelBuilder.Entity<SmsReception>(entity =>
            {
                entity.ToTable("SmsReception");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SmsContent).HasMaxLength(4000);

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.SmsReceptions)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_SmsReception_Receptions");

                entity.HasOne(d => d.SendsmsStatus)
                    .WithMany(p => p.SmsReceptions)
                    .HasForeignKey(d => d.SendsmsStatusId)
                    .HasConstraintName("FK_SmsReception_SendSmsStatus");
            });

            modelBuilder.Entity<SpecialIllness>(entity =>
            {
                entity.ToTable("SpecialIllness");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<SpecialIllnessReception>(entity =>
            {
                entity.ToTable("SpecialIllnessReception");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.SpecialIllnessReceptions)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_SpecialIllnessReception_Receptions");

                entity.HasOne(d => d.SpecialIllness)
                    .WithMany(p => p.SpecialIllnessReceptions)
                    .HasForeignKey(d => d.SpecialIllnessId)
                    .HasConstraintName("FK_Illness_SpecialIllnessReception");
            });

            modelBuilder.Entity<StoreDrug>(entity =>
            {
                entity.ToTable("StoreDrug", "Drug");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.SectionId).HasComment("انبار یا ترالی یا استوک");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.StoreDrugs)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_StoreDrug_Drugs");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.StoreDrugs)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_StoreDrug_Section");
            });

            modelBuilder.Entity<StoreEntery>(entity =>
            {
                entity.ToTable("StoreEntery");
            });

            modelBuilder.Entity<StoreEntry>(entity =>
            {
                entity.ToTable("StoreEntry", "Drug");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.HasOne(d => d.PurchaseInvoice)
                    .WithMany(p => p.StoreEntries)
                    .HasForeignKey(d => d.PurchaseInvoiceId)
                    .HasConstraintName("FK_StoreEntry_PurchaseInvoice");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.StoreEntries)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_StoreEntry");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreEntries)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_StoreEntery_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StoreEntries)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_StoreEntery_Users");
            });

            modelBuilder.Entity<StoreEntryDetail>(entity =>
            {
                entity.ToTable("StoreEntryDetails", "Drug");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.StoreEntryDetails)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_StoreEnteryDetails_Drugs");

                entity.HasOne(d => d.PackagingType)
                    .WithMany(p => p.StoreEntryDetails)
                    .HasForeignKey(d => d.PackagingTypeId)
                    .HasConstraintName("FK_StoreEnteryDetails_PackagingType");

                entity.HasOne(d => d.PurchaseInvoiceDetails)
                    .WithMany(p => p.StoreEntryDetails)
                    .HasForeignKey(d => d.PurchaseInvoiceDetailsId)
                    .HasConstraintName("FK_StoreEntryDetails_PurchaseInvoiceDetails");

                entity.HasOne(d => d.StoreEntry)
                    .WithMany(p => p.StoreEntryDetails)
                    .HasForeignKey(d => d.StoreEntryId)
                    .HasConstraintName("FK_StoreEnteryDetails_StoreEntery");
            });

            modelBuilder.Entity<StoreTransfer>(entity =>
            {
                entity.ToTable("StoreTransfer", "Drug");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.HasOne(d => d.DeliveryUser)
                    .WithMany(p => p.StoreTransferDeliveryUsers)
                    .HasForeignKey(d => d.DeliveryUserId);

                entity.HasOne(d => d.DestinationStore)
                    .WithMany(p => p.StoreTransferDestinationStores)
                    .HasForeignKey(d => d.DestinationStoreId);

                entity.HasOne(d => d.ReceiveUser)
                    .WithMany(p => p.StoreTransferReceiveUsers)
                    .HasForeignKey(d => d.ReceiveUserId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.StoreTransfers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_StoreTransfer");

                entity.HasOne(d => d.SourceStore)
                    .WithMany(p => p.StoreTransferSourceStores)
                    .HasForeignKey(d => d.SourceStoreId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StoreTransfers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<StoreTransferDetail>(entity =>
            {
                entity.ToTable("StoreTransferDetails", "Drug");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.StoreTransferDetails)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_StoreTransferDetails_Drugs");

                entity.HasOne(d => d.PackagingType)
                    .WithMany(p => p.StoreTransferDetails)
                    .HasForeignKey(d => d.PackagingTypeId)
                    .HasConstraintName("FK_StoreTransferDetails_PackagingType1");

                entity.HasOne(d => d.StoreTransfer)
                    .WithMany(p => p.StoreTransferDetails)
                    .HasForeignKey(d => d.StoreTransferId)
                    .HasConstraintName("FK_StoreTransferDetails_StoreTransfer");
            });

            modelBuilder.Entity<StoregCondition>(entity =>
            {
                entity.ToTable("StoregCondition", "Drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<SubSystem>(entity =>
            {
                entity.ToTable("SubSystem", "Link");

                entity.Property(e => e.SubSystem1)
                    .HasMaxLength(200)
                    .HasColumnName("SubSystem");

                entity.Property(e => e.Token).HasMaxLength(200);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.Satet)
                    .HasMaxLength(100)
                    .HasColumnName("satet");

                entity.Property(e => e.Zone)
                    .HasMaxLength(100)
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp");

                entity.Property(e => e.Advice).HasMaxLength(2000);

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.ChiefComplaints).HasMaxLength(2000);

                entity.Property(e => e.ConsumeDrug).HasMaxLength(400);

                entity.Property(e => e.DateOfSign).HasColumnType("datetime");

                entity.Property(e => e.HospitalEnteryDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ReceptionDate).HasColumnType("datetime");

                entity.Property(e => e.RecoveryDate).HasColumnType("datetime");

                entity.Property(e => e.RefferDate).HasColumnType("datetime");

                entity.Property(e => e.ResultNote).HasMaxLength(2500);
            });

            modelBuilder.Entity<TempPationlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempPationlist");

                entity.Property(e => e.AccountExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.DoctorLatinName).HasMaxLength(100);

                entity.Property(e => e.DoctorName).HasMaxLength(403);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Introduced)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.NhsNumber).HasMaxLength(255);

                entity.Property(e => e.PatientId2)
                    .HasMaxLength(500)
                    .HasColumnName("patientId2");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(504);

                entity.Property(e => e.PatientTypeTitle)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PortalRegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SyncDate)
                    .HasColumnType("datetime")
                    .HasColumnName("syncDate");
            });

            modelBuilder.Entity<TempReceptions08>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempReceptions08");

                entity.Property(e => e.Advice).HasMaxLength(2000);

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.ChiefComplaints).HasMaxLength(2000);

                entity.Property(e => e.ConsumeDrug).HasMaxLength(400);

                entity.Property(e => e.DateOfSign).HasColumnType("datetime");

                entity.Property(e => e.HospitalEnteryDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ReceptionDate).HasColumnType("datetime");

                entity.Property(e => e.RecoveryDate).HasColumnType("datetime");

                entity.Property(e => e.RefferDate).HasColumnType("datetime");

                entity.Property(e => e.ResultNote).HasMaxLength(2500);
            });

            modelBuilder.Entity<TempUserRolePermission07>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempUserRolePermission07");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TemperatureType>(entity =>
            {
                entity.ToTable("TemperatureType", "Drug");

                entity.Property(e => e.Note).HasMaxLength(2500);

                entity.Property(e => e.Range).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Template", "Lab");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Templates)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Template_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Templates)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Template_Users");
            });

            modelBuilder.Entity<TestAnswerTime>(entity =>
            {
                entity.ToTable("TestAnswerTime", "Lab");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TestAnswerTimes)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_Table_1_Services");
            });

            modelBuilder.Entity<TestAnswerType>(entity =>
            {
                entity.ToTable("TestAnswerType", "Lab");

                entity.HasComment("این جدول نوع جواب تست تعیین مکنید مثلا از نوعی است");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<TestLabeling>(entity =>
            {
                entity.ToTable("TestLabeling", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<TestRange>(entity =>
            {
                entity.ToTable("TestRange", "Lab");

                entity.Property(e => e.AgeFrom).HasComment("برحسب روز می باشد");

                entity.Property(e => e.AgeTo).HasComment("برحسب روز می باشد");

                entity.Property(e => e.CriticalHighComment).HasMaxLength(500);

                entity.Property(e => e.CriticalLowComment).HasMaxLength(500);

                entity.Property(e => e.LowComment).HasMaxLength(500);

                entity.Property(e => e.NormalComment).HasMaxLength(500);

                entity.Property(e => e.OutOfRangeComment).HasMaxLength(500);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TestRanges)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_TestRange_Services");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.TestRanges)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_TestRange_Sex");
            });

            modelBuilder.Entity<TimeAspct>(entity =>
            {
                entity.ToTable("TimeAspct");

                entity.HasComment("فاصله زمانی که آزمون انجام شده است ، مانند یک نتیجه در یک زمان یا نتیجه ای که در طی 24 ساعت تدوین شده باشد");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit1>(entity =>
            {
                entity.ToTable("Unit", "Drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit2>(entity =>
            {
                entity.ToTable("Unit", "Lab");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MacAddress).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.SmsToken).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.CardCode)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CardCodeId)
                    .HasConstraintName("FK_Users_CardCode");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Users_Person");
            });

            modelBuilder.Entity<UserCardCode>(entity =>
            {
                entity.ToTable("UserCardCode");

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
                    .HasConstraintName("FK_UserCardCode_Users");

                entity.HasOne(d => d.ValidityPeriod)
                    .WithMany(p => p.UserCardCodes)
                    .HasForeignKey(d => d.ValidityPeriodId)
                    .HasConstraintName("FK_ValidityPeriodId_UserCardCode");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("UserPermission");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_UserPermission_Permissions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_UserPermission");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermission_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserPermission_Users");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRole_Users");
            });

            modelBuilder.Entity<UserRolePermission>(entity =>
            {
                entity.ToTable("UserRolePermission");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserRolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_UserRolePermission_Permissions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRolePermission_Role");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.UserRolePermissions)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_UserRolePermission_Section");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRolePermissions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRolePermission_Users");
            });

            modelBuilder.Entity<ValidityPeriod>(entity =>
            {
                entity.ToTable("ValidityPeriod");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<VisitType>(entity =>
            {
                entity.ToTable("VisitType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<VitalSign>(entity =>
            {
                entity.Property(e => e.Bmi)
                    .HasColumnName("BMI")
                    .HasComment("رابط بین قد وزن");

                entity.Property(e => e.BodyMassIndexes).HasComment("چگالی");

                entity.Property(e => e.Bpmean).HasColumnName("BPMean");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creatinine).HasComment("دفع کراتین");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.VitalSigns)
                    .HasForeignKey(d => d.ReceptionId)
                    .HasConstraintName("FK_VitalSigns_Receptions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.VitalSigns)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_VitalSigns");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VitalSigns)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_VitalSigns_Users");
            });

            modelBuilder.Entity<WayOfPrescription>(entity =>
            {
                entity.ToTable("WayOfPrescription", "Drug");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleLang2).HasMaxLength(150);
            });

            modelBuilder.Entity<WorkTimeType>(entity =>
            {
                entity.ToTable("WorkTimeType");

                entity.Property(e => e.Code1).HasMaxLength(20);

                entity.Property(e => e.Code2).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.NoteLang2).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleLang2).HasMaxLength(50);
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.ToTable("Zone");

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
