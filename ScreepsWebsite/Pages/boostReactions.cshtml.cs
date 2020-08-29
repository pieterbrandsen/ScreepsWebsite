using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScreepsWebsite.Models;

namespace ScreepsWebsite.Pages
{
    public class BoostReactionsModel : PageModel
    {
        private readonly static string[] H = { MineralNames.Hydrogen, MineralPrices.Hydrogen.ToString() };
        private readonly static string[] O = { MineralNames.Oxygen, MineralPrices.Oxygen.ToString() };
        private readonly static string[] U = { MineralNames.Utrium, MineralPrices.Utrium.ToString() };
        private readonly static string[] K = { MineralNames.Keanium, MineralPrices.Keanium.ToString() };
        private readonly static string[] L = { MineralNames.Lemergium, MineralPrices.Lemergium.ToString() };
        private readonly static string[] Z = { MineralNames.Zynthium, MineralPrices.Zynthium.ToString() };
        private readonly static string[] X = { MineralNames.Catalyst, MineralPrices.Catalyst.ToString() };

        public Object[] Minerals = { H, O, U, K, L, Z, X };


        public void OnGet()
        {
        }
    }
}
