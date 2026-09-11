using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGrenadeBtnController : UIHudButtonBaseController, INotifyHudConfigChanged
{
	public enum ButtonType
	{
		None,
		Grenade,
		CampFire,
		BuildingIceWall,
		Landmine,
		FlashBomb,
		MiniSentry,
		BuildingBrickBlock,
		WaterBall,
		PaintSprayer,
		Dummy,
		SmokeGrenade,
		Fireworks,
		BigToyGrenade,
		MagneticField,
		PersonalUAV,
		BuildingCraft,
		FrozenGrenade,
		SnowBall,
		FlameFlask,
		SmokeFlask,
		DeIceWall,
		CycloneSmoke,
		JumpPad,
		HandCatapult,
		PersonalShop,
		HealUAV,
		Vehicledrop,
		CreateLootBox,
		LoadoutAirDrop,
		LoadoutGameMission,
		MultiExplosiveGrenade,
		EMPGrenade,
		FireKunai,
		ThunderKunai,
		WindKunai,
		NBGPHiraishin,
		IceWallUAV,
		MapThrower,
		TeamBuffSupporter,
		ReinforcedAnvil,
		PocketRevivePointPlacer,
		DreamlandBoyGrenade,
		Dart,
		ForceFieldGrenade,
		AstrolGatePlacer,
		TeamGather,
		MAX
	}

	public enum EGrenadeType
	{
		None,
		Attack,
		Defence
	}

	public class GrenadeButtonData
	{
		public ButtonType type;

		public int count;

		public int itemtype;

		public GrenadeButtonData(ButtonType t, int c, int it)
		{
		}

		public static string GetSpriteNameByButtonType(ButtonType buttonType)
		{
			return null;
		}
	}

	private class DisableUseState
	{
		public HDAEFOANBGJ Slot;

		public float BanTime;

		public float StartTime;
	}

	public class GrenadeRouletteEvent : GEvent
	{
		public int paramLen;

		public int showType;

		public Vector3 curDirection;

		public void Reset(int paramLen, int showType, Vector3 curDirection)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public Player player;

		public HDAEFOANBGJ slot;

		public bool force;

		public NAELPAAELNO item;

		internal void _003CChangeToSlot_003Eb__0(NAELPAAELNO equipedItem)
		{
		}
	}

	public const uint VISIBILITY_STATE_IIV1v1 = 1073741824u;

	public const uint VISIBILITY_STATE_IIVFloatingLand = 536870912u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 268435456u;

	public const uint VISIBILITY_STATE_CARRY = 134217728u;

	protected UIHudGrenadeBtnView m_View;

	protected ButtonType localPlayer_ButtonType;

	protected ButtonType m_curType;

	protected ButtonType m_RouletteType;

	protected int[] itemCount;

	protected int[] itemType;

	protected Dictionary<int, float> m_LoadoutChargeProgressDic;

	protected float m_InfiniteStartTime;

	protected float m_InfiniteDuration;

	protected uint m_InfiniteVFXHolder;

	protected uint m_PreInfiniteVFXHolder;

	protected uint m_ArrowInfiniteVFXHolder;

	protected uint m_ArrowVerInfiniteVFXHolder;

	protected bool HasShownTutorial;

	protected List<UIHudGrenadeSubBtnController> m_SubBtns;

	private VisualInstanceHolder m_AddIceWallEffectHolder;

	private BitArrayBoolean m_CounterVisible;

	private HashSet<int> m_ForbiddenGrenadeBtnType;

	private const uint CounterVisNormal = 1u;

	private const uint CounterVisButtonType = 2u;

	protected List<GrenadeButtonData> m_SubData;

	protected bool m_ShowSub;

	protected Vector3 m_DefaultPos;

	protected Vector3 m_SpPos;

	protected EGrenadeType m_ButtonType;

	protected int m_HudGrenadeDirection;

	protected int m_HudGrenadeDirection2D;

	protected int m_CustomGrenadeSlot;

	protected const int CyclonesmokeID = 618;

	private UILabel m_HorizonBtnKeyLabel;

	private UILabel m_VerticalBtnKeyLabel;

	protected uint m_VFXReadyDelayCall;

	private Dictionary<uint, DisableUseState> m_DisableUseStates;

	public static float GrenadeMaxDragDis;

	protected static float GrenadeMaxDragDisSquare;

	private static float GreandeQuickDragDis;

	private static float GrenadeQuickDragDisSquare;

	private bool m_IsPressed;

	private float m_PressTime;

	private Vector3 m_GrenadeBtnOriginalPos;

	private Vector3 m_GrenadeBtnStartPos;

	private Vector3 m_GrenadeBtnPressPos;

	private Vector3 m_CurDirection;

	private Camera _camera;

	private bool m_GlobalTouchEnd;

	private List<GameObject> m_CircleListSingle;

	private List<GameObject> m_CircleListDouble;

	private List<bool> m_CircleListBoolean;

	private List<uint> m_CircleListItemIDsSingle;

	private List<uint> m_CircleListFixedItemIDsSingle;

	private List<uint> m_CircleListItemIDsDouble;

	private List<uint> m_CircleListFixedItemIDsDouble;

	private GameObject m_CurrentCircle;

	public static GrenadeRouletteEvent GrenadeRouletteEvt;

	protected ButtonType curType
	{
		get
		{
			return ButtonType.None;
		}
		set
		{
		}
	}

	public EGrenadeType GrenadeType => EGrenadeType.None;

	private Camera m_Camera => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
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

	private void InitIsNewUI()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void RefreshCarryStateVisibility()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void UpdateHudGrenadeDirectionValues()
	{
	}

	private void UpdateCustomGrenadeSlot()
	{
	}

	protected virtual void OnUpdateCustomGrenadeSlot()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public static HDAEFOANBGJ GetSlotType(ButtonType t)
	{
		return HDAEFOANBGJ.PrimaryWeapon1;
	}

	public static ButtonType GetButtonType(HDAEFOANBGJ type)
	{
		return ButtonType.None;
	}

	protected virtual void OnSideWeaponChange(object[] param)
	{
	}

	private void ChangeToSlot(HDAEFOANBGJ slot, bool force = false)
	{
	}

	public void SetGrenadeType(EGrenadeType type)
	{
	}

	protected virtual bool IsDoubleSlotShow()
	{
		return false;
	}

	protected void GenerateSubDatas()
	{
	}

	protected void ShowSubButtons()
	{
	}

	protected void HideSubButtons()
	{
	}

	private void InternalSetSubBtnsVisible(bool isShow)
	{
	}

	protected void ToggleSubBtn()
	{
	}

	protected override void OnBtnClick()
	{
	}

	private bool NeedForceInstant(ButtonType t, bool InSwapWeaponCD)
	{
		return false;
	}

	protected virtual void tryClickPinMark()
	{
	}

	private string OnBotAgentGrenadeGetRuntimeData()
	{
		return null;
	}

	protected void OnArrowClick()
	{
	}

	protected void RefreshArrow()
	{
	}

	protected void OnNewItemOnHand(object[] param)
	{
	}

	public static void GetButtonType(PIJKGPDBNJC itemType, NAELPAAELNO itemOnHand, out ButtonType type, out bool showBtns)
	{
		type = default(ButtonType);
		showBtns = default(bool);
	}

	protected void ProcessNewTypeOnHand(ButtonType type, bool showBtns)
	{
	}

	protected virtual bool NeedHideView(ButtonType tmp, ButtonType hand_type = ButtonType.None)
	{
		return false;
	}

	protected void RefreshButton(bool needFindNext = true)
	{
	}

	private void CheckAttackBtnVisibleInSpectatorView()
	{
	}

	private void OnSpectatorShowTargerPlayerHud(object[] param)
	{
	}

	private void OnSpectatorItemChanged(object[] param)
	{
	}

	protected virtual void OnShowGrenadeTutorialInForceTutorialGame()
	{
	}

	private void ChangeBtnKeyDesc(string keyDesc)
	{
	}

	private void RefershLoadoutItemSprite(AJMGIJJMNAH.PGNLHBOCOJN subtype, float chargeProcess)
	{
	}

	private void UpdateIconAtlas()
	{
	}

	protected virtual ButtonType FindNextType(ButtonType typeidx)
	{
		return ButtonType.None;
	}

	protected void OnTelescopeCountChange(object[] param)
	{
	}

	protected void OnLandmineCountChange(object[] param)
	{
	}

	protected void OnJumpPadCountChange(object[] param)
	{
	}

	protected void OnHandCatapultCountChange(object[] param)
	{
	}

	protected void OnFireworksCountChange(object[] param)
	{
	}

	protected void OnPersonalShopCountChange(object[] param)
	{
	}

	protected void OnMapThrowerCountChange(object[] param)
	{
	}

	protected void OnTeamBuffSupporterCountChange(object[] param)
	{
	}

	protected void OnReinforcedAnvilCountChange(object[] param)
	{
	}

	protected void OnPocketRevivePointPlacerChange(object[] param)
	{
	}

	protected void OnAstrolGatePlacerChange(object[] param)
	{
	}

	private float GetBanDuration(HDAEFOANBGJ slot)
	{
		return 0f;
	}

	private float GetBanStartTime(HDAEFOANBGJ slot)
	{
		return 0f;
	}

	private float GetBanTimeLeft(HDAEFOANBGJ slot, bool considerAll = true)
	{
		return 0f;
	}

	private bool IsBanned()
	{
		return false;
	}

	protected void OnChangeDisableUseStateEnd(object[] param)
	{
	}

	protected void OnChangeDisableUseState(object[] param)
	{
	}

	protected virtual void OnBuildingCountChange(object[] param)
	{
	}

	protected virtual void RefreshAddVfx(ButtonType btype)
	{
	}

	protected void OnMiniSentryCountChange(object[] param)
	{
	}

	protected void OnDummyCountChange(object[] param)
	{
	}

	protected void OnMagneticFieldCountChange(object[] param)
	{
	}

	protected void OnPersonalUAVCountChange(object[] param)
	{
	}

	protected void OnLoadoutCountChange(object[] param)
	{
	}

	protected void OnGrenadeCountChange(object[] param)
	{
	}

	protected void OnLoadoutChargeChange(object[] param)
	{
	}

	protected void ShowTutorial()
	{
	}

	protected void OnDirectionChanged(object[] param)
	{
	}

	protected void OnArrowClicked(object[] param)
	{
	}

	protected void OnGrenadeSlotChanged(object[] param)
	{
	}

	protected bool IsInSlotType(ButtonType type)
	{
		return false;
	}

	private void SetChargeProcessActive(bool visible)
	{
	}

	protected virtual void InitRouletteAwake()
	{
	}

	protected virtual void UpdateAxisTouchingThroughArea()
	{
	}

	protected virtual void ShowRouletteGuide()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	public void ProcessUGCAttackStatus(Player.AALGCBFJHJM status)
	{
	}

	protected virtual void RefreshGrenadeItemList()
	{
	}

	private void OnItemAccountChanged(uint itemID)
	{
	}

	private void AddIceWallEffect()
	{
	}

	private void ResetBooleanCache()
	{
	}

	private void SetFixedCircleActive(uint itemID, int itemCount, GrenadeTypeSettingData settingData, List<GameObject> circleList, int circleIndex, List<uint> itemIds, List<uint> fixedItemIds)
	{
	}

	private void RefreshGrenadeItem(uint itemID)
	{
	}

	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	protected void UpdateDisableUseState()
	{
	}

	protected void UpdateGrenadeRoulette()
	{
	}

	protected virtual void Update()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void ShowOrHideItemCount(bool show, uint flag)
	{
	}

	private void RefreshInfinityIcon()
	{
	}

	protected virtual bool IsInfiniteIceWall()
	{
		return false;
	}

	private bool IsUnlimitedThrowables()
	{
		return false;
	}

	protected virtual void RefershPlayerGrenadeBtn(Player player)
	{
	}

	protected virtual void OnObserverStatusChangeCallback(GEvent data)
	{
	}

	protected bool ObserverIsInSky()
	{
		return false;
	}

	protected void UpdateInfiniteProgress()
	{
	}

	protected virtual void OnStartInfiniteIceWall(GEvent data)
	{
	}

	protected virtual void OnEndInfiniteIceWall()
	{
	}

	protected virtual void OnAddInfiniteGlooWall()
	{
	}

	protected virtual void OnAfterFlyInfiniteGlooWall()
	{
	}

	protected bool CheckInfiniteIceWall()
	{
		return false;
	}

	protected virtual void OnRemoveInfiniteGlooWall()
	{
	}

	protected void RefreshCSSingleSlotVFX()
	{
	}

	public void NotifyHudConfigChanged(HudConfigItem config)
	{
	}

	protected void RefreshCountLabel(ButtonType btnType, int count)
	{
	}

	protected virtual void OnPersonalShopUpgradeBuffChange()
	{
	}

	private void _003COnLoadoutChargeChange_003Eb__115_0()
	{
	}

	private void _003COnAfterFlyInfiniteGlooWall_003Eb__174_0()
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

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}
}
