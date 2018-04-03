﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace BizDev.Library
{
    public class Utils
    {
        public string RemoveDiacritics(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

        public string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Vérifie la validité d'une adresse email.
        /// </summary>
        /// <param name="email">Adresse email à vérifier</param>
        /// <returns></returns>
        public bool IsEmailValid(string email)
        {
            try
            {
                if (email != string.Empty)
                {
                    if (new EmailAddressAttribute().IsValid(email))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// N'accepte que la saisie de chiffres, sans aucune décimale.
        /// </summary>
        /// <param name="e"></param>
        public void ChiffreOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        public string MD5Hash(string input)

        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Modification ou ajout d'un paramètre de configuration.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        /// <summary>
        /// Modification ou ajout d'un paramètre de configuration.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AddUpdateConnString(string name, string dataSource)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.ConnectionStrings.ConnectionStrings;

                settings[name].Name = name;
                settings[name].ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
