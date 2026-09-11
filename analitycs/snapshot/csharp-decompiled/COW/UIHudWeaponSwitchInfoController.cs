using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudWeaponSwitchInfoController : UIBaseController
{
	public UIHudWeaponSwitchInfoView m_View;

	private HDAEFOANBGJ m_EquipSlot;

	private int m_LastAmmoCapacity;

	private int m_LastAmmoLeft;

	private int m_LastAmmoLeftInClip;

	private int m_LastAmmoLeftInBag;

	private bool m_LastComine;

	private NAELPAAELNO m_LastWeaponItem;

	private bool m_LastCombined;

	private float m_QTEEndTime;

	private UILabel m_MaxAmmo;

	private UISprite m_InfiniteAmmo;

	private UIProgressBar m_AmmonStatusBar;

	private StringBuilder m_Sb;

	private GameObject m_FXLevelUpGold;

	private float m_FXLevelUpOrDownLastTime;

	private float m_FXLevelUpEndTime;

	private float m_FXLevelDownEndTime;

	private CommonParticleEffect m_FXLevelUp;

	private CommonParticleEffect m_FXLevelDown;

	private uint m_FXLevelUpLoadTicket;

	private const string m_CombineIcon = "UI_Icon_Double_Weapon_Dissolve_mini";

	private const string m_CombineIconHighLight = "UI_Icon_Double_Weapon_mini";

	private Quaternion NormalPrimaryIconRot;

	private Quaternion CombinedPrimaryIconRot;

	private Color m_MeleeIconInitColor;

	public static Color COLOR_GREY;

	private int m_LastShieldHP;

	public bool ShowEighthInfiniteEffect;

	private bool m_ShowAwakeIcon;

	private bool m_ShowTermIcon;

	private bool m_ShowSpecialWeponIcon;

	private uint m_CloseCombineSpriteDelayCall;

	private bool m_CombineStateChanged;

	private bool m_CanCombine;

	private bool m_CanThisWeaponCombine;

	private bool m_CombineMachineEffectiveTrigger;

	public Action<HDAEFOANBGJ> OnPinMarkCallBack;

	private int m_LastShowLevel;

	private ResourceID m_LastShowLevelResID;

	private List<UISprite> m_CustomLevelList;

	private uint m_ReinforceAnimEffectHideDelayID;

	public HDAEFOANBGJ EquipSlot
	{
		get
		{
			return HDAEFOANBGJ.PrimaryWeapon1;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void Start()
	{
	}

	protected override void Awake()
	{
	}

	private void SetGameObjectActive(VFXCreateHelper go, bool flag)
	{
	}

	private void ClearAwakeWeaponIconMaterials()
	{
	}

	private void RefreshAwakeWeaponIconMaterials(UISprite showIcon, bool showAwakeMaterial)
	{
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private string OnBotAgentGetRunTimeData()
	{
		return null;
	}

	private void ShowLevelUpGoldFX(bool show)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public FDAEPHMIEPC GetCurrentWeapon()
	{
		return null;
	}

	private void OnMsgReplacerRes(object[] param)
	{
	}

	public void ResetUI()
	{
	}

	private void SetLevelEffect(FDAEPHMIEPC weapon)
	{
	}

	private void SetTermIcon(FDAEPHMIEPC curWeapon)
	{
	}

	private void Update()
	{
	}

	private void UpdateInterval()
	{
	}

	public UIButton GetTutorialBtn()
	{
		return null;
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	public void ShowGoldLevelup()
	{
	}

	public void ShowLevelUp()
	{
	}

	public void ShowLevelDown()
	{
	}

	private CommonParticleEffect InitLevelUpOrDownEffect(GameObject go)
	{
		return null;
	}

	private void LoadLevelUpEffectAsync()
	{
	}

	private void CancelLevelUpEffectAsync()
	{
	}

	private void OnLevelUpEffectLoaded(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	private void ShowLevelUpOrDownEffect(bool isUp, bool show)
	{
	}

	private void UpdateLevelUpOrDownEffectHiding()
	{
	}

	private void SetDefaultIcon()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCombineMachineChange(bool param)
	{
	}

	private void CloseCombineSpriteEffect()
	{
	}

	private void OnCanCombineChanged(object[] param)
	{
	}

	private void OnCombineMachineEffective(object[] param)
	{
	}

	private void OnSwitchWeaponClick()
	{
	}

	public void SwitchWeapon()
	{
	}

	public void RegisterWeaponSlotHighlight(bool register)
	{
	}

	private KLDGLAFFLNJ GetHighlightTypeForSlot()
	{
		return KLDGLAFFLNJ.EAIUIHighLight_None;
	}

	private void OnPinMark()
	{
	}

	private void RefreshWeaponCustomLevel(int showLevel, ResourceID showResID)
	{
	}

	private void ClearCustomLevel()
	{
	}

	private void OnEighthShowInfiniteItemRewardFlyEnd(object[] param)
	{
	}

	private void RefreshEighthBg()
	{
	}

	public void InitEighthBg(bool clearFlag = true)
	{
	}

	private void RefreshShowEighthInfiniteEffect()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnWeaponReinforced(uint uniqueID)
	{
	}

	private void OnWeaponReinforcedEffect(uint uniqueID)
	{
	}

	private void TryStopAndHideReinforceAnimEffect()
	{
	}

	private void OnLocalPlayerBeHit(object[] data)
	{
	}

	private void _003COnWeaponReinforcedEffect_003Eb__95_0()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
