using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSMissionSpecialItemController : UIBaseController, UITable2.IUITable2Item
{
	private readonly string SPECIAL_BR_LOC;

	private readonly string SPECIAL_CS_LOC;

	private readonly string SPECIAL_LW_LOC;

	private UINinthSYSMissionSpecialItemView m_View;

	private UIModelNinthSYS.NinthSYSSpecialMissionData m_MissionData;

	private UINinthSYSStandardItemMiniController m_RewardItemCtrl;

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

	private void OnClickGotoBtn()
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

	private void RefreshView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
