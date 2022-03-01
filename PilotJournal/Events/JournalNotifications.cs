using System;

namespace LibElite.PilotJournal.Events
{
    public class JournalNotifications
    {
        public Action<(int systems, int engine, int weapons)> OnPipsChanged;
        public Action<int> OnFiregroupChanged;
        public Action<int> OnGUIFocusChanged;
        public Action<double> OnLatitudeChanged;
        public Action<double> OnLongitudeChanged;
        public Action<int> OnHeadingChanged;
        public Action<int> OnAltitudeChanged;

        public Action<bool> OnDockingChanged;
        public Action<bool> OnLandedChanged;
        public Action<bool> OnGearChanged;
        public Action<bool> OnShieldsChanged;
        public Action<bool> OnSupercruiseChanged;
        public Action<bool> OnFlightAssistChanged;
        public Action<bool> OnHardpointsChanged;
        public Action<bool> OnInWingChanged;
        public Action<bool> OnLightsChanged;
        public Action<bool> OnCargoScoopChanged;
        public Action<bool> OnSilentRunningChanged;
        public Action<bool> OnFuelScoopingChanged;
        public Action<bool> OnSrvHandbrakeChanged;
        public Action<bool> OnSrvTurretChanged;
        public Action<bool> OnSrvUnderShipChanged;
        public Action<bool> OnSrvDriveAssistChanged;
        public Action<bool> OnFsdMasslockChanged;
        public Action<bool> OnFsdChargingChanged;
        public Action<bool> OnFsdCooldownChanged;
        public Action<bool> OnLowFuelChanged;
        public Action<bool> OnOverheatingChanged;
        public Action<bool> OnHasLatLongChanged;
        public Action<bool> OnIsInDangerChanged;
        public Action<bool> OnBeingInterdictedChanged;
        public Action<bool> OnInMainShipChanged;
        public Action<bool> OnInFighterChanged;
        public Action<bool> OnInSRVChanged;
        public Action<bool> OnHudInAnalysisModeChanged;
        public Action<bool> OnNightVisionChanged;
        public Action<bool> OnAltitudeFromAverageRadiusChanged;
        public Action<bool> OnFootChanged;
        public Action<bool> OnInTaxisChanged;
        public Action<bool> OnInOtherShipChanged;
        public Action<bool> OnFootInStationChanged;
        public Action<bool> OnFootOnPlanetChanged;
        public Action<bool> OnAimDownSightChanged;
        public Action<bool> OnLowOxygenChanged;
        public Action<bool> OnLowHealthChanged;
        public Action<bool> OnColdChanged;
        public Action<bool> OnHotChanged;
        public Action<bool> OnVeryColdChanged;
        public Action<bool> OnVeryHotChanged;
        public Action<bool> OnGlideModeChanged;
        public Action<bool> OnFootInHangarChanged;
        public Action<bool> OnFootInSocialSpaceChanged;
        public Action<bool> OnFootExteriorChanged;
        public Action<bool> OnBreathableAtmosphereChanged;
    }
}