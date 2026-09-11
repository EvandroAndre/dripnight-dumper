using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Lean.Touch;
using UnityEngine;
using message;

namespace COW;

internal class UIBigMapController : UIMapBaseController
{
	private sealed class _003C_003Ec__DisplayClass223_0
	{
		public uint itemID;

		internal bool _003COnSceneEditRemoveObj_003Eb__0(SceneEditMapIconItemDesc i)
		{
			return false;
		}
	}

	private sealed class _003CShowSafeZoneChooseTutorialLater_003Ed__348 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigMapController _003C_003E4__this;

		public NAHAOFANHDC data;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSafeZoneChooseTutorialLater_003Ed__348(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CShowSafeZoneTutorialLater_003Ed__139 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigMapController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSafeZoneTutorialLater_003Ed__139(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIBigMapViewExt m_View;

	private Player m_Player;

	private AudioResource m_ReviveCountDownAudio;

	public float SIZE_MAPCONTAINER;

	public float SIZE_BIGMAP_X;

	public float SIZE_BIGMAP_Y;

	private float ScreenHeight;

	private float ScreenWidth;

	private Vector2 m_MapCenterScreenPosition;

	public const float MAX_MAP_SCALE = 4f;

	private float m_MaxMapScale;

	public float WheelSensitivity;

	public Camera Camera;

	public float Target;

	public float Minimum;

	public float Maximum;

	public float Dampening;

	private Dictionary<uint, string> m_itemMarkPointCheckLevelObjectTagDic;

	private List<Vector3> m_MapMarkList;

	private EBigMapType m_MapType;

	private EBigMapInteractionMode m_InteractionMode;

	private bool m_IsCatapultIconInited;

	private bool DEBUG_CATAPULT_ON;

	private Vector3 m_OrignalRebornMapEffectScale;

	private bool mShowIconToggleBtn;

	private Color mToggleIconBgColorOn;

	private Color mToggleIconBgColorOff;

	private float mRevivePointEndTime;

	private Dictionary<uint, uint> m_WSMapIconCntMap;

	private List<SceneEditMapIconItemDesc> m_WSMapIconItemLst;

	private Queue<SceneEditMapIconItemDesc> m_WorskShopItemDescCache;

	private bool m_bIsAllowSlider;

	private bool m_bIsDisableTap;

	private UIPetSkillBigMapBtnController m_PetSkillBtnCtrl;

	private UIPetSkillBigMapRangeController m_inputMapRangeCtrl;

	private UIGameBigMapSafeZoneChooseBtnController m_SafeZoneChoose;

	private UIGameSafeZoneChooseRangeController m_SafeZoneChooseRange;

	private UIHudMetropolisMapAreaController m_MetropolisArea;

	private UIGameMissionController m_GameMissionController;

	private UIHudMapAstrolGateTipsController m_AstrolGateTipsController;

	private UIHudMapAstrolGateButtonsController m_AstrolGateButtonController;

	private bool m_IsInRevival;

	private ulong m_PendingTime;

	private bool m_ScanPointSelected;

	private Vector3 m_SelectPoint;

	private bool m_LackToken;

	private uint m_RadarID;

	private int m_ScanSize;

	private float m_LastClickRadarRefreshTime;

	private bool m_UseForRadar;

	private EEKJJAMLGEO m_CurState;

	private bool m_bMapScaleChangeMove;

	private float m_lastReviveSelectTime;

	private bool m_CanOpen;

	private GameObject m_RankingGameTips;

	private ResourceID m_RankingGameTipsRes;

	private string m_ZoneName;

	private ResourceID m_ZoneResId;

	private ulong m_BigMapOpenTs;

	private ulong m_LastGCTime;

	private UIHudActionController m_JumpController;

	private int BigMapGCInterval;

	private bool m_HasBomberMakerHintPlayed;

	private uint m_uDelayHideAirLine;

	private GameObject m_FloatingLandMap;

	private Vector3 m_FloatingLandCenter;

	private Dictionary<uint, UIHudShibuya_GP_DoorIconController> m_IIVTeleportDoorIcons;

	private Dictionary<BHGGAEEHJCO, UIHudPlayerMarkController> m_FloatingLandTeammateMapMarkDict;

	private UIHudPlayerMarkController m_FloatingLandLocalMapMarkController;

	private const float BIG_MAP_MARK_SCALE = 0.75f;

	private const int ZoomStep = 9;

	private float m_fOpenMapTimer;

	private float m_MapOpenRealTime;

	private const string mc_strMapCloseTutoKey = "ShowedMapCloseTuto{0}";

	private UIHudMarkDetailPopOverController m_UIHudMarkDetailPopOverController;

	private List<LeanFinger> m_setCache;

	private Dictionary<int, LeanFinger> m_dicLastFinger;

	private Dictionary<int, LeanFinger> m_dicCacheFinger;

	private bool m_bIsFirstFrameSkipGesture;

	private bool m_bIsOpenMapFingerDownSkip;

	private int lastReviveTime;

	private bool m_BigMapChooseGuide;

	private bool m_HasShowedSFRoleplayTip;

	private uint m_SFRoleplayTipDelayID;

	private GameObject m_SFRoleplayTip;

	private bool m_HasShowedDiwali25GPCabinTip;

	private bool m_HasShowedDiwali25GPInGameDarkCircleTips;

	private uint m_Diwali25GPCabinTipsDelayID;

	private bool m_HasShowedDiwali25GPLotusLampEffect;

	private bool m_HasShowedDiwali25GPDarkCircleEffect;

	private GameObject m_DiwaliLotusLampLightUpSound;

	private uint m_GameplayOpenBit;

	private uint m_GameplayDelayID;

	private GameObject m_GameplayShowObject;

	private ResourceID m_GamePlayResID;

	private uint m_useTeleScopeId;

	private bool m_NeedClearAstrolGateInfo;

	private uint m_AstrolGateRangeUIFXHandle;

	private uint m_AstrolGateTeleportUIFXHandle;

	private float m_StartTipsTime;

	private float m_EndTipsTime;

	private UIHudMapThrowerDescWndController m_MapThrowerDescWndCtrl;

	private UIHudMapLoadoutTipsController m_MapLoadoutTipsCtrl;

	private UIHudFocusMapController m_MapThrowerFocusMapCtrl;

	private VisualInstanceHolder m_MapThrowerConfirmBtnUIFX;

	private bool m_MapThrowerSelect;

	private Vector3 m_MapThrowerPosition;

	private uint m_MapThrowerItemId;

	private uint m_BomberMakerItemID;

	private List<uint> m_BomberMakerItemIDs;

	private UIHudMapBomberMakerBtnController m_BomberMakerBtnCtrl;

	private UIHudMapBomberMakerConfirmBtnController m_BomberMakerConfirmBtnCtrl;

	private UIHudMapBomberMakerRangeController m_inputBomberMakerRangeCtrl;

	private void RefreshAllowSliderState()
	{
	}

	private bool IsCloseMissionNode()
	{
		return false;
	}

	public List<Vector3> getMapMarks()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	protected override void OnMapOffsetUpdateCallBack()
	{
	}

	private void InitAirLine()
	{
	}

	protected override void OnUIDestory()
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

	public void UpdateFloatingLandMapCenter(Vector3 pos)
	{
	}

	public Vector3 GetFloatingLandMapCenter()
	{
		return default(Vector3);
	}

	public Vector3 FloatingLandProjectToWorldOffset(Vector2 pos2D)
	{
		return default(Vector3);
	}

	public Vector2 ProjectToFloatingLandMapOffsetUnlimited(Vector2 pos2D)
	{
		return default(Vector2);
	}

	private void RefreshFloatingLandMap(object[] param)
	{
	}

	private void RefreshPlayerArrow()
	{
	}

	private void UpdateFloatingLandArrow()
	{
	}

	public bool TryCheckClickIIVTeleportDoor(Vector3 position, out Vector3 transformPos)
	{
		transformPos = default(Vector3);
		return false;
	}

	private void OnIIVTeleportDoorChanged(GEvent data)
	{
	}

	public bool IsFloatingLandMap()
	{
		return false;
	}

	public void UpdateFloatingLandTeamMapMark(uint playerIDInt, int teamIndex, uint posType, bool hasMark, short posX, short posY, Vector3 realPos)
	{
	}

	private void UpdateFloatingLandLocalMark(uint posType, Vector3 realPos)
	{
	}

	private void UpdateBigMapGuideToMark()
	{
	}

	public void FloatingLandLocalMark()
	{
	}

	private void OnShowAirLine(object[] data)
	{
	}

	private void OnUIChangeFromWaitingToBattle()
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OnQuitRevive(object[] data)
	{
	}

	private void OnRevivePosSyncLocalPlayer(object[] data)
	{
	}

	private void OnReviveSend()
	{
	}

	private void DisableReviveSend()
	{
	}

	private void FateRandomCloseCountDown()
	{
	}

	private void OnPlayerKnockDown(object[] data)
	{
	}

	private bool CheckCanEscape()
	{
		return false;
	}

	private void OnFateRandomStartFight(object[] data)
	{
	}

	private void ShowFateRandomTeamZone(object[] data)
	{
	}

	private void ShowCloseBigMapTutorial(object[] data)
	{
	}

	private void ShowHippoCrisisTutorialBigMapTutorial(bool b)
	{
	}

	private void OnAddDetector(object[] data)
	{
	}

	public void OnUsingHotPursuit(List<uint> posList, float radius, uint playerId, float endTime, bool needTween = false)
	{
	}

	public void OnUsingTelescope(Vector3 pos, float radius, uint playerId, float endTime)
	{
	}

	protected override void UnRegisterEvents()
	{
	}

	private void ShowRankingGameTips()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void OnBtnSwitchToggleClick()
	{
	}

	private void OnBtnMarkSelfClick()
	{
	}

	private void DeleteMark()
	{
	}

	private void OnBtnDeleteMarkClick()
	{
	}

	private void OnBtnZoomInClick()
	{
	}

	private void OnBtnZoomOutClick()
	{
	}

	private void OnSliderChange()
	{
	}

	public void RefreshNewTagWhenSliderChange()
	{
	}

	public void SetMapScale(float scale)
	{
	}

	public bool GetBigMapActive()
	{
		return false;
	}

	public void SetBigMapActive(bool b)
	{
	}

	public void SetBigMapTips(string key = "")
	{
	}

	private void SetLeftInputCheckDisableInputInfo(int fingIndex, Vector2 rawPosition)
	{
	}

	private void SetLeftInputCheckDisableInput(bool b)
	{
	}

	private void SetRightInputCheckUpperPanel(bool b)
	{
	}

	private void RefreshLabel()
	{
	}

	private void OnUpdateMapTexture(object[] data)
	{
	}

	public void ChangeToDefaultMapTexture(object[] data)
	{
	}

	private IEnumerator ShowSafeZoneTutorialLater()
	{
		return null;
	}

	private void UpdateSideGameMissionTabsWhenOpenMap()
	{
	}

	private void OnShowMap()
	{
	}

	private void OnHideMap()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ShowTutorialMapClose()
	{
	}

	private void ShowedMapCloseTuto()
	{
	}

	private bool IsTutorialMapCloseAvailable()
	{
		return false;
	}

	private void OnBtnReviveFateRandom()
	{
	}

	private void OnBtnRevive()
	{
	}

	private void OnBtnQuitRevive()
	{
	}

	private bool IsOutsideSafeZone(Vector3 pos, bool project)
	{
		return false;
	}

	private void WarnInvalidRevivePos()
	{
	}

	private void OnFateRandomCountDownFinished()
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void StopReviveCoundDownSound()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	private void OnAddLocalPlayer(object[] param)
	{
	}

	public bool AddMarkOnMap(LeanFinger finger, bool checkWithinSafeZone, OPICPDCLKAG levelObjectType, bool useObjectPos, Vector3 fixedObjectPos, uint levelObjectID, bool clickedBloodmoonCircle = false)
	{
		return false;
	}

	public bool AddMarkOnMapWithLocalPosition(Vector3 mapLocalPosition, OPICPDCLKAG levelObjectType, uint levelObjectID, bool ignoreCD = false, bool needSendChat = true, bool completeBRTutorialTask = true, bool clickedBloodmoonCircle = false)
	{
		return false;
	}

	private void CompleteBRTutorialMapMarkTask(EILKGGIDJEH markPointType)
	{
	}

	private void ShowMarkDetailPop(EILKGGIDJEH type, uint levelId)
	{
	}

	private void OnShowScenesForCabinePhase(object[] data)
	{
	}

	private void UpdateLocalMark(Vector3 p, uint posType, Vector3 realPos, bool isReSetY = true, uint levelObjectID = 0u, bool needSendChat = true, bool playMarkSound = true)
	{
	}

	private void UpdateLocalAssistMark(Vector3 realPos, uint posType)
	{
	}

	private void OnAssistantMarkRemoved(object[] data)
	{
	}

	private void OnAddLocalAssistantMark(object[] data)
	{
	}

	public void RemoveMarkOnMap()
	{
	}

	protected override void OnPlayerHPChanged(GEvent data)
	{
	}

	public void SyncTeammateMapMark(object[] data)
	{
	}

	private Vector3 ShowAssistantMarkForMapMarkSelf(Player targetPlayer, Vector3 realPos, uint posType = 0u, uint levelObjectID = 0u, bool needSendChat = true, bool playMarkSound = true)
	{
		return default(Vector3);
	}

	private Vector3 ShowAssistantMarkForMapMark(Player targetPlayer, float posX, float posY, uint posType = 0u, uint levelObjectID = 0u, bool needSendChat = true, bool playMarkSound = true)
	{
		return default(Vector3);
	}

	private bool TryGetReviveBoxPosition(uint levelObjectID, out Vector3 position)
	{
		position = default(Vector3);
		return false;
	}

	private bool IsTechBuildLevelobject(uint type)
	{
		return false;
	}

	private Vector3 ShowObserverMarkForMapMark(PHLHIEGPMMK targetObserver, float posX, float posY, uint posType = 0u, bool needSendChat = true, bool playMarkSound = true)
	{
		return default(Vector3);
	}

	private void RemoveAssistantMarkForMapMark(Player targetPlayer)
	{
	}

	private void RemoveObserverMarkForMapMark(BHGGAEEHJCO targetObserverID)
	{
	}

	private void OnTeamInfoGet(object[] data)
	{
	}

	private void OnLocalTeamChange(object[] data)
	{
	}

	private void RefreshMarksForLocalTeamChanged(List<KMGBNNHDOHF> teamMateList)
	{
	}

	private void SyncTeamateState(object[] data)
	{
	}

	private void SendMapMarkChangedByMarkSelf(bool playMarkSound = true)
	{
	}

	private void SendMapMarkChanged(Vector3 realPos, bool isDel, EILKGGIDJEH pointType = EILKGGIDJEH.EItemMarkPointType_Location, uint levelObjectID = 0u, bool playMarkSound = true)
	{
	}

	private void SendMapMarkChanged(Vector3 localPos, uint posType, bool playMarkSound = true)
	{
	}

	private bool IgnoreEvents(LeanFinger finger)
	{
		return false;
	}

	private static bool TapDuringLocalPlayerNotFound(out bool localObserverMarkInCD, out float localObserverMarkLastTime)
	{
		localObserverMarkInCD = default(bool);
		localObserverMarkLastTime = default(float);
		return false;
	}

	private static bool TryFindMarkedObjectWithPoint(UIMapContentController mapContentCtrl, UIBigMapController bigMapCtrl, Vector3 worldPoint, out Vector3 objectPos, out OPICPDCLKAG clickObjectType, ref uint levelObjectID, out bool isBloodmoonCircle)
	{
		objectPos = default(Vector3);
		clickObjectType = default(OPICPDCLKAG);
		isBloodmoonCircle = default(bool);
		return false;
	}

	private void TapDuringDefaultMode(LeanFinger finger)
	{
	}

	public void SimulateTapDuringDefaultMode(Vector3 mapPanelLocalPos)
	{
	}

	public void OnTap(LeanFinger finger)
	{
	}

	private bool CheckSafeZoneChoosePosValid(Vector3 pos)
	{
		return false;
	}

	private bool AddFateRandomReviveMark(LeanFinger finger)
	{
		return false;
	}

	private void SendFateRandomReviveMarkPosToServer(Vector3 pos)
	{
	}

	public void FingerSet(LeanFinger finger)
	{
	}

	public void OnGesture(List<LeanFinger> fingers)
	{
	}

	private void OnFingerDown(LeanFinger finger)
	{
	}

	public void FingerDown(LeanFinger finger)
	{
	}

	private void OnEnableBigMap(GEvent eventData)
	{
	}

	private void InitCatapultIconForDebugUsageLegacy()
	{
	}

	private List<HENEHAGJCLI> GetUsingWeaponsList(List<int> unUsedList)
	{
		return null;
	}

	private void UpdateUIForCurrentAttachments(object[] param)
	{
	}

	private bool IsMapTouched(LeanFinger fingerInfo)
	{
		return false;
	}

	private bool IsMapTouched(Vector2 pos)
	{
		return false;
	}

	private Vector3 ScreenToLocalPosition(Vector2 pos)
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	private void UpdateRevivePointLeftTime(int leftTime)
	{
	}

	protected override void OnObservePlayer(object[] data)
	{
	}

	private void OnJumpActionEnter(int data, int data2)
	{
	}

	private void OnJumpActionEnd()
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	private void OnShowIconToggle(object[] data)
	{
	}

	private void OnRevivePointEndTimeRefresh(object[] data)
	{
	}

	private void OnSceneEditUpdateBigMapIconDesc(object[] data)
	{
	}

	private void OnSceneEditAddObj(uint itemID)
	{
	}

	private void OnSceneEditRemoveObj(uint itemID)
	{
	}

	private void SortSceneEditItemIconDesc()
	{
	}

	private void OnWorkShopSceneRefresh(object[] data)
	{
	}

	private void OnBtnToggleShopIcon()
	{
	}

	private void OnBtnToggleAirLine()
	{
	}

	private void OnBtnToggleRevivePointIcon()
	{
	}

	public void ActiveWereWolvesTip(bool isWolf)
	{
	}

	private void ShowRadarInfo(object[] data)
	{
	}

	private void ShowRadarSelectGuide()
	{
	}

	public void RefreshRadarInfo(uint radarID)
	{
	}

	private void HideHotPursuitTween()
	{
	}

	private void HideRadarInfo()
	{
	}

	private void OnBtnRadarClick()
	{
	}

	private void OnBtnRadarRefreshClick()
	{
	}

	private void OnRadarRefresh(object[] data)
	{
	}

	public bool NeedShowOpenTip()
	{
		return false;
	}

	public bool CanOpen()
	{
		return false;
	}

	private void OnSelectMetropolisAreaOnMap(object[] param)
	{
	}

	public void TrackMetropolisArea(uint areaID)
	{
	}

	public void OnBeVehicleScan(object[] param)
	{
	}

	private void OnVehicleDriverScan(object[] param)
	{
	}

	public void InitBigMapByUGCArea(float scale, Vector3 center)
	{
	}

	public void InitHippoCrisisBigMap()
	{
	}

	private void OnMapLegendChange(object[] data)
	{
	}

	public void ShowCabinMapObj(PHEPNBFBLBG info)
	{
	}

	public bool IsUsingSafeZoneChoose()
	{
		return false;
	}

	public override float GetMapScale()
	{
		return 0f;
	}

	public void CloseBigMap()
	{
	}

	private void OnAstrolGatePreparationCancelByMove()
	{
	}

	private void PlaySharedEnterInteractionModeVfx()
	{
	}

	private void HideSharedEnterInteractionModeVfx()
	{
	}

	private void PlayBomberMakerEnterInteractionModeVfx()
	{
	}

	private void HideBomberMakerEnterInteractionModeVfx()
	{
	}

	private void OnTeamScanChange(object[] param)
	{
	}

	private void ShowAllKindsOfGamePlayTips()
	{
	}

	private void HideAllKindsOfGamePlayTips(bool cleanupOnDestroy)
	{
	}

	private void ResetGamePlayTipsRelatedFields()
	{
	}

	private void ShowSFRoleplayTip()
	{
	}

	private void HideSFRoleplayTip()
	{
	}

	private void ChangeShowLotusLampOpenEffect(bool state)
	{
	}

	private void HideDiwali25GPCabinTip(bool needHideWeakEffect = false)
	{
	}

	private void ShowNormalCabinGameplayTip()
	{
	}

	private ResourceID GetCurrentShowGameplayTipRes()
	{
		return default(ResourceID);
	}

	private void HideNormalGameplayTip()
	{
	}

	private void ResetNormalGameplayTipFields()
	{
	}

	private void RemoveShowObj()
	{
	}

	private void GotoInteractionMode(EBigMapInteractionMode interactionMode)
	{
	}

	private void IgnoreTapEventsOnInteractionModeEnter(EBigMapInteractionMode interactionMode)
	{
	}

	private void EnterInteractionMode(EBigMapInteractionMode interactionMode)
	{
	}

	private void ExitInteractionMode(EBigMapInteractionMode interactionMode)
	{
	}

	private void UpdateDuringInteractionMode(EBigMapInteractionMode interactionMode)
	{
	}

	private void OnDefaultInteractionModeEnter()
	{
	}

	private void OnDefaultInteractionModeExit()
	{
	}

	private void RefreshMarkBtnByPlayerState()
	{
	}

	private void HideDefaultMarkButtons()
	{
	}

	private void SetupReviveRelatedContentBigHeadMode()
	{
	}

	private void SetupReviveRelatedContentFateRandomMode()
	{
	}

	private void SetupReviveRelatedContentMetropolisMode()
	{
	}

	private void UpdateReviveRelatedBigMapContent()
	{
	}

	private void HideReviveRelatedBigMapContent()
	{
	}

	private void UpdateTelescopeInteractionModeEntrance()
	{
	}

	private void HideTelescopeInteractionModeEntrance()
	{
	}

	private void UpdateRoutePlanningModeEntrance()
	{
	}

	private void HideRoutePlanningModeEntrance()
	{
	}

	private void UpdateOtherInteractionModesEntrances()
	{
	}

	private void HideOtherInteractionModesEntrances()
	{
	}

	private void OnDefaultInteractionModeEnterShowMapContentView()
	{
	}

	private void OnTelescopeInteractionModeEnter()
	{
	}

	private void OnTelescopeInteractionModeExit()
	{
	}

	private void TapDuringTelescopeMode(Vector3 pos)
	{
	}

	private void OnPetSkillTeleScopeChoosePosition()
	{
	}

	private void OnPetSkillTeleScopeCancel()
	{
	}

	private void OnPetSkillTeleScopeConfirm()
	{
	}

	private void SetUseTeleScopeTipsEnable(bool b)
	{
	}

	private void OnTelescopeCountChange(object[] param)
	{
	}

	private LevelAstrolGate GetCurrentAstrolGate()
	{
		return null;
	}

	private void OnAstrolGateInteractionModeEnter()
	{
	}

	private void ShowAstrolGateRangeUIFX()
	{
	}

	private void OnAstrolGateRangeUIFXLoaded(uint uniqueID, ResourceID vfxResID, GameObject instance)
	{
	}

	private void ReleaseAstrolGateRangeUIFX()
	{
	}

	private void OnAstrolGateInteractionModeExit()
	{
	}

	private void TapDuringAstrolGateMode(Vector3 pos)
	{
	}

	private Vector3 ClampMapPosToAstrolGateTeleportRadius(Vector3 mapLocalPos)
	{
		return default(Vector3);
	}

	private void UpdateAstrolGateSelectionState(Vector3 mapLocalPos)
	{
	}

	private void OnMapAstrolGateSelectWndDragDrop(uint type)
	{
	}

	private void AdjustAstrolGateSelectWnd()
	{
	}

	private void ShowAstrolGateUI(bool showButtons, OONOIDNLCFF state)
	{
	}

	private void UpdateAstrolGateTips(OONOIDNLCFF state)
	{
	}

	public bool TryGetAstrolGateSelectionWorldPos(out Vector3 worldPos)
	{
		worldPos = default(Vector3);
		return false;
	}

	private void ShowAstrolGateButtons()
	{
	}

	private void HideAstrolGateUI()
	{
	}

	private void OnAstrolGateTeleportInteractionModeEnter()
	{
	}

	private void OnAstrolGateTeleportInteractionModeExit()
	{
	}

	private void TryLoadAstrolGateTeleportUIFX(LevelAstrolGate astrolGate)
	{
	}

	private void ReleaseAstrolGateTeleportUIFX()
	{
	}

	private void OnAstrolGateNearEnd(int astrolGateID)
	{
	}

	private void OnChooseSafeZoneInteractionModeEnter()
	{
	}

	private void OnChooseSafeZoneInteractionModeExit()
	{
	}

	private void UpdateChooseSafeZoneInteractionMode()
	{
	}

	private void TapDuringChooseSafeZoneMode(Vector3 mapLocalPosition)
	{
	}

	private void ShowSafeZoneChooseBtns(uint levelObjectID)
	{
	}

	private void ShowSafeZoneRange(NAHAOFANHDC data)
	{
	}

	private void SetMapPanelToChooseSafeZoneScale(float scalingFactor)
	{
	}

	private void SetChooseSafeZoneTipsEnable(bool enable)
	{
	}

	private void TryShowSafeZoneControllerTutorial(NAHAOFANHDC data)
	{
	}

	private IEnumerator ShowSafeZoneChooseTutorialLater(NAHAOFANHDC data)
	{
		return null;
	}

	private void OnSafeZoneChooseCancel()
	{
	}

	private void OnSafeZoneChooseConfirmed()
	{
	}

	private void OnRoutePlanningInteractionModeEnter()
	{
	}

	private void OnRoutePlanningInteractionModeExit()
	{
	}

	private bool RoutePlanningModeCooldownCheck()
	{
		return false;
	}

	private void TapDuringRoutePlanningMode(Vector3 mapLocalPosition)
	{
	}

	private void TrySimulateTapAndMarkingOnRoutePlanningExit()
	{
	}

	private void OnRoutePlanningInteractionModeEntryBtnClick()
	{
	}

	private void OnRoutePlanningInteractionModeExitBtnClick()
	{
	}

	private void OnRoutePlanningInteractionRemoveLastBtnClick()
	{
	}

	private void OnRoutePlanningInteractionRemoveAllBtnClick()
	{
	}

	private void OnMapThrowerInteractionModeEnter()
	{
	}

	private void OnMapThrowerDescItemClick(uint itemIndex)
	{
	}

	private void OnMapThrowerSelectItemClick(Vector3 pos, uint itemIndex)
	{
	}

	private void FingerDownDuringMapThrower(Vector3 pos)
	{
	}

	private void OnMapThrowerRecommendBtnClick()
	{
	}

	private void OnMapThrowerConfirmBtnClick()
	{
	}

	private void OnMapThrowerSelectWndDragDrop(uint type)
	{
	}

	private void OnMapThrowerInteractionModeExit()
	{
	}

	private void AdjustMapThrowerSelectWnd()
	{
	}

	private void UpdateMapThrowerPosition(Vector3 localPos)
	{
	}

	public void ShowMapThrowerSuccessTips(uint itemId)
	{
	}

	private void RefreshMapThrowerBtn(bool showMapThrowerBtn, bool showMapThrowerConfirmBtn)
	{
	}

	private void OnBomberMakerCountChange(object[] param)
	{
	}

	private void OnAstrolGateStateSelected(int astrolGateID)
	{
	}

	private void UpdateBomberMakerInteractionModeEntrance()
	{
	}

	private void HideBomberMakerInteractionModeEntrance()
	{
	}

	private void OnBomberMakerInteractionModeEnter()
	{
	}

	private void OnBomberMakerInteractionModeExit()
	{
	}

	private void TapDuringBomberMakerMode(Vector3 pos)
	{
	}

	private void OnBomberMakerChoosePosition()
	{
	}

	private void OnBomberMakerConfirm(bool isSuccess)
	{
	}

	private void OnBomberMakerCancel()
	{
	}

	private void _003COnUIReInit_003Eb__70_0(GameObject go)
	{
	}

	private void _003COnUIReInit_003Eb__70_1(GameObject go)
	{
	}

	private void _003CInitAirLine_003Eb__72_0()
	{
	}

	private void _003COnShowAirLine_003Eb__98_0()
	{
	}

	private void _003COnShowMap_003Eb__141_0()
	{
	}

	private void _003COnVisibilityChanged_003Eb__144_0()
	{
	}

	private void _003CIgnoreTapEventsOnInteractionModeEnter_003Eb__284_0()
	{
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

	public void _003C_003EiFixBaseProxy_OnMapOffsetUpdateCallBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerHPChanged(GEvent P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnObservePlayer(object[] P0)
	{
	}

	public float _003C_003EiFixBaseProxy_GetMapScale()
	{
		return 0f;
	}
}
