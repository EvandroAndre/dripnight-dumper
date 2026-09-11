using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISparkPetAvatarWindowController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CStartBoomVFx_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISparkPetAvatarWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartBoomVFx_003Ed__89(int _003C_003E1__state)
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

	private UIModelSparkPet m_ModelSparkPet;

	private UIModelSparkPetTest m_ModelSparkPetTest;

	private UIModelUser m_ModelUser;

	private UISparkPetAvatarWindowView m_View;

	private UISparkPetAvatar m_SparkPetAvatar;

	private UISparkPetAvatar m_CollabSparkPetAvatar;

	private UISparkPetDragDropItem m_DragDropItem;

	private UISparkPetDragDropItem m_CollabDragDropItem;

	private UISparkPetRaycastDragHandler m_RaycastDragHandler;

	private UISparkPetRaycastDragHandler m_CollabRaycastDragHandler;

	private UISparkPetProfileController m_ProfileController;

	private UISparkPetDialogueController m_PetDialogueController;

	private UISparkPetDialogueLobbyController m_PetDialogueLobbyController;

	private UISparkPetBubbleController m_PetBubbleController;

	private UISparkPetCosmeticVaultController m_PetCosmeticVaultController;

	private UIRoot m_UIRoot;

	private Coroutine m_BoomVFXCoroutine;

	private ESparkPetPopType m_SparkPetPopType;

	private Camera m_UICamera;

	private uint m_AsyncCreateSparkPetTicket;

	private uint m_AsyncCreateBuddySparkPetTicket;

	private bool m_DelayCreateCollabSparkPet;

	private ESparkAvatarOrigin m_ESparkAvatarOrigin;

	private OtherSparkPetCreateParams m_OtherCreateParams;

	private uint[] m_NeedToClaimAwards;

	private bool m_IsFirstCreate;

	private uint m_DailyFirstLoginDialogueDelayCall;

	private bool m_SetSnapTarget;

	private bool m_NeedShowSecondExtinguishedDialogue;

	private bool m_IsCoveredByPopup;

	private bool m_IsTakePhotoOpen;

	private bool m_IsCameraInGameOpen;

	private const float FALLBACK_UI_POSITION_X = 300f;

	private const float FALLBACK_UI_POSITION_Y = 50f;

	private const string PREF_KEY_POS_X = "SparkPet_Position_NormalizedX";

	private const string PREF_KEY_POS_Y = "SparkPet_Position_NormalizedY";

	private string m_PlayAnimNameAfterCreate;

	private UICommonGuideController m_StageEvolutionGuideCtrl;

	private uint m_StageEvolutionGuideDelayCall;

	private ESparkPetStage m_PendingEvolutionStage;

	private uint m_FirstClaimGuideDelayCall;

	private bool m_PendingFirstClaimGuide;

	private bool m_FirstClaimGuideShown;

	private UICommonGuideController m_FirstClaimGuideCtrl;

	private const float VFX_STAGE_EVOLUTION_LIFETIME = 3f;

	private VisualInstanceHolder m_StageEvolutionVFXHolder;

	private UINewDownloadInfoController m_DownloadCtrl;

	private bool m_IsPartialDownload;

	private bool m_PendingDownloadRefresh;

	private bool m_IsBoomPlaying;

	private bool m_WaitingBoomForRewards;

	public ESparkPetPopType SparkPetPopType => ESparkPetPopType.None;

	public bool IsPartialDownload => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void CreateSelfSparkPet(bool isFirstCreate = false, string animName = "")
	{
	}

	public void CreateOther(uint sparkPetStage, uint collabSparkPetStage, uint[] appearanceItemIdsSelf, uint[] appearanceItemIdsCollab, EFriend.SparkState stateSelf, EFriend.SparkState stateCollab, uint selfLoginStreakDays = 0u, uint collabLoginStreakDays = 0u, uint colorIDSelf = 1u, uint colorIDCollab = 1u)
	{
	}

	private void CleanupSparkPetState()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void CancelAsyncCreateSparkPet()
	{
	}

	private void CancelAsyncCollabCreateSparkPet()
	{
	}

	private void OnSparkPetCreated(uint ticket, UISparkPetAvatar sparkPetAvatar, uint sparkAvatarType)
	{
	}

	private void ApplyInitialTransform(UISparkPetAvatar sparkPetAvatar, ESparkAvatarType avatarType)
	{
	}

	private void PlayDebugAnim()
	{
	}

	private void SetLoginDaysUI(uint sparkAvatarType)
	{
	}

	public void SetSparkUI(uint sparkAvatarType)
	{
	}

	private void ShowChooseTemperDialogue()
	{
	}

	private void ShowDailyLoginDialogue()
	{
	}

	private void ShowExtinguishedDailyLoginDialogue()
	{
	}

	private void OnExtinguishedFirstDialogueClose()
	{
	}

	private void ShowExtinguishedSecondDialogue()
	{
	}

	private void ShowAnimLoopDialogue(ESparkPetDialogueType dialogueType, string dialogueText)
	{
	}

	private void OnExtinctionFeedbackClose()
	{
	}

	private void OnDialogueCtrlClose()
	{
	}

	private void OnBubbleClose(Vector3 boomVFXStartPos)
	{
	}

	private void StartFlyVFX()
	{
	}

	private void OnFlyVFXArcEnd(TweenPositionArc arc)
	{
	}

	private void StopFlyVFX()
	{
	}

	private void StopBoomVFX()
	{
	}

	private void OnBubbleAwardsClaim()
	{
	}

	private void RequestClaimLevelAwardFromPending()
	{
	}

	private void ShowClaimLevelRewardsWnd()
	{
	}

	private void ShowClaimRewardThenLuckyDraw()
	{
	}

	private void OnClaimRewardWndClosed()
	{
	}

	private void ShowLuckyDrawWndIfNeeded()
	{
	}

	private void PlayLevelUpVFX()
	{
	}

	private void OnBoomStart(Vector3 boomVFXStartPos)
	{
	}

	private IEnumerator StartBoomVFx()
	{
		return null;
	}

	private void ResetPopTipType()
	{
	}

	private void CloseChooseTemperDialogue()
	{
	}

	private void CloseLobbyDialogue()
	{
	}

	private void SetupRaycastDragHandler()
	{
	}

	private void OnSparkPetRotateEnd()
	{
	}

	private void SetupSnapTarget()
	{
	}

	private void SetupCollabRaycastDragHandler()
	{
	}

	private void OnSelfSparkPetDragPositionChanged()
	{
	}

	private void OnCollabSparkPetPositionChanged()
	{
	}

	private void OnSelfSparkPetPositionChanged()
	{
	}

	private void ResetDragBounds()
	{
	}

	private void CalculateCollabModeBounds()
	{
	}

	private void SetupDragDropComponent()
	{
	}

	private void SetupCollabDragDropComponent()
	{
	}

	private void SetSparkPetPosition(bool checkIsSuccessFix = false)
	{
	}

	private void SetCollabSparkPetPosition()
	{
	}

	private Vector2 LoadPositionFromPlayerPrefs()
	{
		return default(Vector2);
	}

	private bool FixPositionFromPlayerPrefs(ref Vector2 uiSize)
	{
		return false;
	}

	private void SavePositionToPlayerPrefs()
	{
	}

	private bool IsLobbyHudIn3DLobby()
	{
		return false;
	}

	private Vector2 GetDefaultUIPosition()
	{
		return default(Vector2);
	}

	private string GetPosKeyX()
	{
		return null;
	}

	private string GetPosKeyY()
	{
		return null;
	}

	private float GetCameraZDepth()
	{
		return 0f;
	}

	private float GetScreenToUIRatio()
	{
		return 0f;
	}

	private void OnDragStart()
	{
	}

	private void OnDragEnd()
	{
	}

	private void OnSparkPetClicked()
	{
	}

	private void ShowProfilePopup()
	{
	}

	private void OnCollabSparkPetClicked()
	{
	}

	private Vector3 GetSparkPetCornerPosition(UISparkPetAvatar sparkPet, out bool preferRight, out bool preferUp)
	{
		preferRight = default(bool);
		preferUp = default(bool);
		return default(Vector3);
	}

	public void SetSelfSparkPetColor(uint colorID)
	{
	}

	public bool IsSelfLevelUp()
	{
		return false;
	}

	public void HideSpark()
	{
	}

	public void ShowSpark()
	{
	}

	private void OnShowLoginDaysLabel(bool isShow)
	{
	}

	private void OnShowInLobby(bool isShow)
	{
	}

	private void OnShowAnimDialogueLobby(object[] datas)
	{
	}

	private void OnNavigationChanged()
	{
	}

	private bool ShouldShowSparkInCurrentNavigation()
	{
		return false;
	}

	private bool IsInProfileNavigation()
	{
		return false;
	}

	public void RefreshSparkPetSocialAreaLight()
	{
	}

	private bool IsLobbySocialImmersiveMode()
	{
		return false;
	}

	private bool IsLocalPlayerHorizontalMoving()
	{
		return false;
	}

	public void UpdateSparkVisibility()
	{
	}

	private void OnShowBuddy(bool isShow)
	{
	}

	private void OnShowAward()
	{
	}

	private void OnSetPopType(object[] data)
	{
	}

	private bool ShouldShowRotateIcon()
	{
		return false;
	}

	public void UpdateRotateIconVisibility()
	{
	}

	private void OnPopupWindowChanged(object[] data)
	{
	}

	private void OnTakePhotoVisibilityChanged(object[] data)
	{
	}

	private void OnCameraInGameVisibilityChanged(object[] data)
	{
	}

	private void OnGameModeVisibleChange()
	{
	}

	private void OnSparkPetRefreshVisibility()
	{
	}

	public bool IsCoveredByPopupWindow()
	{
		return false;
	}

	private void OnBubbleClick()
	{
	}

	private bool ShowAwardsBubble()
	{
		return false;
	}

	private void CloseAwardBubble()
	{
	}

	public void ShowStageEvolutionBubble()
	{
	}

	private void StartStageEvolutionGuideDelayCall()
	{
	}

	private void CancelStageEvolutionGuideDelayCall()
	{
	}

	private void ShowStageEvolutionGuide()
	{
	}

	private void CloseStageEvolutionGuide()
	{
	}

	private void OnStageEvolutionGuideClose()
	{
	}

	private void OnStageEvolutionBubbleClose(Vector3 bubblePos)
	{
	}

	private void OnStageEvolutionClick()
	{
	}

	private void PlayStageEvolutionVFX()
	{
	}

	private void OnStageEvolutionVFXCreated(GameObject vfxInstance)
	{
	}

	private void ShowFirstClaimGuide()
	{
	}

	private void StartFirstClaimGuideDelayCall()
	{
	}

	private void CancelFirstClaimGuideDelayCall()
	{
	}

	private void TryShowFirstClaimGuideInternal()
	{
	}

	private void OnFirstClaimGuideClose()
	{
	}

	private void ShowFirstClaimCdnGuide()
	{
	}

	private void OnFirstClaimCdnGuideClose()
	{
	}

	public void PlaySparkPetAnim(string aniName)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void CheckHideAfterRefresh()
	{
	}

	private void RefreshDownloadInfo()
	{
	}

	private void UpdateDownloadCtrlPosition()
	{
	}

	private void OnDownloadClick()
	{
	}

	private void MoveClickWidgetToDefaultPosition()
	{
	}

	private void HideDownloadInfo()
	{
	}

	private void OnSparkPetDownloadComplete()
	{
	}

	private void OnSparkPetDownloadDeleted()
	{
	}

	private void RecreateSparkPet()
	{
	}

	private void ChangeSparkPetStage(ESparkPetStage stage)
	{
	}

	private void Update()
	{
	}

	public void DebugPlayLevelUpVFX()
	{
	}

	public void DebugPlayFlyVFX()
	{
	}

	public void PlayRecoveryStateSwitch()
	{
	}

	private void _003COnStageEvolutionBubbleClose_003Eb__155_0()
	{
	}

	private void _003CDebugPlayFlyVFX_003Eb__181_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
