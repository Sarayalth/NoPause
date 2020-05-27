using BS_Utils.Utilities;
using NoPause.UI;
using HarmonyLib;
using UnityEngine;

namespace NoPause
{
	[HarmonyPatch(typeof(PauseController))]
	[HarmonyPatch("canPause", MethodType.Getter)]
	class TextSegmentedControlCellNew_Patch
	{
		static void Postfix(ref bool __result)
		{
			if (__result && Settings.ApplyNoPause)
				__result = false;
		}
	}
}
