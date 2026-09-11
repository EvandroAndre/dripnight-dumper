using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityCollectionEventController : UIActivityContentController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<UIActivityCollectionSigninItemController> _003C_003E9__19_0;

		internal bool _003CScrollToFirstNotClaimedItem_003Eb__19_0(UIActivityCollectionSigninItemController temp)
		{
			return false;
		}
	}

	private sealed class _003COnEnableRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIActivityCollectionEventController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnEnableRoutine_003Ed__20(int _003C_003E1__state)
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

	private List<UIActivityCollectionSigninItemController> m_ItemList;

	private UIActivityCollectionEventView m_View;

	private ActivityGroupDesc m_GroupDesc;

	private UIModelActivity m_ModelActivity;

	private UIModelInventory m_ModelInventory;

	private List<UIActivityExchangeItemController> m_ExchangeDescUIs;

	private int m_ADWidth;

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

	public override void SetData(object data)
	{
	}

	private void UpdateIntroData()
	{
	}

	private void UpdateActivityInfo()
	{
	}

	private void OnClickToken0()
	{
	}

	private void OnClickToken1()
	{
	}

	private void OnClickCountDown()
	{
	}

	private void OnClickStore()
	{
	}

	public override void Reload()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void ScrollToFirstNotClaimedItem()
	{
	}

	private IEnumerator OnEnableRoutine()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshList()
	{
	}

	public void SetAD(string url)
	{
	}

	private void OnDownloadFinish()
	{
	}

	private void UpdateInfos()
	{
	}

	private void CreateEventDescList()
	{
	}

	private UIActivityExchangeItemController CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	private void _003CUpdateInfos_003Eb__26_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
