using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScreepsWebsite.Models;

namespace ScreepsWebsite.Pages
{
    public class RemoteRoomCalculatorModel : PageModel
    {
        public bool inputHasData = false;
        public bool optimalHasData = false;

        // Room Information //
        public string isRoomReserverd;
        public int sourceAmount = 2;
        public int averageRange;


        // Input Performance Variables //
        public double inputEnergyEachTick;
        
        // Energy Cost //
        public int inputTransfererCost;
        public int inputHarvesterCost;
        public int inputReserverCost;

        // Creep Information //
        public int inputTransfererCarryCount;
        public int inputHarvesterWorkCount;
        public int inputReserverClaimCount;

        // Optimal Data //
        public int[] inputTransfererBody = { 0, 0 };
        public int[] inputHarvesterBody = { 0, 0, 0 };
        public int[] inputReserverBody = { 0, 0 };

        public double inputTotalCreepCostEachTick;
        public double inputTransfererCreepCostEachTick;
        public double inputHarvesterCreepsCostEachTick;
        public double inputReserverCreepCostEachTick;


        // Optimal Performance Variables //
        public double optimalEnergyEachTick;
       
        // Energy Cost //
        public int optimalTransfererCost;
        public int optimalHarvesterCost;
        public int optimalReserverCost;

        // Creep Information //
        public int optimalTransfererCarryCount;
        public int optimalHarvesterWorkCount;
        public int optimalReserverClaimCount;

        // Optimal Data //
        public int[] optimalTransfererBody = { 0,0 };
        public int[] optimalHarvesterBody = { 0, 0, 0 };
        public int[] optimalReserverBody = { 0, 0 };

        public double optimalTotalCreepCostEachTick;
        public double optimalTransfererCreepCostEachTick; 
        public double optimalHarvesterCreepsCostEachTick;
        public double optimalReserverCreepCostEachTick;


        public int GetData()
        {
            string queryString = HttpContext.Request.QueryString.ToString();

            if (queryString.Length > 0)
            {
                bool result;
                int integer;

                // Room Information //
                isRoomReserverd = HttpUtility.ParseQueryString(queryString).Get("isRoomReserved");

                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("sourceAmount"), out integer);
                if (result)
                {
                    sourceAmount = integer;
                }

                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("averageRange"), out integer);
                if (result)
                {
                    averageRange = integer;
                }


                // Energy Cost //
                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("transfererCost"), out integer);
                if (result)
                {
                    inputTransfererCost = integer;
                }

                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("harvesterCost"), out integer);
                if (result)
                {
                    inputHarvesterCost = integer;
                }

                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("reserverCost"), out integer);
                if (result)
                {
                    inputReserverCost = integer;
                }


                // Creep Body Information //
                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("transfererCarryCount"), out integer);
                if (result)
                {
                    inputTransfererCarryCount = integer;
                }

                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("harvesterWorkCount"), out integer);
                if (result)
                {
                    inputHarvesterWorkCount = integer;
                }

                result = Int32.TryParse(HttpUtility.ParseQueryString(queryString).Get("reserverClaimCount"), out integer);
                if (result)
                {
                    inputReserverClaimCount = integer;
                }
            }

            ProcessData();
            return 0;
        }

        void ProcessData()
        {
            if (sourceAmount > 0 && averageRange > 0)
            {
                inputEnergyEachTick = sourceAmount * 10;
                if (isRoomReserverd == "on")
                {
                    inputEnergyEachTick = inputEnergyEachTick / 2;
                }


                if (inputHarvesterWorkCount > 0)
                {
                    inputHasData = true;

                    int inputTransfererEnergyEachTickCap = inputTransfererCarryCount * 50 / averageRange;
                    if (inputEnergyEachTick > inputTransfererEnergyEachTickCap)
                    {
                        inputEnergyEachTick = inputTransfererEnergyEachTickCap;
                    }

                    // input Creep Body //
                    inputTransfererBody[0] = inputTransfererCarryCount;
                    inputHarvesterBody[0] = inputHarvesterWorkCount;
                    inputReserverBody[0] = inputReserverClaimCount;

                    // Input Room Income //
                    inputTransfererCreepCostEachTick = Math.Round((double)(inputTransfererCost) / 1500, 2);
                    inputHarvesterCreepsCostEachTick = Math.Round((double)(inputHarvesterCost) * sourceAmount / 1500, 2);
                    inputReserverCreepCostEachTick = Math.Round((double)(inputReserverCost) / 600, 2);
                    inputTotalCreepCostEachTick = inputTransfererCreepCostEachTick + inputHarvesterCreepsCostEachTick + inputReserverCreepCostEachTick;
                }



                optimalHasData = true;

                optimalEnergyEachTick = sourceAmount * 10;
                if (isRoomReserverd == null)
                {
                    optimalEnergyEachTick = optimalEnergyEachTick / 2;
                }


                // Optimal Creep Body //
                optimalTransfererBody[0] = Convert.ToInt32(Math.Ceiling(optimalEnergyEachTick * averageRange * 2 / 50));
                optimalTransfererBody[1] = optimalTransfererBody[0];
                optimalHarvesterBody[0] = (int)Math.Ceiling(optimalEnergyEachTick * 1.2 / 2);
                optimalHarvesterBody[1] = optimalHarvesterBody[0] / 2;
                optimalHarvesterBody[2] = 1;
                if (isRoomReserverd == "on")
                {
                    optimalReserverBody[0] = 1;
                    optimalReserverBody[1] = 1;
                }

                // Optimal Room Expense //
                optimalTransfererCreepCostEachTick = Math.Round((double)(optimalTransfererBody[0] * CreepPartsCost.CARRY + optimalTransfererBody[1] * CreepPartsCost.MOVE) / 1500,2);
                optimalHarvesterCreepsCostEachTick = Math.Round((double)(optimalHarvesterBody[0] * CreepPartsCost.WORK + optimalHarvesterBody[1] * CreepPartsCost.MOVE + optimalHarvesterBody[2] * CreepPartsCost.CARRY) * sourceAmount / 1500,2); 
                optimalReserverCreepCostEachTick = Math.Round((double)(optimalReserverBody[0] * CreepPartsCost.CLAIM + optimalReserverBody[1] * CreepPartsCost.MOVE) / 600,2);
                optimalTotalCreepCostEachTick = optimalTransfererCreepCostEachTick + optimalHarvesterCreepsCostEachTick + optimalReserverCreepCostEachTick;
            }
        }
    }
}
