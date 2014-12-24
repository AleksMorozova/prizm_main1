using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Prizm.Main.Commands
{
   public class CommandInfo : IDisposable
   {
      ICommand executor = null;
      IAttacher attacher = null;

      public CommandInfo Executor(ICommand executor)
      {
         this.executor = executor;
         return this;
      }

      public CommandInfo Executor(Action<object> exec, Func<object> argQuery, Func<bool> enabledPredicate)
      {
         executor = new ClosureCommand(exec, enabledPredicate, argQuery);
         return this;
      }

      public CommandInfo AttachTo(SimpleButton button)
      {
         if (executor == null)
            throw new InvalidOperationException("command executor is not specified");

         attacher = new SimpleButtonAttacher(executor, button);
         return this;
      }

      public CommandInfo AttachTo(IAttacher attacher)
      {
         this.attacher = attacher;
         attacher.Attach();
         return this;
      }

      public CommandInfo Execute()
      {
         if (executor == null)
            throw new InvalidOperationException("executor is null");

         if (executor.CanExecute())
         {
            Prizm.Main.Forms.IUserNotify notify = Program.Kernel.Get<Prizm.Main.Forms.IUserNotify>();
            try
            {
                notify.ShowProcessing();
                executor.Execute();
            }
            finally
            {
                notify.HideProcessing();
            }
         }
         return this;
      }

      public bool CanExecute()
      {
         return executor != null ? executor.CanExecute() : false;
      }
      
      public void RefreshState()
      {
         if (attacher != null)
            attacher.RefreshState();
      }

      public void Dispose()
      {
         if (attacher != null)
            attacher.Dispose();

         attacher = null;
         executor = null;
      }

      #region Internal implementation

      #region SimpleButtonAttacher

      class SimpleButtonAttacher : Attacher<SimpleButton>
      {
         public SimpleButtonAttacher(ICommand command, SimpleButton btn) : base(command, btn)
         {
            Attach();
         }

         public override void Attach()
         {
            Detach();
            component.Click += btn_Click;
         }

         public override void Detach()
         {
            if (component != null)
            {
               component.Click -= btn_Click;
            }
         }

         public override void RefreshState()
         {
            component.Enabled = command.CanExecute();
         }

         void btn_Click(object sender, EventArgs e)
         {
            if (command == null)
               throw new InvalidOperationException("command is null");

            Prizm.Main.Forms.IUserNotify notify = Program.Kernel.Get<Prizm.Main.Forms.IUserNotify>();
            try
            {
                notify.ShowProcessing();

                command.Execute();
            }
            finally
            {
                notify.HideProcessing();
            }
         }

      }

      #endregion

      #region ClosureCommand

      class ClosureCommand : ICommand
      {
         readonly Action<object> execute;
         readonly Func<bool> canExecute;
         readonly Func<object> queryParameter;

         public ClosureCommand(Action<object> execute, Func<bool> canExecute, Func<object> queryParameter)
         {
            this.execute = execute;
            this.canExecute = canExecute;
            this.queryParameter = queryParameter;
         }

         public void Execute()
         {
            if (execute == null)
               throw new InvalidOperationException("execute function is null");

            object args = queryParameter != null ? queryParameter() : null;
            execute(args);
         }

         public bool CanExecute()
         {
            return canExecute != null ? canExecute() : false;
         }

         //TODO: IsExecutable should be removed.
         public bool IsExecutable
         {
            get
            {
               throw new NotImplementedException();
            }
            set
            {
               throw new NotImplementedException();
            }
         }
      }

      #endregion

      #endregion

      
   }
}
