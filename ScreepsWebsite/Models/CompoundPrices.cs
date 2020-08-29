using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreepsWebsite.Models
{
    static public class CompoundPrices
    {
        public static double GetCreditCost(object[] compound)
        {
            double creditCost = 0;


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

            return Math.Round(creditCost * 15, 2);
        }

        // Base Compounds
        public static double Hydroxide = GetCreditCost(CompoundMineralsNeeded.Hydroxide);
        public static double ZynthiumKeanite = GetCreditCost(CompoundMineralsNeeded.ZynthiumKeanite);
        public static double UtriumLemergite = GetCreditCost(CompoundMineralsNeeded.UtriumLemergite);
        public static double Ghodium = GetCreditCost(CompoundMineralsNeeded.Ghodium);


        // Tier 1 Compounds //
        public static double UtriumHydride = GetCreditCost(CompoundMineralsNeeded.UtriumHydride);
        public static double UtriumOxide = GetCreditCost(CompoundMineralsNeeded.UtriumOxide);

        public static double KeaniumHydride = GetCreditCost(CompoundMineralsNeeded.KeaniumHydride);
        public static double KeaniumOxide = GetCreditCost(CompoundMineralsNeeded.KeaniumOxide);

        public static double LemergiumHydride = GetCreditCost(CompoundMineralsNeeded.LemergiumHydride);
        public static double LemergiumOxide = GetCreditCost(CompoundMineralsNeeded.LemergiumOxide);

        public static double ZynthiumHydride = GetCreditCost(CompoundMineralsNeeded.ZynthiumHydride);
        public static double ZynthiumOxide = GetCreditCost(CompoundMineralsNeeded.ZynthiumOxide);

        public static double GhodiumHydride = GetCreditCost(CompoundMineralsNeeded.GhodiumHydride);
        public static double GhodiumOxide = GetCreditCost(CompoundMineralsNeeded.GhodiumOxide);


        // Tier 2 Compounds //
        public static double UtriumAcid = GetCreditCost(CompoundMineralsNeeded.UtriumAcid);
        public static double UtriumAlkalide = GetCreditCost(CompoundMineralsNeeded.UtriumAlkalide);

        public static double KeaniumAcid = GetCreditCost(CompoundMineralsNeeded.KeaniumAcid);
        public static double KeaniumAlkalide = GetCreditCost(CompoundMineralsNeeded.KeaniumAlkalide);

        public static double LemergiumAcid = GetCreditCost(CompoundMineralsNeeded.LemergiumAcid);
        public static double LemergiumAlkalide = GetCreditCost(CompoundMineralsNeeded.LemergiumAlkalide);

        public static double ZynthiumAcid = GetCreditCost(CompoundMineralsNeeded.ZynthiumAcid);
        public static double ZynthiumAlkalide = GetCreditCost(CompoundMineralsNeeded.ZynthiumAlkalide);

        public static double GhodiumAcid = GetCreditCost(CompoundMineralsNeeded.GhodiumAcid);
        public static double GhodiumAlkalide = GetCreditCost(CompoundMineralsNeeded.GhodiumAlkalide);


        // Tier 3 Compounds //
        public static double CatalyzedUtriumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedUtriumAcid);
        public static double CatalyzedUtriumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedUtriumAlkalide);

        public static double CatalyzedKeaniumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedKeaniumAcid);
        public static double CatalyzedKeaniumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedKeaniumAlkalide);

        public static double CatalyzedLemergiumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedLemergiumAcid);
        public static double CatalyzedLemergiumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedLemergiumAlkalide);

        public static double CatalyzedZynthiumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedZynthiumAcid);
        public static double CatalyzedZynthiumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedZynthiumAlkalide);

        public static double CatalyzedGhodiumAcid = GetCreditCost(CompoundMineralsNeeded.CatalyzedGhodiumAcid);
        public static double CatalyzedGhodiumAlkalide = GetCreditCost(CompoundMineralsNeeded.CatalyzedGhodiumAlkalide);
    }
}
