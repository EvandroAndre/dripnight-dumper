using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class WeaponSkinData : CSVBaseData
{
	private ResourceID[] m_KatanaSoundResIDs;

	public int CollectionWeaponExtIndex;

	public Vector3 MaxPosition;

	public Vector3 MaxRotatiton;

	public Vector3 MaxScale;

	public string FistPreviewSound;

	public ResourceID IngameSwitchGunFemale;

	public ResourceID PrivilegeChangeWeaponMale;

	public ResourceID PrivilegeReloadWeaponFemale;

	public ResourceID PrivilegeReloadWeaponMale;

	public ResourceID AceTeamUIFXRes;

	public uint iID;

	public ResourceID IngameHitEffect;

	public ResourceID HUDHitEffect;

	public ResourceID FireEffect;

	public ResourceID SecondFireSound;

	public ResourceID FireSoundMuffler;

	public ResourceID SecondFireEffect;

	public ResourceID HudKillNotiEmoteRes;

	public ResourceID KnockDownUIFXRes;

	public ResourceID CampIcon;

	public ResourceID PreviewShootEffect;

	public ResourceID PreviewBackRes;

	public ResourceID PreviewHitEffect;

	public ResourceID inGameRes3P;

	public ResourceID inGameRes1P;

	public ResourceID IngameKillEffect;

	public ResourceID PreviewGrenadeGun;

	public ResourceID PreviewKillEffect;

	public ResourceID BackRes;

	public ResourceID previewEffectRes;

	public ResourceID ParticleRes;

	public ResourceID previewRes;

	public uint WeaponID;

	public ResourceID IngameSwitchGunMale;

	public ResourceID PrivilegeChangeWeaponFemale;

	public ResourceID AnnouncementType;

	public ResourceID HDIngameSwitchGunMale;

	public ResourceID HDIngameSwitchGunFemale;

	public bool IsFireSoundCombo;

	public bool FireSoundOptional;

	public byte LabelID;

	public bool IsSpecialAnim;

	public bool IsShow;

	public bool IsAnimation;

	public bool InGameHitCameraEffectActiveForAllTarget;

	public bool WeaponExecutionAlwaysPlay;

	public byte SkinLevel;

	public bool MaxShow;

	public byte Announcement;

	public byte FireSoundDistance;

	public byte AnimationID;

	public byte WeaponSet;

	public JAIKAENPNGO PreviewHitCameraShake => default(JAIKAENPNGO);

	public JAIKAENPNGO InGameHitCameraShake => default(JAIKAENPNGO);

	public JAIKAENPNGO InGameHitHeadCameraShake => default(JAIKAENPNGO);

	public ResourceID[] KillNotificationSoundArray => null;

	public ResourceID[] KatanaSoundResIDs => null;

	public ResourceID KillNotificationUIFXRes => default(ResourceID);

	public ResourceID SwitchGunResource => default(ResourceID);

	public ResourceID IngameClipOutSound => default(ResourceID);

	public ResourceID IngameClipInSound => default(ResourceID);

	public ResourceID IngameChangeWeaponSound => default(ResourceID);

	public int WeaponExecutionID => 0;

	public int PrivilegeRight => 0;

	public uint NewMatType => 0u;

	public ResourceID FireEffect2 => default(ResourceID);

	public ResourceID AnnouncementBG => default(ResourceID);

	public ResourceID IngameReloadEffect => default(ResourceID);

	public ResourceID PreviewReloadEffectFemale => default(ResourceID);

	public ResourceID PreviewReloadEffectMale => default(ResourceID);

	public ResourceID PreviewSpecialSound => default(ResourceID);

	public ResourceID PreviewNormalSound => default(ResourceID);

	public ResourceID PreviewFireSound => default(ResourceID);

	public int KillCountDisplayed => 0;

	public ResourceID PreviewMeleeRunEffect => default(ResourceID);

	public ResourceID InGameWeaponEffect => default(ResourceID);

	public ResourceID PreviewGunTraceEffect => default(ResourceID);

	public ResourceID IngameGunTraceEffect => default(ResourceID);

	public ResourceID inGameRes3PSecond => default(ResourceID);

	public ResourceID AceSound => default(ResourceID);

	public ResourceID PreviewFemaleMeleeRunAnim => default(ResourceID);

	public ResourceID PreviewMaleMeleeRunAnim => default(ResourceID);

	public ResourceID PreviewSwitchGunFemale => default(ResourceID);

	public ResourceID FistPreviewSoundResID => default(ResourceID);

	public ResourceID FireSound => default(ResourceID);

	public ResourceID inGameRes1PSecond => default(ResourceID);

	public ResourceID BackResSecond => default(ResourceID);

	public ResourceID FireEffect3 => default(ResourceID);

	public ResourceID ParticleResSecond => default(ResourceID);

	public ResourceID PreviewSwitchGunMale => default(ResourceID);

	public bool ShowFullAnim => false;

	public bool IsNamed => false;

	public bool IsPVE_WeaponSkin => false;

	public bool PowerSwitch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool BuffSwitch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FistRightZScaleInverse => false;

	public bool FistUseForeArm => false;

	public bool IsDoubleWeapon => false;

	public bool IsDoubleFISTWeapon => false;

	public bool HideGunWhenReload => false;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public bool IsEvoGunAnnounceBgAvailable()
	{
		return false;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
