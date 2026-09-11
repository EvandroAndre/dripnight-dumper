using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Lean.Touch;
using UnityEngine;
using tcp;

namespace COW;

internal class UILobbySocialAreaScene : UIFrontEndScene, IUIModelDataChangeObserver
{
	private enum EBillboardMVPDataSource
	{
		AddPlayer,
		GroupJoin
	}

	private sealed class _003C_003Ec__DisplayClass157_0
	{
		public UILobbySocialAreaScene _003C_003E4__this;

		public float duration;

		internal void _003COnLocalPlayerHorizontalMovingStateChanged_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public Vector3 localPos;

		internal int _003CRefreshDisplayNameHuds_003Eb__0(Player a, Player b)
		{
			return 0;
		}
	}

	private sealed class _003CDelayShowAvatarAndPlayMvpAnim_003Ed__233 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbySocialAreaScene _003C_003E4__this;

		public bool isFemale;

		public uint groupAnimId;

		public GameObject mvpCameraOB;

		public ResourceID playerAnimID;

		public ResourceID soundAnimID;

		public ResourceID freezzIdleAnimId;

		private uint _003CmaxFrameToWait_003E5__2;

		private int _003CcurrentFrame_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowAvatarAndPlayMvpAnim_003Ed__233(int _003C_003E1__state)
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

	private const uint VISIBILITY_STATE_IMMERSIVE_HIDE = 268435456u;

	private const uint VISIBILITY_STATE_CAMERA_MODE_HIDE = 1073741824u;

	private const uint VISIBILITY_STATE_ROOM_HANGUP_HIDE = 33554432u;

	private Transform m_HudRoot;

	private Transform m_HudRootObserve;

	private UIRootFrontEndPanelContainerController m_RootFrontEndPanelContainerCtrl;

	private UIRootFinderContainerController m_RootFinderContainerCtrl;

	private UIHudMovingJoystickController m_MoveJoyStickCtrl;

	private UIHudFireController m_FireController;

	private UIHudSpeedupAreaController m_RushingSpeedUI;

	private UIHudCrouchController m_CrouchUI;

	private UIHudJumpController m_JumpUI;

	private UIHudLobbySocialAreaTargetPlayerController m_LobbySocialAreaTargetPlayerCtrl;

	private UIHudLobbySocialAreaEventActionController m_LobbySocialAreaUseBtnCtrl;

	private UIHudLobbySocialAreaEventActionController m_LobbySocialAreaSubUse1BtnCtrl;

	private UIHudLobbySocialAreaEventActionController m_LobbySocialAreaSubUse2BtnCtrl;

	private UIHudLobbySocialAreaEventActionController m_LobbySocialAreaSEBtnCtrl;

	private UIHudPreparationTimerController m_PrepareCtrl;

	private UIHudTweenTipsController m_TweenTipsController;

	private UILoginAge18Controller m_LobbyAge18LogoCtrl;

	private UIHudLobbySocialAreaDancePanelController m_DancePanelCtrl;

	private UIHudLobbySocialAreaDanceBannerController m_DanceBannerController;

	private UIHudLobbySocialAreaDanceRewardController m_DanceRewardCtrl;

	private UIHudLobbySocialAreaLobbyLWRewardController m_LobbyLWRewardCtrl;

	private bool m_IsInDancePoolArea;

	private UIHudLobbySocialAreaSoftCloseNoticeController m_SoftCloseNoticeCtrl;

	private UIHudLobbySocialAreaSoftCloseTipsController m_SoftCloseTipsCtrl;

	private UIHudLobbySocialAreaSoftCloseTimeController m_SoftCloseTimeCtrl;

	private UIHudLobbySocialPrivilegeController m_SocialPrivilegeCtrl;

	private UIHudLobbySocialPrivilegeCloseBtnController m_SocialPrivilegeCloseCtrl;

	private UIHudLobbySocialPrivilegeRemainTimeController m_SocialPrivilegeRemainTimeCtrl;

	protected UIHudTriggerGrenadeController m_TriggerGrenadeCtrl;

	protected UIHudGrenadeAndCancleParentController m_GrenadeAndCancleParentController;

	private UINinthSYSAreaTipsController m_NinthSYSAreaTipsCtrl;

	private UIHudLobbySocialAreaCarryHitController m_CarryHitCtrl;

	private UIHudCrosshairsController m_CrossHairCtrl;

	private UIHudEmotionEntryController m_EmotionEntryController;

	private UIHudEmotionController m_EmotionCtrl;

	private UIHudSuperEmoteController m_HudSuperEmoteCtrl;

	private UIHudLobbySocialShowHideLobbyUIController m_ShowHideLobbyUICtrl;

	private UIHudSpeakerMuteController m_SpeakerMuteCtrl;

	private UIHudMicroPhoneMuteController m_MicroPhoneMuteCtrl;

	private UILobbySocialVoiceInfoController m_VoiceMicCtrl;

	private UILobbySocialVoiceInfoController m_VoiceSpeakerCtrl;

	private bool m_ShowHideLobbyUIVisibleForNinth;

	private UIHudCameraEntryController m_CameraEntryCtrl;

	private UIHudCameraInGameController m_CameraInGameCtrl;

	private UIHudLobbyLWScoreboardHudNameController m_ScoreboardCtrl;

	private UIHudPickupListControllerV2 m_LobbyPicupListCtrl;

	private Vector3 m_SEBtnDefaultPos;

	private Vector3 m_SEBtnResetDeformPos;

	private bool m_IsPrivilegeDeformResetVisible;

	private bool m_IsBigHeadResetVisible;

	private bool m_LocalPlayerAdded;

	private bool m_PreloadLoaded;

	private bool m_IsProcessedPreLoad;

	private bool m_EscapeHandleRegistered;

	private uint m_StopMoveRestoreDelayCallId;

	private bool m_StopMoveRestoreActive;

	private List<TweenAlpha> m_StopMoveRestoreTweenAlphas;

	private float m_HorizontalMoveStartTime;

	private bool m_ImmersiveMode;

	private uint m_EnteringImmersiveModeDelayCallId;

	private bool m_IsCameraInGameOpen;

	private float m_CameraModeSettingAlpha;

	private List<UIBaseController> m_CameraModeHiddenControllers;

	private Dictionary<BHGGAEEHJCO, UIHudLobbySocialAreaNameController> m_PlayerNameHuds;

	private Dictionary<Type, Queue<UIBaseController>> m_LobbySocialInGameUIPoolDic;

	protected BitArrayBoolean m_IsHudVisible;

	public const uint HUD_FLAG_BACKGROUND = 1u;

	public const uint HUD_FLAG_NINTH_STATUE_ANIM = 2u;

	public const uint HUD_FLAG_SUBGAME_LW_MATCH_RESULT = 4u;

	public const uint HUD_FLAG_SPECTATOR_CAMERA = 8u;

	public const uint HUD_FLAG_NINTH_PRIZE_POOL_PREVIEW = 16u;

	public const uint HUD_FLAG_CAMERA_VEDIO_REC = 32u;

	public const uint CAMERA_CULLING_MASK_BACKGROUND = 1u;

	public const uint CAMERA_CULLING_MASK_NINTH_REWARD_POOL = 2u;

	public const uint CAMERA_CULLING_MASK_NINTH_GAMEPLAY = 4u;

	public const uint CAMERA_CULLING_MASK_NINTH_PEAKDAY = 8u;

	public const uint CAMERA_CULLING_MASK_NINTH_MISSION = 16u;

	protected BitArrayBoolean m_CameraCullingMask;

	private LeanTouch m_LeanTouch;

	private bool m_EnableImmersiveMode;

	private static readonly Vector3 MVP_STAGE_POS;

	private GameObject m_MVPStageRoot;

	private RenderTexture m_MVPRenderTexture;

	private UIMaleAvatar m_MVPAvatar;

	private bool m_IsMVPPlaying;

	private uint m_MVPAnimEndDelayCall;

	private float m_MVPAnimClipDuration;

	private UILobbySocialBillboardController m_BillboardCtrl;

	private uint m_MVPSound;

	private ulong m_CurrentPlayingAccountId;

	private bool m_IsNinthDelayDestroyTimeApplied;

	private UILobbySocialAreaActionArbiter m_Arbiter;

	private static readonly UInt128 LOBBY_SOCIAL_HUD_GROUP_EXCEPT_SUPER_EMOTE;

	private bool m_InviteGroupShow;

	private bool m_BriefBoxShow;

	private int m_SavedGameCameraCullingMask;

	private bool m_GameCameraCullingMaskSaved;

	private GameObject LightingObj;

	private const float m_DancePoolMusicFadeTime = 0.3f;

	public UIHudLobbyLWScoreboardHudNameController ScoreboardCtrl => null;

	public bool IsImmersiveMode => false;

	public float CameraModeSettingAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool EnableImmersiveMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UILobbySocialBillboardController BillboardCtrl => null;

	public Transform HudRoot => null;

	public Transform HudRootObserve => null;

	public bool IsLobbySocialAreaActionVisible => false;

	public bool IsLobbySocialAreaPendingActionButton => false;

	public bool IsLobbySocialFollowMoveActionVisible => false;

	public void ApplyNinthDelayDestroyTime()
	{
	}

	private static UInt128 BuildLobbySocialHudGroup(UIInGameScene.EUIGroup[] excludedGroups)
	{
		return default(UInt128);
	}

	public T GetUIControllerFromPool<T>() where T : UIBaseController
	{
		return null;
	}

	private void SetLobbySocialHudGroupExceptSuperEmote(UIBaseController controller)
	{
	}

	public void CreateLobbyAge18Logo()
	{
	}

	public void RecycleUIController<T>(T uicontroller) where T : UIBaseController
	{
	}

	private void ClearLobbySocialInGameUIPoolDic()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDestory()
	{
	}

	public override void Show()
	{
	}

	private bool IsOnlyLobbyV2()
	{
		return false;
	}

	private bool IsLobbySocialAreaRoomMode()
	{
		return false;
	}

	public void OnInviteGroupBoxStateChange(bool show)
	{
	}

	public void OnBriefBoxStateChange(bool show)
	{
	}

	public void TryEnableCheckUpperPanelForRightAxisInput()
	{
	}

	private bool NeedCheckUpperPanelForRightAxisInput(UIPopupWindowController pop)
	{
		return false;
	}

	public void RefreshShaderLOD()
	{
	}

	public override UIBaseNavigationController PushNavigation(Type type, UINavigationData navigationData, bool isRoot = false, UIControllerContext context = null)
	{
		return null;
	}

	public override UINavigationData PopNavigation()
	{
		return null;
	}

	public void CloseLobbyLWObserveNavigation()
	{
	}

	private void TryRequestLocalPlayerDeformHangSetupAfterReturnToSocialLobby()
	{
	}

	private bool IsInCameraVedioRecording()
	{
		return false;
	}

	private void RefreshHudStateByNavigation()
	{
	}

	protected override Transform FindUIRoot()
	{
		return null;
	}

	public override void SetBackgroundActive(bool active)
	{
	}

	public void SetCameraCullingMask(uint flag, bool visible)
	{
	}

	private void SetGameCameraCullingMaskForBackground(bool backgroundActive)
	{
	}

	public void SetNinthVisible(bool visible)
	{
	}

	public void SetShowHideLobbyUIVisibleForNinth(bool visible)
	{
	}

	private void ApplyShowHideLobbyUIVisibleForNinth()
	{
	}

	private void CloseMaskInternal(bool data)
	{
	}

	private void OnUIQuitGameRequest(object[] param)
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void RequestQuitLobbySocialAreaGame()
	{
	}

	public override void SetNavigationTopbarViewData(UINavigationTopbarViewData viewData)
	{
	}

	public void SetTopbarLobbyV2PanelActive(bool active)
	{
	}

	private void SetTopbarLobbyV2PanelAlpha(float alpha)
	{
	}

	private UIBaseNavigationController GetNavigationByType(Type type)
	{
		return null;
	}

	public UIPresetSideController FindPresetSideController()
	{
		return null;
	}

	private void SetControllerRootPanelAlpha(Component ctrl, float alpha)
	{
	}

	public void SetControllerImmersiveVisible(UIBaseController ctrl, bool visible)
	{
	}

	private void OnLocalPlayerHorizontalMovingStateChanged(object[] data)
	{
	}

	private void CancelStopMoveRestoreDelay()
	{
	}

	private void EnteringImmersiveMode()
	{
	}

	public void CancelEnteringImmersiveMode()
	{
	}

	public void EnterImmersiveMode()
	{
	}

	public void QuitImmersiveMode()
	{
	}

	public bool ShouldBlockLobbyUIRestoreByCameraMode()
	{
		return false;
	}

	private bool ShouldHideLobbyUIByMovementOrImmersive()
	{
		return false;
	}

	public void ResetLobbyUIAlpha()
	{
	}

	private void StartStopMoveRestoreAlphaTweenAlpha(float duration, float startAlpha)
	{
	}

	private static UIPanel GetPanelFromController(Component ctrl)
	{
		return null;
	}

	public void PopupWindowSetHud(bool state)
	{
	}

	public void SetHudState(uint flag, bool state)
	{
	}

	private void OnAddPlayer(GEvent data)
	{
	}

	private void RefreshMoveJoystickInputForMovingJoystickMode()
	{
	}

	private void RefreshLeftAxisUpperPanelForMovingJoystickMode()
	{
	}

	private void OnRemovePlayer(uint data)
	{
	}

	private void SyncLobbySocialAreaTeammateNameHuds()
	{
	}

	public void RefreshDisplayNameHuds()
	{
	}

	public UIHudLobbySocialAreaNameController GetPlayerNameHud(BHGGAEEHJCO pID)
	{
		return null;
	}

	public void ShowPlayerCommonTitle(BHGGAEEHJCO playerID, uint titleId = 0u)
	{
	}

	private void ClearLobbySocialAreaPlayersNameHuds()
	{
	}

	private void OnGroupJoinNtf(object[] data)
	{
	}

	private void OnLobbyGroupCreate(object[] data)
	{
	}

	private void CheckToCloseHUDMask()
	{
	}

	private void OnPreloadLoaded(object[] data)
	{
	}

	private void OnJoinMatchFinished()
	{
	}

	protected Transform FindInGameRankBiliboardRoot()
	{
		return null;
	}

	private void OpenInGameRankBiliboard(Transform biliboardRoot)
	{
	}

	private void OnSocialLobbyTipsCallback(uint data)
	{
	}

	private void OnLobbySocialObjectActionEnter(int param, int param2)
	{
	}

	private void OnLobbySocialObjectActionEnd()
	{
	}

	public static UIHudLobbySocialAreaEventActionController.EEventActionType HudActionTypeToLobbySocialEventType(EHudActionType t)
	{
		return UIHudLobbySocialAreaEventActionController.EEventActionType.None;
	}

	public void ApplyLobbySocialActionFromTrigger(int hudActionParam, int objectParam)
	{
	}

	private static EventLogger.ESocialHubPersonalInfoTriggerSource GetSocialHubActionTriggerSource(UIHudLobbySocialAreaEventActionController.EEventActionType type)
	{
		return EventLogger.ESocialHubPersonalInfoTriggerSource.None;
	}

	private void TryLogSocialHubActionTrigger(EventLogger.ESocialHubPersonalInfoTriggerSource source, uint targetPlayerId)
	{
	}

	private bool TryGetSocialHubSeesawSeatPlayerId(out BHGGAEEHJCO seatPlayerId)
	{
		seatPlayerId = default(BHGGAEEHJCO);
		return false;
	}

	public static bool IsEmoteType(UIHudLobbySocialAreaEventActionController.EEventActionType t)
	{
		return false;
	}

	public void ClearLobbySocialActionFromTrigger()
	{
	}

	public void OpenHud()
	{
	}

	public bool CheckTriggerGrenadeShowed()
	{
		return false;
	}

	private void TryShowSparkPet()
	{
	}

	private void HideSparkPet()
	{
	}

	private void OnSparkPetDescInfoReady()
	{
	}

	private void OnSparkPetShowInLobbyPreferenceChanged(bool showInLobby)
	{
	}

	private void OnOpenTweenTipsWithIconAndBG(object[] data)
	{
	}

	private void OnOpenSocialLobbyTweenTips(object[] data)
	{
	}

	public UIHudTweenTipsController GetTweenTipsController()
	{
		return null;
	}

	public override void ShowPopupMessage(string message, float duration = 2f, bool forceShow = false)
	{
	}

	public void RefreshLobbyLWObserveScoreboard()
	{
	}

	public void BindLobbySocialAreaTargetPlayer(uint playerId, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	public void OnLobbySocialAreaPreSelectedChanged(Player preSelected)
	{
	}

	public void UnbindLobbySocialAreaTargetPlayer()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void OnFollowEmoteStateChanged()
	{
	}

	public void ShowCarryBattleHitResult(uint hitCount)
	{
	}

	public void OpenSoftCloseNotice(float remaining)
	{
	}

	public void OpenSoftCloseTips(float remaining)
	{
	}

	public void OpenSoftCloseTime(float remaining)
	{
	}

	public void CloseSoftCloseCtrl(MNDHKHJINOG.HONMPPEAHMF phase)
	{
	}

	public RenderTexture GetMVPRenderTextureForAvatar(UIMaleAvatar avatar)
	{
		return null;
	}

	public void RequestPlayGroupAnim(ulong accountId, uint groupAnimId)
	{
	}

	private void RequestPlayGroupAnim(ulong accountId, uint groupAnimId, EBillboardMVPDataSource dataSource)
	{
	}

	private bool DisableBillboardGroupAnimByRecommendedQuality()
	{
		return false;
	}

	public void PlayMVPAnimOnBillboard(ulong targetAccountId, uint mvpAnimId)
	{
	}

	private void PlayMVPAnimOnBillboard(ulong targetAccountId, uint mvpAnimId, EBillboardMVPDataSource dataSource)
	{
	}

	private Player GetBillboardMVPPlayer(ulong targetAccountId)
	{
		return null;
	}

	private void ScheduleStopMVPAnimOnBillboard(float animDuration)
	{
	}

	public void StopMVPAnimOnBillboard()
	{
	}

	private bool CreateBillboardMVPRoom(uint mvpAnimId, bool isFemale, ref float mvpAnimDuration)
	{
		return false;
	}

	private void ShowAvatarAndPlayMvpAnim(bool isFemale, uint groupAnimId, GameObject mvpCameraOB, ResourceID playerAnimID, ResourceID soundAnimID, ResourceID freezzIdleAnimId)
	{
	}

	private IEnumerator DelayShowAvatarAndPlayMvpAnim(bool isFemale, uint groupAnimId, GameObject mvpCameraOB, ResourceID playerAnimID, ResourceID soundAnimID, ResourceID freezzIdleAnimId)
	{
		return null;
	}

	private void PlayMvpAnimInternal(bool isFemale, uint groupAnimId, GameObject mvpCameraOB, ResourceID playerAnimID, ResourceID soundAnimID, ResourceID freezzIdleAnimId)
	{
	}

	private UIMaleAvatar CreateBillboardMVPAvatar(Player player)
	{
		return null;
	}

	private UIMaleAvatar CreateBillboardMVPAvatarFromMember(GroupMemberInfo memberInfo)
	{
		return null;
	}

	private void OnBillboardAvatarAnimatorUpdate(UIStatedAvatar avatar)
	{
	}

	private void CleanupMVPStage()
	{
	}

	private void OnSocialLobbyEmotionOpen(object[] param)
	{
	}

	private void OnSocialLobbyEmotionClose(object[] param)
	{
	}

	private void CloseEmotionPanel()
	{
	}

	private void RefreshVoiceDisconnectStateAndToggleState()
	{
	}

	private void RefreshVoiceDisconnectState()
	{
	}

	private void RefreshVoiceToggleState()
	{
	}

	private void OnVoiceJoinedRoom(object[] data)
	{
	}

	private void OnVoiceLeavedRoom(object[] data)
	{
	}

	private void OnLobbySocialRoomHangup(object[] data)
	{
	}

	private void OnLobbySocialRoomHangupEnd(object[] data)
	{
	}

	private void SetLobbySocialVoiceHudVisibleByRoomHangup(bool visible)
	{
	}

	public void LobbyPopupListChange()
	{
	}

	private void RefreshRealTimeLightState()
	{
	}

	private void ShowSpeakerInfo(object[] data)
	{
	}

	private void ShowMicInfo(object[] data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshLocalBackpackShowAfterLoginBackpackReady()
	{
	}

	private void RefreshAllPlayersClothes()
	{
	}

	private bool IsSelfOrLobbyGroupMemberNameHud(Player p)
	{
		return false;
	}

	public float GetAllNeedDownloadSize()
	{
		return 0f;
	}

	public void DownLoadAllTeamateEquipment()
	{
	}

	private void RefreshSuperEmoteHud()
	{
	}

	private void SetSuperEmoteHudByEmoteId(uint superEmoteId)
	{
	}

	private void CloseSuperEmoteHud()
	{
	}

	private void OnSuperEmoteChanged(object[] data)
	{
	}

	private void OnLocalPlayerNameRefresh(object[] data)
	{
	}

	private void OnLocalPlayerBadgeRefresh(object[] data)
	{
	}

	private void OnLocalPlayerTitleRefresh(object[] data)
	{
	}

	public void SetHudVisible(bool visible)
	{
	}

	public void SetSpectatorCameraHudVisible(bool visible)
	{
	}

	public void ShowDancePoolAreaAction()
	{
	}

	public void OnExitDancePoolArea()
	{
	}

	public void OnLocalPlayerDancePoolStarted()
	{
	}

	public void OnLocalPlayerDancePoolStopped()
	{
	}

	private void OnLobbySocialPrivilegeResetVisible(bool visible)
	{
	}

	private void OnLocalPlayerBigHeadChange(bool isBigHead)
	{
	}

	public void OnLobbySocialResetAllActionClick()
	{
	}

	private void RefreshLobbySocialAreaSEBtnCtrl()
	{
	}

	private UIHudLobbySocialAreaEventActionController.EEventActionType EvaluateSEBtnActionType()
	{
		return UIHudLobbySocialAreaEventActionController.EEventActionType.None;
	}

	public void ShowSpectatorCamAction()
	{
	}

	public void HideSpectatorCamAction()
	{
	}

	public void ShowRewardPoolAction()
	{
	}

	public void RefreshRewardPoolAction()
	{
	}

	public void HideRewardPoolAction()
	{
	}

	private void SetDancePoolHudState(bool isDancing)
	{
	}

	private void OnDancePoolEnterArea(bool enter)
	{
	}

	private void TryShowDancePoolSoftCloseTips()
	{
	}

	private void OnLobbyOfflineModeChanged(bool offlineState)
	{
	}

	public void ShowDancePanel()
	{
	}

	public void HideDancePanel()
	{
	}

	private void CloseDancePanel()
	{
	}

	private void ShowSocialAreaBanner(ELobbySocialAreaBannerType type, bool isCarrier = false)
	{
	}

	private void HideDanceBanner()
	{
	}

	private void CloseDanceBanner()
	{
	}

	private void OnCarryAreaEnter(bool enter)
	{
	}

	public void TryShowCarryTriggerCDNGuide()
	{
	}

	private void OnDancePoolDJEnterArea(bool enter)
	{
	}

	private void ShowDancePoolDJInteract()
	{
	}

	private void HideDancePoolDJInteract()
	{
	}

	private void InitScoreboard(Transform root)
	{
	}

	public void OpenDancePoolDanceReward()
	{
	}

	private void CloseDanceRewardCtrl()
	{
	}

	public void OpenLobbyLWReward()
	{
	}

	private void CloseLobbyLWCtrl()
	{
	}

	private void OnLobbyLWInteractEnterArea(bool enter)
	{
	}

	private void ShowLobbyLWInteract()
	{
	}

	private void HideLobbyLWInteract()
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	private void OnVedioRecordBeforeStartEnd(bool isSuccess)
	{
	}

	private void OnCameraModeStateChanged(int state)
	{
	}

	private void RefreshHudRootVisibleState(uint flag, bool state)
	{
	}

	private void SyncLobbyUIAfterCameraModeClosed()
	{
	}

	private void RefreshHUDAlphaByCameraMode()
	{
	}

	private void SetLobbyUIVisibleForCameraMode(bool visible)
	{
	}

	private void SetControllerCameraModeVisible(UIBaseController ctrl, bool visible)
	{
	}

	private void RestoreCameraModeHiddenControllers()
	{
	}

	public void ShowDefenderRecruitAction()
	{
	}

	public void HideDefenderRecruitAction()
	{
	}

	public void HideAllEventActionButtons()
	{
	}

	public void RefreshEventActionButtonsAfterTeleportCancelled()
	{
	}

	public void SetLobbySocialFollowMove(uint ownerId)
	{
	}

	public void ClearLobbySocialFollowMove(uint ownerId)
	{
	}

	private void _003CEnteringImmersiveMode_003Eb__159_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public new UIBaseNavigationController _003C_003EiFixBaseProxy_PushNavigation(Type P0, UINavigationData P1, bool P2, UIControllerContext P3)
	{
		return null;
	}

	public UINavigationData _003C_003EiFixBaseProxy_PopNavigation()
	{
		return null;
	}

	public new Transform _003C_003EiFixBaseProxy_FindUIRoot()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetBackgroundActive(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetNavigationTopbarViewData(UINavigationTopbarViewData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowPopupMessage(string P0, float P1, bool P2)
	{
	}
}
