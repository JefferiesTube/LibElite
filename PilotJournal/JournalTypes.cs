namespace LibElite.PilotJournal
{
    public enum FriendStatus { Requested, Declined, Added, Lost, Offline, Online }

    public enum Vessel { Ship, SRV }

    public enum GameMode { Open, Solo, Group }

    public enum StationService
    {
        Dock, Autodock, BlackMarket, Commodities, Contacts, Exploration, Initiatives, Missions,
        Outfitting, CrewLounge, Rearm, Refuel, Repair, Shipyard, Tuning, Workshop, MissionsGenerated,
        Facilitator, Research, FlightController, StationOperations, OnDockMission, Powerplay,
        SearchAndRescue, MaterialTrader, TechBroker, StationMenu, Shop, CarrierManagement, CarrierFuel,
        CarrierVendor, Livery, ModulePacks, VoucherRedemption, Engineer, SearchRescue, SocialSpace, 
        Bartender, VistaGenomics, PioneerSupplies, ApexInterstellar, FrontlineSolutions
    }

    public enum StationType
    {
        PlanetaryOutpost, PlanetarySettlement, CivilianOutpost, MiningOutpost, OrbisStarport, PlanetaryPort, CoriolisStarport, IndustrialOutpost,
        OcellusStarport, MilitaryOutpost, CommercialOutpost, NonDockableOrbital, Megaship, ScientificOutpost, AsteroidBase,
        FleetCarrier, UnknownDockable, Coriolis, Orbis, Bernal, CraterOutpost, OnFootSettlement, Outpost,
        Unknown
    };

    public enum DockingDenialReason
    {
        NoSpace, TooLarge, Hostile, Offences, Distance, ActiveFighter, NoReason, RestrictedAccess, JumpImminent
    }

    public enum PowerplayState { InPrepareRadius, Prepared, Exploited, Contested, Controlled, Turmoil, HomeSystem }

    public enum JumpType { Hyperspace, Supercruise }

    public enum ReserveLevel { PristineResources, MajorResources, CommonResources, LowResources, DepletedResources }

    public enum MaterialCategory { Raw, Encoded, Manufactured }

    public enum CargoDepotUpdateType { Collect, Deliver, WingUpdate }

    public enum EngineerContributionType { Commodity, Materials, Credits, Bond, Bounty }

    public enum EngineerProgressStage { Invited, Known, Acquainted, Unlocked, Barred }

    public enum VoucherType { CombatBond, Bounty, Trade, Settlement, Scannable, Codex }

    public enum CrewRole { Idle, FireCon, FighterCon }

    public enum Crime
    {
        Assault, Murder, Piracy, Interdiction, IllegalCargo, DisobeyPolice, FireInNoFireZone, FireInStation, DumpingDangerous,
        dumpingNearStation, dockingMinorBlockingAirlock, dockingMajorBlockingAirlock, dockingMinorBlockingLandingPad, dockingMajorBlockingLandingPad,
        dockingMinorTresspass, dockingMajorTresspass, collidedAtSpeedInNoFireZone, CollidedAtSpeedInNoFireZone_HullDamage,
        passengerWanted, recklessWeaponsDischarge, OnFoot_Murder, OnFoot_DamagingDefences, OnFoot_IdentityTheft,
        OnFoot_RecklessEndangerment, OnFoot_Trespass
    }

    public enum DroneType { Hatchbreaker, FuelTransfer, Collection, Prospector, Repair, Research, Decontamination }

    public enum MessageChannel { Wing, Local, VoiceChat, Friend, Player, NPC, Squadron, StarSystem }

    public enum ScanType { Cargo, Crime, Cabin, Data, Unknown }

    public enum VehicleSwitchTarget { Mothership, Fighter }

    public enum LegalState { Clean, IllegalCargo, Speeding, Wanted, Hostile, PassengerWanted, Warrant }

    public enum CombatRank { Harmless = 0, MostlyHarmless = 1, Novice = 2, Competent = 3, Expert = 4, Master = 5, Dangerous = 6, Deadly = 7, Elite = 8 }

    public enum DockingAccess { All, None, Friends, Squadron, SquadronFriends }

    public enum CarrierCrewOperation { Activate, Deactivate, Pause, Resume, Replace }

    public enum LandingPadSize { None, S, M, L }

    public enum PowerState { Control, Exploited, Contested, Expansion };

    public enum ReserveType { Common, Depleted, Low, Major, Pristine };

    public enum Security { Anarchy, High, Low, Medium };

    public enum Efficiency { A, B, C, D, E, F, G, H, I };

    public enum WeaponMode { Fixed, Gimbal, Turret };

    public enum Allegiance
    {
        Alliance, Empire, Federation, Independent,
        PilotsFederation,
        None,
        Guardian, Thargoid
    };

    public enum SystemState
    {
        Blight, Boom, Bust, CivilLiberty, CivilUnrest, CivilWar, Drought, Election, Expansion, InfrastructureFailure, Lockdown, None, Outbreak, PirateAttack, PublicHoliday, War,
        TerroristAttack,
        NaturalDisaster,
        Retreat,
        Famine,
        Investment,
        UnderRepairs,
        Damaged
    };
}