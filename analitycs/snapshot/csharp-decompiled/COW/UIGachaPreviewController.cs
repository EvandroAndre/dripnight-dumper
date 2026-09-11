using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaPreviewController : UIBaseController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public uint itemID;

		internal bool _003CHighLightItemByID_003Eb__0(GachaShowItem item)
		{
			return false;
		}

		internal bool _003CHighLightItemByID_003Eb__1(GachaShowItem item)
		{
			return false;
		}

		internal bool _003CHighLightItemByID_003Eb__2(GachaShowItem item)
		{
			return false;
		}
	}

	private sealed class _003CCoCenterOnTarget_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaPreviewController _003C_003E4__this;

		public Transform trans;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCenterOnTarget_003Ed__23(int _003C_003E1__state)
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

	private UIGachaPreviewView m_View;

	protected UIModelGacha m_ModelGacha;

	private List<GachaShowItem> m_Infolist;

	private List<GachaShowItem> m_GrandPrizeList;

	private List<GachaShowItem> m_CommonRewardList;

	private List<UIGachaPreviewItemController> m_GrandPrizeCtrls;

	private List<UIGachaPreviewItemController> m_CommmonRewardCtrls;

	private UIGachaPreviewItemController m_LastSelectedCtrl;

	protected uint m_GachaId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnProbabilityClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void ClosePanel(object[] data)
	{
	}

	public virtual void RefreshView(uint gachaId)
	{
	}

	public void SetSelectedCtrl(UIGachaPreviewItemController itemCtrl)
	{
	}

	private void RefreshGrid(List<GachaShowItem> dataList, List<UIGachaPreviewItemController> ctrlList, Transform pos)
	{
	}

	private void ShowRareProbabilityTips(object[] param)
	{
	}

	public virtual void HighLightItemByIndex(int index, bool needScroll = false)
	{
	}

	public virtual void HighLightItemByID(uint itemID, bool needScroll = false)
	{
	}

	private void CenterOnTarget(Transform trans)
	{
	}

	private IEnumerator CoCenterOnTarget(Transform trans)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
