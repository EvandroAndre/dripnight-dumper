using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopUnlimitedTokenTowerPreviewPopWndController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClientDrawShopTowerGoodsDesc> _003C_003E9__10_0;

		internal int _003CShowView_003Eb__10_0(ClientDrawShopTowerGoodsDesc a, ClientDrawShopTowerGoodsDesc b)
		{
			return 0;
		}
	}

	private sealed class _003CCoCenterOnTarget_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawShopUnlimitedTokenTowerPreviewPopWndController _003C_003E4__this;

		public Transform trans;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCenterOnTarget_003Ed__12(int _003C_003E1__state)
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

	private UILengendGachaPreviewPopWndView m_View;

	private UIModelDrawShop m_Model;

	private List<ClientDrawShopTowerGoodsDesc> m_SortedGoodsList;

	private List<UIDrawShopPreviewPopWndItemController> m_ItemCtrlList;

	private uint m_GachaID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetUIData(uint chestId)
	{
	}

	private void ShowView()
	{
	}

	public void CenterOnTarget(uint itemId)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
