using System;
using GCommon;
using proto;

namespace COW;

public class UITreasureBoxOpenWndontroller : UIPopupWindowController
{
	public Action<uint, uint> OpenAction;

	private UITreasureBoxOpenWndView m_View;

	private Item m_Item;

	private int maxOpenCnt;

	private UIStandardItemMAXBController m_ItemCtrl;

	private uint m_SelectCnt;

	private bool m_IsSliderChange;

	private uint SelectCnt
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshView(uint itemID, bool maxCount = false)
	{
	}

	private void OnOpenBtnClick()
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnMinsBtnClick()
	{
	}

	private void OnSliderValueChange()
	{
	}

	private void OnSelectCntChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
