using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings.ViewTypes
{
   public class WelderViewType : INotifyPropertyChanged
   {
      readonly Welder welder;
      public event PropertyChangedEventHandler PropertyChanged = delegate { };

      public WelderViewType(Welder welder)
      {
         this.welder = welder;
      }

      public WelderViewType()
      {
         this.welder = new Welder();
         this.welder.IsActive = true;
         CheckName();
      }

      public String FirstName
      {
         get
         {
            return welder.Name.FirstName;
         }
         set
         {
            CheckName();
            if (value != welder.Name.FirstName)
            {
               welder.Name.FirstName = value;
               FirePropertyChanged("FirstName");
            }
         }
      }

      public String LastName
      {
         get
         {
            return welder.Name.LastName;
         }
         set
         {
            CheckName();
            if (value != welder.Name.LastName)
            {
               welder.Name.LastName = value;
               FirePropertyChanged("LastName");
            }
         }
      }

      public String MiddleName
      {
         get
         {
            return welder.Name.MiddleName;
         }
         set
         {
            CheckName();
            if (value != welder.Name.MiddleName)
            {
               welder.Name.MiddleName = value;
               FirePropertyChanged("MiddleName");
            }
         }
      }

      public string Certificate 
      { 
         get
         {
            return welder.Certificate;
         }
         set
         {
            if (value != welder.Certificate)
            {
               welder.Certificate = value;
               FirePropertyChanged("Certificate");
            }
         }
      }

      public DateTime? CertificateExpitation
      {
         get
         {
            return welder.CertificateExpitation;
         }
         set
         {
            if (value != welder.CertificateExpitation)
            {
               welder.CertificateExpitation = value;
               FirePropertyChanged("CertificateExpitation");
            }
         }
      }

      public string Stamp
      {
         get
         {
            return welder.Stamp;
         }
         set
         {
            if (value != welder.Stamp)
            {
               welder.Stamp = value;
               FirePropertyChanged("Stamp");
            }
         }
      }

      public int Grade
      {
         get
         {
            return welder.Grade;
         }
         set
         {
            if (value != welder.Grade)
            {
               welder.Grade = value;
               FirePropertyChanged("Grade");
            }
         }
      }

      public bool Active
      {
         get
         {
            return welder.IsActive;
         }
         set
         {
            if (value != welder.IsActive)
            {
               welder.IsActive = value;
               FirePropertyChanged("Active");
            }
         }
      }

      void CheckName()
      {
         if (welder.Name == null)
            welder.Name = new PersonName();
      }

      private void FirePropertyChanged(string prop)
      {
         PropertyChanged(this, new PropertyChangedEventArgs(prop));
      }

      public Welder Welder
      {
         get
         {
            return welder;
         }
      }

   }
   
}
