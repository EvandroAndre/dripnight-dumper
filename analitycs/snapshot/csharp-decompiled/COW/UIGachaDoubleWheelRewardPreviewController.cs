using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaDoubleWheelRewardPreviewController : UIPreviewNavigationController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GachaShowItem> _003C_003E9__15_0;

		internal int _003CRefreshView_003Eb__15_0(GachaShowItem x, GachaShowItem y)
		{
			return 0;
		}
	}

	private sealed class _003CCoCenterOnTarget_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaDoubleWheelRewardPreviewController _003C_003E4__this;

		public Transform trans;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCenterOnTarget_003Ed__19(int _003C_003E1__state)
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

	private UIGachaDoubleWheelRewardPreviewView m_View;

	private List<GachaShowItem> m_GrandPrizeList;

	private List<GachaShowItem> m_CommonRewardList;

	private List<UIGachaDoubleWheelRewardPreviewItemController> m_GrandPrizeItemList;

	private List<UIGachaDoubleWheelRewardPreviewItemController> m_CommonRewardItemList;

	private UIGachaDoubleWheelRewardPreviewItemController m_LastSelectedCtrl;

	private uint m_GachaID;

	private uint m_NaviID;

	private UIModelGacha m_ModelGacha;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshGrid(List<GachaShowItem> dataList, List<UIGachaDoubleWheelRewardPreviewItemController> ctrlList, Transform pos)
	{
	}

	private void NavigationToItem()
	{
	}

	public void OnItemSelected(UIGachaDoubleWheelRewardPreviewItemController itemCtrl, BaseItemInfo itemInfo)
	{
	}

	private IEnumerator CoCenterOnTarget(Transform trans)
	{
		return null;
	}

	private bool _003CNavigationToItem_003Eb__17_0(GachaShowItem prize)
	{
		return false;
	}

	private bool _003CNavigationToItem_003Eb__17_1(GachaShowItem reward)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
