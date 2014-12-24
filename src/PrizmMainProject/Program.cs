using System;
using System.Configuration;
using System.Windows.Forms;

using Ninject;

using Prizm.Data.DAL.Hibernate;


using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Properties;
using Prizm.Main.Forms.Common;
using Prizm.Main.Security;
using Prizm.Data.DAL.Security;
using Prizm.Domain.Entity.Security;
using Prizm.Data.DAL;
using Prizm.Main.Forms.MainChildForm.FirstSetupForm;
using Prizm.Main.Forms.Settings;
using DevExpress.XtraSplashScreen;


namespace Prizm.Main
{
    internal static class Program
    {
        public static IKernel Kernel { get; private set; }
        /// <summary>
        /// the months count of user password prolongation
        /// </summary>
        private const int monthsCountPasswordProlongation = 3;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            bool cmdLineMode = false;
            try
            {
                // Splash screen
                SplashScreenManager.ShowForm(typeof(AppSplashScreen), true, false);

                // Database
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];

                HibernateUtil.Initialize(settings.ConnectionString);

                // Ninject
                Kernel = new StandardKernel(new PrizmModule());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Hide splash screen
                SplashScreenManager.CloseForm(false);

                while (!CreateProject())
                { }

                //Login
                while (!Login())
                {
                    MessageBox.Show(Resources.AuthenticationFailed, "PRIZMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mainForm = new PrizmApplicationXtraForm();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();//String.Format(Resources.IDS_ERROR + Environment.NewLine + "{0}\n{01}", ex.InnerException.Message + Environment.NewLine, ex.InnerException.InnerException.Message + Environment.NewLine);
                if (cmdLineMode)
                {
                    Console.Error.WriteLine(error);
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            finally
            {
                // Hide splash screen
                SplashScreenManager.CloseForm(false);
            }
        }

        static bool Login()
        {
           LoginForm dlg = new LoginForm();
           if (dlg.ShowDialog() == DialogResult.OK)
           {

              string login = dlg.Login;
              string password = dlg.Password;

               #if DEBUG
              if(string.IsNullOrWhiteSpace(dlg.Login) || string.IsNullOrWhiteSpace(dlg.Password))
              {
                  login = "admin";
                  password = "admin";
              }
               #endif

              User user = new User() { IsActive = false, Login = "system" };


              IUserRepository userRepo;


              using ( userRepo = Kernel.Get<IUserRepository>())
              {
                  user = userRepo.FindByLogin(login);

                  if (user == null || !user.IsActive)
                      return false;
              }

              userRepo = (UserRepository)Program.Kernel.GetService(typeof(UserRepository));

              string hash = PasswordEncryptor.EncryptPassword(password);

              if (user.PasswordHash != hash)
                 return false;

              if (user.PasswordExpires != null && user.PasswordExpires < DateTime.Now)
              {
                  PasswordChangeDialog dlgPassChange = new PasswordChangeDialog();

                  if (dlgPassChange.ShowPasswordDialog(user.PasswordHash) ==
                      System.Windows.Forms.DialogResult.OK)
                  {
                      user.PasswordHash = dlgPassChange.NewPasswordHash;
                      user.PasswordExpires = DateTime.Now.AddMonths(monthsCountPasswordProlongation);

                      userRepo.BeginTransaction();
                      userRepo.SaveOrUpdate(user);
                      userRepo.Commit();
                      userRepo.Evict(user);
                  }
                  else
                  {
                      return false;
                  }
              }
              
              ISecurityContext ctx = Kernel.Get<ISecurityContext>();
              ctx.LoggedUser = user;

              HibernateUtil.CurrentUser = ctx.GetLoggedPerson();
              return true;
           }
           else
           {
              System.Environment.Exit(0);
           }

           return false;
        }

        static bool CreateProject()
        {
            bool result = false;
            IProjectRepository repo = (IProjectRepository)Program.Kernel.Get(typeof(IProjectRepository));

            if(repo.GetSingle() == null)
            {
                using (var setupDialog = (FirstSetupXtraForm)Program.Kernel.Get(typeof(FirstSetupXtraForm)))
                {
                    setupDialog.ShowDialog();
                    if (setupDialog.DialogResult == DialogResult.Cancel)
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
            else
            {
                result = true;
            }

            return result;
        }


        //Global data
        private static DevExpress.XtraEditors.XtraForm mainForm;
        /// <summary>
        /// Global access to main form need to update statusbar texts
        /// </summary>
        public static DevExpress.XtraEditors.XtraForm MainForm { get { return mainForm; } }
    }
}