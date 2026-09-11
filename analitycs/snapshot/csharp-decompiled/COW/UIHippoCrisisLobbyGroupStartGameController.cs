using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHippoCrisisLobbyGroupStartGameController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CSetButtonCoolDown_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public UIHippoCrisisLobbyGroupStartGameController _003C_003E4__this;

		public UIButton btn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetButtonCoolDown_003Ed__71(int _003C_003E1__state)
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

	private UIHippoCrisisLobbyGroupStartGameView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelMatch m_ModelMatch;

	private UIModelInventory m_ModelInventory;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private UIHippoCrisisLobbyTeamInfoController m_TeamInfoController;

	private UIHippoCrisisRankIconController m_HippoCrisisRankIconController;

	private CMDBIPLGLGA m_GroupMode;

	private bool m_IsInGame;

	private uint m_PlayDelayCall;

	private uint m_AllReadyDelayCall;

	private bool m_UpdateAfterPurchase;

	private bool m_AllReady;

	private bool m_IsNeedPreStart;

	private UIPopupMessageBoxController m_QuitDialog;

	private GameObject m_RemindPlayShot;

	private IEnumerator m_ResetReadyButtonCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnRemindSuccess()
	{
	}

	private void OnGetRemind(object[] param)
	{
	}

	private void RefreshGroupLeaderView(object[] data)
	{
	}

	private void OnGroupNotReady(object[] data)
	{
	}

	public void StopRemindAnim(object[] data)
	{
	}

	private void OnSelfNotReady(object[] data)
	{
	}

	private void CancelPlayDelayCall()
	{
	}

	private void RefreshReadyState(object[] param)
	{
	}

	private bool CheckIsMapAvailabe()
	{
		return false;
	}

	private void RequestPlayAfterCreateGroup()
	{
	}

	private void RefreshBtnTeamInfoView()
	{
	}

	private void UpdateGroupInfo()
	{
	}

	public void CloseGroupUI()
	{
	}

	private void UpdateSkillBtnState()
	{
	}

	private void HideReadyEffect(object[] data)
	{
	}

	private void RefreshReadyBtnStyle()
	{
	}

	private void OnGroupAllReadyStateChanged(object[] data)
	{
	}

	private void RefreshStartBtn(bool showAllReady = false, bool showAllReadyTips = false)
	{
	}

	private void RefreshPreStartBtn()
	{
	}

	private void ShowReadyEffect(GroupEffectShow show)
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private void OnLeaveNtf(object[] data)
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void OnServiceOff(object[] data)
	{
	}

	private void HandleLeaveNtf(object[] param)
	{
	}

	private void OnGroupStartNtf(object[] data)
	{
	}

	private void OnGroupStopNtf(object[] data)
	{
	}

	private void OnGroupReadyNtf(object[] data)
	{
	}

	private void OnQuitToSolo(object[] data)
	{
	}

	private void OnCreateGroupFail(object[] data)
	{
	}

	private void OnDismissNtf(object[] data)
	{
	}

	private void OnGroupQuit(object[] data)
	{
	}

	private void NotInGroup(object[] data)
	{
	}

	public void SetData(uint groupMode)
	{
	}

	private void OnClickLeaveGroup(object[] data)
	{
	}

	private void onLeaveBtnClick()
	{
	}

	private void OnMatchmakingHide()
	{
	}

	private void OnMatchmakingShow()
	{
	}

	private void RefreshBtnView()
	{
	}

	private void GroupInfoSync(object[] param)
	{
	}

	private void GroupVoiceRejoin(object[] param)
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	public void OnPlayBtnClick()
	{
	}

	public void OnPreStartBtnClick()
	{
	}

	public void OnReadyBtnClick()
	{
	}

	private void OnHighPingExpire()
	{
	}

	private void OnReady(bool manualClick)
	{
	}

	private void OnBtnTeamInfoClick()
	{
	}

	private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void PreStartCompleted()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnGroupNotReady_003Eb__26_0()
	{
	}

	private void _003CRefreshStartBtn_003Eb__40_0()
	{
	}

	private void _003ConLeaveBtnClick_003Eb__58_0()
	{
	}

	private void _003ConLeaveBtnClick_003Eb__58_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
