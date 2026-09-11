using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UINewPlayerV3GrowPathController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CRefreshViewInternal_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewPlayerV3GrowPathController _003C_003E4__this;

		public bool needScrollToCurLevel;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshViewInternal_003Ed__21(int _003C_003E1__state)
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

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UINewPlayerV3GrowPathView m_View;

	private UIModelProfile m_ModelProfile;

	private Vector2 ITEM_SIZE;

	private Vector2 ITEM_SIZE_SINGLE_TAIL;

	private Vector2 ITEM_SIZE_DOUBLE_TAIL;

	private Vector2 ITEM_SIZE_HEAD;

	private int m_LastSelectIndex;

	private UINewPlayerV3GrowPathDetailAwardPopController m_GrowPathDetailAwardPopController;

	private Coroutine m_CoroutineRefreshView;

	private bool m_HasInitTable2Item;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitTable2TemPlate()
	{
	}

	private void InitTable2Item()
	{
	}

	public void RefreshView(bool needScrollToCurLevel = false)
	{
	}

	public void ShowPreview(AwardDesc awardItemInfo, EInventory.AwardType awardType, string previewCDNUrl)
	{
	}

	public int GetLastSelectIndex()
	{
		return 0;
	}

	private IEnumerator RefreshViewInternal(bool needScrollToCurLevel)
	{
		return null;
	}

	private void RefreshCurLevelText()
	{
	}

	private void RefreshRewardItemList()
	{
	}

	private void ScrollToCurLevel()
	{
	}

	private void TryRequestLevelRewardsDisplayDesc()
	{
	}

	public void OnItemClick(int index, bool force = false)
	{
	}

	public void OnDetailAwardPopOpen(Vector3 startfrom, List<AwardDesc> awardDescs, uint level)
	{
	}

	public void OnDetailAwardPopCLose()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private UITable2.IUITable2Item _003CInitTable2TemPlate_003Eb__16_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2TemPlate_003Eb__16_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2TemPlate_003Eb__16_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2TemPlate_003Eb__16_3()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2TemPlate_003Eb__16_4()
	{
		return null;
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
