using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMessageController : UIBaseController, IUIModelDataChangeObserver
{
	public enum SocialInviteType
	{
		None,
		MixGroup,
		Reservation,
		Friend,
		Team
	}

	public class SocialInviteItemData
	{
		public SocialInviteType type;

		public object data;

		public float sortTime;

		public ulong reservationId;
	}

	public class HistoryMessageItemList : IEasyList
	{
		private UIHudMessageController m_Owner;

		public HistoryMessageItemList(UIHudMessageController owner)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	private enum EKeyboardSource
	{
		None,
		TrainingModeSend,
		TextChat
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__47_0;

		public static Action _003C_003E9__47_1;

		internal void _003CSetControllerCursorEvent_003Eb__47_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__47_1()
		{
		}
	}

	private static readonly int[] m_MicPermissions;

	private UIHudMessageView m_View;

	private UIModelTeamReserve m_ModelTeamReserve;

	private UIModelChat m_ModelChat;

	private UIModelMatch m_ModelMatch;

	private UIModelInGameChat m_ModelInGameChat;

	private List<UIHudQuickChatItemController> m_QuickChatItemList;

	private List<StickerSpriteView> m_StickerItemList;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCtrl;

	private UIClickMask m_ClickMask;

	public const int WIDGET_WIDTH = 276;

	public const int WIDGET_HEIGHT = 376;

	private UIModelQuickMessage m_QuickMsgModel;

	private bool m_ShowedServerData;

	private bool m_ShowedDefaultData;

	private TouchScreenKeyboard m_CurKeyBoard;

	private string m_CachedText;

	private int m_characterLimit;

	private EKeyboardSource m_KeyboardSource;

	private List<HistoryMessageItemData> m_HistoryMessageList;

	private List<ForbidQuickChatView> m_TeammatesViewMap;

	private List<MatchTeam.KMGBNNHDOHF> m_TeamCache;

	private bool m_IsAllMute;

	private ulong m_MatchID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void TrySendMsgToSocialChannel(string msg)
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnPlayerRevive(object[] data)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnTabToggleSelect(UIToggleButton button)
	{
	}

	public void AddClickMaskRange(UIWidget widget)
	{
	}

	private void OnNewMessageReceived(object[] data)
	{
	}

	private void OnQuickChatSoundBlockClick()
	{
	}

	private void OnSocialInviteBlockClick()
	{
	}

	private void OnStickerItemClick(object[] data)
	{
	}

	private void OnSendClick()
	{
	}

	private string Validate(string val)
	{
		return null;
	}

	private void StartMsgCDCheck()
	{
	}

	private void StartTextChatCDCheck()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	private void InitView()
	{
	}

	private void SetToggleView()
	{
	}

	private void InitSocialInviteBlockToggle()
	{
	}

	private void RefreshMsgList()
	{
	}

	private void RefreshQuickChatList(bool isDead = true)
	{
	}

	private void SetQuickChatList()
	{
	}

	private void InitForbidView()
	{
	}

	private void OnForbidViewDestroy()
	{
	}

	private void RefreshForbidView()
	{
	}

	private int CompareToTeamIndex(MatchTeam.KMGBNNHDOHF a, MatchTeam.KMGBNNHDOHF b)
	{
		return 0;
	}

	private void OnAllMuteBtnClick()
	{
	}

	private void SaveMatchID()
	{
	}

	private void CheckAllBtnMute()
	{
	}

	private void SetAllMuteBtnState(bool isAllBtnMute)
	{
	}

	private void OnForbidToggleSelect(UIToggleButton toggleButton)
	{
	}

	private void InitLeaderboardTitleContent()
	{
	}

	private void RefreshShowLeaderboardTitleToggle()
	{
	}

	private void OnLeaderboardTitleClick()
	{
	}

	private void AutoSelectLeaderboardTitleToggleCauseFirstClick()
	{
	}

	private void OnTextChatBtnClick()
	{
	}

	private void OnVoiceToTextBtnClick()
	{
	}

	private void OpenVoiceToTextUI()
	{
	}

	private void InitSocialInviteUITable2Template()
	{
	}

	private bool ShowReservationToggle()
	{
		return false;
	}

	private bool ShowTeamInviteToggle()
	{
		return false;
	}

	private bool IsExistTeamInvite()
	{
		return false;
	}

	private bool ShowFriendInviteToggle()
	{
		return false;
	}

	private bool IsExistFriendInvite()
	{
		return false;
	}

	private bool ShowForbidToggle()
	{
		return false;
	}

	private bool ShowStickerToggle()
	{
		return false;
	}

	private bool ShowQuickChatToggle()
	{
		return false;
	}

	private bool ShowHistoryMessageToggle()
	{
		return false;
	}

	private bool ShowSocialInviteToggle()
	{
		return false;
	}

	private bool ShowMixGroupToggle()
	{
		return false;
	}

	private bool IsSocialInviteRedDotShow()
	{
		return false;
	}

	private bool ShowTextChatBtn()
	{
		return false;
	}

	private bool ShowVoiceToTextBtn()
	{
		return false;
	}

	private bool ShowTrainingModeMessageContent()
	{
		return false;
	}

	public void RefreshSocialInviteList()
	{
	}

	private UIModelTeamReserve.EReserveReplyStatus GetMixGroupReplyStatus(object data)
	{
		return UIModelTeamReserve.EReserveReplyStatus.None;
	}

	private int GetMixGroupItemPriority(object data)
	{
		return 0;
	}

	private int GetMixGroupInviteStatusPriority(UIModelTeamReserve.EReserveReplyStatus status)
	{
		return 0;
	}

	private int GetMixGroupJoinStatusPriority(UIModelTeamReserve.EReserveReplyStatus status)
	{
		return 0;
	}

	private Vector2 GetSocialInviteItemSize(SocialInviteType type)
	{
		return default(Vector2);
	}

	public void RefreshHistoryMessageEasyList()
	{
	}

	private void _003COnVoiceToTextBtnClick_003Eb__72_0(Dictionary<int, bool> results)
	{
	}

	private UITable2.IUITable2Item _003CInitSocialInviteUITable2Template_003Eb__74_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitSocialInviteUITable2Template_003Eb__74_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitSocialInviteUITable2Template_003Eb__74_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitSocialInviteUITable2Template_003Eb__74_3()
	{
		return null;
	}

	private int _003CRefreshSocialInviteList_003Eb__90_0(SocialInviteItemData a, SocialInviteItemData b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
