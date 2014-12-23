using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL;
using NHibernate;
using Ninject.Modules;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.Joint.Search;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.Railcar.Search;
using Prizm.Main.Forms.Reports.Construction;
using Prizm.Main.Forms.Reports.Incoming;
using Prizm.Main.Forms.Reports.Mill;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Forms.Spool;
using Prizm.Main.Forms;
using Prizm.Main.Forms.PipeMill.Heat;
using Prizm.Main.Forms.Railcar;
using Prizm.Main.Forms.PipeMill;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.PipeMill.Purchase;
using Prizm.Data.DAL.ADO;
using Prizm.Data.DAL.Security;
using Prizm.Main.Forms.Audit;
using Prizm.Main.Security;
using Prizm.Main.Forms.Component;
using Prizm.Main.Forms.Joint;
using Prizm.Data.DAL.Construction;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.MainChildForm.FirstSetupForm;
using Prizm.DAL.Hibernate;
using Prizm.Main.Forms.ExternalFile;
namespace Prizm.Main
{
    public class PrizmModule : NinjectModule
    {
        
        public override void Load()
        {
            #region Repository
            Bind<ISession>().ToMethod(_ => HibernateUtil.OpenSession(true));

            Bind<IRailcarRepository>().To<RailcarRepository>();
            Bind<IPipeRepository>().To<PipeRepository>();
            Bind<IHeatRepository>().To<HeatRepository>();
            Bind<IPlateRepository>().To<PlateRepository>();
            Bind<IAuditLogRepository>().To<AuditLogRepository>();
            Bind<IPurchaseOrderRepository>().To<PurchaseOrderRepository>();
            Bind<IWeldRepository>().To<WeldRepository>();
            Bind<IWelderRepository>().To<WelderRepository>();
            Bind<IPipeTestResultRepository>().To<PipeTestResultRepository>();
            Bind<IMillPipeSizeTypeRepository>().To<MillPipeSizeTypeRepository>();
            Bind<IPipeTestRepository>().To<PipeTestRepository>();
            Bind<IMillRepository>().To<MillRepository>();
            Bind<IJointOperationRepository>().To<JointOperationRepository>();

            Bind<ISettingsRepositories>().To<SettingsRepositories>();
            Bind<IRailcarRepositories>().To<RailcarRepositories>();
            Bind<IHeatRepositories>().To<HeatRepositories>();
            Bind<IProjectRepository>().To<ProjectRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<IMillReportsRepository>().To<MillReportsRepository>();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IRoleRepository>().To<RoleRepository>();
            Bind<IPermissionRepository>().To<PermissionRepository>();
            Bind<IConstructionRepository>().To<ConstructionRepository>();
            Bind<IJointRepository>().To<JointRepository>();

            Bind<IFirstSetupRepo>().To<FirstSetupRepo>();
            
            Bind<IComponentRepositories>().To<ComponentRepositories>();
            Bind<IComponentTypeRepository>().To<ComponentTypeRepository>();
            Bind<IComponentRepository>().To<ComponentRepository>();
            Bind<ISpoolRepository>().To<SpoolRepository>();
            Bind<ISpoolRepositories>().To<SpoolRepositories>();
            Bind<IJointTestResultRepository>().To<JointTestResultRepository>();
            Bind<IJointWeldResultRepository>().To<JointWeldResultRepository>();
            Bind<IInspectorRepository>().To<InspectorRepository>();
            Bind<IFileRepository>().To<FileRepository>();
            Bind<IWorkWithFilesRepository>().To<WorkWithFilesRepository>();
            // TODO: remove TemporaryContext after binding to real context.
            Bind<Prizm.Main.Security.ISecurityContext>().To<SecurityContext>().InSingletonScope();

            #endregion

            #region ViewModel
            Bind<HeatViewModel>().ToSelf();
            Bind<PurchaseOrderViewModel>().ToSelf();
            Bind<RailcarViewModel>().ToSelf();
            Bind<MillPipeSearchViewModel>().ToSelf();
            Bind<MillPipeNewEditViewModel>().ToSelf();
            Bind<RailcarSearchViewModel>().ToSelf();
            Bind<SettingsViewModel>().ToSelf();
            Bind<MillReportsViewModel>().ToSelf();
            Bind<PrizmApplicationViewModel>().ToSelf();
            Bind<JointNewEditViewModel>().ToSelf();
	        Bind<JointSearchViewModel>().ToSelf();
            Bind<PartSearchViewModel>().ToSelf();
            Bind<FirstSetupViewModel>().ToSelf();
            Bind<SpoolViewModel>().ToSelf();
            Bind<ExternalFilesViewModel>().ToSelf();
            #endregion

            #region Forms Binding
            Bind<MillPipeNewEditXtraForm>().ToSelf();
            Bind<RailcarNewEditXtraForm>().ToSelf();
            Bind<MillPipeSearchXtraForm>().ToSelf();
            Bind<MillReportsXtraForm>().ToSelf();
            Bind<ComponentNewEditXtraForm>().ToSelf();
            Bind<InspectionReportsXtraForm>().ToSelf();
            Bind<JointNewEditXtraForm>().ToSelf();
            Bind<JointSearchXtraForm>().ToSelf();
            Bind<ConstructionReportsXtraForm>().ToSelf();
            Bind<SettingsXtraForm>().ToSelf();
            Bind<RailcarSearchXtraForm>().ToSelf();
            Bind<SpoolsXtraForm>().ToSelf();
            Bind<HeatXtraForm>().ToSelf();
            Bind<PurchaseOrderXtraForm>().ToSelf();
            Bind<AuditXtraForm>().ToSelf();
            Bind<PartSearchXtraForm>().ToSelf();
            Bind<FirstSetupXtraForm>().ToSelf();
            Bind<ExternalFilesXtraForm>().ToSelf();
            #endregion

            #region Commands
            Bind<JointSearchCommand>().ToSelf(); 
            #endregion

            Bind<IUserNotify>().To<PrizmApplicationXtraForm>().InSingletonScope();
            Bind<AuditInterceptor>().ToSelf();
        }
    }
}