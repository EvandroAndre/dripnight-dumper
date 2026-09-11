using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINinthSYSPeakDayItemController : UIBaseController, UITable2.IUITable2Item
{
	private UINinthSYSPeakDayItemView m_View;

	private UIModelActivity m_ModelActivity;

	private ClientActivityDesc m_Desc;

	private int m_Index;

	private UIStandardItemMiniController m_ItemController;

	private bool m_IsActivityEnded;

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

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public EActivity.State RefreshView()
	{
		return EActivity.State.State_RECEIVED;
	}

	private void LogClick(string posfix)
	{
	}

	private void OnClickItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
