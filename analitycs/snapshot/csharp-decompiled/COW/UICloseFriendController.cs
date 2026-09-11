using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UICloseFriendController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__26_0;

		public static Action _003C_003E9__47_0;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__48_0;

		internal BaseItemInfo _003COnShowRewardWnd_003Eb__26_0(AwardDesc item)
		{
			return null;
		}

		internal void _003COnReceivedIntimacyRewards_003Eb__47_0()
		{
		}

		internal CommonRewardItemInfo _003COnDataChanged_003Eb__48_0(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UICloseFriendController _003C_003E4__this;

		public UISecondConfirmSmallContoller controller;

		internal void _003COnClickRequestBreakBtn_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public UICloseFriendController _003C_003E4__this;

		public UISecondConfirmSmallContoller controller;

		internal void _003COnClickBreakRelationshipBtn_003Eb__0()
		{
		}

		internal void _003COnClickBreakRelationshipBtn_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public UICloseFriendController _003C_003E4__this;

		public UISecondConfirmSmallContoller inviteConfirmCtrl;

		internal void _003COnClickInvite_003Eb__0()
		{
		}
	}

	private sealed class _003CStartProgressBarChange_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICloseFriendController _003C_003E4__this;

		public float IntimacyMax;

		private float _003CupdateTime_003E5__2;

		private int _003ColdValue_003E5__3;

		private uint _003CnewValue_003E5__4;

		private float _003CcurrentValue_003E5__5;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartProgressBarChange_003Ed__46(int _003C_003E1__state)
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

	public const float IntimacyAwardShowAwardPaddingX = 1.15f;

	public const float VFXSkillShareAwardStayTime = 1f;

	public const int BtnTableEachBtnWidth = 80;

	private UICloseFriendView m_View;

	private uint m_ShareSkillAwardLevel;

	private uint m_DelayCallId;

	private UIModelRelationShip m_RelationshipModel;

	private FriendAccountInfo m_CurrentInviteFriend;

	private RelationshipInfo m_CurrentRelationshipInfo;

	private RelationTypeInfoData m_ConfigRelationshipData;

	private Dictionary<uint, UIRelationshipRewardItemController> m_ItemList;

	private bool m_isDismissApplicant;

	private bool m_GroupBuildInCurPage;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateCheckboxforNotify()
	{
	}

	private void OnShowInviteWnd(object[] param)
	{
	}

	private void OnClickSettingBtn()
	{
	}

	private void OnClickAnniversaryTips()
	{
	}

	private void OnClickBtnSkillShareTip()
	{
	}

	private void OnNotifyCheckboxChange()
	{
	}

	private void OnClickDescTips()
	{
	}

	private void OnClickRequestBreakBtn()
	{
	}

	private void OnClickChatBtn()
	{
	}

	private void OnClickRequestGroup()
	{
	}

	private void OnShowRewardWnd(object[] param)
	{
	}

	private void OnChooseFriend(object[] param)
	{
	}

	private void OnClickCallBackBtn()
	{
	}

	private void OnClickMaskBtn()
	{
	}

	private void OnClickMaskBtn_2()
	{
	}

	private void OnClickBreakRelationshipBtn()
	{
	}

	private void OnClickSendGift()
	{
	}

	private void OnClickInvite()
	{
	}

	private void OnClickSelectFriend()
	{
	}

	private void OnClickInvitationList()
	{
	}

	public void ShowContent(RelationshipInfo CurrentInfo)
	{
	}

	private void RefreshStateNone()
	{
	}

	private void RefreshStateSent()
	{
	}

	private void RefreshStateAlreadyBe()
	{
	}

	private void RefreshIntimacyState()
	{
	}

	private void RefreshStateWaitBroken()
	{
	}

	private void OnSkillShareReward()
	{
	}

	private void UpdateBtnSkillShareTip(bool showSkillShareTip)
	{
	}

	private void RefreshRewardList(object[] param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private IEnumerator StartProgressBarChange(float IntimacyMax)
	{
		return null;
	}

	private void OnReceivedIntimacyRewards(List<CommonRewardItemInfo> rewardData)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void ClearChooseFriend()
	{
	}

	private void _003CRefreshStateWaitBroken_003Eb__41_0()
	{
	}

	private void _003COnSkillShareReward_003Eb__42_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
