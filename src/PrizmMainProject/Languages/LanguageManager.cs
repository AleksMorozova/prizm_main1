using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Common;
using System.IO;
using System.Globalization;
using System.Resources;
using Prizm.Main.Properties;
using System.Reflection;

namespace Prizm.Main.Languages
{
    class LanguageManager : ILanguageManager
    {
        #region Language pack class

        private class LanguagePack
        {
            /// <summary>
            /// Groups information about chosen language around culture information
            /// </summary>
            /// <param name="culture">culture information</param>
            /// <param name="isDefault">is this culture default (only one could be default among all language packs)</param>
            public LanguagePack(CultureInfo culture, bool isDefault = false)
            {
                this.culture = culture;
                this.isDefault = isDefault;
                if (isDefault)
                {
                    manager = Resources.ResourceManager;
                }
            }
            private CultureInfo culture;
            private bool isDefault;
            private ResourceManager manager;

            public static implicit operator CultureInfo(LanguagePack pack)
            {
                return pack.culture;
            }

            public CultureInfo Culture { get { return culture; } }
            public bool IsDefault { get { return isDefault; } }
            public ResourceManager Manager { get { return manager; } set { manager = value; } }
        }

        #endregion // Language pack class

        private const string defaultCulture = "ru-RU";
        private CultureInfo defaultCultureInfo = new CultureInfo(defaultCulture);

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(LanguageManager));

        public LanguageManager()
        {
            FindAvailableTranslations();
        }

        /// <summary>
        /// Is supposed to be called once, finding all available external files with translation resources
        /// </summary>
        private void FindAvailableTranslations()
        {
            List<string> translationFiles = new List<string>();
            var installedCultures = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);

            if (Directory.Exists(Directories.LanguagesResources))
            {
                IEnumerable<string> directoryFiles = Directory.EnumerateFiles(Directories.LanguagesResources, "*.??-??.resources", SearchOption.TopDirectoryOnly);
                foreach (var file in directoryFiles)
                {
                    string[] tmp = file.Split('.');
                    if (tmp.Length > 1) // just in case
                    {
                        translationFiles.Add(tmp[tmp.Length - 2].Trim());
                    }
                }
            }
            cultures.Clear();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
            {
                bool cultureIsDefault = ci.Name == defaultCulture;
                int index = translationFiles.FindIndex((cultureName) => { return ci.Name == cultureName; });
                if (index >= 0 && cultures.FindIndex((a) => { return ci.Name == a.Culture.Name; }) < 0 || cultureIsDefault)
                {
                    cultures.Add(new LanguagePack(ci, cultureIsDefault));

                    if (cultureIsDefault)
                    {
                        indexDefault = cultures.Count - 1;
                    }
                }
            }
            indexCurrent = indexDefault;
            if (cultures.Count < 0)
            {
                ApplicationException e = new ApplicationException("Language error: no default culture information available.");
                log.Error(e.Message);
                throw e;
            }
        }

        private List<LanguagePack> cultures = new List<LanguagePack>();
        private int indexDefault = -1;
        private int indexCurrent = -1;

        /// <summary>
        /// return list of all cultures, for which our local translations are available
        /// (including default culture even if there is no appropriate external resource file).
        /// </summary>
        /// <param name="indexDefault">returned index of default culture in this list</param>
        /// <returns>list of cultures</returns>
        public IReadOnlyList<CultureInfo> GetCultures(out int indexDefault)
        {
                if (cultures.Count <= 0)
                {
                    FindAvailableTranslations();
                }
                indexDefault = this.indexDefault;
                List<CultureInfo> list = cultures.ConvertAll(new Converter<LanguagePack, CultureInfo>((lp) => { return (CultureInfo)lp; }));
                return list;
        }

        /// <summary>
        /// Change current culture to given culture.
        /// </summary>
        /// <param name="culture">given culture</param>
        /// <returns>true on success</returns>
        public bool LoadTranslation(CultureInfo culture)
        {
            bool status = false;
            int index = cultures.FindIndex((lp) => { return lp.Culture.Name == culture.Name; });
            if (index >= 0)
            {
                indexCurrent = index;
                status = true;
            }
            return status;
        }

        private ResourceManager manager = null;

        private ResourceManager Current 
        { 
            get 
            {
                if (manager == null)
                {
                    manager = ResourceManager.CreateFileBasedResourceManager(Directories.BaseLanguageFileName, Directories.LanguagesResourcesFolderName, null);
                }
                return manager ?? Default;
            } 
        }

        private ResourceManager Default
        {
            get
            {
                return Resources.ResourceManager;
            }
        }

        private CultureInfo CurrentCulture
        {
            get 
            {
                return cultures[indexCurrent].Culture;
            }
        }
        private CultureInfo DefaultCulture
        {
            get
            {
                return cultures[indexDefault].Culture;
            }
        }

        /// <summary>
        /// retrieves localized string when available. Otherwise retrieves default string.
        /// </summary>
        /// <param name="resourceId">id of requested string resource</param>
        /// <returns>localized string</returns>
        private bool TryGetLocalizedString(string resourceId, out string resource)
        {
            bool ret = true;
            resource = String.Empty;
            try
            {
                resource = this.Current.GetString(resourceId, this.CurrentCulture);
                ret = true;
            }
            catch (SystemException)
            {
                ret = false;
            }
            if (ret == false || String.IsNullOrWhiteSpace(resource))
            {
                try
                {
                    resource = this.Default.GetString(resourceId, Resources.Culture);
                    ret = true;
                }
                catch (SystemException e)
                {
                    ret = false;
                }
            }
            if (ret == false || String.IsNullOrWhiteSpace(resource))
            {
                resource = "<no resource>";
                log.Warn(string.Format("No resource for id {0}.", resourceId));
                ret = false;
            }
            return ret;
        }

        /// <summary>
        /// Change language at all localizable items.
        /// </summary>
        /// <param name="localizable">localizable item</param>
        public void ChangeLanguage(ILocalizable localizable)
        {
            if (localizable != null)
            {
                foreach (var localizedItem in localizable)
                {
                    for (int index = 0; index < localizedItem.Count; index++)
                    {

                        string resource;
                        if (TryGetLocalizedString(localizedItem.GetResourceId(index), out resource))
                        {
                            localizedItem[index] = resource;
                        }
                        else
                        {
                            localizedItem.BackToDefault(index);
                        }
                    }
                    localizedItem.Refresh();
                }
            }
        }

        /// <summary>
        /// Default culture information is always the same.
        /// </summary>
        public CultureInfo DefaultCultureInfo
        {
            get { return defaultCultureInfo; }
        }

        /// <summary>
        /// retrieve localized strings for messages
        /// </summary>
        /// <param name="resourceDescription">id and description of localized string. Only id will be used.</param>
        /// <returns>localized string, or empty if no localized or original string available.</returns>
        public string GetString(StringResource resourceDescription)
        {
            string ret;
            if (!TryGetLocalizedString(resourceDescription.Id, out ret))
            {
                log.Warn(string.Format("No StringResource for id {0}.", resourceDescription.Id));
            }
            return ret ?? "";
        }

        private class LocalEnumerator : IEnumerable<StringResource>
        {
            private System.Type type;
            public LocalEnumerator(System.Type stringResourcesStaticClassType)
            {
                this.type = stringResourcesStaticClassType;
            }

            public IEnumerator<StringResource> GetEnumerator()
            {
                if (type.IsAbstract && type.IsSealed) // that language-dependent strange way to check static class
                {
                    MemberInfo[] info = typeof(StringResources).GetMembers(BindingFlags.Public | BindingFlags.Static);
                    foreach (MemberInfo item in info)
                    {
                        FieldInfo field = typeof(StringResources).GetField(item.Name, BindingFlags.Public | BindingFlags.Static);
                        yield return (StringResource)field.GetValue(null);
                    }
                }
                else
                {
                    ApplicationException e = new ApplicationException(
                        string.Format("Cannot enumerate local strings in non-static class {0}.", type.Name));
                    log.Error(e.Message);
                    throw e;
                }
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

        public IEnumerable<StringResource> EnumerateStringResources(System.Type stringResourcesStaticClassType)
        {
            return new LocalEnumerator(stringResourcesStaticClassType);
        }

        public StringResource? FindById(System.Type stringResourcesStaticClassType, string resourceId)
        {
            StringResource? ret = null;
            foreach(var item in this.EnumerateStringResources(stringResourcesStaticClassType))
            {
                if(item.Id.Equals(resourceId))
                {
                    ret = item;
                    break;
                }
            }
            return ret;
        }

    }
}
