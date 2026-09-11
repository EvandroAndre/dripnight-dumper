using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMailController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public uint type;

		internal bool _003CSelectMail_003Eb__0(MailInfo mail)
		{
			return false;
		}

		internal bool _003CSelectMail_003Eb__1(MailInfo mail)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public UIMailController _003C_003E4__this;

		public EMail.Status type;

		public bool isBatchOp;

		public Predicate<MailInfo> _003C_003E9__1;

		public Predicate<MailInfo> _003C_003E9__2;

		internal void _003CReadMailRefreshUIData_003Eb__0()
		{
		}

		internal bool _003CReadMailRefreshUIData_003Eb__1(MailInfo a)
		{
			return false;
		}

		internal bool _003CReadMailRefreshUIData_003Eb__2(MailInfo a)
		{
			return false;
		}
	}

	private sealed class _003CDelayCreateTopItem_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMailController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCreateTopItem_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CGetMailRefreshUIDataDelay_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMailController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetMailRefreshUIDataDelay_003Ed__80(int _003C_003E1__state)
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

	private sealed class _003CtReasonTableReposition_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMailController _003C_003E4__this;

		public bool isReportHack;

		public bool isRankCreditPunish;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CtReasonTableReposition_003Ed__93(int _003C_003E1__state)
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

	private UIMailView m_View;

	private UIModelMail m_Model;

	private MailTab m_CurrentTab;

	private List<MailInfo> m_MailInfoList;

	private List<MailInfo> m_NoticeInfoList;

	private List<MailInfo> m_SystemInfoList;

	private int m_CurrentIndex;

	private MailInfo m_CurrentMailInfo;

	private ulong m_CurrentMailId;

	private List<MailInfo> m_ShouldUpdateMail;

	private List<MailInfo> m_ShouldDelayUpdateMail;

	private List<ReportMailInfo> m_ReportMailInfoList;

	private int m_CurrentReportIndex;

	private ReportMailInfo m_CurrentReportMailInfo;

	private ulong m_CurrentReportMailId;

	private List<ReportMailInfo> m_ShouldUpdateReportMail;

	private List<ReportMailInfo> m_ShouldDelayUpdateReportMail;

	private UIMailReportReasonItemController m_UIMailReportReason;

	private Action m_ActionOnActive;

	private UIMallV2IntimacyProfileInfoController m_GiftMailCallsignCtrl;

	private FriendInfo m_GiftMailSenderInfo;

	private UIStandardItemMAXBController m_GiftMailItemCtrl;

	private const int MailNoRewardBottom = 20;

	private const int MailRewardBottom = 140;

	private const string GoPosToRelationShipLabelKey = "T_38_AG_BUDDY_MAIL";

	private const string GoPosToCreditReportKey = "T_41_WCL_CREDITPENALTY_MAILGOPOS";

	private const string GoPosToTournamentKey = "T_51_ZF_ESPORTS_TOURNAMENT_JOIN_TEAM";

	private string mainReasons;

	private string matchTimeStamp;

	private string reportTimeStamp;

	private bool outGameFlg;

	private List<uint> m_ReportTypeLists;

	private uint m_GoPos;

	private string m_subGoPos;

	private ReportFeedbackMailData m_ReportFeedbackMailData;

	private bool m_PageOpening;

	private Coroutine m_DelayCreateCoroutine;

	private UIMailTopItem m_MailTopItemController;

	private UIMailTopItem MailTopItemController => null;

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

	protected override void OnVisibilityChanged()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnReceiveAllBtnClick()
	{
	}

	private void OnDeleteAllBtnClick()
	{
	}

	private void OnRejectBtnClick()
	{
	}

	public void SelectMail(uint type)
	{
	}

	private void OnAcceptBtnClick()
	{
	}

	private void OnReceiveBtnClick()
	{
	}

	private void OnOpenBtnClick()
	{
	}

	private void OnClickGoToCreditButton()
	{
	}

	private void OnClickGoPosBtn()
	{
	}

	private void UrgentCreateTopItem()
	{
	}

	private IEnumerator DelayCreateTopItem()
	{
		return null;
	}

	public void ChangeTab(MailTab tab)
	{
	}

	private void OnClickNoticeTabBtn()
	{
	}

	private void OnClickSystemTabBtn()
	{
	}

	private void OnClickReportTabBtn()
	{
	}

	public void ShowGetGiftPanel(MailInfo mailInfo)
	{
	}

	private void OnDeleteBtnClick()
	{
	}

	public void SetMailStatus(EMail.Status status)
	{
	}

	public void SetReportMailStatus(EMail.Status status)
	{
	}

	private void SetMailContentBtnStatus(bool del = true, bool rec = false, bool acc = false, bool rej = false, bool open = false, bool gotoHistoryDetail = false)
	{
	}

	private void GotoHistoryDetail()
	{
	}

	private void UpdateMailView(object[] data)
	{
	}

	private void SetCDNContent()
	{
	}

	private void OnCDNContentBtnClick()
	{
	}

	private void SetButtonStateByMailType()
	{
	}

	private void RefreshBatchOperationBtns()
	{
	}

	private void RefreshRewardData()
	{
	}

	private void SetMailGrid(UIGrid grid, MailAttachment attachment, EMail.Status status)
	{
	}

	private void SetRewardContainerActive(bool active)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void CheckIfPopupRewards(object[] objects)
	{
	}

	private void CheckIfPopupRewardsReport(object[] objects)
	{
	}

	private void GetMailRefreshUIData()
	{
	}

	private IEnumerator GetMailRefreshUIDataDelay()
	{
		return null;
	}

	private void GetMailRefreshUIDataImmediately()
	{
	}

	private void ReadMailRefreshUIData(object[] objects)
	{
	}

	private void ReadReportMailRefreshUIData(object[] objects)
	{
	}

	private void SelectMailItem(int index)
	{
	}

	private void SelectReportMailItem(int index)
	{
	}

	private void RefreshMailUI(bool show)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void RefreshReportMailView()
	{
	}

	private void RefreshReportGoPosBtn(ReportFeedbackMailData data)
	{
	}

	private void OnReportGoPosBtnClick()
	{
	}

	private IEnumerator tReasonTableReposition(bool isReportHack, bool isRankCreditPunish)
	{
		return null;
	}

	private void SetMailContentText(string text)
	{
	}

	private void SetMailContextTextWithSpritesMixed(string text, string[] spriteNames)
	{
	}

	private void SetGiftMailMessageText(string text)
	{
	}

	private string FixRichTextToBlack(string str)
	{
		return null;
	}

	private string GetMainReason(uint reason)
	{
		return null;
	}

	private void RefreshGiftMailAddFriendBtn()
	{
	}

	private void OnClickGiftMailAddFriendBtn()
	{
	}

	private void OnClickApplyJoinClan()
	{
	}

	private void RefreshCallsignView()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	private bool _003COnDeleteAllBtnClick_003Eb__46_0(MailInfo a)
	{
		return false;
	}

	private void _003COnDeleteAllBtnClick_003Eb__46_1()
	{
	}

	private void _003COnDeleteAllBtnClick_003Eb__46_2()
	{
	}

	private bool _003COnDeleteAllBtnClick_003Eb__46_3(MailInfo a)
	{
		return false;
	}

	private void _003COnDeleteAllBtnClick_003Eb__46_4()
	{
	}

	private void _003COnDeleteAllBtnClick_003Eb__46_5()
	{
	}

	private bool _003COnDeleteAllBtnClick_003Eb__46_6(ReportMailInfo a)
	{
		return false;
	}

	private void _003COnDeleteAllBtnClick_003Eb__46_7()
	{
	}

	private void _003COnDeleteAllBtnClick_003Eb__46_8()
	{
	}

	private bool _003CReadReportMailRefreshUIData_003Eb__83_0(ReportMailInfo a)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
