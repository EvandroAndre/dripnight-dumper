using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudReportNewController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<uint, ECreditScore.ReportType> _003C_003E9__53_1;

		internal ECreditScore.ReportType _003CReportPlayer_003Eb__53_1(uint item)
		{
			return ECreditScore.ReportType.ReportType_NONE;
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public ulong userId;

		internal bool _003CSetUIData_003Eb__0(CandidateReporteeData item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public ulong userId;

		internal bool _003CSetLobbyUIData_003Eb__0(CandidateReporteeData item)
		{
			return false;
		}
	}

	private sealed class _003CInitToggle_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudReportNewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitToggle_003Ed__38(int _003C_003E1__state)
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

	private UIHudReportNewView m_View;

	private ulong m_ReporteeUserId;

	private string m_ReporteeClientVersion;

	private uint m_ReporteeClientType;

	private BHGGAEEHJCO m_ReporteePlayerId;

	private string m_NickName;

	private uint m_HeadPic;

	private CandidateReporteeType m_ReporteeType;

	private uint m_ReportReason;

	private List<UIHudReportMainReasonToggleController> m_MainReasonCtrlList;

	private Dictionary<uint, List<UIHudReportSubReasonToggleController>> m_SubReasonCtrlDic;

	private Dictionary<uint, List<uint>> m_ReasonDic;

	private List<uint> m_SubReason;

	private UIToggleButtonGroup m_MainReasonToggleGroup;

	private List<CandidateReporteeData> m_ReporteeList;

	private ulong m_MatchID;

	private bool m_InGame;

	private ulong? m_HistoryMatchId;

	private bool m_IsInLobby;

	private UINavigationUtil.UINavigationFrom m_From;

	private bool m_IsProfileReport;

	private bool m_HideReporteeInfo;

	private uint m_GameMode;

	private uint m_MatchMode;

	private const string PhotoWallDailyReportKeyPrefix = "PhotoWallDailyReport";

	private const string PhotoWallDailyReportCountDayKeyPrefix = "PhotoWallDailyReportCountDay";

	private bool m_CloseHit;

	private UIModelReport.EReportMethod m_ReportMethod;

	private Action _003COnReportConfirmed_003Ek__BackingField;

	public bool CloseOnHit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Action OnReportConfirmed
	{
		get
		{
			return _003COnReportConfirmed_003Ek__BackingField;
		}
		set
		{
			_003COnReportConfirmed_003Ek__BackingField = value;
		}
	}

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

	private IEnumerator InitToggle()
	{
		return null;
	}

	private void IniteMainToggleGroup()
	{
	}

	private void TryRecoverContent()
	{
	}

	private UIHudReportMainReasonToggleController OpenNewMainReasonController(ReportReason reason, UIHudReportMainReasonLineController lineCtrl)
	{
		return null;
	}

	public void SetHistoryMatchId(ulong matchId)
	{
	}

	private UIHudReportSubReasonToggleController OpenNewSubReasonController(ReportType subReason, UIHudReportMainReasonToggleController mainCtrl)
	{
		return null;
	}

	private string GetReasonString(ReportType subReason)
	{
		return null;
	}

	private void GetSubReason()
	{
	}

	private void MainReasonToggleSelected(object[] param)
	{
	}

	private void InitSubReasonCtrl()
	{
	}

	private void InitPos()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetEmpty(bool finishedReport = false)
	{
	}

	public void SetUIData(ulong userId, string name, BHGGAEEHJCO playerID, List<CandidateReporteeData> datas, uint gameMode, uint matchMode, uint groupMode, ulong matchID, bool InGame, bool needDeepCloneReporteeData = true, bool hideReporteeInfo = false, UIModelReport.EReportMethod method = UIModelReport.EReportMethod.Common, bool finishedReportWhenEmpty = false)
	{
	}

	public void SetLobbyUIData(ulong userId, string name, List<CandidateReporteeData> datas, UINavigationUtil.UINavigationFrom from = UINavigationUtil.UINavigationFrom.None)
	{
	}

	private void ReportPlayer()
	{
	}

	private bool ShouldBlockPhotoWallDailyReport()
	{
		return false;
	}

	private bool IsPhotoWallReportRecordedToday(ulong reporteeUserId)
	{
		return false;
	}

	private void RecordPhotoWallDailyReport()
	{
	}

	private string GetPhotoWallDailyReportKey(ulong reporteeUserId)
	{
		return null;
	}

	private bool HasReachedPhotoWallDailyReportLimit(PhotoWallReportDesc photoWallDesc)
	{
		return false;
	}

	private uint GetPhotoWallDailyReportCountToday()
	{
		return 0u;
	}

	private PhotoWallReportInfo GetOrCreateLocalPlayerPhotoWallReportInfo()
	{
		return null;
	}

	private void SyncPhotoWallDailyReportCountDay(PhotoWallReportInfo reportInfo)
	{
	}

	private void IncrementPhotoWallDailyReportCount()
	{
	}

	private string GetPhotoWallDailyReportCountDayKey()
	{
		return null;
	}

	private void OnBtnConfirmClick()
	{
	}

	private void OnBtnConfrimFeedback()
	{
	}

	private void HideFeedbackAndShowReport()
	{
	}

	public ulong GetCurrentSelectedReporteeUserId()
	{
		return 0uL;
	}

	public void OnReporteeItemSelected(UIHudReportNewPlayerItemController selectedItem, CandidateReporteeData data)
	{
	}

	private void SelectReporteeItemByIndex(int index)
	{
	}

	private void InitReasons(uint gameMode, uint matchMode, uint groupMode)
	{
	}

	private uint GetFromType()
	{
		return 0u;
	}

	private void OnPlayerBeHit(object[] param)
	{
	}

	private void OnReportFeedback(object[] param)
	{
	}

	private void ShowSuccessFeedback(ReportFeedbackData data)
	{
	}

	private void SuccessFeedbackShowProtectComponsation()
	{
	}

	private void ShowHead(uint headPic)
	{
	}

	public void ShowFailedFeedback()
	{
	}

	public void ShowCreditAutoReportFeedback()
	{
	}

	private MatchRecordPersonal GetHistoryRecord()
	{
		return null;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void _003CReportPlayer_003Eb__53_0(HttpErrorCode errCode, object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
