using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScreepsWebsite.Models;

namespace ScreepsWebsite.Pages
{
    public class boostReactionsModel : PageModel
    {
        private static string[] H = { MineralNames.Hydrogen, MineralPrices.Hydrogen.ToString() };
        private static string[] O = { MineralNames.Oxygen, MineralPrices.Oxygen.ToString() };
        private static string[] U = { MineralNames.Utrium, MineralPrices.Utrium.ToString() };
        private static string[] K = { MineralNames.Keanium, MineralPrices.Keanium.ToString() };
        private static string[] L = { MineralNames.Lemergium, MineralPrices.Lemergium.ToString() };
        private static string[] Z = { MineralNames.Zynthium, MineralPrices.Zynthium.ToString() };
        private static string[] X = { MineralNames.Catalyst, MineralPrices.Catalyst.ToString() };

        public Object[] Minerals = { H, O, U, K, L, Z, X };

        public void OnGet()
        {
        }
    }
}
