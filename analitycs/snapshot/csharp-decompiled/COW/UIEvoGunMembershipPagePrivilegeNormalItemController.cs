using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIEvoGunMembershipPagePrivilegeNormalItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIEvoGunMembershipPagePrivilegeNormalItemView m_View;

	private MembershipAwardDesc m_Data;

	private UIModelEvoPass m_ModelEvoPass;

	private string m_ShowTips;

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

	object UITable2.IUITable2Item.SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	void UITable2.IUITable2Item.SetPosition(Vector2 position)
	{
	}

	void UITable2.IUITable2Item.SetTable2Visible(bool visible)
	{
	}

	private void OnClick()
	{
	}

	private void RefreshData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
