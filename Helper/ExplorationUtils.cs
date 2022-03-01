using System;
using System.Linq;

namespace LibElite.Helper
{
    public enum ExplorationDataSellLikeliness { Possible, Likely, Unlikely, Impossible }

    public enum ThreatLevel { Low, Mid, High }

    public struct ScanResult
    {
        public long ValueScanned;
        public long ValueScannedAndDiscoveredFirst;
        public long ValueMapped;
        public long ValueMappedFirst;
        public long ValueMappedAndDiscoveredFirst;
        public long ValueMappedFirstAndDiscoveredFirst;
        public long ValueMappedEfficiently;
        public long ValueMappedFirstEfficiently;
        public long ValueMappedEfficientlyAndDiscoveredFirst;
        public long ValueMappedFirstEfficientlyAndDiscoveredFirst;
    }

    public static class ExplorationUtils
    {
        public const long BonusPerBodyForFullSystemScan = 1000;

        private static readonly string[] BlackHoles = { "Black Hole", "Supermassive Black Hole", "H" };

        private static readonly string[] WhiteDwarfs =
        {
            "D", "DA", "DAB", "DAO", "DAZ", "DAV", "DB", "DBZ", "DBV", "DO", "DOV", "DQ", "DC", "DCV", "DX",
            "White Dwarf (D) Star", "White Dwarf (DA) Star", "White Dwarf (DAB) Star", "White Dwarf (DAO) Star",
            "White Dwarf (DAZ) Star",
            "White Dwarf (DAV) Star", "White Dwarf (DB) Star", "White Dwarf (DBZ) Star", "White Dwarf (DBV) Star",
            "White Dwarf (DO) Star",
            "White Dwarf (DOV) Star", "White Dwarf (DQ) Star", "White Dwarf (DC) Star", "White Dwarf (DCV) Star",
            "White Dwarf (DX) Star"
        };

        public static readonly string[] NeutronStars = { "N", "Neutron Star" };

        public static ExplorationDataSellLikeliness SellLikelinessByPopulation(long population)
        {
            if (population == 0)
                return ExplorationDataSellLikeliness.Possible;
            if (population > 0 && population < 1_000_000)
                return ExplorationDataSellLikeliness.Likely;
            if (population >= 1_000_000)
                return ExplorationDataSellLikeliness.Unlikely;

            throw new ArgumentOutOfRangeException(nameof(population));
        }

        public static ThreatLevel GetSystemThreatLevel(long deathsDay, long deathsWeek)
        {
            switch (deathsDay)
            {
                case 0 when deathsWeek == 0:
                    return ThreatLevel.Low;

                case 0 when deathsWeek != 0:
                    return ThreatLevel.Mid;

                default:
                    return ThreatLevel.High;
            }
        }

        public static (long ValueScanned, long ValueMapped) GetStarValue(string starType, long mass)
        {
            (long ValueScanned, long ValueMapped) result = (0, 0);

            if (BlackHoles.Contains(starType) || NeutronStars.Contains(starType))
            {
                long value = (long)Math.Round(22628 + 22628 * mass / 66.25);

                result.ValueScanned += value;
                result.ValueMapped += value;
            }
            else if (WhiteDwarfs.Contains(starType))
            {
                long value = (long)Math.Round(14057 + 14057 * mass / 66.25);

                result.ValueScanned += value;
                result.ValueMapped += value;
            }
            else
            {
                long value = (long)Math.Round(1200 + 1200 * mass / 66.25);

                result.ValueScanned += value;
                result.ValueMapped += value;
            }

            return result;
        }

        public static int GetScanBaseValue(string planetClass, string terraformState)
        {
            int baseValue;
            bool terraformable = terraformState.Equals("Terraformable", StringComparison.InvariantCultureIgnoreCase);

            switch (planetClass)
            {
                case "Metal rich body":
                    baseValue = 21790;
                    break;

                case "Ammonia world":
                    baseValue = 96932;
                    break;

                case "Sudarsky class I gas giant":
                    baseValue = 1656;
                    break;

                case "Sudarsky class II gas giant":
                case "High metal content body":
                    baseValue = (terraformable) ? 100677 : 9654;
                    break;

                case "Water world":
                case "Earthlike body":
                    baseValue = (terraformable) ? 116295 : 64831;
                    break;

                case "Rocky body":
                    baseValue = (terraformable) ? 93328 : 300;
                    break;

                default:
                    baseValue = 300;
                    break;
            }

            return baseValue;
        }

        public static ScanResult EstimateBodyValue(int baseValue, double mass)
        {
            const double efficiencyBonus = 1.25;
            const double firstDiscoverBonus = 2.6;

            ScanResult result = new ScanResult();
            double creditsFormula = (baseValue + baseValue * 0.56591828 * Math.Pow(mass, 0.2));

            result.ValueScanned = (long)Math.Max(500, creditsFormula);
            result.ValueScannedAndDiscoveredFirst = (long)(result.ValueScanned * firstDiscoverBonus);

            result.ValueMapped = (long)Math.Max(500, creditsFormula * (1 / 3d));
            result.ValueMappedFirst = (long)Math.Max(500, creditsFormula * 8.0956);
            result.ValueMappedAndDiscoveredFirst = (long)(Math.Max(500, creditsFormula * (1 / 3d)) * firstDiscoverBonus);
            result.ValueMappedFirstAndDiscoveredFirst = (long)(Math.Max(500, creditsFormula * 3.699622554) * firstDiscoverBonus);

            result.ValueMappedEfficiently = (long)Math.Max(500, creditsFormula * (1 / 3d) * efficiencyBonus);
            result.ValueMappedFirstEfficiently = (long)Math.Max(500, creditsFormula * 8.0956 * efficiencyBonus);
            result.ValueMappedEfficientlyAndDiscoveredFirst = (long)(Math.Max(500, creditsFormula * (1 / 3d) * efficiencyBonus) * firstDiscoverBonus);
            result.ValueMappedFirstEfficientlyAndDiscoveredFirst = (long)(Math.Max(500, creditsFormula * 3.699622554 * efficiencyBonus) * firstDiscoverBonus);

            return result;
        }
    }
}