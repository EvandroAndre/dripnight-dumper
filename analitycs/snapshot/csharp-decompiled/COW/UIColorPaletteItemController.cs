using GCommon;
using UnityEngine;

namespace COW;

internal class UIColorPaletteItemController : UIBaseController
{
	private UIColorPaletteItemView m_View;

	private uint m_ItemId;

	private bool m_IsLock;

	private int m_Index;

	private static readonly Color LOCK;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint item, int index)
	{
	}

	public void SelectItem(bool isSelect)
	{
	}

	public void SetItemLockStatus(bool isLock)
	{
	}

	private void OnColorBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
