using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using MelonLoader;
using UnhollowerBaseLib;
using UnityEngine;

namespace CraftingAnywhere
{
    internal static class Patches
    {
        private const string arrow = "GEAR_Arrow";
        private const string arrowhead = "GEAR_ArrowHead";
        private const string arrowShaft = "GEAR_ArrowShaft";
        private const string bearskinBedroll = "GEAR_BearSkinBedRoll";
        private const string bearskinCoat = "GEAR_BearSkinCoat";
        private const string bedroll = "GEAR_BedRoll";
        private const string bow = "GEAR_Bow";
        private const string bullet = "GEAR_Bullet";
        private const string deerskinBoots = "GEAR_DeerSkinBoots";
        private const string deerskinPants = "GEAR_DeerSkinPants";
        private const string gunpowder = "GEAR_GunpowderCan";
        private const string hook = "GEAR_Hook";
        private const string improvisedHatchet = "GEAR_HatchetImprovised";
        private const string improvisedKnife = "GEAR_KnifeImprovised";
        private const string line = "GEAR_Line";
        private const string moosehideCloak = "GEAR_MooseHideCloak";
        private const string moosehideSatchel = "GEAR_MooseHideBag";
        private const string patchworkBlanket = "GEAR_ClothSheet";
        private const string rabbitskinHat = "GEAR_RabbitskinHat";
        private const string rabbitskinMitts = "GEAR_RabbitSkinMittens";
        private const string revolverAmmunition = "GEAR_RevolverAmmoSingle";
        private const string rifleAmmunition = "GEAR_RifleAmmoSingle";
        private const string snare = "GEAR_Snare";
        private const string waterskin = "GEAR_Waterskin";
        private const string wolfskinCoat = "GEAR_WolfSkinCape";


        [HarmonyPatch(typeof(Panel_Crafting), "ItemPassesFilter")]
        private static class ChangeCraftingLocation
        {
            internal static void Postfix(Panel_Crafting __instance, BlueprintItem bpi)
            {
                if (bpi?.m_CraftedResult?.name == arrow && Settings.options.arrowAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == arrowhead && Settings.options.arrowheadAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == arrowShaft && Settings.options.arrowShaftAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == bearskinBedroll && Settings.options.bearskinBedrollAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == bedroll && Settings.options.bedrollAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == bearskinCoat && Settings.options.bearskinCoatAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == bow && Settings.options.bowAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == bullet && Settings.options.bulletAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == deerskinBoots && Settings.options.deerskinBootsAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == deerskinPants && Settings.options.deerskinPantsAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == gunpowder && Settings.options.gunpowderAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == hook && Settings.options.hookAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == improvisedHatchet && Settings.options.improvisedHatchetAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == improvisedKnife && Settings.options.improvisedKnifeAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == line && Settings.options.lineAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == moosehideCloak && Settings.options.moosehideCloakAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == moosehideSatchel && Settings.options.moosehideSatchelAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == patchworkBlanket && Settings.options.patchworkBlanketAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == rabbitskinHat && Settings.options.rabbitskinHatAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == rabbitskinMitts && Settings.options.rabbitskinMittsAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == revolverAmmunition && Settings.options.revolverAmmunitionAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == rifleAmmunition && Settings.options.rifleAmmunitionAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == snare && Settings.options.snareAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == waterskin && Settings.options.waterskinAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

                if (bpi?.m_CraftedResult?.name == wolfskinCoat && Settings.options.wolfskinCoatAnywhere == true)
                {
                    bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                }

            }
        }
        private static GearItem GetGearItemPrefab(string name) => Resources.Load(name).Cast<GameObject>().GetComponent<GearItem>();

    }
}