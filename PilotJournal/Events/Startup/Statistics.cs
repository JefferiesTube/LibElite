using System;
using LibElite.PilotJournal.Converter;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("Statistics")]
    public class Statistics : EventBase
    {
        public StatisticsBankAccount Bank_Account { get; set; }
        public StatisticsCombat Combat { get; set; }
        public StatisticsCrime Crime{ get; set; }
        public StatisticsSmuggling Smuggling { get; set; }
        public StatisticsTrading Trading { get; set; }
        public StatisticsMining Mining { get; set; }
        public StatisticsExploration Exploration { get; set; }
        public StatisticsPassengers Passengers { get; set; }
        [J("Search_And_Rescue")] public StatisticsSearchAndRescue SearchAndRescue { get; set; }
        public StatisticsCrafting Crafting { get; set; }
        public StatisticsCrew Crew { get; set; }
        public StatisticsMulticrew Multicrew { get; set; }
        [J("Material_Trader_Stats")] public MaterialTraderStatistics MaterialTrader { get; set; }
        public StatisticsCQC CQC { get; set; }

        [J("TG_ENCOUNTERS")] public ThargoidEncounters ThargoidEncounters { get; set; }
        [J("FLEETCARRIER")] public Fleetcarrier Fleetcarrier { get; set; }
    }

    public class MaterialTraderStatistics
    {
        [J("Trades_Completed")] public int TradesCompleted { get; set; }
        [J("Materials_Traded")] public int MaterialsTraded { get; set; }
        [J("Encoded_Materials_Traded")] public int EncodedMaterialsTraded { get; set; }
        [J("Raw_Materials_Traded")] public int RawMaterialsTraded { get; set; }
        [J("Grade_1_Materials_Traded")] public int Grade1MaterialsTraded { get; set; }
        [J("Grade_2_Materials_Traded")] public int Grade2MaterialsTraded { get; set; }
        [J("Grade_3_Materials_Traded")] public int Grade3MaterialsTraded { get; set; }
        [J("Grade_4_Materials_Traded")] public int Grade4MaterialsTraded { get; set; }
        [J("Grade_5_Materials_Traded")] public int Grade5MaterialsTraded { get; set; }
    }

    public class StatisticsBankAccount
    {
        [J("Current_Wealth")] public long CurrentWealth { get; set; }
        [J("Spent_On_Ships")] public long SpentOnShips { get; set; }
        [J("Spent_On_Outfitting")] public long SpentOnOutfitting { get; set; }
        [J("Spent_On_Repairs")] public long SpentOnRepairs { get; set; }
        [J("Spent_On_Fuel")] public long SpentOnFuel { get; set; }
        [J("Spent_On_Ammo_Consumables")] public long SpentOnAmmoConsumables { get; set; }
        [J("Insurance_Claims")] public long InsuranceClaims { get; set; }
        [J("Spent_On_Insurance")] public long SpentOnInsurance { get; set; }
        [J("Owned_Ship_Count")] public int OwnedShipCount { get; set; }
    }

    public class StatisticsCombat
    {
        [J("Bounties_Claimed")] public long BountiesClaimed { get; set; }
        [J("Bounty_Hunting_Profit")] public long BountyHuntingProfit { get; set; }
        [J("Combat_Bonds")] public long CombatBonds { get; set; }
        [J("Combat_Bond_Profits")] public long CombatBondProfits { get; set; }
        public long Assassinations { get; set; }
        [J("Assassination_Profits")] public long AssassinationProfits { get; set; }
        [J("Highest_Single_Reward")] public long HighestSingleReward { get; set; }
        [J("Skimmers_Killed")] public long SkimmersKilled { get; set; }
    }

    public class StatisticsCrime
    {
        public long Fines { get; set; }
        public int Notoriety { get; set; }
        [J("Total_Fines")] public long TotalFines { get; set; }
        [J("Bounties_Received")] public int BountiesReceived { get; set; }
        [J("Total_Bounties")] public int TotalBounties { get; set; }
        [J("Highest_Bounty")] public long HighestBounty { get; set; }
    }

    public class StatisticsSmuggling
    {
        [J("Black_Markets_Traded_With")] public int BlackMarketsTradedWith { get; set; }
        [J("Black_Markets_Profits")] public long BlackMarketsProfits { get; set; }
        [J("Resources_Smuggled")] public long ResourcesSmuggled { get; set; }
        [J("Average_Profit")] public long AverageProfit { get; set; }
        [J("Highest_Single_Transaction")] public long HighestSingleTransaction { get; set; }
    }

    public class StatisticsTrading
    {
        [J("Markets_Traded_With")] public int MarketsTradedWith { get; set; }
        [J("Market_Profits")] public long MarketProfits { get; set; }
        [J("Resources_Traded")] public int ResourcesTraded { get; set; }
        [J("Average_Profit")] public long AverageProfit { get; set; }
        [J("Highest_Single_Transaction")] public long HighestSingleTransaction { get; set; }
    }

    public class StatisticsMining
    {
        [J("Mining_Profits")] public long MiningProfits { get; set; }
        [J("Quantity_Mined")] public int QuantityMined { get; set; }
        [J("Materials_Collected")] public int MaterialsCollected { get; set; }
    }

    public class StatisticsExploration
    {
        [J("Systems_Visited")] public int SystemsVisited { get; set; }
        [J("Fuel_Scooped")] public int FuelScooped { get; set; }
        [J("Fuel_Purchased")] public int FuelPurchased { get; set; }
        [J("Exploration_Profits")] public long ExplorationProfits { get; set; }
        [J("Planets_Scanned_To_Level_2")] public int PlanetsScannedToLevel2 { get; set; }
        [J("Planets_Scanned_To_Level_3")] public int PlanetsScannedToLevel3 { get; set; }
        [J("Highest_Payout")] public long Highest_Payout { get; set; }
        [J("Total_Hyperspace_Distance")] public long TotalHyperspaceDistance { get; set; }
        [J("Total_Hyperspace_Jumps")] public int TotalHyperspaceJumps { get; set; }
        [J("Greatest_Distance_From_Start")] public double GreatestDistanceFromStart { get; set; }
        [J("Time_Played")] public long TimePlayed { get; set; }
        [J("Efficient_Scans")] public int EfficientScans { get; set; }
    }

    public class StatisticsPassengers
    {
        [J("Passengers_Missions_Bulk")] public int PassengersMissionsBulk { get; set; }

        [J("Passengers_Missions_VIP")] public int PassengersMissionsVIP { get; set; }
        [J("Passengers_Missions_Delivered")] public int PassengersMissionsDelivered { get; set; }
        [J("Passengers_Missions_Ejected")] public int PassengersMissionsEjected { get; set; }
        [J("Passengers_Missions_Accepted")] public int PassengersMissionsAccepted { get; set; }
        [J("Passengers_Missions_Disgruntled")] public int PassengerMissionsDisgruntled { get; set; }
    }

    public class StatisticsSearchAndRescue
    {
        [J("SearchRescue_Traded")] public int SearchRescueTraded { get; set; }

        [J("SearchRescue_Profit")] public long SearchRescueProfit { get; set; }
        [J("SearchRescue_Count")] public int SearchRescueCount { get; set; }
    }

    public class StatisticsCrafting
    {
        [J("Spent_On_Crafting")] public int SpentOnCrafting { get; set; }
        [J("Count_Of_Used_Engineers")] public int CountOfUsedEngineers { get; set; }
        [J("Recipes_Generated")] public int RecipesGenerated { get; set; }
        [J("Recipes_Generated_Rank_1")] public int RecipesGeneratedRank1 { get; set; }
        [J("Recipes_Generated_Rank_2")] public int RecipesGeneratedRank2 { get; set; }
        [J("Recipes_Generated_Rank_3")] public int RecipesGeneratedRank3 { get; set; }
        [J("Recipes_Generated_Rank_4")] public int RecipesGeneratedRank4 { get; set; }
        [J("Recipes_Generated_Rank_5")] public int RecipesGeneratedRank5 { get; set; }
        [J("Recipes_Applied")] public int RecipesApplied { get; set; }
        [J("Recipes_Applied_Rank_1")] public int RecipesAppliedRank1 { get; set; }
        [J("Recipes_Applied_Rank_2")] public int RecipesAppliedRank2 { get; set; }
        [J("Recipes_Applied_Rank_3")] public int RecipesAppliedRank3 { get; set; }
        [J("Recipes_Applied_Rank_4")] public int RecipesAppliedRank4 { get; set; }
        [J("Recipes_Applied_Rank_5")] public int RecipesAppliedRank5 { get; set; }
        [J("Recipes_Applied_On_Previously_Modified_Modules")] public int RecipesAppliedOnPreviouslyModifiedModules { get; set; }
    }

    public class StatisticsCrew
    {
        [J("NpcCrew_TotalWages")] public long NpcCrewTotalWages { get; set; }
        [J("NpcCrew_Hired")] public long NpcCrewHired { get; set; }
        [J("NpcCrew_Fired")] public long NpcCrewFired { get; set; }
        [J("NpcCrew_Died")] public long NpcCrewDied { get; set; }
    }

    public class StatisticsMulticrew
    {
        [J("Multicrew_Time_Total")] public long MulticrewTimeTotal { get; set; }
        [J("Multicrew_Gunner_Time_Total")] public long MulticrewGunnerTimeTotal { get; set; }
        [J("Multicrew_Fighter_Time_Total")] public long MulticrewFighterTimeTotal { get; set; }
        [J("Multicrew_Credits_Total")] public long MulticrewCreditsTotal { get; set; }
        [J("Multicrew_Fines_Total")] public long MulticrewFinesTotal { get; set; }
    }

    public class StatisticsCQC
    {
        [J("CQC_Time_Played")] public long TimePlayed { get; set; }
        [J("CQC_KD")] public double KD { get; set; }
        [J("CQC_Kills")] public int Kills { get; set; }
        [J("CQC_WL")] public double WL { get; set; }
    }

    public class ThargoidEncounters
    {
        [J("TG_ENCOUNTER_TOTAL")] public int TotalEncounters { get; set; }
        [J("TG_ENCOUNTER_TOTAL_LAST_SYSTEM")] public string LastEncounteredSystem { get; set; }
        [J("TG_ENCOUNTER_TOTAL_LAST_TIMESTAMP")] public DateTime LastEncounterTimestamp { get; set; }
        [J("TG_ENCOUNTER_TOTAL_LAST_SHIP")] public string EncounterLastShip { get; set; }
        [J("TG_SCOUT_COUNT")] public int EncounteredScouts { get; set; }
    }

    public class Fleetcarrier
    {
        [J("FLEETCARRIER_EXPORT_TOTAL")] public long ExportTotal { get; set; }
        [J("FLEETCARRIER_IMPORT_TOTAL")] public long ImportTotal { get; set; }
        [J("FLEETCARRIER_TRADEPROFIT_TOTAL")] public long TotalTradeProfit{ get; set; }
        [J("FLEETCARRIER_TRADESPEND_TOTAL")] public long TotalTradeSpend { get; set; }
        [J("FLEETCARRIER_STOLENPROFIT_TOTAL")] public long TotalStolenProfit { get; set; }
        [J("FLEETCARRIER_STOLENSPEND_TOTAL")] public long TotalStolenSpend { get; set; }
        [J("FLEETCARRIER_DISTANCE_TRAVELLED")] public string DistanceTravelled { get; set; }
        [J("FLEETCARRIER_TOTAL_JUMPS")] public long TotalJumps { get; set; }
        [J("FLEETCARRIER_SHIPYARD_SOLD")] public long ShipyardSold { get; set; }
        [J("FLEETCARRIER_SHIPYARD_PROFIT")] public long ShipyardProfit { get; set; }
        [J("FLEETCARRIER_OUTFITTING_SOLD")] public long OutfittingSold { get; set; }
        [J("FLEETCARRIER_OUTFITTING_PROFIT")] public long OutfittingProfit { get; set; }
        [J("FLEETCARRIER_REARM_TOTAL")] public long RearmTotal { get; set; }
        [J("FLEETCARRIER_REFUEL_TOTAL")] public long RefuelTotal { get; set; }
        [J("FLEETCARRIER_REFUEL_PROFIT")] public long RefuelProfit { get; set; }
        [J("FLEETCARRIER_REPAIRS_TOTAL")] public long RepairsTotal { get; set; }
        [J("FLEETCARRIER_VOUCHERS_REDEEMED")] public long VouchersRedeemed { get; set; }
        [J("FLEETCARRIER_VOUCHERS_PROFIT")] public long VouchersProfit { get; set; }

    }
}