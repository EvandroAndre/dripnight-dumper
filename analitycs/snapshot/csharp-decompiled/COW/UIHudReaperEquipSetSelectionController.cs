using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudReaperEquipSetSelectionController : UIPopupWindowController
{
	private UIEquipSetSelectionView m_View;

	private UIEquipSetItemController m_SelectSetUI;

	private List<UIEquipSetItemController> m_SetItemUIs;

	private UITimeLabelHelper m_EndTime;

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

	private int GetEquipSetUIIndex(uint equipSetID)
	{
		return 0;
	}

	private void OnSelectItem(int index)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
