using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreepsWebsite.Models
{
    static public class CompoundPrices
    {
        public static int GetCreditCost(object[] compound)
        {
            int creditCost = 0;


            foreach (string[] mineral in compound)
            {
                int mineralAmount = Convert.ToInt32(mineral[1]);

                switch (mineral[0])
                {
                    case MineralNames.Hydrogen:
                        creditCost += MineralPrices.Hydrogen * mineralAmount;
                        break;
                    case MineralNames.Oxygen:
                        creditCost += MineralPrices.Oxygen * mineralAmount;
                        break;
                    case MineralNames.Utrium:
                        creditCost += MineralPrices.Utrium * mineralAmount;
                        break;
                    case MineralNames.Keanium:
                        creditCost += MineralPrices.Keanium * mineralAmount;
                        break;
                    case MineralNames.Lemergium:
                        creditCost += MineralPrices.Lemergium * mineralAmount;
                        break;
                    case MineralNames.Zynthium:
                        creditCost += MineralPrices.Zynthium * mineralAmount;
                        break;
                    case MineralNames.Catalyst:
                        creditCost += MineralPrices.Catalyst * mineralAmount;
                        break;
                    default:
                        break;
                }
            }

            return creditCost;
        }

        // Base Compounds
        public static int Hydroxide = GetCreditCost(CompoundMineralsNeeded.Hydroxide);
        public static int ZynthiumKeanite = GetCreditCost(CompoundMineralsNeeded.ZynthiumKeanite);
        public static int UtriumLemergite = GetCreditCost(CompoundMineralsNeeded.UtriumLemergite);
        public static int Ghodium = GetCreditCost(CompoundMineralsNeeded.Ghodium);


        // Tier 1 Compounds //
        public static int UtriumHydride = GetCreditCost(CompoundMineralsNeeded.UtriumHydride);
        public static int UtriumOxide = GetCreditCost(CompoundMineralsNeeded.UtriumOxide);

        public static int KeaniumHydride = GetCreditCost(CompoundMineralsNeeded.KeaniumHydride);
        public static int KeaniumOxide = GetCreditCost(CompoundMineralsNeeded.KeaniumOxide);

        public static int LemergiumHydride = GetCreditCost(CompoundMineralsNeeded.LemergiumHydride);
        public static int LemergiumOxide = GetCreditCost(CompoundMineralsNeeded.LemergiumOxide);

        public static int ZynthiumHydride = GetCreditCost(CompoundMineralsNeeded.ZynthiumHydride);
        public static int ZynthiumOxide = GetCreditCost(CompoundMineralsNeeded.ZynthiumOxide);

        public static int GhodiumHydride = GetCreditCost(CompoundMineralsNeeded.GhodiumHydride);
        public static int GhodiumOxide = GetCreditCost(CompoundMineralsNeeded.GhodiumOxide);


        // Tier 2 Compounds //
        public static int UtriumAcid = GetCreditCost(CompoundMineralsNeeded.UtriumAcid);
        public static int UtriumAlkalide = GetCreditCost(CompoundMineralsNeeded.UtriumAlkalide);

        public static int KeaniumAcid = GetCreditCost(CompoundMineralsNeeded.KeaniumAcid);
        public static int KeaniumAlkalide = GetCreditCost(CompoundMineralsNeeded.KeaniumAlkalide);

        public static int LemergiumAcid = GetCreditCost(CompoundMineralsNeeded.LemergiumAcid);
        public static int LemergiumAlkalide = GetCreditCost(CompoundMineralsNeeded.LemergiumAlkalide);

        public static int ZynthiumAcid = GetCreditCost(CompoundMineralsNeeded.ZynthiumAcid);
        public static int ZynthiumAlkalide = GetCreditCost(CompoundMineralsNeeded.ZynthiumAlkalide);

        public static int GhodiumAcid = GetCreditCost(CompoundMineralsNeeded.GhodiumAcid);
        public static int GhodiumAlkalide = GetCreditCost(CompoundMineralsNeeded.GhodiumAlkalide);


        // Tier 3 Compounds //
        public static int CatalyzedUtriumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedUtriumAcid);
        public static int CatalyzedUtriumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedUtriumAlkalide);

        public static int CatalyzedKeaniumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedKeaniumAcid);
        public static int CatalyzedKeaniumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedKeaniumAlkalide);

        public static int CatalyzedLemergiumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedLemergiumAcid);
        public static int CatalyzedLemergiumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedLemergiumAlkalide);

        public static int CatalyzedZynthiumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedZynthiumAcid);
        public static int CatalyzedZynthiumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedZynthiumAlkalide);

        public static int CatalyzedGhodiumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedGhodiumAcid);
        public static int CatalyzedGhodiumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedGhodiumAlkalide);
    }
}
