using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCommonHudSwitchControllerRepItem
{
	public const int PROP_ID_CROUCH = -248000;

	public const int PROP_ID_CREEP = -248001;

	public const int PROP_ID_JUMP = -248002;

	public const int PROP_ID_FIRE = -248003;

	public const int PROP_ID_MOVINGJOYSTICK = -248004;

	public const int PROP_ID_TEAMMATESINFO = -248005;

	public const int PROP_ID_ATTACKGRENADE = -248006;

	public const int PROP_ID_DEFENCEGRENADE = -248007;

	public const int PROP_ID_SPEEDUP = -248008;

	public const int PROP_ID_KILLINGTIPS = -248009;

	public const int PROP_ID_WEAPONHUD = -248010;

	public const int PROP_ID_MINMAPHUD = -248011;

	public const int PROP_ID_BAGHUD = -248012;

	public const int PROP_ID_MEDICALPROPSHUD = -248013;

	public const int PROP_ID_EMOTIONHUD = -248014;

	public const int PROP_ID_QUICKCHATHUD = -248015;

	public const int PROP_ID_PICKUPLISTHUD = -248016;

	public const int PROP_ID_QUICKCHATSHOWHUD = -248017;

	public const int PROP_ID_HPITEMHUD = -248018;

	public const int PROP_ID_EPITEMHUD = -248019;

	public const int PROP_ID_ARMORHUD = -248020;

	public const int PROP_ID_RELOADBTNHUD = -248021;

	public const int PROP_ID_SWEAPWEAPONQUICKBTNHUD = -248022;

	public const int PROP_ID_SPEAKERBTNHUD = -248023;

	public const int PROP_ID_MICROPHONEBTNHUD = -248024;

	public const int PROP_ID_MARKBTNHUD = -248025;

	public const int PROP_ID_SETTINGSBTNHUD = -248026;

	public const int PROP_ID_SIGNALICOHUD = -248027;

	public const int PROP_ID_ACTIVESKILLBTNHUD = -248028;

	public const int PROP_ID_CROSSHAIRSHUD = -248029;

	public const int PROP_ID_PASSIVESKILLHUD = -248030;

	public const int PROP_ID_FPPINSPECTIONHUD = -248031;

	public const int PROP_ID_HELPUPHUD = -248032;

	public const int PROP_ID_RESCUREHUD = -248033;

	public const int PROP_ID_ATTACK2HUD = -248034;

	public const int PROP_ID_COMBINEWEAPONHUD = -248035;

	public const int PROP_ID_SWIMMINGSURFHUD = -248036;

	public const int PROP_ID_ACTIONHUD = -248037;

	public const int PROP_ID_TAKEPHOTOHUD = -248038;

	public const int PROP_ID_PULLTHEPIN = -248039;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnCrouchChangeEvent;

	public Action<int> OnCreepChangeEvent;

	public Action<int> OnJumpChangeEvent;

	public Action<int> OnFireChangeEvent;

	public Action<int> OnMovingJoystickChangeEvent;

	public Action<int> OnTeammatesInfoChangeEvent;

	public Action<int> OnAttackGrenadeChangeEvent;

	public Action<int> OnDefenceGrenadeChangeEvent;

	public Action<int> OnSpeedupChangeEvent;

	public Action<int> OnKillingTipsChangeEvent;

	public Action<int> OnWeaponHUDChangeEvent;

	public Action<int> OnMinMapHUDChangeEvent;

	public Action<int> OnBagHUDChangeEvent;

	public Action<int> OnMedicalPropsHUDChangeEvent;

	public Action<int> OnEmotionHUDChangeEvent;

	public Action<int> OnQuickChatHUDChangeEvent;

	public Action<int> OnPickupListHUDChangeEvent;

	public Action<int> OnQuickChatShowHUDChangeEvent;

	public Action<int> OnHPItemHUDChangeEvent;

	public Action<int> OnEPItemHUDChangeEvent;

	public Action<int> OnArmorHUDChangeEvent;

	public Action<int> OnReloadBtnHUDChangeEvent;

	public Action<int> OnSweapWeaponQuickBtnHUDChangeEvent;

	public Action<int> OnSpeakerBtnHUDChangeEvent;

	public Action<int> OnMicroPhoneBtnHUDChangeEvent;

	public Action<int> OnMarkBtnHUDChangeEvent;

	public Action<int> OnSettingsBtnHUDChangeEvent;

	public Action<int> OnSignalIcoHUDChangeEvent;

	public Action<int> OnActiveSkillBtnHUDChangeEvent;

	public Action<int> OnCrosshairsHUDChangeEvent;

	public Action<int> OnPassiveSkillHUDChangeEvent;

	public Action<int> OnFPPInspectionHUDChangeEvent;

	public Action<int> OnHelpUpHudChangeEvent;

	public Action<int> OnRescureHudChangeEvent;

	public Action<int> OnAttack2HudChangeEvent;

	public Action<int> OnCombineWeaponHudChangeEvent;

	public Action<int> OnSwimmingSurfHudChangeEvent;

	public Action<int> OnActionHudChangeEvent;

	public Action<int> OnTakePhotoHudChangeEvent;

	public Action<int> OnPullThePinChangeEvent;

	private int _003CCrouch_003Ek__BackingField;

	private int _003CCreep_003Ek__BackingField;

	private int _003CJump_003Ek__BackingField;

	private int _003CFire_003Ek__BackingField;

	private int _003CMovingJoystick_003Ek__BackingField;

	private int _003CTeammatesInfo_003Ek__BackingField;

	private int _003CAttackGrenade_003Ek__BackingField;

	private int _003CDefenceGrenade_003Ek__BackingField;

	private int _003CSpeedup_003Ek__BackingField;

	private int _003CKillingTips_003Ek__BackingField;

	private int _003CWeaponHUD_003Ek__BackingField;

	private int _003CMinMapHUD_003Ek__BackingField;

	private int _003CBagHUD_003Ek__BackingField;

	private int _003CMedicalPropsHUD_003Ek__BackingField;

	private int _003CEmotionHUD_003Ek__BackingField;

	private int _003CQuickChatHUD_003Ek__BackingField;

	private int _003CPickupListHUD_003Ek__BackingField;

	private int _003CQuickChatShowHUD_003Ek__BackingField;

	private int _003CHPItemHUD_003Ek__BackingField;

	private int _003CEPItemHUD_003Ek__BackingField;

	private int _003CArmorHUD_003Ek__BackingField;

	private int _003CReloadBtnHUD_003Ek__BackingField;

	private int _003CSweapWeaponQuickBtnHUD_003Ek__BackingField;

	private int _003CSpeakerBtnHUD_003Ek__BackingField;

	private int _003CMicroPhoneBtnHUD_003Ek__BackingField;

	private int _003CMarkBtnHUD_003Ek__BackingField;

	private int _003CSettingsBtnHUD_003Ek__BackingField;

	private int _003CSignalIcoHUD_003Ek__BackingField;

	private int _003CActiveSkillBtnHUD_003Ek__BackingField;

	private int _003CCrosshairsHUD_003Ek__BackingField;

	private int _003CPassiveSkillHUD_003Ek__BackingField;

	private int _003CFPPInspectionHUD_003Ek__BackingField;

	private int _003CHelpUpHud_003Ek__BackingField;

	private int _003CRescureHud_003Ek__BackingField;

	private int _003CAttack2Hud_003Ek__BackingField;

	private int _003CCombineWeaponHud_003Ek__BackingField;

	private int _003CSwimmingSurfHud_003Ek__BackingField;

	private int _003CActionHud_003Ek__BackingField;

	private int _003CTakePhotoHud_003Ek__BackingField;

	private int _003CPullThePin_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Crouch
	{
		get
		{
			return _003CCrouch_003Ek__BackingField;
		}
		private set
		{
			_003CCrouch_003Ek__BackingField = value;
		}
	}

	public int Creep
	{
		get
		{
			return _003CCreep_003Ek__BackingField;
		}
		private set
		{
			_003CCreep_003Ek__BackingField = value;
		}
	}

	public int Jump
	{
		get
		{
			return _003CJump_003Ek__BackingField;
		}
		private set
		{
			_003CJump_003Ek__BackingField = value;
		}
	}

	public int Fire
	{
		get
		{
			return _003CFire_003Ek__BackingField;
		}
		private set
		{
			_003CFire_003Ek__BackingField = value;
		}
	}

	public int MovingJoystick
	{
		get
		{
			return _003CMovingJoystick_003Ek__BackingField;
		}
		private set
		{
			_003CMovingJoystick_003Ek__BackingField = value;
		}
	}

	public int TeammatesInfo
	{
		get
		{
			return _003CTeammatesInfo_003Ek__BackingField;
		}
		private set
		{
			_003CTeammatesInfo_003Ek__BackingField = value;
		}
	}

	public int AttackGrenade
	{
		get
		{
			return _003CAttackGrenade_003Ek__BackingField;
		}
		private set
		{
			_003CAttackGrenade_003Ek__BackingField = value;
		}
	}

	public int DefenceGrenade
	{
		get
		{
			return _003CDefenceGrenade_003Ek__BackingField;
		}
		private set
		{
			_003CDefenceGrenade_003Ek__BackingField = value;
		}
	}

	public int Speedup
	{
		get
		{
			return _003CSpeedup_003Ek__BackingField;
		}
		private set
		{
			_003CSpeedup_003Ek__BackingField = value;
		}
	}

	public int KillingTips
	{
		get
		{
			return _003CKillingTips_003Ek__BackingField;
		}
		private set
		{
			_003CKillingTips_003Ek__BackingField = value;
		}
	}

	public int WeaponHUD
	{
		get
		{
			return _003CWeaponHUD_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponHUD_003Ek__BackingField = value;
		}
	}

	public int MinMapHUD
	{
		get
		{
			return _003CMinMapHUD_003Ek__BackingField;
		}
		private set
		{
			_003CMinMapHUD_003Ek__BackingField = value;
		}
	}

	public int BagHUD
	{
		get
		{
			return _003CBagHUD_003Ek__BackingField;
		}
		private set
		{
			_003CBagHUD_003Ek__BackingField = value;
		}
	}

	public int MedicalPropsHUD
	{
		get
		{
			return _003CMedicalPropsHUD_003Ek__BackingField;
		}
		private set
		{
			_003CMedicalPropsHUD_003Ek__BackingField = value;
		}
	}

	public int EmotionHUD
	{
		get
		{
			return _003CEmotionHUD_003Ek__BackingField;
		}
		private set
		{
			_003CEmotionHUD_003Ek__BackingField = value;
		}
	}

	public int QuickChatHUD
	{
		get
		{
			return _003CQuickChatHUD_003Ek__BackingField;
		}
		private set
		{
			_003CQuickChatHUD_003Ek__BackingField = value;
		}
	}

	public int PickupListHUD
	{
		get
		{
			return _003CPickupListHUD_003Ek__BackingField;
		}
		private set
		{
			_003CPickupListHUD_003Ek__BackingField = value;
		}
	}

	public int QuickChatShowHUD
	{
		get
		{
			return _003CQuickChatShowHUD_003Ek__BackingField;
		}
		private set
		{
			_003CQuickChatShowHUD_003Ek__BackingField = value;
		}
	}

	public int HPItemHUD
	{
		get
		{
			return _003CHPItemHUD_003Ek__BackingField;
		}
		private set
		{
			_003CHPItemHUD_003Ek__BackingField = value;
		}
	}

	public int EPItemHUD
	{
		get
		{
			return _003CEPItemHUD_003Ek__BackingField;
		}
		private set
		{
			_003CEPItemHUD_003Ek__BackingField = value;
		}
	}

	public int ArmorHUD
	{
		get
		{
			return _003CArmorHUD_003Ek__BackingField;
		}
		private set
		{
			_003CArmorHUD_003Ek__BackingField = value;
		}
	}

	public int ReloadBtnHUD
	{
		get
		{
			return _003CReloadBtnHUD_003Ek__BackingField;
		}
		private set
		{
			_003CReloadBtnHUD_003Ek__BackingField = value;
		}
	}

	public int SweapWeaponQuickBtnHUD
	{
		get
		{
			return _003CSweapWeaponQuickBtnHUD_003Ek__BackingField;
		}
		private set
		{
			_003CSweapWeaponQuickBtnHUD_003Ek__BackingField = value;
		}
	}

	public int SpeakerBtnHUD
	{
		get
		{
			return _003CSpeakerBtnHUD_003Ek__BackingField;
		}
		private set
		{
			_003CSpeakerBtnHUD_003Ek__BackingField = value;
		}
	}

	public int MicroPhoneBtnHUD
	{
		get
		{
			return _003CMicroPhoneBtnHUD_003Ek__BackingField;
		}
		private set
		{
			_003CMicroPhoneBtnHUD_003Ek__BackingField = value;
		}
	}

	public int MarkBtnHUD
	{
		get
		{
			return _003CMarkBtnHUD_003Ek__BackingField;
		}
		private set
		{
			_003CMarkBtnHUD_003Ek__BackingField = value;
		}
	}

	public int SettingsBtnHUD
	{
		get
		{
			return _003CSettingsBtnHUD_003Ek__BackingField;
		}
		private set
		{
			_003CSettingsBtnHUD_003Ek__BackingField = value;
		}
	}

	public int SignalIcoHUD
	{
		get
		{
			return _003CSignalIcoHUD_003Ek__BackingField;
		}
		private set
		{
			_003CSignalIcoHUD_003Ek__BackingField = value;
		}
	}

	public int ActiveSkillBtnHUD
	{
		get
		{
			return _003CActiveSkillBtnHUD_003Ek__BackingField;
		}
		private set
		{
			_003CActiveSkillBtnHUD_003Ek__BackingField = value;
		}
	}

	public int CrosshairsHUD
	{
		get
		{
			return _003CCrosshairsHUD_003Ek__BackingField;
		}
		private set
		{
			_003CCrosshairsHUD_003Ek__BackingField = value;
		}
	}

	public int PassiveSkillHUD
	{
		get
		{
			return _003CPassiveSkillHUD_003Ek__BackingField;
		}
		private set
		{
			_003CPassiveSkillHUD_003Ek__BackingField = value;
		}
	}

	public int FPPInspectionHUD
	{
		get
		{
			return _003CFPPInspectionHUD_003Ek__BackingField;
		}
		private set
		{
			_003CFPPInspectionHUD_003Ek__BackingField = value;
		}
	}

	public int HelpUpHud
	{
		get
		{
			return _003CHelpUpHud_003Ek__BackingField;
		}
		private set
		{
			_003CHelpUpHud_003Ek__BackingField = value;
		}
	}

	public int RescureHud
	{
		get
		{
			return _003CRescureHud_003Ek__BackingField;
		}
		private set
		{
			_003CRescureHud_003Ek__BackingField = value;
		}
	}

	public int Attack2Hud
	{
		get
		{
			return _003CAttack2Hud_003Ek__BackingField;
		}
		private set
		{
			_003CAttack2Hud_003Ek__BackingField = value;
		}
	}

	public int CombineWeaponHud
	{
		get
		{
			return _003CCombineWeaponHud_003Ek__BackingField;
		}
		private set
		{
			_003CCombineWeaponHud_003Ek__BackingField = value;
		}
	}

	public int SwimmingSurfHud
	{
		get
		{
			return _003CSwimmingSurfHud_003Ek__BackingField;
		}
		private set
		{
			_003CSwimmingSurfHud_003Ek__BackingField = value;
		}
	}

	public int ActionHud
	{
		get
		{
			return _003CActionHud_003Ek__BackingField;
		}
		private set
		{
			_003CActionHud_003Ek__BackingField = value;
		}
	}

	public int TakePhotoHud
	{
		get
		{
			return _003CTakePhotoHud_003Ek__BackingField;
		}
		private set
		{
			_003CTakePhotoHud_003Ek__BackingField = value;
		}
	}

	public int PullThePin
	{
		get
		{
			return _003CPullThePin_003Ek__BackingField;
		}
		private set
		{
			_003CPullThePin_003Ek__BackingField = value;
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

	public UGCCommonHudSwitchControllerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
