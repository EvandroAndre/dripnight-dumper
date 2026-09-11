using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIEvoGunMembershipPagePrivilegeGunItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIEvoGunMembershipPagePrivilegeGunItemView m_View;

	private UIModelEvoPass m_ModelEvoPass;

	private bool m_ChooseCurrent;

	private MembershipBigAwardDesc m_Data;

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

	private void ShowPreview()
	{
	}

	private void OnCurButtonClick()
	{
	}

	private void OnNextButtonClick()
	{
	}

	private void RefreshData()
	{
	}

	private string GetTimeString(long startTime, long endTime)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
