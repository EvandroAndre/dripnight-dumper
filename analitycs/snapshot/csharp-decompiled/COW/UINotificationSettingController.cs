using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UINotificationSettingController : UISettingContentBase
{
	private enum BlockType
	{
		LobbyMsg,
		Notification,
		Barrage,
		CupMatch
	}

	private enum NotificationSettingKey
	{
		Stranger,
		Booking,
		AcceptInvite,
		FriendRecommend,
		NotificationFriendApply,
		ChatBubble,
		FreeGacha,
		DiamondMembership,
		CupInvite,
		CupJoinTeam,
		GameResultFriendRecommend,
		GameResultInviteRecommend,
		InviteNotify,
		BarrageForRelationShip,
		BarrageForGuildWar,
		SendRemindNotify,
		LobbyVibration,
		TeamUpRecommend
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__23_1;

		public static Action _003C_003E9__23_2;

		public static Func<int> _003C_003E9__23_0;

		public static Action _003C_003E9__24_1;

		public static Action _003C_003E9__24_2;

		public static Func<int> _003C_003E9__24_0;

		public static Action _003C_003E9__25_1;

		public static Action _003C_003E9__25_2;

		public static Func<int> _003C_003E9__25_0;

		public static Action _003C_003E9__26_1;

		public static Action _003C_003E9__26_2;

		public static Func<int> _003C_003E9__26_0;

		public static Action _003C_003E9__27_1;

		public static Action _003C_003E9__27_2;

		public static Func<int> _003C_003E9__27_0;

		public static Action _003C_003E9__28_1;

		public static Action _003C_003E9__28_2;

		public static Func<int> _003C_003E9__28_0;

		public static Func<int> _003C_003E9__47_0;

		internal void _003CCreateTeamUpRecommendData_003Eb__23_1()
		{
		}

		internal void _003CCreateTeamUpRecommendData_003Eb__23_2()
		{
		}

		internal int _003CCreateTeamUpRecommendData_003Eb__23_0()
		{
			return 0;
		}

		internal void _003CCreateLobbyVibrationData_003Eb__24_1()
		{
		}

		internal void _003CCreateLobbyVibrationData_003Eb__24_2()
		{
		}

		internal int _003CCreateLobbyVibrationData_003Eb__24_0()
		{
			return 0;
		}

		internal void _003CCreateGameResultInviteRecommendData_003Eb__25_1()
		{
		}

		internal void _003CCreateGameResultInviteRecommendData_003Eb__25_2()
		{
		}

		internal int _003CCreateGameResultInviteRecommendData_003Eb__25_0()
		{
			return 0;
		}

		internal void _003CCreateGameResultFriendRecommendData_003Eb__26_1()
		{
		}

		internal void _003CCreateGameResultFriendRecommendData_003Eb__26_2()
		{
		}

		internal int _003CCreateGameResultFriendRecommendData_003Eb__26_0()
		{
			return 0;
		}

		internal void _003CCreateRequestJoinCupTeamData_003Eb__27_1()
		{
		}

		internal void _003CCreateRequestJoinCupTeamData_003Eb__27_2()
		{
		}

		internal int _003CCreateRequestJoinCupTeamData_003Eb__27_0()
		{
			return 0;
		}

		internal void _003CCreateCupInviteData_003Eb__28_1()
		{
		}

		internal void _003CCreateCupInviteData_003Eb__28_2()
		{
		}

		internal int _003CCreateCupInviteData_003Eb__28_0()
		{
			return 0;
		}

		internal int _003CCreateBarrageForFriendShipData_003Eb__47_0()
		{
			return 0;
		}
	}

	private sealed class _003CRefreshScroll_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINotificationSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__14(int _003C_003E1__state)
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

	private UINotificationsSettingView m_View;

	private bool m_PreInviteNotify;

	private bool m_IsClickBarrageSwitchToggle;

	private Dictionary<int, UICommonSettingContentController> m_CtrlList;

	private Dictionary<int, CommonSettingContentData> m_DataList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void RefreshContent(object[] param)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void Start()
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
	}

	private CommonSettingContentData CreateCupMatchData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateStrangerData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateBookingData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateAcceptInviteData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateFriendRecommendData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateChatBubbletData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateNotifyFriendApplyData()
	{
		return null;
	}

	private CommonSettingContentData CreateBlock1Data()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateTeamUpRecommendData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateLobbyVibrationData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateGameResultInviteRecommendData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateGameResultFriendRecommendData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateRequestJoinCupTeamData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateCupInviteData()
	{
		return null;
	}

	private void OnStrangerOn()
	{
	}

	private void OnStrangerOff()
	{
	}

	private void OnBookingOn()
	{
	}

	private void OnBookingOff()
	{
	}

	private void OnAcceptInviteOn()
	{
	}

	private void OnAcceptInviteOff()
	{
	}

	private void OnFriendRecommendOn()
	{
	}

	private void OnFriendRecommendOff()
	{
	}

	private void OnChatBubbleOn()
	{
	}

	private void OnChatBubbleOff()
	{
	}

	private void OnNotifyFriendApplyOn()
	{
	}

	private void OnNotifyFriendApplyOff()
	{
	}

	private int GetStrangerSelectBtn()
	{
		return 0;
	}

	private int GetBookingSelectBtn()
	{
		return 0;
	}

	private int GetAcceptInviteSelectBtn()
	{
		return 0;
	}

	private int GetFriendRecommendSelectBtn()
	{
		return 0;
	}

	private int GetNotifyFriendApplySelectBtn()
	{
		return 0;
	}

	private int GetChatBubbleSelectBtn()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateBarrageForFriendShipData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateDiamondMembershipData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateInviteNotifyData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateSendRemindNotifyData()
	{
		return null;
	}

	private CommonSettingContentData CreateBlock3Data()
	{
		return null;
	}

	private bool InviteNotifyIsEnable()
	{
		return false;
	}

	private void OnDiamondMembershipOn()
	{
	}

	private void OnDiamondMembershipOff()
	{
	}

	private void OnSendRemindNotifyOn()
	{
	}

	private void OnSendRemindNotifyOff()
	{
	}

	private void OnSendRemindNotifyTipClick()
	{
	}

	private void OnInviteNotifyOn()
	{
	}

	private void OnInviteNotifyOff()
	{
	}

	private void RefreshInviteNotify()
	{
	}

	private int GetDiamondMembershipSelectBtn()
	{
		return 0;
	}

	private int GetInviteNotifyBtn()
	{
		return 0;
	}

	private int GetSendRemindNotifyBtn()
	{
		return 0;
	}

	private void RefreshBtnsState(object[] param)
	{
	}

	private CommonSettingContentData CreateBlockBarrageData()
	{
		return null;
	}

	private void _003CCreateBarrageForFriendShipData_003Eb__47_1()
	{
	}

	private void _003CCreateBarrageForFriendShipData_003Eb__47_2()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
