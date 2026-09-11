using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudMinimapController : UIMapBaseController
{
	private interface IPlayerSprite
	{
		void SetSpriteName(string spriteName);

		void ResetSpriteName();
	}

	private class PlayerSpriteCtrl : IPlayerSprite
	{
		private UISprite m_sprite;

		private string m_defaultSpriteName;

		private GameObject _003CgameObject_003Ek__BackingField;

		public GameObject gameObject
		{
			get
			{
				return _003CgameObject_003Ek__BackingField;
			}
			private set
			{
				_003CgameObject_003Ek__BackingField = value;
			}
		}

		public PlayerSpriteCtrl(GameObject obj)
		{
		}

		public void SetSpriteName(string spriteName)
		{
		}

		public void ResetSpriteName()
		{
		}

		public void SetVisible(bool value)
		{
		}

		public void SetColor(Color color)
		{
		}
	}

	private class FiringEnemyCtrl : PlayerSpriteCtrl
	{
		public float AutoDestroyTime;

		protected GameObject m_obj;

		public GameObject obj => null;

		public FiringEnemyCtrl(GameObject obj)
		{
		}

		public void SetLocalScale(Vector3 fixedScale)
		{
		}

		public void Show(string idString, Vector3 localScale)
		{
		}

		public virtual void Cache()
		{
		}
	}

	private class GrenadeTriggerEnemyCtrl : FiringEnemyCtrl
	{
		public GrenadeTriggerEnemyCtrl(GameObject obj)
		{
		}

		public override void Cache()
		{
		}

		public void _003C_003EiFixBaseProxy_Cache()
		{
		}
	}

	private enum EFirstScalePhase
	{
		Waiting,
		Stable,
		Scaling,
		End
	}

	public enum EMinimapMode
	{
		NorthUp,
		PlayerUp
	}

	public enum EFullEdgeUIFX
	{
		EFullEdgeUIFX_None,
		EFullEdgeUIFX_TreasureHuntUnderTreasury,
		EFullEdgeUIFX_TreasureHuntMap
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GameplayAffixConfigData, int> _003C_003E9__197_0;

		internal int _003CGetGameplayModifierCarouselViewDataList_003Eb__197_0(GameplayAffixConfigData x)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public UIHudMinimapController _003C_003E4__this;

		public Player tar;

		internal void _003COnShowCSGuideMap_003Eb__0()
		{
		}
	}

	public const uint VISIBILITY_STATE_IIV1v1 = 1073741824u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 536870912u;

	private const string MAX_KILLER_SPRITE_NAME = "Minimap_KillKing";

	private const string GAMEPLAY_MODIFIER_CAROUSEL_PROGRESS_ANIM = "UIFX_UIHudGameplayModifierCarouselItem_Loop";

	private UIHudMinimapView m_View;

	private PlayerSpriteCtrl m_localPlayerSpriteCtrl;

	private PlayerSpriteCtrl m_trainingMaxKillPlayerSpriteCtrl;

	private BHGGAEEHJCO m_trainingMaxKiller;

	private Player m_Player;

	private Vector3 m_Center;

	private float OFFSET_SCALE_RATIO_X;

	private Dictionary<BHGGAEEHJCO, GrenadeTriggerEnemyCtrl> m_GrenadeTriggerEnemiesMap;

	private Queue<GrenadeTriggerEnemyCtrl> m_GrenadeTriggerEnemiesCache;

	private Dictionary<uint, List<BHGGAEEHJCO>> m_TeammateVehicleDict;

	private Dictionary<LevelVehicle, SoundTipsView> m_VehicleSoundTipDict;

	private Queue<SoundTipsView> m_SoundTipObjectCache;

	private Dictionary<LevelVehicle, GameObject> m_HelicopterViewDict;

	private Queue<GameObject> m_HelicopterViewCache;

	private SoundTipsData m_VehicleSoundTipsConfig;

	private Dictionary<uint, Dictionary<uint, FiringEnemyCtrl>> m_FiringEnemiesMap;

	private Dictionary<uint, Dictionary<uint, FiringEnemyCtrl>> m_FiringObjectsMap;

	private Dictionary<uint, uint> m_TopAutoDestroyFiringEnemyId;

	private Dictionary<uint, uint> m_TopAutoDestroyFiringObjectId;

	private Queue<FiringEnemyCtrl> m_FiringEnemiesCache;

	private SafeZone m_CurrentSafeZone;

	private AudioResource m_LoopSfx;

	private BitArrayBoolean m_MapContentVisible;

	private const uint VISIBLE_MAPCONTENT_NORMAL = 1u;

	private const uint VISIBLE_MAPCONTENT_PARTYMODE = 2u;

	private const uint VISIBLE_MAPCONTENT_NOSIGNAL = 4u;

	private const uint VISIBLE_MAPCONTENT_KILLCAM = 8u;

	private const uint VISIBLE_MAPCONTENT_FakeMiniMap = 16u;

	private float m_ScaleDest;

	private float m_ScaleDefault;

	private float m_ScaleFixedForExtraMiniMap;

	private float m_PanelWidthToWorldDistance;

	private float m_FirstScale;

	private float m_CurrFirstScaleStableTime;

	private float m_CurrFirstScaleTime;

	private Vector3 m_FirstScaleStartPos;

	private EFirstScalePhase m_FirstScalePhase;

	private bool m_IsPersonalUAVEquipped;

	private bool m_CanDynamicScale;

	private bool m_bIsHideCloseBigMapTips;

	private uint m_InfoBoxNotifyVFXDelayCall;

	private UIHudMetropolisGameTimeController metropolis;

	private VisualInstanceHolder m_GameplayModifierCarouselVfxHolder;

	private Animation m_GameplayModifierCarouselProgressAnim;

	private float m_MiniMapScale;

	private object[] m_CacheData;

	private bool m_IsFirstRandomMove;

	private UIGameMissionMiniInfoController m_MissionInfoController;

	private UIHudMiniMapBottomInfoController m_MiniMapBottomInfoController;

	private Vector3 m_CachedCatapultOffset;

	private bool m_WasInCatapult;

	private float m_TeamScanStartTime;

	private float m_TeamScanNextStartTime;

	private bool m_MapContentShowChanged;

	private UIHudGameplayModifierCarouselItemViewData.Source _003CDisplayedGameplayModifierCarouselState_003Ek__BackingField;

	public static EMinimapMode MinimapMode;

	private bool m_IsPlayerArrowScoutDriving;

	private const string DefaultPlayerArrowName = "UI_minimap_icon_outset";

	private Vector2 DefaultPlayerArrowSize;

	private UIHudEighthMiniMapTrainTipController m_EighthTrainTip;

	private TweenProperty[] m_TweenProperties;

	private CAJFIOIDPKC m_ScanData;

	private UIHudHippoCrisisCountDownController m_HCTimer;

	private uint m_BeMarkedEffectDelayCall;

	private uint m_PainEffectDelayCall;

	private VisualInstanceHolder m_BTUnderwaterMapEffectHolder;

	private uint m_TeamScanDelayCallID;

	private uint m_AutoScrollDelayCallID;

	private List<UISprite> m_TopRightIcons;

	private int m_TopRightIconsIndex;

	private float m_MapScale;

	private Vector3 m_MapIconScale;

	private ResourceID m_CurFakeMiniMapTextureResID;

	private GameObject m_IIVTempleScanRangeObject;

	private GameObject m_IIV1v1RangeObject;

	private float m_IIV1v1Range;

	private VisualInstanceHolder m_FullEdgeUIFXHolder;

	private float m_ScaleDefaultForHomerUAV;

	public UIHudGameplayModifierCarouselItemViewData.Source DisplayedGameplayModifierCarouselState
	{
		get
		{
			return _003CDisplayedGameplayModifierCarouselState_003Ek__BackingField;
		}
		private set
		{
			_003CDisplayedGameplayModifierCarouselState_003Ek__BackingField = value;
		}
	}

	private Dictionary<uint, FiringEnemyCtrl> GetOrCreateFiringEnemiesMap(uint mapType)
	{
		return null;
	}

	private Dictionary<uint, FiringEnemyCtrl> GetOrCreateFiringObjectsMap(uint mapType)
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
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

	private void SetNoSignalState(bool isNoSignal)
	{
	}

	public void SetMapContentVisible(uint flag, bool bVisible)
	{
	}

	private void UIChangeFormWatingToBattle()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ClearHint()
	{
	}

	private void OnMapStateChange(object[] data)
	{
	}

	private void OnSafeZoneChanged()
	{
	}

	private void OnInfoBoxNotify(object[] data)
	{
	}

	private Vector3 GetTargetPostion()
	{
		return default(Vector3);
	}

	private void HideInfoBoxNotifyVFX()
	{
	}

	private void OnShowAirLine(object[] data)
	{
	}

	private void OnHideAirLine(object[] data)
	{
	}

	private void OnShowCSGuideMap(object[] data)
	{
	}

	private void InitUIParams()
	{
	}

	private void InitUIElements()
	{
	}

	protected override void RegisterEvents()
	{
	}

	protected override void UnRegisterEvents()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private bool CanDynamicScale()
	{
		return false;
	}

	private bool GetCanDynamicScale()
	{
		return false;
	}

	private void Update()
	{
	}

	private bool UpdateNeverChangeMiniMapScaling(float angleView)
	{
		return false;
	}

	private bool UpdateMinimapScaling(float angleView)
	{
		return false;
	}

	private void UpdateMiniMapScaleByTimeSpan()
	{
	}

	private void TryLerpMapContentScale(float prevScale, float targetScale, float lerpProgress)
	{
	}

	private float GetTargetScaleByTimeSpan(float defaultScale)
	{
		return 0f;
	}

	private void UpdateMinimapNormally(float angleView)
	{
	}

	private float CalcMinimapScale()
	{
		return 0f;
	}

	private void UpdateHelicopterView()
	{
	}

	private void UpdateVehicleTrackRotation()
	{
	}

	private float GetRotationAngleFromView()
	{
		return 0f;
	}

	private float GetRotationAngleFromPlayer(EMinimapMode minimapMode)
	{
		return 0f;
	}

	private void OnAddLocalPlayer(object[] param)
	{
	}

	private void UpdateLocalScoutDriving()
	{
	}

	private void SetLocalPlayerArrowScoutDriving()
	{
	}

	private void RevertLocalPlayerArrowScoutDriving()
	{
	}

	private void OnLocalTeamChange(object[] param)
	{
	}

	private void OnEighthAllWaveTrainInfoCome(object[] param)
	{
	}

	public void TrackMetropolisArea(uint areaID)
	{
	}

	public void RefreshPlayerArrow()
	{
	}

	private void OnLocalPlayerFactionChange(object[] param)
	{
	}

	private void OnLocalPlayerFinishTeleport(object[] param)
	{
	}

	private void OnBtnZoomClick()
	{
	}

	private void OnRegionRankListClick()
	{
	}

	private void OnUpdateMapMark(object[] param)
	{
	}

	private void OnRemoveMapMark(object[] param)
	{
	}

	private void DestroyGrenadeHint(BHGGAEEHJCO pid)
	{
	}

	private void OnSomeoneTriggerGrenade(object[] param)
	{
	}

	private void AddGrenadeHint(BHGGAEEHJCO pID, Vector3 pos)
	{
	}

	private void OnSomeoneFiring(GEvent param)
	{
	}

	private void OnSomeoneStopFiring(uint param)
	{
	}

	private void OnSomeoneVisibleChanged(object[] param)
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

	private void CheckEnemyFiringAutoDestroy(Dictionary<uint, FiringEnemyCtrl> uiMap, ref uint topId)
	{
	}

	private void CancelAutoDestroyEnemyFiring(Dictionary<uint, FiringEnemyCtrl> uiMap, ref uint topId, uint id)
	{
	}

	private void WhoIsTopAutoDestroyEnemyFiring(Dictionary<uint, FiringEnemyCtrl> uiMap, ref uint topId, uint? newId = null)
	{
	}

	protected override void OnObservePlayer(object[] data)
	{
	}

	private void DestroyFiringEnemyOrObject(Dictionary<uint, FiringEnemyCtrl> map, uint pID)
	{
	}

	public void OnSafeZoneChanged(object[] param)
	{
	}

	private void ShowTutorialMinimap(object[] data)
	{
	}

	private void OnPermanentScan(GEvent data)
	{
	}

	private void HideScanLine()
	{
	}

	private void HideTeamScanLine()
	{
	}

	private void OnTutorialRunTowardsSafezone(object[] data)
	{
	}

	public void OnShowJKPTutorial(object[] param)
	{
	}

	public void OnForecastEffectShow(object[] param)
	{
	}

	public void OnTrainingZoneChange(object[] param)
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void OnGameZoneIndexChanged(object[] data)
	{
	}

	private void OnUpdateMapTexture(object[] data)
	{
	}

	public void ChangeToDefaultMapTexture(object[] data)
	{
	}

	private void OnMinimapModeChange(object[] data)
	{
	}

	protected override void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnHelicopterPassengerChange(object[] data)
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	private void RefreshTeammateVehicleState(List<BHGGAEEHJCO> playerlist, Vehicle vehicle, BHGGAEEHJCO driver_id)
	{
	}

	private void OnTeammateKnockDown(object[] data)
	{
	}

	private void OnTeammateRevive(object[] data)
	{
	}

	private void OnVehicleVisibilityChange(GEvent data)
	{
	}

	private void OnVehicleDead(object[] data)
	{
	}

	private void OnSomeObjectFiring(object[] param)
	{
	}

	private FiringEnemyCtrl CreateEnemyHint(uint id, Vector3 pos, Vector3 forward)
	{
		return null;
	}

	private GrenadeTriggerEnemyCtrl CreateEnemyGrenadeHint(uint id, Vector3 pos)
	{
		return null;
	}

	private void UpdateEnemyHint(FiringEnemyCtrl cloneEnemy, Vector3 pos, Vector3 forward)
	{
	}

	private void OnItemOnHandChanged(object[] data)
	{
	}

	private void RefreshIsPersonalUAVEquipped(NAELPAAELNO newItem)
	{
	}

	private void OnLocalPlayerBeHit(object[] data)
	{
	}

	protected override void OnMapOffsetUpdateCallBack()
	{
	}

	private void OnHippoCrisisPhaseChange(object[] data)
	{
	}

	private void OnTrainingMaxKillChange(object[] data)
	{
	}

	public void OnUsingHotPursuit(List<uint> posList, float radius, uint playerId, float endTime)
	{
	}

	public void OnUsingTelescope(Vector3 pos, float radius, uint playerId, float endTime)
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	private void OnShowInfoBoxShowMapTutorial(object[] data)
	{
	}

	private void OnReceiveQuickChatMsg(object[] data)
	{
	}

	private bool NeedShowOpenTip()
	{
		return false;
	}

	private void OnDetectiveBeMarkedNotify(object[] data)
	{
	}

	private void OnDetectiveMarkEnemyNotify(object[] data)
	{
	}

	private void OnReviveMissionStart(object[] data)
	{
	}

	private void OnReviveMissionEnd(object[] data)
	{
	}

	private void OnSwitchObserver(object[] param)
	{
	}

	private void OnHippoCrisisMissionStart(GEvent data)
	{
	}

	private void OnRefreshBTUnderwaterMap(bool isUnderWater)
	{
	}

	private void OnBeVehicleScan(object[] data)
	{
	}

	private void OnVehicleDriverScan(object[] param)
	{
	}

	private void OnHippoCrisisShowMapGuide(object[] data)
	{
	}

	public Transform GetTopEXUIRoot()
	{
		return null;
	}

	public Transform GetBottomEXUIRoot()
	{
		return null;
	}

	private static List<object> GetGameplayModifierCarouselViewDataList()
	{
		return null;
	}

	private void OnFinishFFWSGuide()
	{
	}

	private IFixTimeCarouselItem GameplayModifierCarouselItemGenerator(Transform carouselContainer)
	{
		return null;
	}

	private void OnGameplayModifierCarouselItemEntered(int viewDataIndex, object viewData)
	{
	}

	private void OnGameplayModifierCarouselVfxAttached(GameObject vfxInstance)
	{
	}

	private bool TryDisplayGameplayModifierCarousel()
	{
		return false;
	}

	private void HideGameplayModifierCarousel(bool cleanDisplayedSourceFlag)
	{
	}

	public void RefreshGameplayModifierCarousel()
	{
	}

	private void TryResumeGameplayModifierCarousel()
	{
	}

	private void ResetGameplayModifierCarouselOnDestroy()
	{
	}

	private void OnTelescopeCountChange(object[] param)
	{
	}

	private void RefreshTelescopeCount()
	{
	}

	private void OnBomberMakerCountChange(object[] param)
	{
	}

	private void RefreshBomberMakerCount()
	{
	}

	private void OnTeamScanChange(object[] param)
	{
	}

	private void OnTeamScanIconChange(object[] param)
	{
	}

	private void OnTeamScanIconCDChange(object[] param)
	{
	}

	private void RefreshTopRightIcons()
	{
	}

	private void OnAutoScrollTopRightIcons()
	{
	}

	private void NotBestPracticeSetMiniMapIconScaleByMapScale(float mapScale, bool force = false)
	{
	}

	private void OnEnterEighthSubGameState(object[] data)
	{
	}

	private void OnLeaveEighthSubGameState(object[] data)
	{
	}

	private void SyncIIVFloatingGameLandState(bool join)
	{
	}

	private void ShowFakeMiniMap(bool isShow, ResourceID resID)
	{
	}

	private void ShowOrHideIIVTempleScanRange(object[] data)
	{
	}

	private void ShowOrHideIIV1v1Range(object[] data)
	{
	}

	private void RefreshIIV1v1Range()
	{
	}

	private void RefreshUIWhenOffsetUpdate()
	{
	}

	public override float GetMapScale()
	{
		return 0f;
	}

	public Vector3 GetMapRightBottomWorldPosition()
	{
		return default(Vector3);
	}

	private void OnShowMinimapFullEdgeUIFX(uint uifxType)
	{
	}

	private void CheckAndInitExtraMiniMap()
	{
	}

	private bool EnableHomerUAVScaleInCSMode(out float scale)
	{
		scale = default(float);
		return false;
	}

	private void UpdateHomerUAVScaleOnlyCSMode()
	{
	}

	private void _003COnDetectiveBeMarkedNotify_003Eb__184_0()
	{
	}

	private void _003COnDetectiveBeMarkedNotify_003Eb__184_1()
	{
	}

	private void _003COnDetectiveMarkEnemyNotify_003Eb__185_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnObservePlayer(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerHPChanged(GEvent P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnMapOffsetUpdateCallBack()
	{
	}

	public float _003C_003EiFixBaseProxy_GetMapScale()
	{
		return 0f;
	}
}
