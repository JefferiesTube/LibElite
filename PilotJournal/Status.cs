using System;
using System.Linq;
using LibElite.PilotJournal.Converter;
using LibElite.PilotJournal.Events;

namespace LibElite.PilotJournal
{
    [EventType("Status")]
    public class Status : EventBase
    {
        public static Status LastStatus { get; private set; }

        public int Flags { get; set; }
        public int Flags2 { get; set; }
        public byte[] Pips { get; set; }
        public byte Firegroup { get; set; }
        public byte GuiFocus { get; set; }
        public FuelState Fuel { get; set; }
        public double Cargo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Altitude { get; set; }
        public int Heading { get; set; }
        public string BodyName { get; set; }
        public double PlanetRadius { get; set; }
        public LegalState LegalState { get; set; }
        public bool Docked => FlagSet(0);
        public bool Landed => FlagSet(1);
        public bool LandingGearDown => FlagSet(2);
        public bool ShieldsUp => FlagSet(3);
        public bool Supercruise => FlagSet(4);
        public bool FlightAssistOff => FlagSet(5);
        public bool HardpointsDeployed => FlagSet(6);
        public bool InWing => FlagSet(7);
        public bool LightsOn => FlagSet(8);
        public bool CargoScoopDeployed => FlagSet(9);
        public bool SilentRunning => FlagSet(10);
        public bool ScoopingFuel => FlagSet(11);
        public bool SrvHandbrake => FlagSet(12);
        public bool SrvTurret => FlagSet(13);
        public bool SrvUnderShip => FlagSet(14);
        public bool SrvDriveAssist => FlagSet(15);
        public bool FsdMassLocked => FlagSet(16);
        public bool FsdCharging => FlagSet(17);
        public bool FsdCooldown => FlagSet(18);
        public bool LowFuel => FlagSet(19);
        public bool Overheating => FlagSet(20);
        public bool HasLatLong => FlagSet(21);
        public bool IsInDanger => FlagSet(22);
        public bool BeingInterdicted => FlagSet(23);
        public bool InMainShip => FlagSet(24);
        public bool InFighter => FlagSet(25);
        public bool InSRV => FlagSet(26);
        public bool HudInAnalysisMode => FlagSet(27);
        public bool NightVision => FlagSet(28);
        public bool AltitudeFromAverageRadius => FlagSet(29);
        public bool OnFoot => Flag2Set(0);
        public bool InTaxi => Flag2Set(1);
        public bool InOtherShip => Flag2Set(2);
        public bool OnFootInStation => Flag2Set(3);
        public bool OnFootOnPlanet => Flag2Set(4);
        public bool AimDownSight => Flag2Set(5);
        public bool LowOxygen => Flag2Set(6);
        public bool LowHealth => Flag2Set(7);
        public bool Cold => Flag2Set(8);
        public bool Hot => Flag2Set(9);
        public bool VeryCold => Flag2Set(10);
        public bool VeryHot => Flag2Set(11);
        public bool GlideMode => Flag2Set(12);
        public bool OnFootInHangar => Flag2Set(13);
        public bool OnFootInSocialSpace => Flag2Set(14);
        public bool OnFootExterior => Flag2Set(15);
        public bool BreathableAtmosphere => Flag2Set(16);

        public void Process(JournalNotifications notifications)
        {
            if (LastStatus == null)
            {
                LastStatus = this;
            }

            if (Pips != null && LastStatus.Pips != null && !Pips.SequenceEqual(LastStatus.Pips))
            {
                 notifications.OnPipsChanged?.Invoke((systems: Pips[0], engine: Pips[1], weapons: Pips[2]));
            }
            CheckNotification(Firegroup, LastStatus.Firegroup, notifications.OnFiregroupChanged);
            CheckNotification(GuiFocus, LastStatus.GuiFocus, notifications.OnGUIFocusChanged);
            CheckNotification(Latitude, LastStatus.Latitude, notifications.OnLatitudeChanged);
            CheckNotification(Longitude, LastStatus.Longitude, notifications.OnLongitudeChanged);
            CheckNotification(Altitude, LastStatus.Altitude, notifications.OnAltitudeChanged);
            CheckNotification(Heading, LastStatus.Heading, notifications.OnHeadingChanged);
            CheckNotification(Docked, LastStatus.Docked, notifications.OnDockingChanged);
            CheckNotification(Landed, LastStatus.Landed, notifications.OnLandedChanged);
            CheckNotification(LandingGearDown, LastStatus.LandingGearDown, notifications.OnGearChanged);
            CheckNotification(ShieldsUp, LastStatus.ShieldsUp, notifications.OnShieldsChanged);
            CheckNotification(Supercruise, LastStatus.Supercruise, notifications.OnSupercruiseChanged);
            CheckNotification(FlightAssistOff, LastStatus.FlightAssistOff, notifications.OnFlightAssistChanged);
            CheckNotification(HardpointsDeployed, LastStatus.HardpointsDeployed, notifications.OnHardpointsChanged);
            CheckNotification(InWing, LastStatus.InWing, notifications.OnInWingChanged);
            CheckNotification(LightsOn, LastStatus.LightsOn, notifications.OnLightsChanged);
            CheckNotification(CargoScoopDeployed, LastStatus.CargoScoopDeployed, notifications.OnCargoScoopChanged);
            CheckNotification(SilentRunning, LastStatus.SilentRunning, notifications.OnSilentRunningChanged);
            CheckNotification(ScoopingFuel, LastStatus.ScoopingFuel, notifications.OnFuelScoopingChanged);
            CheckNotification(SrvHandbrake, LastStatus.SrvHandbrake, notifications.OnSrvHandbrakeChanged);
            CheckNotification(SrvTurret, LastStatus.SrvTurret, notifications.OnSrvTurretChanged);
            CheckNotification(SrvUnderShip, LastStatus.SrvUnderShip, notifications.OnSrvUnderShipChanged);
            CheckNotification(SrvDriveAssist, LastStatus.SrvDriveAssist, notifications.OnSrvDriveAssistChanged);
            CheckNotification(FsdMassLocked, LastStatus.FsdMassLocked, notifications.OnFsdMasslockChanged);
            CheckNotification(FsdCharging, LastStatus.FsdCharging, notifications.OnFsdChargingChanged);
            CheckNotification(FsdCooldown, LastStatus.FsdCooldown, notifications.OnFsdCooldownChanged);
            CheckNotification(LowFuel, LastStatus.LowFuel, notifications.OnLowFuelChanged);
            CheckNotification(Overheating, LastStatus.Overheating, notifications.OnOverheatingChanged);
            CheckNotification(HasLatLong, LastStatus.HasLatLong, notifications.OnHasLatLongChanged);
            CheckNotification(IsInDanger, LastStatus.IsInDanger, notifications.OnIsInDangerChanged);
            CheckNotification(BeingInterdicted, LastStatus.BeingInterdicted, notifications.OnBeingInterdictedChanged);
            CheckNotification(InMainShip, LastStatus.InMainShip, notifications.OnInMainShipChanged);
            CheckNotification(InFighter, LastStatus.InFighter, notifications.OnInFighterChanged);
            CheckNotification(InSRV, LastStatus.InSRV, notifications.OnInSRVChanged);
            CheckNotification(HudInAnalysisMode, LastStatus.HudInAnalysisMode, notifications.OnHudInAnalysisModeChanged);
            CheckNotification(NightVision, LastStatus.NightVision, notifications.OnNightVisionChanged);
            CheckNotification(AltitudeFromAverageRadius, LastStatus.AltitudeFromAverageRadius, notifications.OnAltitudeFromAverageRadiusChanged);

            CheckNotification(OnFoot, LastStatus.OnFoot, notifications.OnFootChanged);
            CheckNotification(InTaxi, LastStatus.InTaxi, notifications.OnInTaxisChanged);
            CheckNotification(InOtherShip, LastStatus.InOtherShip, notifications.OnInOtherShipChanged);
            CheckNotification(OnFootInStation, LastStatus.OnFootInStation, notifications.OnFootInStationChanged);
            CheckNotification(OnFootOnPlanet, LastStatus.OnFootOnPlanet, notifications.OnFootOnPlanetChanged);
            CheckNotification(AimDownSight, LastStatus.AimDownSight, notifications.OnAimDownSightChanged);
            CheckNotification(LowOxygen, LastStatus.LowOxygen, notifications.OnLowOxygenChanged);
            CheckNotification(LowHealth, LastStatus.LowHealth, notifications.OnLowHealthChanged);
            CheckNotification(Cold, LastStatus.Cold, notifications.OnColdChanged);
            CheckNotification(Hot, LastStatus.Hot, notifications.OnHotChanged);
            CheckNotification(VeryCold, LastStatus.VeryCold, notifications.OnVeryColdChanged);
            CheckNotification(VeryHot, LastStatus.VeryHot, notifications.OnVeryHotChanged);
            CheckNotification(GlideMode, LastStatus.GlideMode, notifications.OnGlideModeChanged);
            CheckNotification(OnFootInHangar, LastStatus.OnFootInHangar, notifications.OnFootInHangarChanged);
            CheckNotification(OnFootInSocialSpace, LastStatus.OnFootInSocialSpace, notifications.OnFootInSocialSpaceChanged);
            CheckNotification(OnFootExterior, LastStatus.OnFootExterior, notifications.OnFootExteriorChanged);
            CheckNotification(BreathableAtmosphere, LastStatus.BreathableAtmosphere, notifications.OnBreathableAtmosphereChanged);
            LastStatus = this;
        }

        private void CheckNotification<T>(T newValue, T oldValue, Action<T> notification)
        {
            notification?.Invoke(newValue);
        }

        private bool FlagSet(byte bitIndex)
        {
            return (Flags & (1 << bitIndex)) > 0;
        }

        private bool Flag2Set(byte bitIndex)
        {
            return (Flags2 & (1 << bitIndex)) > 0;
        }
    }

    public class FuelState
    {
        public double FuelMain;
        public double FuelReservoir;
    }
}