using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UICSBanPickWindowController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AvatarSuit> _003C_003E9__101_0;

		public static Action _003C_003E9__119_0;

		internal bool _003CRefreshLockSkillModel_003Eb__101_0(AvatarSuit x)
		{
			return false;
		}

		internal void _003COnObserverClickQuitRoom_003Eb__119_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public UIPopupMessageBoxController quitDialog;

		internal void _003COnObserverClickQuitRoom_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public UIModelAvatarProfile model;

		internal bool _003CAppendAllSkills_003Eb__0(AvatarProfile a)
		{
			return false;
		}
	}

	private sealed class _003CCreatePlayerItemCoroutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICSBanPickWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreatePlayerItemCoroutine_003Ed__68(int _003C_003E1__state)
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

	private ECSBPPhase m_BPStatus;

	private UICSBanPickWindowView m_View;

	private Coroutine m_CreatePlayerItemCoroutine;

	private List<UICSBanPickPlayerItemController> m_LeftPlayerItemList;

	private List<UICSBanPickPlayerItemRightController> m_RightPlayerItemList;

	private UICSBanPickSkillItemController m_LeftBanSkillItem;

	private UICSBanPickSkillItemController m_RightBanSkillItem;

	private int m_PerTeamPlayerCount;

	private bool m_IsObserver;

	private Dictionary<ulong, UICSBanPickPlayerItemController> m_PlayerItemMap;

	private float STAGE_CHANGE_TIME;

	protected uint m_DelaySwitchID;

	protected uint m_StageCoolDownID;

	protected uint m_PhaseChangeAnimationID;

	private ulong m_StageEndTime;

	private List<UICSBanPickSkillItemData> m_MiddleSkillItemList;

	private List<uint> m_MiddleSkillItemSkillIDs;

	private uint m_CurrentTag;

	private UIModelLoadout m_ModelLoadout;

	private UIModelBanPick m_ModelBanPick;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelAvatar m_ModelAvatar;

	private CSBPContext m_Context;

	private UIModelCustomRoom m_ModelCustomRoom;

	private EGameVoiceListenMode m_VoiceBeforeEnterMicMode;

	private EGameVoiceListenMode m_VoiceBeforeEnterSpeakerMode;

	private EGameVoiceListenMode m_RoomMicModeBeforeEnter;

	private EGameVoiceListenMode m_RoomSpeakerModeBeforeEnter;

	private List<string> m_VoiceMuteBeforeEnter;

	private bool m_IsBPVoiceEnabled;

	private uint m_BanSkillID;

	private uint m_PrePickSkillID;

	private uint m_LockedSkillID;

	private bool m_IsLocked;

	private float m_HelpPickAnswerTimeEnd;

	protected uint m_DelayHelpPickAnswerID;

	private bool m_IsRequestHelpPick;

	private bool m_IsRequestChangeSkill;

	private ulong m_RequestChangeSkillTargetPlayerId;

	private uint m_RequestChangeSkillSkillID;

	private uint m_CurrentSkillID;

	private bool m_IsReconnected;

	private List<ulong> m_InExchangeTeammate;

	private RoomBPPhaseInfo m_ReconnectPhaseInfo;

	protected UICSBanPickCountDownController m_CountDownController;

	private UICSBanPickPresetSideController m_PresetSideController;

	private GameObject m_GoMixCamera;

	private UIMaleAvatar m_Avatar;

	private const float MiddlePixel = 0.15f;

	private Vector3 m_AvatarMidPos;

	private UICSBanPickPlayerItemController m_ChangeBubblePlayerItem;

	private bool m_IsPlayedPickVoice;

	private const string ANIMATION_OUT_NAME = "UIFX_UICSBanPickWindow_PhaseChange_Close";

	private const string ANIMATION_TOP_IN_NAME = "UIFX_UICSBanPickWindow_Top_Saoguang";

	private float m_AnimationOutTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetPerTeamPlayerCount()
	{
	}

	private void CreatePlayerItem()
	{
	}

	private IEnumerator CreatePlayerItemCoroutine()
	{
		return null;
	}

	public void OnSkillItemSelect(uint skillID)
	{
	}

	private void RefreshPlayerSelectSkill(ulong playerId, uint skillID)
	{
	}

	public void SetBPStatus(ECSBPPhase status)
	{
	}

	private void PlayPhaseChangeAnimation()
	{
	}

	private void PlayStageChangeAnimation()
	{
	}

	private void StageCoolDown()
	{
	}

	private void RefreshMiddleSkillList()
	{
	}

	private void HideMiddleSkillList()
	{
	}

	private void OnTypeSelected(uint popMenuType)
	{
	}

	private void RefreshMiddleSkillItem()
	{
	}

	private void AppendAvailableSkills()
	{
	}

	private bool IsOtherPick(uint skillId)
	{
		return false;
	}

	private void AppendCloseFriendSkills()
	{
	}

	private void AppendAllSkills()
	{
	}

	private void AfterStageRefreshPreSelectInfos()
	{
	}

	private void AfterStageRefreshPickedSkills()
	{
	}

	private void ShowTopBanItem()
	{
	}

	private void ShowRightPlayerItem()
	{
	}

	private void OnBanPlayerChange()
	{
	}

	private void RefreshBottomBanButton()
	{
	}

	private void OnPreBanSkillChange(ulong playerId, uint skillID)
	{
	}

	private void RefreshReconnectTopBanItem()
	{
	}

	private void OnBanResultChange(ulong playerId)
	{
	}

	private void OnBtnBanClick()
	{
	}

	private void RefreshTopBanItem()
	{
	}

	private void OnReceiveAskBan(ulong askerId, uint skillID)
	{
	}

	private void OnBtnRequestBanClick()
	{
	}

	public void OnAgreeHelpBan(uint skillID)
	{
	}

	private void RefreshBanResult()
	{
	}

	private void OnBtnLockClick()
	{
	}

	private void OnLockSkill()
	{
	}

	private void InitAvatarAndCamera()
	{
	}

	private void RefreshLockSkillModel()
	{
	}

	private void OnPickPlayerChange()
	{
	}

	private void OnPickPlayerSelectChange(ulong playerId, uint skillID)
	{
	}

	private void OnNextPickPlayerChange()
	{
	}

	private void OnPlayerLockSkillChange(ulong playerId, uint skillID)
	{
	}

	private void OnBtnRequestClick()
	{
	}

	private void RefreshHelpPickBtnStatus()
	{
	}

	private void OnReciveHelpPick(ulong requestPlayerId, uint skillID, ulong answerPlayerId)
	{
	}

	private void OnHelpPickAnswer(ulong requestPlayerId, bool isAccept, ulong answerPlayerId)
	{
	}

	private void OnHelpPickResult(ulong requestPlayerId, ulong answerPlayerId, List<RoomBPPlayerPickedSkill> picked_skill)
	{
	}

	private void OnPlayerPassiveSkillChange(ulong playerId, List<uint> skillIDList, uint petID, uint loadoutID)
	{
	}

	public void OnRequestChangeSkill(ulong targetPlayerId, uint skillID)
	{
	}

	private void OnPlayerRequestChangeSkill(ulong requestPlayerId, ulong answerPlayerId, ulong answerCd)
	{
	}

	private void OnPlayerChangeSkillAnswer(ulong requestPlayerId, bool isAccept, ulong answerPlayerId)
	{
	}

	private void OnExchangeSkillComplete(List<RoomBPPlayerPickedSkill> picked_skills, ulong requesterId, ulong receiverId)
	{
	}

	private void OnReplyExchangeSkill()
	{
	}

	private void OnAnswerExchangeSkill(ulong requesterId, ulong answerId)
	{
	}

	private void RefreshTeammateLeftStatus()
	{
	}

	public void OnObserverClickQuitRoom()
	{
	}

	private void OnTestQuitRoom()
	{
	}

	private void RefreshChangeBubblePlayerItem(uint skillID, ulong RequestplayerID, ulong AnswerplayerID, ulong answerCd, uint targetSkillID)
	{
	}

	private void OnBPErrorCodeChange(uint errorCode)
	{
	}

	public void OnReconnectBPRoom(RoomBPPhaseInfo phaseInfo)
	{
	}

	private void RefreshReconnectPlayerUI()
	{
	}

	private void OnLoadoutBtnClick()
	{
	}

	private void OnPresetSideClosed()
	{
	}

	public bool IsPresetSideOpen()
	{
		return false;
	}

	public bool IsPresetLeftSideOpen()
	{
		return false;
	}

	private bool EnableBPVoice()
	{
		return false;
	}

	private void InitBPVoice()
	{
	}

	private void ApplyBPVoiceMuteState()
	{
	}

	private void JoinBPVoiceRoom()
	{
	}

	private void JoinBPTeamVoiceRoom()
	{
	}

	private void CleanupBPVoice()
	{
	}

	private void SetBPVoiceBtnVisible(bool visible)
	{
	}

	private void RefreshBPVoiceBtnView()
	{
	}

	private void OnBPSpeakerBtnClick()
	{
	}

	private void OnBPMicBtnClick()
	{
	}

	private void OnBPMicrophoneChanged(object[] data)
	{
	}

	private EGameVoiceListenMode GetBPEnabledSpeakerMode()
	{
		return EGameVoiceListenMode.None;
	}

	private EGameVoiceListenMode GetBPEnabledMicMode()
	{
		return EGameVoiceListenMode.None;
	}

	private void OnBPVoiceJoinRoom(object[] data)
	{
	}

	private void _003COnUIInit_003Eb__57_0()
	{
	}

	private void _003COnUIInit_003Eb__57_1()
	{
	}

	private void _003COnUIInit_003Eb__57_2()
	{
	}

	private void _003COnUIInit_003Eb__57_3()
	{
	}

	private void _003COnUIInit_003Eb__57_4()
	{
	}

	private void _003CSetBPStatus_003Eb__71_0()
	{
	}

	private void _003CPlayPhaseChangeAnimation_003Eb__72_0()
	{
	}

	private void _003CPlayPhaseChangeAnimation_003Eb__72_1()
	{
	}

	private void _003CPlayStageChangeAnimation_003Eb__73_0()
	{
	}

	private void _003CPlayStageChangeAnimation_003Eb__73_1()
	{
	}

	private void _003CPlayStageChangeAnimation_003Eb__73_2()
	{
	}

	private void _003COnBtnRequestBanClick_003Eb__95_0()
	{
	}

	private void _003COnBtnRequestClick_003Eb__106_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}
}
