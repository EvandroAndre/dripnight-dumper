using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCWeaponRepItem
{
	public const int PROP_ID_DAMAGE = -79000;

	public const int PROP_ID_RANGE = -79001;

	public const int PROP_ID_FIREINTERVAL = -79002;

	public const int PROP_ID_AMMOCLIPSIZE = -79003;

	public const int PROP_ID_INITIALCLIPCOUNT = -79004;

	public const int PROP_ID_BITEARMOR = -79005;

	public const int PROP_ID_FULLDAMAGEDISTANCE = -79006;

	public const int PROP_ID_MINDAMAGEDISTANCE = -79007;

	public const int PROP_ID_MINDAMAGE = -79008;

	public const int PROP_ID_SCATTERNUM = -79009;

	public const int PROP_ID_SCATTERMAX = -79010;

	public const int PROP_ID_WEAPONITEMID = -79011;

	public const int PROP_ID_REPEATFIREINTERVAL = -79012;

	public const int PROP_ID_OWNER = -79013;

	public const int PROP_ID_COSTAMMO = -79014;

	public const int PROP_ID_COMBINETYPE = -79015;

	public const int PROP_ID_ARMORDESTROY = -79016;

	public const int PROP_ID_PLAYERSPEEDFACTOR = -79017;

	public const int PROP_ID_DAMAGERATIOBODY = -79018;

	public const int PROP_ID_DAMAGERATIOHEAD = -79019;

	public const int PROP_ID_DAMAGELIMBBODY = -79020;

	public const int PROP_ID_EXTRADAMAGERATE = -79021;

	public const int PROP_ID_VISIBLEONBACK = -79022;

	public const int PROP_ID_KNOCKDOWNDAMAGE = -79023;

	public const int PROP_ID_ONCEAMMO = -79024;

	public const int PROP_ID_RELOADSPEED = -79025;

	public const int PROP_ID_AMMOINCLIP = -79026;

	public const int PROP_ID_WEAPONSKINID = -79027;

	public const int PROP_ID_OVERLOADBYPLAYERWEAPONSKIN = -79028;

	public const int PROP_ID_ENABLEWEAPONSKINPROP = -79029;

	public const int PROP_ID_SCATTERSPEED = -79030;

	public const int PROP_ID_SCATTERRECOVERSPEED = -79031;

	public const int PROP_ID_PLAYERSPEEDFACTORFIRING = -79032;

	public const int PROP_ID_SCATTERMOVE = -79033;

	public const int PROP_ID_ORIGINWEAPONTYPE = -79034;

	public const int PROP_ID_AMMOTYPE = -79035;

	public const int PROP_ID_FIRETYPE = -79036;

	public const int PROP_ID_ISSINGLESHOT = -79037;

	public const int PROP_ID_ISSILENCE = -79038;

	public const int PROP_ID_SPEEDWHILEAIMING = -79039;

	public const int PROP_ID_SWITCHWEAPONTIME = -79040;

	public const int PROP_ID_PRESWITCHWEAPONTIME = -79041;

	public const int PROP_ID_POSTSWITCHWEAPONTIME = -79042;

	public const int PROP_ID_SCOPETRANSITIONTIME = -79043;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnDamageChangeEvent;

	public Action<float> OnRangeChangeEvent;

	public Action<float> OnFireIntervalChangeEvent;

	public Action<int> OnAmmoClipSizeChangeEvent;

	public Action<int> OnInitialClipCountChangeEvent;

	public Action<float> OnBiteArmorChangeEvent;

	public Action<float> OnFullDamageDistanceChangeEvent;

	public Action<float> OnMinDamageDistanceChangeEvent;

	public Action<int> OnMinDamageChangeEvent;

	public Action<float> OnScatterNumChangeEvent;

	public Action<float> OnScatterMaxChangeEvent;

	public Action<int> OnWeaponItemIDChangeEvent;

	public Action<float> OnRepeatFireIntervalChangeEvent;

	public Action<bool> OnCostAmmoChangeEvent;

	public Action<int> OnCombineTypeChangeEvent;

	public Action<float> OnArmordestroyChangeEvent;

	public Action<float> OnPlayerSpeedFactorChangeEvent;

	public Action<float> OnDamageRatioBodyChangeEvent;

	public Action<float> OnDamageRatioHeadChangeEvent;

	public Action<float> OnDamageLimbBodyChangeEvent;

	public Action<float> OnExtraDamageRateChangeEvent;

	public Action<bool> OnVisibleOnBackChangeEvent;

	public Action<int> OnKnockDownDamageChangeEvent;

	public Action<int> OnOnceAmmoChangeEvent;

	public Action<float> OnReloadSpeedChangeEvent;

	public Action<int> OnAmmoInClipChangeEvent;

	public Action<int> OnWeaponSkinIDChangeEvent;

	public Action<bool> OnOverloadByPlayerWeaponSkinChangeEvent;

	public Action<bool> OnEnableWeaponSkinPropChangeEvent;

	public Action<float> OnScatterSpeedChangeEvent;

	public Action<float> OnScatterRecoverSpeedChangeEvent;

	public Action<float> OnPlayerSpeedFactorFiringChangeEvent;

	public Action<float> OnScatterMoveChangeEvent;

	public Action<int> OnOriginWeaponTypeChangeEvent;

	public Action<int> OnAmmoTypeChangeEvent;

	public Action<int> OnFireTypeChangeEvent;

	public Action<bool> OnIsSingleShotChangeEvent;

	public Action<bool> OnIsSilenceChangeEvent;

	public Action<float> OnSpeedWhileAimingChangeEvent;

	public Action<float> OnSwitchWeaponTimeChangeEvent;

	public Action<float> OnPreSwitchWeaponTimeChangeEvent;

	public Action<float> OnPostSwitchWeaponTimeChangeEvent;

	public Action<float> OnScopeTransitionTimeChangeEvent;

	private int _003CDamage_003Ek__BackingField;

	private float _003CRange_003Ek__BackingField;

	private float _003CFireInterval_003Ek__BackingField;

	private int _003CAmmoClipSize_003Ek__BackingField;

	private int _003CInitialClipCount_003Ek__BackingField;

	private float _003CBiteArmor_003Ek__BackingField;

	private float _003CFullDamageDistance_003Ek__BackingField;

	private float _003CMinDamageDistance_003Ek__BackingField;

	private int _003CMinDamage_003Ek__BackingField;

	private float _003CScatterNum_003Ek__BackingField;

	private float _003CScatterMax_003Ek__BackingField;

	private int _003CWeaponItemID_003Ek__BackingField;

	private float _003CRepeatFireInterval_003Ek__BackingField;

	private bool _003CCostAmmo_003Ek__BackingField;

	private int _003CCombineType_003Ek__BackingField;

	private float _003CArmordestroy_003Ek__BackingField;

	private float _003CPlayerSpeedFactor_003Ek__BackingField;

	private float _003CDamageRatioBody_003Ek__BackingField;

	private float _003CDamageRatioHead_003Ek__BackingField;

	private float _003CDamageLimbBody_003Ek__BackingField;

	private float _003CExtraDamageRate_003Ek__BackingField;

	private bool _003CVisibleOnBack_003Ek__BackingField;

	private int _003CKnockDownDamage_003Ek__BackingField;

	private int _003COnceAmmo_003Ek__BackingField;

	private float _003CReloadSpeed_003Ek__BackingField;

	private int _003CAmmoInClip_003Ek__BackingField;

	private int _003CWeaponSkinID_003Ek__BackingField;

	private bool _003COverloadByPlayerWeaponSkin_003Ek__BackingField;

	private bool _003CEnableWeaponSkinProp_003Ek__BackingField;

	private float _003CScatterSpeed_003Ek__BackingField;

	private float _003CScatterRecoverSpeed_003Ek__BackingField;

	private float _003CPlayerSpeedFactorFiring_003Ek__BackingField;

	private float _003CScatterMove_003Ek__BackingField;

	private int _003COriginWeaponType_003Ek__BackingField;

	private int _003CAmmoType_003Ek__BackingField;

	private int _003CFireType_003Ek__BackingField;

	private bool _003CIsSingleShot_003Ek__BackingField;

	private bool _003CIsSilence_003Ek__BackingField;

	private float _003CSpeedWhileAiming_003Ek__BackingField;

	private float _003CSwitchWeaponTime_003Ek__BackingField;

	private float _003CPreSwitchWeaponTime_003Ek__BackingField;

	private float _003CPostSwitchWeaponTime_003Ek__BackingField;

	private float _003CScopeTransitionTime_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Damage
	{
		get
		{
			return _003CDamage_003Ek__BackingField;
		}
		private set
		{
			_003CDamage_003Ek__BackingField = value;
		}
	}

	public float Range
	{
		get
		{
			return _003CRange_003Ek__BackingField;
		}
		private set
		{
			_003CRange_003Ek__BackingField = value;
		}
	}

	public float FireInterval
	{
		get
		{
			return _003CFireInterval_003Ek__BackingField;
		}
		private set
		{
			_003CFireInterval_003Ek__BackingField = value;
		}
	}

	public int AmmoClipSize
	{
		get
		{
			return _003CAmmoClipSize_003Ek__BackingField;
		}
		private set
		{
			_003CAmmoClipSize_003Ek__BackingField = value;
		}
	}

	public int InitialClipCount
	{
		get
		{
			return _003CInitialClipCount_003Ek__BackingField;
		}
		private set
		{
			_003CInitialClipCount_003Ek__BackingField = value;
		}
	}

	public float BiteArmor
	{
		get
		{
			return _003CBiteArmor_003Ek__BackingField;
		}
		private set
		{
			_003CBiteArmor_003Ek__BackingField = value;
		}
	}

	public float FullDamageDistance
	{
		get
		{
			return _003CFullDamageDistance_003Ek__BackingField;
		}
		private set
		{
			_003CFullDamageDistance_003Ek__BackingField = value;
		}
	}

	public float MinDamageDistance
	{
		get
		{
			return _003CMinDamageDistance_003Ek__BackingField;
		}
		private set
		{
			_003CMinDamageDistance_003Ek__BackingField = value;
		}
	}

	public int MinDamage
	{
		get
		{
			return _003CMinDamage_003Ek__BackingField;
		}
		private set
		{
			_003CMinDamage_003Ek__BackingField = value;
		}
	}

	public float ScatterNum
	{
		get
		{
			return _003CScatterNum_003Ek__BackingField;
		}
		private set
		{
			_003CScatterNum_003Ek__BackingField = value;
		}
	}

	public float ScatterMax
	{
		get
		{
			return _003CScatterMax_003Ek__BackingField;
		}
		private set
		{
			_003CScatterMax_003Ek__BackingField = value;
		}
	}

	public int WeaponItemID
	{
		get
		{
			return _003CWeaponItemID_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponItemID_003Ek__BackingField = value;
		}
	}

	public float RepeatFireInterval
	{
		get
		{
			return _003CRepeatFireInterval_003Ek__BackingField;
		}
		private set
		{
			_003CRepeatFireInterval_003Ek__BackingField = value;
		}
	}

	public bool CostAmmo
	{
		get
		{
			return _003CCostAmmo_003Ek__BackingField;
		}
		private set
		{
			_003CCostAmmo_003Ek__BackingField = value;
		}
	}

	public int CombineType
	{
		get
		{
			return _003CCombineType_003Ek__BackingField;
		}
		private set
		{
			_003CCombineType_003Ek__BackingField = value;
		}
	}

	public float Armordestroy
	{
		get
		{
			return _003CArmordestroy_003Ek__BackingField;
		}
		private set
		{
			_003CArmordestroy_003Ek__BackingField = value;
		}
	}

	public float PlayerSpeedFactor
	{
		get
		{
			return _003CPlayerSpeedFactor_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerSpeedFactor_003Ek__BackingField = value;
		}
	}

	public float DamageRatioBody
	{
		get
		{
			return _003CDamageRatioBody_003Ek__BackingField;
		}
		private set
		{
			_003CDamageRatioBody_003Ek__BackingField = value;
		}
	}

	public float DamageRatioHead
	{
		get
		{
			return _003CDamageRatioHead_003Ek__BackingField;
		}
		private set
		{
			_003CDamageRatioHead_003Ek__BackingField = value;
		}
	}

	public float DamageLimbBody
	{
		get
		{
			return _003CDamageLimbBody_003Ek__BackingField;
		}
		private set
		{
			_003CDamageLimbBody_003Ek__BackingField = value;
		}
	}

	public float ExtraDamageRate
	{
		get
		{
			return _003CExtraDamageRate_003Ek__BackingField;
		}
		private set
		{
			_003CExtraDamageRate_003Ek__BackingField = value;
		}
	}

	public bool VisibleOnBack
	{
		get
		{
			return _003CVisibleOnBack_003Ek__BackingField;
		}
		private set
		{
			_003CVisibleOnBack_003Ek__BackingField = value;
		}
	}

	public int KnockDownDamage
	{
		get
		{
			return _003CKnockDownDamage_003Ek__BackingField;
		}
		private set
		{
			_003CKnockDownDamage_003Ek__BackingField = value;
		}
	}

	public int OnceAmmo
	{
		get
		{
			return _003COnceAmmo_003Ek__BackingField;
		}
		private set
		{
			_003COnceAmmo_003Ek__BackingField = value;
		}
	}

	public float ReloadSpeed
	{
		get
		{
			return _003CReloadSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CReloadSpeed_003Ek__BackingField = value;
		}
	}

	public int AmmoInClip
	{
		get
		{
			return _003CAmmoInClip_003Ek__BackingField;
		}
		private set
		{
			_003CAmmoInClip_003Ek__BackingField = value;
		}
	}

	public int WeaponSkinID
	{
		get
		{
			return _003CWeaponSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponSkinID_003Ek__BackingField = value;
		}
	}

	public bool OverloadByPlayerWeaponSkin
	{
		get
		{
			return _003COverloadByPlayerWeaponSkin_003Ek__BackingField;
		}
		private set
		{
			_003COverloadByPlayerWeaponSkin_003Ek__BackingField = value;
		}
	}

	public bool EnableWeaponSkinProp
	{
		get
		{
			return _003CEnableWeaponSkinProp_003Ek__BackingField;
		}
		private set
		{
			_003CEnableWeaponSkinProp_003Ek__BackingField = value;
		}
	}

	public float ScatterSpeed
	{
		get
		{
			return _003CScatterSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CScatterSpeed_003Ek__BackingField = value;
		}
	}

	public float ScatterRecoverSpeed
	{
		get
		{
			return _003CScatterRecoverSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CScatterRecoverSpeed_003Ek__BackingField = value;
		}
	}

	public float PlayerSpeedFactorFiring
	{
		get
		{
			return _003CPlayerSpeedFactorFiring_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerSpeedFactorFiring_003Ek__BackingField = value;
		}
	}

	public float ScatterMove
	{
		get
		{
			return _003CScatterMove_003Ek__BackingField;
		}
		private set
		{
			_003CScatterMove_003Ek__BackingField = value;
		}
	}

	public int OriginWeaponType
	{
		get
		{
			return _003COriginWeaponType_003Ek__BackingField;
		}
		private set
		{
			_003COriginWeaponType_003Ek__BackingField = value;
		}
	}

	public int AmmoType
	{
		get
		{
			return _003CAmmoType_003Ek__BackingField;
		}
		private set
		{
			_003CAmmoType_003Ek__BackingField = value;
		}
	}

	public int FireType
	{
		get
		{
			return _003CFireType_003Ek__BackingField;
		}
		private set
		{
			_003CFireType_003Ek__BackingField = value;
		}
	}

	public bool IsSingleShot
	{
		get
		{
			return _003CIsSingleShot_003Ek__BackingField;
		}
		private set
		{
			_003CIsSingleShot_003Ek__BackingField = value;
		}
	}

	public bool IsSilence
	{
		get
		{
			return _003CIsSilence_003Ek__BackingField;
		}
		private set
		{
			_003CIsSilence_003Ek__BackingField = value;
		}
	}

	public float SpeedWhileAiming
	{
		get
		{
			return _003CSpeedWhileAiming_003Ek__BackingField;
		}
		private set
		{
			_003CSpeedWhileAiming_003Ek__BackingField = value;
		}
	}

	public float SwitchWeaponTime
	{
		get
		{
			return _003CSwitchWeaponTime_003Ek__BackingField;
		}
		private set
		{
			_003CSwitchWeaponTime_003Ek__BackingField = value;
		}
	}

	public float PreSwitchWeaponTime
	{
		get
		{
			return _003CPreSwitchWeaponTime_003Ek__BackingField;
		}
		private set
		{
			_003CPreSwitchWeaponTime_003Ek__BackingField = value;
		}
	}

	public float PostSwitchWeaponTime
	{
		get
		{
			return _003CPostSwitchWeaponTime_003Ek__BackingField;
		}
		private set
		{
			_003CPostSwitchWeaponTime_003Ek__BackingField = value;
		}
	}

	public float ScopeTransitionTime
	{
		get
		{
			return _003CScopeTransitionTime_003Ek__BackingField;
		}
		private set
		{
			_003CScopeTransitionTime_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCWeaponRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
