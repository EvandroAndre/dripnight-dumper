using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIHippoCrisisLobbyController : UINavigationController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<GroupMemberInfo, FriendInfo> _003C_003E9__45_0;

		internal FriendInfo _003COnFastSendGiftBtnClick_003Eb__45_0(GroupMemberInfo teammate)
		{
			return null;
		}
	}

	private sealed class _003CDelayCreateResidentFriendList_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHippoCrisisLobbyController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCreateResidentFriendList_003Ed__27(int _003C_003E1__state)
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

	private UIHippoCrisisLobbyView m_View;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private UIModelUser m_ModelUser;

	private UIModelActivity m_ModelActivity;

	private UIModelChat m_ModelChat;

	private UIModelGroup m_ModelGroup;

	private UIModelInventory m_ModelInventory;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelAvatar m_ModelAvatar;

	private UIModelCollection m_ModelCollection;

	private uint m_NoticeRecruitDelayCallID;

	private UILobbyV2InviteGroupBoxController m_InviteBox;

	private UILobbyV2ResidentFriendListController m_ResidentFriendListCtrl;

	private UIHippoCrisisLobbyMissionPanelController m_MissionPanelCtrl;

	private UIHippoCrisisLobbyEquipmentController m_EquipmentCtrl;

	private UIHippoCrisisLobbyStartGameController m_StartGameCtrl;

	private UIHippoCrisisCommonTopCurrencyController m_TopCurrencyCtrl;

	private uint m_MessageDispearCallID;

	private int m_MessageLabelOrigWidth;

	private const string SHOWEDRULEEFFECT = "ShowedRuleEffect";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	private void StartGuide()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private IEnumerator DelayCreateResidentFriendList()
	{
		return null;
	}

	private void CreateResidentFriendList()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OpenInviteGroupBox(GroupInviteMemberType defaultInviteType = GroupInviteMemberType.Friend)
	{
	}

	public void CloseInviteBoxWithUIEffect()
	{
	}

	private void RefreshTailorEffect()
	{
	}

	private void RefreshLatestMessage()
	{
	}

	private void OnRefreshGroupModeUI(object[] data)
	{
	}

	private void OnGroupEnter(object[] param)
	{
	}

	private void OnGroupQuit()
	{
	}

	private void RefreshNoticeRecruitState(object[] data)
	{
	}

	private void OnGroupStateChange(bool inTeam)
	{
	}

	private void OnChatGroupInfoChange()
	{
	}

	private void OnChatRecruitBtnClick()
	{
	}

	public void OnRecruitTeammateBtnClick()
	{
	}

	private void OnChatBtnClick()
	{
	}

	private void OnChatMessageBtnClick()
	{
	}

	private void OnFastSendGiftBtnClick()
	{
	}

	private void OnChatMessageLabelScrollFinish()
	{
	}

	private void OnInviteClick()
	{
	}

	private void OnInventoryBtnClick()
	{
	}

	private void OnMarketBtnClick()
	{
	}

	private void OnLeaderboardBtnClick()
	{
	}

	private void OnGoToLobbyBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void _003CRefreshNoticeRecruitState_003Eb__38_0()
	{
	}

	private void _003COnCloseBtnClick_003Eb__53_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
