using COW.GamePlay;
using GCommon;

namespace COW;

public class CollectionWeaponExt : CSVBaseData
{
	public JAIKAENPNGO PreviewHitCameraShake;

	public JAIKAENPNGO InGameHitCameraShake;

	public JAIKAENPNGO InGameHitHeadCameraShake;

	public ResourceID[] KillNotificationSoundArray;

	public string KatanaSound;

	public ResourceID KillNotificationUIFXRes;

	public ResourceID SwitchGunResource;

	public ResourceID IngameClipOutSound;

	public ResourceID IngameClipInSound;

	public ResourceID IngameChangeWeaponSound;

	public int WeaponExecutionID;

	public int PrivilegeRight;

	public uint NewMatType;

	public ResourceID FireEffect2;

	public ResourceID AnnouncementBG;

	public ResourceID IngameReloadEffect;

	public ResourceID PreviewReloadEffectFemale;

	public ResourceID PreviewReloadEffectMale;

	public ResourceID PreviewSpecialSound;

	public ResourceID PreviewNormalSound;

	public ResourceID PreviewFireSound;

	public int KillCountDisplayed;

	public ResourceID PreviewMeleeRunEffect;

	public ResourceID InGameWeaponEffect;

	public ResourceID PreviewGunTraceEffect;

	public ResourceID IngameGunTraceEffect;

	public ResourceID inGameRes3PSecond;

	public ResourceID AceSound;

	public ResourceID PreviewFemaleMeleeRunAnim;

	public ResourceID PreviewMaleMeleeRunAnim;

	public ResourceID inGameRes1PSecond;

	public uint iID;

	public ResourceID FireSound;

	public ResourceID BackResSecond;

	public ResourceID FireEffect3;

	public ResourceID PreviewSwitchGunFemale;

	public ResourceID ParticleResSecond;

	public ResourceID PreviewSwitchGunMale;

	public bool IsDoubleWeapon;

	public bool ShowFullAnim;

	public bool IsNamed;

	public bool BuffSwitch;

	public bool IsPVE_WeaponSkin;

	public bool PowerSwitch;

	public bool FistRightZScaleInverse;

	public bool FistUseForeArm;

	public bool DoubleFISTWeapon;

	public bool HideGunWhenReload;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
