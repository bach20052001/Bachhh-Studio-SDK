#region

using MoreMountains.NiceVibrations;

#endregion

namespace BachhhStudioSdk
{
    public static class BachhhVibrate
    {
        public static void Haptic(BachhhHapticTypes type)
        {
            if (!GameManager.Instance.data.setting.haptic)
                return;

            MMVibrationManager.Haptic((HapticTypes) type, false, true);
        }
    }
}

public enum BachhhHapticTypes
{
    Selection,
    Success,
    Warning,
    Failure,
    LightImpact,
    MediumImpact,
    HeavyImpact,
    RigidImpact,
    SoftImpact,
    None
}