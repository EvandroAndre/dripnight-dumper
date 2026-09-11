using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2ResidentFriendListController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003CRefresh_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2ResidentFriendListController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefresh_003Ed__28(int _003C_003E1__state)
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

	private UILobbyV2ResidentFriendListView m_View;

	private UIModelFriends m_ModelFriends;

	private UIModelRelationShip m_ModelRelationShip;

	private UIModelGroup m_ModelGroup;

	private string INVITE_FILTER;

	private float m_LastRefreshTime;

	private uint m_ItemCountInScrollView;

	private float m_Timer;

	private bool m_ForceSample;

	private uint m_CSPeakNotifyDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnReturnFromInGame()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void InitItemCountData()
	{
	}

	private bool IsVisibleAndActive()
	{
		return false;
	}

	private void RefreshFriendState()
	{
	}

	private void RefreshCSPeakNotify()
	{
	}

	private void RefreshFriendList()
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	private void OnGroupCreate(object[] data)
	{
	}

	private void OnGroupJoin(object[] data)
	{
	}

	private void OnLeaveGroup(object[] data)
	{
	}

	private void OnDismissGroup(object[] data)
	{
	}

	private void OnSelectGameMode(object[] args)
	{
	}

	private IEnumerator Refresh()
	{
		return null;
	}

	private int CompareFriendListInfo(FriendAccountInfo curInfo, FriendAccountInfo nextInfo)
	{
		return 0;
	}

	private void SetFriendUIData()
	{
	}

	public Vector3 GetBriefBoxPos()
	{
		return default(Vector3);
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void _003CRefreshCSPeakNotify_003Eb__20_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
