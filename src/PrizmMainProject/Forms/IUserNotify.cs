using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms
{
    public interface IUserNotify
    {
        void ShowError(string text, string header);
        void ShowWarning(string text, string header);
        void ShowInfo(string text, string header);
        bool ShowYesNo(string text, string header);
        int ShowYesNoCancel(string text, string header);
        void ShowSuccess(string text, string header);
        void ShowFailure(string text, string header);
    }

}
