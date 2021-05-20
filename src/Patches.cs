using Harmony;
using UnityEngine;

namespace CraftingAnywhere
{
    internal static class Patches
    {

        [HarmonyPatch(typeof(Panel_Crafting), "ItemPassesFilter")]
        private static class ChangeCraftingLocation
        {
            internal static void Postfix(BlueprintItem bpi)
            {
                if (Settings.options.arrowAnywhere && bpi?.m_CraftedResult?.name == "GEAR_Arrow")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.arrowheadAnywhere && bpi?.m_CraftedResult?.name == "GEAR_ArrowHead")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.arrowShaftAnywhere && bpi?.m_CraftedResult?.name == "GEAR_ArrowShaft")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.bearskinBedrollAnywhere && bpi?.m_CraftedResult?.name == "GEAR_BearSkinBedRoll")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.bearskinCoatAnywhere && bpi?.m_CraftedResult?.name == "GEAR_BearSkinCoat")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.bedrollAnywhere && bpi?.m_CraftedResult?.name == "GEAR_BedRoll")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.bowAnywhere && bpi?.m_CraftedResult?.name == "GEAR_Bow")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.bulletAnywhere && bpi?.m_CraftedResult?.name == "GEAR_Bullet")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.patchworkBlanketAnywhere && bpi?.m_CraftedResult?.name == "GEAR_ClothSheet")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.deerskinBootsAnywhere && bpi?.m_CraftedResult?.name == "GEAR_DeerSkinBoots")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.deerskinPantsAnywhere && bpi?.m_CraftedResult?.name == "GEAR_DeerSkinPants")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.gunpowderAnywhere && bpi?.m_CraftedResult?.name == "GEAR_GunpowderCan")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.improvisedHatchetAnywhere && bpi?.m_CraftedResult?.name == "GEAR_HatchetImprovised")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.hookAnywhere && bpi?.m_CraftedResult?.name == "GEAR_Hook")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.improvisedKnifeAnywhere && bpi?.m_CraftedResult?.name == "GEAR_KnifeImprovised")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.lineAnywhere && bpi?.m_CraftedResult?.name == "GEAR_Line")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.moosehideSatchelAnywhere && bpi?.m_CraftedResult?.name == "GEAR_MooseHideBag")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.moosehideCloakAnywhere && bpi?.m_CraftedResult?.name == "GEAR_MooseHideCloak")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.rabbitskinHatAnywhere && bpi?.m_CraftedResult?.name == "GEAR_RabbitskinHat")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.rabbitskinMittsAnywhere && bpi?.m_CraftedResult?.name == "GEAR_RabbitSkinMittens")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.revolverAmmunitionAnywhere && bpi?.m_CraftedResult?.name == "GEAR_RevolverAmmoSingle")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.rifleAmmunitionAnywhere && bpi?.m_CraftedResult?.name == "GEAR_RifleAmmoSingle")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.snareAnywhere && bpi?.m_CraftedResult?.name == "GEAR_Snare")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.waterskinAnywhere && bpi?.m_CraftedResult?.name == "GEAR_Waterskin")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                else if (Settings.options.wolfskinCoatAnywhere && bpi?.m_CraftedResult?.name == "GEAR_WolfSkinCape")
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }
            }
        }
    }
}
