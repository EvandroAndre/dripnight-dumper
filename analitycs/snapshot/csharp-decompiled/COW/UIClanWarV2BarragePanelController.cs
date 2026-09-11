using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanWarV2BarragePanelController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CRefreshTransformAndStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanWarV2BarragePanelController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshTransformAndStart_003Ed__14(int _003C_003E1__state)
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

	private const int LENTH_Y_OFFSET = 200;

	private UIClanWarV2BarragePanelView m_View;

	private bool m_HasSetDynamicUI;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelRelationShip m_ModelRelation;

	private UIModelClan m_ModelClan;

	private UIModelBarrage m_ModelBarrage;

	private HashSet<int> m_BarrageTypes;

	private UIBarragePanelComponent m_BarragePanelComponent;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void LoadDynamicUIConfig()
	{
	}

	public void StartSend(bool isClanWarOpen)
	{
	}

	private IEnumerator RefreshTransformAndStart()
	{
		return null;
	}

	private void StartDelayCall()
	{
	}

	private void OnDataReady()
	{
	}

	public void CancelSend()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public BarrageData GetBarrageData(uint rowId)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
