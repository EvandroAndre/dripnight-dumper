using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDCommonEquipSetSelectionController : UIPopupWindowController
{
	private UIEquipSetSelectionView m_View;

	private int m_SelectedIndex;

	private List<UIEquipSetItemController> m_SetItemUIs;

	private UITimeLabelHelper m_EndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowWindow(int defalutIndex, float showTime)
	{
	}

	private void OnSelectItem(int index)
	{
	}

	private void HighLightIndex(int index, bool hightlight)
	{
	}

	private void OnConfirm()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
