using Harmony;
using UnityEngine;
using ModSettings;

namespace CraftingAnywhere
{
	internal class CraftingAnywhereSettings : JsonModSettings
	{
		[Section("Ammunition Workbench Items")]
		[Name("Bullet")]
		[Description("Craft anywhere")]
		public bool bulletAnywhere = false;

		[Name("Gunpowder")]
		[Description("Craft anywhere")]
		public bool gunpowderAnywhere = false;

		[Name("Revolver Ammunition")]
		[Description("Craft anywhere")]
		public bool revolverAmmunitionAnywhere = false;

		[Name("Rifle Ammunition")]
		[Description("Craft anywhere")]
		public bool rifleAmmunitionAnywhere = false;



		[Section("Forge Items")]
		[Name("Arrowhead")]
		[Description("Craft anywhere")]
		public bool arrowheadAnywhere = false;

		[Name("Improvised Hatchet")]
		[Description("Craft anywhere")]
		public bool improvisedHatchetAnywhere = false;

		[Name("Improvised Knife")]
		[Description("Craft anywhere")]
		public bool improvisedKnifeAnywhere = false;



		[Section("Workbench Items")]
		[Name("Arrow")]
		[Description("Craft anywhere")]
		public bool arrowAnywhere = false;

		[Name("Arrow Shaft")]
		[Description("Craft anywhere")]
		public bool arrowShaftAnywhere = false;

		[Name("Bearskin Bedroll")]
		[Description("Craft anywhere")]
		public bool bearskinBedrollAnywhere = false;

		[Name("Bearskin Coat")]
		[Description("Craft anywhere")]
		public bool bearskinCoatAnywhere = false;

		[Name("Bedroll (BlanketMod)")]
		[Description("Craft anywhere")]
		public bool bedrollAnywhere = false;

		[Name("Deerskin Boots")]
		[Description("Craft anywhere")]
		public bool deerskinBootsAnywhere = false;

		[Name("Deerskin Pants")]
		[Description("Craft anywhere")]
		public bool deerskinPantsAnywhere = false;

		[Name("Hook")]
		[Description("Craft anywhere")]
		public bool hookAnywhere = false;

		[Name("Line")]
		[Description("Craft anywhere")]
		public bool lineAnywhere = false;

		[Name("Moose-Hide Cloak")]
		[Description("Craft anywhere")]
		public bool moosehideCloakAnywhere = false;

		[Name("Moose-Hide Satchel")]
		[Description("Craft anywhere")]
		public bool moosehideSatchelAnywhere = false;

		[Name("Patchwork Blanket (BlanketMod)")]
		[Description("Craft anywhere")]
		public bool patchworkBlanketAnywhere = false;

		[Name("Rabbitskin Hat")]
		[Description("Craft anywhere")]
		public bool rabbitskinHatAnywhere = false;

		[Name("Rabbitskin Mitts")]
		[Description("Craft anywhere")]
		public bool rabbitskinMittsAnywhere = false;

		[Name("Snare")]
		[Description("Craft anywhere")]
		public bool snareAnywhere = false;

		[Name("Survival Bow")]
		[Description("Craft anywhere")]
		public bool bowAnywhere = false;

		[Name("Waterskin (Better Water Management)")]
		[Description("Craft anywhere")]
		public bool waterskinAnywhere = false;

		[Name("Wolfskin Coat")]
		[Description("Craft anywhere")]
		public bool wolfskinCoatAnywhere = false;
	}

	internal static class Settings
	{
		public static CraftingAnywhereSettings options;
		public static void OnLoad()
		{
			options = new CraftingAnywhereSettings();
			options.AddToModSettings("Crafting Anywhere");
		}
	}
}
