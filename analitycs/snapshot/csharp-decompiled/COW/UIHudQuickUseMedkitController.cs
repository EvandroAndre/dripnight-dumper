using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudQuickUseMedkitController : UIBaseController
{
	private enum EQuickUseType
	{
		Medkit,
		Inhaler,
		SuperMedkit,
		PED,
		ShieldRecover
	}

	private enum EIconShowPlayerState : uint
	{
		None = 0u,
		FullHp = 1u,
		FullEp = 2u,
		Dash = 4u
	}

	private class IconPriority
	{
		public List<int> ShowTypes;

		public IconPriority(EQuickUseType type1, EQuickUseType type2, EQuickUseType type3)
		{
		}

		public IconPriority()
		{
		}
	}

	public const uint VISIBILITY_STATE_GB_GPGulag = 1073741824u;

	public static float MedkitMaxDragDis;

	private static float MedkitMaxDragDisSquare;

	private static float MedkitQuickDragDis;

	private static float MedkitQuickDragDisSquare;

	private UIHudQuickUseMedkitView m_View;

	private float m_StartTime;

	private float m_TotalTime;

	private int m_MedkitCount;

	private int m_InhalerCount;

	private int m_ShieldRecoverCount;

	private int m_PEDCount;

	private Player m_LocalPlayer;

	private SafeZone m_SafeZone;

	private bool isPlayerWalking;

	private bool isInSafeZone;

	private bool isPlayerDashing;

	private EQuickUseType showType;

	private const string MEDKIT_ICON_SPRITENAME = "UI_icon_FirstAidKit";

	private const string INHALER_ICON_SPRITENAME = "Icon_HUD_Gold_INHALER_Attachment";

	private bool m_IsPressed;

	private float m_PressTime;

	private Vector3 m_MedkitBtnOriginalPos;

	private Vector3 m_MedkitBtnStartPos;

	private Vector3 m_MedkitBtnPressPos;

	private Vector3 m_CurDirection;

	private Camera m_Camera;

	private bool m_GlobalTouchEnd;

	private Color m_SelectedColor;

	private List<GameObject> m_CircleList;

	private List<CureGearSettingData> m_GearSettingData;

	private List<CureGearSettingData> m_EnumGearSettingData;

	private uint m_ChangeToSuperMedkitDelayCall;

	private uint m_SwitchBetweenShieldRecoverAndMedKitDelayCall;

	private uint m_DelayCallInventoryPickupVFX;

	private float m_lastTime;

	private Dictionary<uint, IconPriority> m_IconPriorityDict;

	private bool CanDriverUseMedkit => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	private void InitSortConfig()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnRouletteUseMedkit(object[] data)
	{
	}

	private void OnBtnQuickUse()
	{
	}

	private void OnBtnQuickUseInside(uint itemUniqueID, uint moveStatus)
	{
	}

	private bool CheckMedkitCanUse(Player player)
	{
		return false;
	}

	private void OnShowedEffect(bool param)
	{
	}

	private void OnInventoryMedkitChanged(int param)
	{
	}

	private void OnInventoryInhalerChanged(object[] param)
	{
	}

	private void OnInventoryShieldRecoverChanged(object[] param)
	{
	}

	private void OnPEDChanged(object[] param)
	{
	}

	private void OnInventoryPickup(object[] param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void OnLocalPlayerPhysicsStateChange(GEvent data)
	{
	}

	private bool CheckToShowUse(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void OnPlayerTryUseItem(object[] param)
	{
	}

	private void OnPlayerCancelUseItem(object[] param)
	{
	}

	private void OnHPChanged(GEvent data)
	{
	}

	private void OnPlayerSPChanged(GEvent data)
	{
	}

	private void OnPlayerEPChanged(GEvent data)
	{
	}

	private void OnSpectatorOBChange(object[] param)
	{
	}

	private void OnSpectatorItemChanged(object[] param)
	{
	}

	private void ShowMedkitTutorial(object[] data)
	{
	}

	private void ShowMedkitTutorialInForceTutorialGame(object[] data)
	{
	}

	private void ShowMedkitDontMoveTutorialInForceTutorialGame(object[] data)
	{
	}

	private void OnGetOnVehicle(object[] param)
	{
	}

	private void OnGetOffVehicle(object[] param)
	{
	}

	private void UpdateIconStatus(Player p)
	{
	}

	private void UpdateUrgencyEffect()
	{
	}

	private void OnTrainingZoneChanged(object[] param)
	{
	}

	private List<int> GetIconShowPriorityList(Player player)
	{
		return null;
	}

	private void RefreshQuickUseIconShow(object[] objs)
	{
	}

	private int GetItemCountByShowType(Player player, EQuickUseType showType)
	{
		return 0;
	}

	private ResourceID GetIconByShowType(Player player, EQuickUseType showType)
	{
		return default(ResourceID);
	}

	private void ShowMedikitOrSuperMedikit(Player player, int superCount, int normalCount)
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	private void ShowRouletteGuide()
	{
	}

	private void RefreshMedkitItemList(object[] data)
	{
	}

	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	private void UpdateRolette()
	{
	}

	private void OnPinMark()
	{
	}

	private void CancelMedKitChangeDelayCall()
	{
	}

	private void CancelSwitchBetweenShieldRecoverAndMedKitDelayCall()
	{
	}

	private void _003COnInventoryPickup_003Eb__52_0()
	{
	}

	private void _003CRefreshQuickUseIconShow_003Eb__77_0()
	{
	}

	private void _003CShowMedikitOrSuperMedikit_003Eb__80_0()
	{
	}

	private void _003CShowMedikitOrSuperMedikit_003Eb__80_1()
	{
	}

	private void _003CShowMedikitOrSuperMedikit_003Eb__80_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
