using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageGalleryClient.Properties;
using L10NSharp;
using SIL.IO;

namespace ImageGalleryClient
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		
			var installedStringFileFolder = FileLocationUtilities.GetDirectoryDistributedWithApplication(false, "localization");
			LocalizationManager.UseLanguageCodeFolders = true;
			LocalizationManager.ReturnOnlyApprovedStrings = true;

			// we start with the language of their Operating System
			var uiLanguage = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
			// then if they've chosen a language in the past, use that
			if (Settings.Default.UserInterfaceLanguageSetExplicitly)
			{
				uiLanguage = Settings.Default.UserInterfaceLanguage;
			}

			using (var lm = LocalizationManager.Create(TranslationMemory.XLiff,
				uiLanguage,
				"Palaso", "Palaso", "1.0.0" /*product version*/, installedStringFileFolder, "SIL/Palaso",
				null /*icon*/, ""))
			{
				// if the language we asked for wasn't available, the LocalizationManager will ask the user
				// to choose a different one. If that happens, let's remember their choice for next time
				if (uiLanguage != LocalizationManager.UILanguageId)
				{
					Settings.Default.UserInterfaceLanguage = LocalizationManager.UILanguageId;
					Settings.Default.UserInterfaceLanguageSetExplicitly = true;
					Settings.Default.Save();
				}
				Application.Run(new Form1());
			}

			/*
			 LocalizationManager.SetUILanguage(tag.IsoCode, true);
			Settings.Default.UserInterfaceLanguage = tag.IsoCode;
			Settings.Default.UserInterfaceLanguageSetExplicitly = true;
			Settings.Default.Save();
			*/
		}
	}
}
