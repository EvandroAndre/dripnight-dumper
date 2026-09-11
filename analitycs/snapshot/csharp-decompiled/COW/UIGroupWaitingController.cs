using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIGroupWaitingController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UIGroupWaitingController _003C_003E4__this;

		public uint reDefId;

		internal void _003CRefreshDownloadState_003Eb__0()
		{
		}
	}

	private sealed class _003CSetButtonCoolDown_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public UIGroupWaitingController _003C_003E4__this;

		public bool needHide;

		public UIButton btn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetButtonCoolDown_003Ed__48(int _003C_003E1__state)
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

	public bool NeedResetPos;

	private UIGroupWaitingView m_View;

	private UIGroupWaitingDropItem m_DragDropItem;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMap;

	private float m_CDTime;

	private bool m_IsInRemindCD;

	private bool m_IsAllReady;

	private bool m_IsUsedInGame;

	private bool m_IsSingleInHCMode;

	private int m_LastGroupCnt;

	private bool m_NeedRefreshGrid;

	private List<UIGroupMemberWaitingItemController> m_GroupMemberCtrls;

	private Coroutine m_ShowQuickBtnCoroutine;

	private GameObject m_RemindPlayShot;

	private UINewDownloadInfoController m_DownloadCtrl;

	public bool m_IsDuelMode;

	private bool m_HideNotAllReadyStateForBRReview;

	private bool m_IsHiddenByBRReviewFilter;

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

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void ChangeUseSpecialCameraRenderHangOutUI(object[] param)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void InitViewAndEventDelegate(bool isUsedInGame)
	{
	}

	private void RefreshReturnBtnView()
	{
	}

	private void SetVibrate(EGroup.RemindType remindType)
	{
	}

	private void SetNoticeBtnView()
	{
	}

	private void SetQuickBtnView(EGroup.RemindType remindType)
	{
	}

	private void SetWaitingView(bool isLeader)
	{
	}

	public void SetGroupInfoView(int groupCnt, int readyCnt, bool isLeader, bool duelMode = false)
	{
	}

	public void SetGroupInfoView()
	{
	}

	public void UpdateByAllReadyState(bool byTcpEvent = false)
	{
	}

	private void InitDragDropItem()
	{
	}

	private Vector2 GetBound()
	{
		return default(Vector2);
	}

	private void AdjustQuickBtnTrans()
	{
	}

	private void OnRemindSuccess()
	{
	}

	private void OnGetRemind(object[] data)
	{
	}

	public void SetAllReadyRemind(bool byTcpEvent = false)
	{
	}

	private void OnWholeBtnClick()
	{
	}

	private void Update()
	{
	}

	private void OnNoticeBtnClick()
	{
	}

	private void OnQuickBtnClick()
	{
	}

	private bool NeedNoticeLeader()
	{
		return false;
	}

	private bool NeedNoticeMember()
	{
		return false;
	}

	private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime, bool needHide)
	{
		return null;
	}

	private void ShowNoticeBtnCD(bool show)
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	public bool IsDragging()
	{
		return false;
	}

	public bool IsShowingAllReadyState()
	{
		return false;
	}

	public void SetHideNotAllReadyStateForBRReview(bool hideNotAllReadyState)
	{
	}

	private void ApplyBRReviewVisibilityFilter()
	{
	}

	private void SendMsgToLobby()
	{
	}

	private bool IsOpenHippoCrisisLobby()
	{
		return false;
	}

	private bool IsInHippoCrisisMode()
	{
		return false;
	}

	private void RefreshDownloadState()
	{
	}

	private void OnLeaveGroup(object[] data)
	{
	}

	private void OnTeammatesDisplayStatChange()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshGroupInfoView()
	{
	}

	private void RefreshGroupInfoViewInFriendObserver()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CInitDragDropItem_003Eb__36_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
