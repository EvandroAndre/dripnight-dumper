using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIWorkshopLeaderboardController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public UIWorkshopLeaderboardController _003C_003E4__this;

		public ulong localUserId;

		internal WorkshopDataStorageContent _003CShowSelfItem_003Eb__0(int index)
		{
			return null;
		}

		internal DataStoragePlatformInfo _003CShowSelfItem_003Eb__1(int index)
		{
			return null;
		}
	}

	private sealed class _003CRefreshCountdownRoutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWorkshopLeaderboardController _003C_003E4__this;

		private UIWidget _003Cwidget_003E5__2;

		private int _003CremainTimeS_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshCountdownRoutine_003Ed__34(int _003C_003E1__state)
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

	private UIWorkshopLeaderboardView m_View;

	private UIModelUGCDatabase m_ModelDatabase;

	private List<WidgetAutoScrollLabel> m_HeaderLabels;

	private UIWorkshopLeaderboardItemController m_SelfItemCtrl;

	private UIModelUGCDatabase.LeaderboardShowMetaData m_LeaderboardMetaData;

	private WorkshopLeaderboard m_CurrentLeaderboard;

	private WorkshopDataStorage m_CurrentAssociationStorage;

	private EventLogger.EventTypeUGCViewMapLeaderboard m_ViewLeaderboardLog;

	private Vector4 m_ScrollViewInitClipRegion;

	private string m_CurrentWorkshopCode;

	private string m_CurrentLeaderboardName;

	private string m_CurrentDataStorageName;

	private float m_LastRefreshTimeMs;

	private bool m_LeaderboardPrepared;

	private bool m_AssociationStoragePrepared;

	private bool m_PlatformProfilePrepared;

	private bool m_SelfDataPrepared;

	private uint m_PlatformProfileRequestID;

	private uint m_DataStorageRequestID;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetViewData(string workshopCode, List<string> leaderboardNames, int index = 0)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
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

	private bool IsAllReady()
	{
		return false;
	}

	private void OnGetWorkshopLeaderboard(WorkshopLeaderboard leaderboard)
	{
	}

	private void RefreshUI()
	{
	}

	private void ShowClearTime(WorkshopLeaderboard leaderboard)
	{
	}

	private void ShowHeader()
	{
	}

	private void ShowSelfItem()
	{
	}

	private IEnumerator RefreshCountdownRoutine()
	{
		return null;
	}

	private void OnRefreshBtnClick()
	{
	}

	private WorkshopDataStorageContent _003COpenItemController_003Eb__26_0(int index)
	{
		return null;
	}

	private DataStoragePlatformInfo _003COpenItemController_003Eb__26_1(int index)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
