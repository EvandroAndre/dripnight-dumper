using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILegendDrawAnimPopWindowController : UIPopupWindowController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public List<GachaShowItem> lotteriesSorted;

		internal bool _003CRefreshEasyListView_003Eb__0(BaseItemInfo x)
		{
			return false;
		}
	}

	private uint m_GachaID;

	private uint m_DelayCallID;

	private int m_ListCount;

	private float m_TotalTime;

	private float m_StayTimeAfterAnimEnd;

	private UILegendDrawAnimPopWindowView m_View;

	private UIModelGacha m_Model;

	private int m_TargetIndex;

	private List<BaseItemInfo> gachaShowItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetGachaID(uint gachaID)
	{
	}

	private void RefreshEasyListView()
	{
	}

	private void DOScroll()
	{
	}

	private void OnFinished()
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void _003COnFinished_003Eb__16_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
