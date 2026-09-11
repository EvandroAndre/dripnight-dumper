using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPostMatchTeamUpCountDownController : UIBaseController, IUIModelDataChangeObserver
{
	public class PlayerData
	{
		public ulong uid;

		public TeammateState state;

		public ulong groupId;
	}

	private sealed class _003CCountDownUpdateCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPostMatchTeamUpCountDownController _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003CtotalTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCountDownUpdateCoroutine_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CDelayInitTeammateItemsAndCountDown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPostMatchTeamUpCountDownController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayInitTeammateItemsAndCountDown_003Ed__15(int _003C_003E1__state)
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

	private UIPostMatchTeamUpCountDownView m_View;

	private GameObject m_CountDownUIFXPrefab;

	private List<PlayerData> m_SortedAllPlayers;

	private UIGroupWaitingDropItem m_DragDropItem;

	private UIModelGroup m_groupModel;

	private ulong m_CurrentPlayerId;

	private Coroutine m_CountDownCoroutine;

	private bool m_HasOpenDetail;

	private UIPostMatchTeammatePanelController m_PostMatchTeammatePanelController;

	private List<UIPostMatchTeammateItemController> m_UIPostMatchTeammateItemCtrls;

	private List<GameObject> m_CopySilders;

	private float m_EmergencyEffect;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator DelayInitTeammateItemsAndCountDown()
	{
		return null;
	}

	public void ShowReturnBtn()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void InitCountDown()
	{
	}

	public void TestInitCountDown()
	{
	}

	public void UpdateCountDown()
	{
	}

	private void StartCountDownUpdate()
	{
	}

	private void StopCountDownUpdate()
	{
	}

	private IEnumerator CountDownUpdateCoroutine()
	{
		return null;
	}

	public void UpdateTeammateItems()
	{
	}

	public void InitDrag()
	{
	}

	public bool IsDragging()
	{
		return false;
	}

	private Vector2 GetBound()
	{
		return default(Vector2);
	}

	public void SelectTeammateItem(int index)
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	private void RefreshDetailUI()
	{
	}

	private void OnOtherCancelBtnClick()
	{
	}

	private void OnSwitchToQuickMatchMode()
	{
	}

	private void OnOpenDetailButtonClick()
	{
	}

	private void OnReturnBtnClick()
	{
	}

	private void UpdatePostMatchTeammatePanel()
	{
	}

	public void HideDetailButton()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private List<int> GetGroupChangeIndices(List<PlayerData> playerDatas)
	{
		return null;
	}

	public void RefreshUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
