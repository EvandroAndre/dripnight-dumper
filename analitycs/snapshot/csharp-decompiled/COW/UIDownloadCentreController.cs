using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__73_1;

		public static EventDelegate.Callback _003C_003E9__73_2;

		internal void _003COnDownloadAllClick_003Eb__73_1()
		{
		}

		internal void _003COnDownloadAllClick_003Eb__73_2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public uint patchOptionalTypeId;

		internal bool _003CScrollerToSpecificTab_003Eb__0(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public uint optionalReDefId;

		internal bool _003CScrollerToSpecificItem_003Eb__0(uint x)
		{
			return false;
		}
	}

	private sealed class _003CStartTabItemShowInit_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDownloadCentreController _003C_003E4__this;

		private int _003Cindex_003E5__2;

		private int _003Cend_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartTabItemShowInit_003Ed__65(int _003C_003E1__state)
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

	private UIDownloadCentreView m_View;

	private UIModelOptionalDownload m_Model;

	private EModelDownloadState m_LastShowedState;

	private uint m_CurrentSelectTabTypeId;

	private uint m_GridTabTypeId;

	private UIWaitingForRequestController m_WaitforReqCtrl;

	private List<uint> m_TabDownloadTypeList;

	private List<UIDownloadCentreTabItemController> m_TabItems;

	private DownloadCentreContentItemShowType m_ShowType;

	private UIDownloadCentreSettingWndController m_SettingWnd;

	private List<uint> m_DownloadInfoShowTagList;

	private List<uint> m_TempDownloadInfoShowTagList;

	public const int MAXLEFTTABGRID = 5;

	private Coroutine m_OpenTabItemCoroutine;

	private bool m_TabItemInitFinished;

	private const int MAXOPENTABITEMCOUNTONFRAME = 5;

	private EDownloadCentreDownloadState m_DownloadCentreDownloadState;

	private EDownloadCentrePageShowType m_DownloadCentrePageShowType;

	private List<UIDownloadCentreBaseItemController> m_BaseItemCtrl;

	private const string PauseBtnEnableSpriteName = "UI_Btn_01_Mid_Normal";

	private const string BtnUnAbelSpriteName = "UI_Btn_0102_Mid_Disable";

	private const string DownloadBtnEnableSpriteName = "UI_Btn_02_Mid_Normal";

	private const string OptionalDownloadSizeKey = "{0}MB";

	private Vector3 RepairBtnPosInRecommend;

	private Vector3 RepaireBtnPosInNormal;

	private List<UIDownloadCentreBaseItemController> m_RecommendCtrls;

	private uint m_AfterCorCallBackGoto;

	private bool m_showLogin;

	private float TotalTimeForNetState;

	private MutableString m_SelecterProgressSb;

	private const string OptionalDownloadSizeUnit = "MB";

	private string m_CentreKeyDolocResult;

	private string m_ProgressTempText;

	private float m_LastShowAmount;

	private float m_NowShowAmount;

	private EDownloadCentreDownloadState m_LastDownloadCenterState;

	private List<uint> m_needDeletedTagDownloadInfoId;

	public EDownloadCentrePageShowType DownloadCentreShowType => EDownloadCentrePageShowType.Recommend;

	public EDownloadCentreDownloadState DownloadCentreDownloadState => EDownloadCentreDownloadState.Download;

	public bool SHOWINLOGIN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string Rule()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	public override bool EnablePlayTweenAminAgain()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void RefreshSettingBtnShowState()
	{
	}

	private void OnSettingBtnClick()
	{
	}

	private void SwitchPageShow(EDownloadCentrePageShowType showType)
	{
	}

	private void CheckToggleBtnShow()
	{
	}

	private void InitRecommendPage()
	{
	}

	private void Update()
	{
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	private void RefreshTotalAmount(bool forceUpdate = false)
	{
	}

	private void RefreshTotalAmount_OLD()
	{
	}

	private void RefreshTotalAmount_New(bool forceUpdate)
	{
	}

	public void GotoSpeicficOptionalReDefItemTab(uint optionalReDefId)
	{
	}

	public void GotoSpeicficTab(uint patchOptionalTypeId)
	{
	}

	public void ScrollerToSpecificTab(uint patchOptionalTypeId)
	{
	}

	public void ScrollerToSpecificItem(uint patchTypeId, uint optionalReDefId)
	{
	}

	private void InitTabCtrlState()
	{
	}

	private void InitTabItemShowState()
	{
	}

	private IEnumerator StartTabItemShowInit()
	{
		return null;
	}

	private void GotoSpeicficCallBack()
	{
	}

	private UIDownloadCentreTabItemController OpenNewDownloadCentreTabItemController()
	{
		return null;
	}

	private void RefreshNowContentShowType()
	{
	}

	private void SetNowNewState()
	{
	}

	public void RefreshDownloadCentreItemShow()
	{
	}

	private void RefreshLoadingIconShowState()
	{
	}

	private void OnPauseAllDownloadClick()
	{
	}

	private void OnDownloadAllClick()
	{
	}

	private void TabItemClick(object[] data)
	{
	}

	private void OnCheckToggleDeletedCheckAllClick()
	{
	}

	public void SetCoroutineCallBackGoto(uint optionalRedefId)
	{
	}

	private void ChangeTagDownloadInfoInDeteledList(bool add = true)
	{
	}

	private void OnRecomendPageBtnClick()
	{
	}

	private void OnMoreBtnClick()
	{
	}

	private void OnDeleteBtnClick()
	{
	}

	private void SwitchDownloadStateShow(EDownloadCentreDownloadState downloadState)
	{
	}

	private void ChangeDownloadBaseItemShowState()
	{
	}

	private void ChangeDownloadBaseItemToggleState(bool clear = false, bool Total = false)
	{
	}

	public void DownloadCentreNeedDeletedOptionalRedefIdRefresh(uint tagDownloadInfoId, bool add = true)
	{
	}

	public bool CheckThisTagNeedDeleted(uint tagDownloadId)
	{
		return false;
	}

	private void RefreshMoreBtnRewardRedTips()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void DownloadAllBtnStateInit()
	{
	}

	private void ChangePauseAndCancelBtnShowState()
	{
	}

	private void ChangeDownloadAndDeletedBtnShowState()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public bool CheckSkipDelete(uint tagDownloadId)
	{
		return false;
	}

	private void _003COnDownloadAllClick_003Eb__73_0()
	{
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_EnablePlayTweenAminAgain()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}
}
