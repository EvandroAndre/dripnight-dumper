using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudEscortEquipSetSelectionController : UIBaseController
{
	private UIHudEscortEquipSetSelectionView m_View;

	private UIEscortEquipSetItemController m_SelectSetUI;

	private List<UIEscortEquipSetItemController> m_SetItemUIs;

	private UITimeLabelHelper m_EndTime;

	private const int m_MaxItemCout = 6;

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

	private void OnRefreshEquip(object[] param)
	{
	}

	private void OnUpdateEquip(object[] param)
	{
	}

	private int GetEquipSetUIIndex(uint equipSetID)
	{
		return 0;
	}

	public void SetStartState()
	{
	}

	private void OnSelectItem(int index)
	{
	}

	private void SetConfirmButtonState(bool canclick)
	{
	}

	private void OnConfirm()
	{
	}

	private void RequestEquipInfo()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
