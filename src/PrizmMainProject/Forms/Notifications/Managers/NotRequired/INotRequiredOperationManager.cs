﻿using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Notifications.Managers.NotRequired
{

    interface IPipeNotifier
    {
        void UpdateNotifications(Pipe pipeSavingState);
    }

    interface INotRequiredOperationManager
    {
        IPipeNotifier CreateNotifier(Pipe pipeInitialState);
    }
}