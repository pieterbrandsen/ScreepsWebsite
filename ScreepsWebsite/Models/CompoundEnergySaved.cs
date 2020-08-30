using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreepsWebsite.Models
{
    public class CompoundEnergySaved
    {
        // Base Compounds
        public static string Hydroxide = "None";
        public static string ZynthiumKeanite = "None";
        public static string UtriumLemergite = "None";
        public static string Ghodium = "None";


        // Tier 1 Compounds //
        public static int UtriumHydride = 60;
        public static int UtriumOxide = 180;

        public static int KeaniumHydride = 30;
        public static int KeaniumOxide = 130;

        public static string[] LemergiumHydride = { "Build: 2.480 / Repair: 480 (Based on 1K work ticks)", "2480", "480" };
        public static int LemergiumOxide = 230;

        public static int ZynthiumHydride = 80;
        public static int ZynthiumOxide = 30;

        public static string[] GhodiumHydride = { "Upgrade: 480 (Based on 1K work ticks)", "480" };
        public static int GhodiumOxide = -20;


        // Tier 2 Compounds //
        public static int UtriumAcid = 140;
        public static int UtriumAlkalide = 380;

        public static int KeaniumAcid = 80;
        public static int KeaniumAlkalide = 280;

        public static string[] LemergiumAcid = { "Build: 3.980 / Repair: 780 (Based on 1K work ticks)", "3980", "780" };
        public static int LemergiumAlkalide = 480;

        public static int ZynthiumAcid = 180;
        public static int ZynthiumAlkalide = 80;

        public static string[] GhodiumAcid = { "Upgrade: 780 (Based on 1K work ticks)", "780" };
        public static int GhodiumAlkalide = -20;


        // Tier 3 Compounds //
        public static int CatalyzedUtriumAcid = 220;
        public static int CatalyzedUtriumAlkalide = 580;

        public static int CatalyzedKeaniumAcid = 130;
        public static int CatalyzedKeaniumAlkalide = 430;

        public static string[] CatalyzedLemergiumAcid = { "Build: 4.980 / Repair: 980 (Based on 1K work ticks)", "4980", "980" };
        public static int CatalyzedLemergiumAlkalide = 730;

        public static int CatalyzedZynthiumAcid = 280;
        public static int CatalyzedZynthiumAlkalide = 130;

        public static string[] CatalyzedGhodiumAcid = { "Upgrade: 980 (Based on 1K work ticks)", "980" };
        public static int CatalyzedGhodiumAlkalide = -20;
    }
}
