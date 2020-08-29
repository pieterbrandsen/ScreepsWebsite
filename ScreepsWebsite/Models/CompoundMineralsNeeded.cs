using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreepsWebsite.Models;

namespace ScreepsWebsite.Models
{
    public class CompoundMineralsNeeded
    {
        public static object[] AddMineralRaw(string mineralType0, string mineralType1)
        {
            string[] H = { MineralNames.Hydrogen, "0" };
            string[] O = { MineralNames.Oxygen, "0" };
            string[] U = { MineralNames.Utrium, "0" };
            string[] K = { MineralNames.Keanium, "0" };
            string[] L = { MineralNames.Lemergium, "0" };
            string[] Z = { MineralNames.Zynthium, "0" };
            string[] X = { MineralNames.Catalyst, "0" };

            object[] EmptyMineralList = { H, O, U, K, L, Z, X };


            foreach (string[] mineral in EmptyMineralList)
            {
                if (mineral[0] == mineralType0 || mineral[0] == mineralType1)
                {
                    int _mineralAmount = Convert.ToInt32(mineral[1]);
                    mineral[1] = (_mineralAmount += 1).ToString();
                }
            }

            return EmptyMineralList;
        }

        public static object[] AddMineralHalfRaw(object[] compound0, string mineralType1)
        {
            foreach (string[] mineral in compound0)
            {
                if (mineral[0] == mineralType1)
                {
                    int _mineralAmount = Convert.ToInt32(mineral[1]);
                    mineral[1] = (_mineralAmount += 1).ToString();
                }
            }

            return compound0;
        }

        public static object[] AddMineral(object[] compound0, object[] compound1)
        {
            for (int i = 0; i < compound0.Length; i++)
            {
                string[] _compound0 = (string[])compound0[i];
                string[] _compound1 = (string[])compound1[i];

                int mineralAmount = Convert.ToInt32(_compound0[1]) + Convert.ToInt32(_compound1[1]);

                _compound0[1] = mineralAmount.ToString();
            }

            return compound0;
        }

        public static object[] Hydroxide = AddMineralRaw(MineralNames.Hydrogen, MineralNames.Oxygen);
        public static object[] ZynthiumKeanite = AddMineralRaw(MineralNames.Zynthium, MineralNames.Keanium);
        public static object[] UtriumLemergite = AddMineralRaw(MineralNames.Utrium, MineralNames.Lemergium);
        public static object[] Ghodium = AddMineral(Hydroxide, UtriumLemergite);


        // Tier 1 Compounds //
        public static object[] UtriumHydride = AddMineralRaw(MineralNames.Utrium, MineralNames.Hydrogen);
        public static object[] UtriumOxide = AddMineralRaw(MineralNames.Utrium, MineralNames.Oxygen);

        public static object[] KeaniumHydride = AddMineralRaw(MineralNames.Keanium, MineralNames.Hydrogen);
        public static object[] KeaniumOxide = AddMineralRaw(MineralNames.Keanium, MineralNames.Oxygen);

        public static object[] LemergiumHydride = AddMineralRaw(MineralNames.Lemergium, MineralNames.Hydrogen);
        public static object[] LemergiumOxide = AddMineralRaw(MineralNames.Lemergium, MineralNames.Oxygen);

        public static object[] ZynthiumHydride = AddMineralRaw(MineralNames.Zynthium, MineralNames.Hydrogen);
        public static object[] ZynthiumOxide = AddMineralRaw(MineralNames.Zynthium, MineralNames.Oxygen);

        public static object[] GhodiumHydride = AddMineralHalfRaw(Ghodium, MineralNames.Hydrogen);
        public static object[] GhodiumOxide = AddMineralHalfRaw(Ghodium, MineralNames.Oxygen);


        // Tier 2 Compounds //
        public static object[] UtriumAcid = AddMineral(UtriumHydride, Hydroxide);
        public static object[] UtriumAlkalide = AddMineral(UtriumOxide, Hydroxide);

        public static object[] KeaniumAcid = AddMineral(KeaniumHydride, Hydroxide);
        public static object[] KeaniumAlkalide = AddMineral(KeaniumOxide, Hydroxide);

        public static object[] LemergiumAcid = AddMineral(LemergiumHydride, Hydroxide);
        public static object[] LemergiumAlkalide = AddMineral(LemergiumOxide, Hydroxide);

        public static object[] ZynthiumAcid = AddMineral(ZynthiumHydride, Hydroxide);
        public static object[] ZynthiumAlkalide = AddMineral(ZynthiumOxide, Hydroxide);

        public static object[] GhodiumAcid = AddMineral(GhodiumHydride, Hydroxide);
        public static object[] GhodiumAlkalide = AddMineral(GhodiumOxide, Hydroxide);


        // Tier 3 Compounds //
        public static object[] CatalyzedUtriumAcid = AddMineralHalfRaw(UtriumAcid, MineralNames.Catalyst);
        public static object[] CatalyzedUtriumAlkalide = AddMineralHalfRaw(UtriumAlkalide, MineralNames.Catalyst);

        public static object[] CatalyzedKeaniumAcid = AddMineralHalfRaw(KeaniumAcid, MineralNames.Catalyst);
        public static object[] CatalyzedKeaniumAlkalide = AddMineralHalfRaw(KeaniumAlkalide, MineralNames.Catalyst);

        public static object[] CatalyzedLemergiumAcid = AddMineralHalfRaw(LemergiumAcid, MineralNames.Catalyst);
        public static object[] CatalyzedLemergiumAlkalide = AddMineralHalfRaw(LemergiumAlkalide, MineralNames.Catalyst);

        public static object[] CatalyzedZynthiumAcid = AddMineralHalfRaw(ZynthiumAcid, MineralNames.Catalyst);
        public static object[] CatalyzedZynthiumAlkalide = AddMineralHalfRaw(ZynthiumAlkalide, MineralNames.Catalyst);

        public static object[] CatalyzedGhodiumAcid = AddMineralHalfRaw(GhodiumAcid, MineralNames.Catalyst);
        public static object[] CatalyzedGhodiumAlkalide = AddMineralHalfRaw(GhodiumAlkalide, MineralNames.Catalyst);
    }
}
