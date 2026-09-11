using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanSponsorRecordItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIClanSponsorRecordItemView m_View;

	private UIModelClan m_ModelClan;

	private UIBaseProfileInfoController m_CurrentCtrl;

	private UIBaseProfileInfoController m_HistoryCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(ClanPrivilegeRecord data)
	{
	}

	public void SetUIData(ClanPrivilegeHistoryRecord data)
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
