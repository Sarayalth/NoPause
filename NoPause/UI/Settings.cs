using BeatSaberMarkupLanguage.Attributes;
using BS_Utils.Utilities;
using UnityEngine;
namespace NoPause.UI
{
	class Settings : PersistentSingleton<Settings>
	{
		public static Config config;
		public void Awake()
		{
			config = new Config("NoPause");
		}

		[UIValue("no-pause-bool")]
		public static bool ApplyNoPause {
			get => config.GetBool("NoPause", "ApplyNoPause", true);
			set => config.SetBool("NoPause", "ApplyNoPause", value);
		}
	}
}
