﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.XtraEditors;

namespace Prizm.Main.Common
{
    static class ControlColorExtensions
    {
        private static readonly Color requiredFieldColor = Color.LightYellow;

        private static void SwitchRequired(this TextEdit edit)
        {
            edit.BackColor = (String.IsNullOrEmpty(edit.Text) || edit.Text == "0") ? requiredFieldColor : Color.Empty;
        }

        private static void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBoxEdit)
            {
                ((ComboBoxEdit)sender).SwitchRequired();
            }
        }

        private static void OnTextChanged(object sender, EventArgs e)
        {
            if (sender is TextEdit)
            {
                ((TextEdit)sender).SwitchRequired();
            }
        }

        private static void OnGridLookupChanged(object sender, EventArgs e)
        {
            if(sender is GridLookUpEdit)
            {
                ((GridLookUpEdit)sender).SwitchRequired();
            }
        }

        /// <summary>
        /// set combo control color as 'required' for the form completion
        /// </summary>
        /// <param name="cEdit"></param>
        public static void SetRequiredCombo(this ComboBoxEdit cEdit)
        {
            cEdit.SelectedIndexChanged += new System.EventHandler(ControlColorExtensions.OnSelectedIndexChanged);
            cEdit.SwitchRequired();
        }

        /// <summary>
        /// set text edit control color as 'required' for the form completion
        /// </summary>
        /// <param name="edit"></param>
        public static void SetRequiredText(this TextEdit edit)
        {
            edit.TextChanged += new System.EventHandler(ControlColorExtensions.OnTextChanged);
            edit.SwitchRequired();
        }

        public static void SetRequiredGridLookUp(this GridLookUpEdit edit)
        {
            edit.TextChanged += new System.EventHandler(ControlColorExtensions.OnGridLookupChanged);
            edit.EditValueChanged += new System.EventHandler(ControlColorExtensions.OnGridLookupChanged);
            edit.SwitchRequired();
        }

    }
}
